﻿using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Scenes.Views;
using System.Collections.Generic;
using System.Linq;

namespace Insight.MTP.Client.Platform.Scenes.ViewModels
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
            initGrid(view.grdTemplate, view.gdvTemplate, null, "configChanged", view.ppcTemplate, "getConfigs");
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
            config = null;
            if (index < 0 || index >= list.Count)
            {
                item = null;
                view.ppcTemplate.totalRows = 0;
                view.grdTemplate.DataSource = null;
                view.gdvTemplate.FocusedRowHandle = -1;
                refreshToolBar();

                return;
            }

            item = list[index];
            if (!item.configs.Any()) getConfigs();

            view.ppcTemplate.totalRows = item.configTotal;
            view.grdTemplate.DataSource = item.configs;
            view.gdvTemplate.FocusedRowHandle = 0;

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
            item.configTotal = result.total;
        }

        /// <summary>
        /// 添加场景配置
        /// </summary>
        /// <param name="data"></param>
        public void addConfig(TempConfig data)
        {
            item.configs.Add(data);
            view.ppcTemplate.addItems();
        }

        /// <summary>
        /// 移除场景配置
        /// </summary>
        public void removeConfig()
        {
            item.configs.Remove(config);
            view.ppcTemplate.removeItems();
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
                ["addConfig"] = item != null,
                ["removeConfig"] = item != null && config != null,
            };

            base.refreshToolBar();
        }
    }
}