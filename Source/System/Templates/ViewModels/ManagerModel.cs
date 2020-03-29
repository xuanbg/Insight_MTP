﻿using System.Collections.Generic;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Setting.Templates.Views;
using Insight.Utils.BaseViewModels;

namespace Insight.MTP.Client.Setting.Templates.ViewModels
{
    public class ManagerModel : BaseMdiModel<MessageTemp, Manager, DataModel>
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdTemplate, view.gdvTemplate, view.pccTemplate);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="page">当前页</param>
        /// <param name="handle">焦点行号</param>
        public void loadData(int page = 1, int handle = 0)
        {
            showWaitForm();
            var result = dataModel.getTemplates(keyWord, page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total;
            tab.page = page;
            view.gdvTemplate.FocusedRowHandle = handle;

            refreshToolBar();
        }

        /// <summary>
        /// 主列表所选数据改变
        /// </summary>
        /// <param name="index">List下标</param>
        public void itemChanged(int index)
        {
            item = index < 0 || index >= list.Count ? null : list[index];

            refreshToolBar();
        }

        /// <summary>
        /// 刷新列表数据
        /// </summary>
        public void refreshGrid()
        {
            view.gdvTemplate.RefreshData();
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
                ["disable"] = item != null && !item.invalid,
                ["enable"] = item != null && item.invalid
            };
            switchItemStatus(dict);
        }
    }
}