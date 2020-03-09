﻿using System.Collections.Generic;
using Insight.Utils.BaseForms;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Platform.Tenants.Views
{
    public partial class Manager : BaseMdi
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Manager()
        {
            InitializeComponent();
            var list = new List<LookUpMember>
            {
                new LookUpMember {id = "0", name = "待审核"},
                new LookUpMember {id = "1", name = "已审核"},
                new LookUpMember {id = "2", name = "未通过"}
            };
            repStatus.DataSource = list;
        }
    }
}
