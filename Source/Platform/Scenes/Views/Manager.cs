using System.Collections.Generic;
using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Forms;

namespace Insight.MTP.Client.Platform.Scenes.Views
{
    public partial class Manager : BaseMdi
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Manager()
        {
            InitializeComponent();

            var type = new List<LookUpMember>
            {
                new LookUpMember {id = "0", name = "不发送"},
                new LookUpMember {id = "1", name = "仅消息"},
                new LookUpMember {id = "2", name = "仅推送"},
                new LookUpMember {id = "3", name = "推送|消息"},
                new LookUpMember {id = "4", name = "仅短信"},
                new LookUpMember {id = "5", name = "短信|消息"},
                new LookUpMember {id = "6", name = "短信|推送"},
                new LookUpMember {id = "7", name = "全部"}
            };
            rleType.DataSource = type;
            rleType.ValueMember = "id";
            rleType.DisplayMember = "name";
        }
    }
}
