using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Scenes.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.Setting.Scenes.ViewModels
{
    public class ManagerModel : BaseMdiModel<Scene, Manager, DataModel>
    {
        public TempConfig config;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdScene, view.gdvScene, view.ppcScene);
            initGrid(view.gdvTemplate, "configChanged", null, view.ppcTemplate, "getConfigs");
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="handle">焦点行号</param>
        public void loadData(int page = 1, int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getScenes(keyWord, page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total;
            tab.page = page;
            view.gdvScene.FocusedRowHandle = handle;

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
                if (!item.configs.Any()) getConfigs();
            }

            view.grdTemplate.DataSource = item?.configs;
            refreshToolBar();
        }

        /// <summary>
        /// 所选模板配置改变
        /// </summary>
        /// <param name="index">列表行号</param>
        public void configChanged(int index)
        {
            config = index < 0 ? null : item.configs[index];

            refreshToolBar();
        }

        /// <summary>
        /// 读取模板配置数据
        /// </summary>
        /// <param name="handle"></param>
        public void getConfigs(int handle = 0)
        {
            var result = dataModel.getTempConfigs(item.id, view.ppcTemplate.page, view.ppcTemplate.size);
            if (!result.success) return;

            item.configs = result.data;
            view.ppcTemplate.totalRows = result.total;
            view.grdTemplate.DataSource = item.configs;
            view.gdvTemplate.FocusedRowHandle = handle;

            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvScene.RefreshData();
            refreshToolBar();
        }
        
        /// <summary>
        /// 刷新工具条按钮状态
        /// </summary>
        private void refreshToolBar()
        {
            var dict = new Dictionary<string, bool>
            {
                ["editItem"] = item != null,
                ["deleteItem"] = item != null,
                ["bind"] = item != null,
                ["unbind"] = item != null && config != null,
            };
            switchItemStatus(dict);
        }
    }
}