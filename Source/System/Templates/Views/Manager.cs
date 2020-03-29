using System.Collections.Generic;
using Insight.Utils.BaseForms;
using Insight.Utils.Controls;
using Insight.Utils.Entity;

namespace Insight.MTP.Client.Setting.Templates.Views
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
                new LookUpMember {id = "1", name = "仅消息"},
                new LookUpMember {id = "2", name = "仅推送"},
                new LookUpMember {id = "3", name = "推送+消息"},
                new LookUpMember {id = "4", name = "仅短信"},
                new LookUpMember {id = "8", name = "仅邮件"}
            };
            Format.initLookUpEdit(repType, list);
        }
    }
}
