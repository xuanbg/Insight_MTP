﻿using Insight.Base.BaseForm.ViewModels;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Data.Interfaces.Views;
using System.Collections.Generic;

namespace Insight.MTP.Client.Data.Interfaces.ViewModels
{
    public class ManagerModel : BaseMdiModel<Interface, Manager, DataModel>
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagerModel()
        {
            initSearch(view.KeyInput, view.Search);
            initMainGrid(view.grdInterface, view.gdvInterface, view.pccInterface);
        }

        /// <summary>
        /// 加载列表数据
        /// </summary>
        /// <param name="pageNum">当前页</param>
        public void loadData(int page = 1)
        {
            showWaitForm();
            var result = dataModel.getInterfaces(keyword, page, tab.size);
            closeWaitForm();
            if (!result.success) return;

            item = null;
            list.Clear();

            list.AddRange(result.data);
            tab.totalRows = result.total;

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
        /// 刷新工具条按钮状态
        /// </summary>
        private new void refreshToolBar()
        {
            buttonStatus = new Dictionary<string, bool>
            {
                ["editItem"] = item != null,
                ["deleteItem"] = item != null
            };

            base.refreshToolBar();
        }
    }
}