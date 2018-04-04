﻿using System.Collections.Generic;
using Insight.MTP.Client.Base.Tenants.Views;
using Insight.MTP.Client.Common.Entity;
using Insight.Utils.Client;
using Insight.Utils.Models;

namespace Insight.MTP.Client.Base.Tenants.Models
{
    public class ExtendModel : BaseModel
    {
        public ExtendDialog view;

        private readonly Tenant tenant;

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        /// <param name="data">初始化数据</param>
        /// <param name="title">View标题</param>
        public ExtendModel(Tenant data, string title)
        {
            tenant = data;
            view = new ExtendDialog {Text = title};
        }

        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        public Tenant Save()
        {
            var day = (int) view.speDays.Value;
            const string msg = "续租失败！";
            var url = $"{appServer}/tenantapi/v1.0/tenants/{tenant.id}/expire";
            var dict = new Dictionary<string, object> {{"expire", day}};
            var client = new HttpClient<object>(tokenHelper);

            if (!client.Put(url, dict, msg)) return null;

            tenant.expireDate = tenant.expireDate.AddDays(day);

            return tenant;
        }
    }
}
