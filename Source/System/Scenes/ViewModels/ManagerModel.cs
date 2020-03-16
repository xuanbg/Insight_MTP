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
            initGrid(view.gdvTemplate, "configChanged", null, view.ppcTemplate);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="handle">当前焦点行</param>
        public void loadData(int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getScenes(keyWord, tab.page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = int.Parse(result.option.ToString());
            view.gdvScene.RefreshData();
            view.gdvScene.FocusedRowHandle = handle;

            refreshToolBar();
        }

        /// <summary>
        /// 列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            if (index < 0)
            {
                item = null;
                config = null;
            }
            else
            {
                var id = item?.id;
                item = list[index];
                if (item.id != id)
                {
                    if (!item.configs.Any())
                    {
                        var result = dataModel.getTempConfigs(item.id, view.ppcTemplate.page, view.ppcTemplate.size);
                        if (result.success)
                        {
                            item.configs = result.data;
                            view.ppcTemplate.totalRows = int.Parse(result.option.ToString());
                        }
                    }
                }
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