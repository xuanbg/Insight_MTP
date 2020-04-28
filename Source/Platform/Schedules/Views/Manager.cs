using System.Collections.Generic;
using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Forms;

namespace Insight.MTP.Client.Platform.Schedules.Views
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
                new LookUpMember {id = "0", name = "消息"},
                new LookUpMember {id = "1", name = "本地调用"},
                new LookUpMember {id = "2", name = "远程调用"}
            };
            repType.DataSource = list;
        }
    }
}
