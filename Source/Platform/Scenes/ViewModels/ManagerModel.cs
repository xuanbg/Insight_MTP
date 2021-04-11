using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Scenes.Views;
using System.Collections.Generic;
using System.Linq;

namespace Insight.MTP.Client.Platform.Scenes.ViewModels
{
    public class ManagerModel : BaseMdiModel<Scene, Manager, DataModel>
    {
        public SceneConfig config;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdMaster, view.gdvMaster, view.pucMaster);
            initGrid(view.grdDetail, view.gdvDetail, "editConfig");
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">当前页</param>
        public void loadData(int page = 1)
        {
            showWaitForm();
            var result = dataModel.getScenes(keyword, page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total;

            refreshToolBar();
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                item = null;
                config = null;
            }
            else
            {
                item = list[index];
                if (item.configs == null) item.configs = new List<SceneConfig>();

                if (!item.configs.Any())
                {
                    var details = dataModel.getConfigs(item.id);
                    if (details == null || !details.Any()) config = null;
                    else item.configs.AddRange(details);
                }
            }

            view.grdDetail.DataSource = item?.configs;
            view.gdvDetail.FocusedRowHandle = 0;

            refreshToolBar();
        }

        /// <summary>
        /// 所选模板配置改变
        /// </summary>
        /// <param name="index">列表行号</param>
        public void detailChanged(int index)
        {
            config = index < 0 ? null : item.configs[index];

            refreshToolBar();
        }

        /// <summary>
        /// 刷新明细列表数据
        /// </summary>
        public void refreshDetailGrid()
        {
            view.gdvDetail.RefreshData();
            refreshToolBar();
        }

        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private new void refreshToolBar()
        {
            buttonStatus = new Dictionary<string, bool>
            {
                ["editItem"] = item != null,
                ["deleteItem"] = item != null,
                ["newConfig"] = item != null,
                ["editConfig"] = item != null && config != null,
                ["deleteConfig"] = item != null && config != null,
            };

            base.refreshToolBar();
        }
    }
}