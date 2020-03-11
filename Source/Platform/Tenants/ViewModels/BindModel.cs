﻿using System.Collections.Generic;
using System.Linq;
using Insight.MTP.Client.Common.Entity;
using Insight.MTP.Client.Platform.Tenants.Views;
using Insight.Utils.BaseViewModels;
using Insight.Utils.Common;
using Insight.Utils.Controls;

namespace Insight.MTP.Client.Platform.Tenants.ViewModels
{
    public class BindModel : BaseDialogModel<object, BindDialog>
    {
        public List<TenantApp> apps;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data"></param>
        /// <param name="title"></param>
        public BindModel(List<TenantApp> data, string title) : base(title)
        {
            view.grdApp.DataSource = data;
            Format.gridFormat(view.gdvApp);
        }

        /// <summary>
        /// 输入合法性检查
        /// </summary>
        public new void confirm()
        {
            var list = from r in view.gdvApp.GetSelectedRows()
                select (TenantApp) view.gdvApp.GetRow(r);
            apps = list.ToList();
            if (!apps.Any())
            {
                Messages.showWarning("请选择需要绑定的应用！");
                return;
            }

            base.confirm();
        }
    }
}
