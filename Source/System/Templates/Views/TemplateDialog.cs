using System.Collections.Generic;
using Insight.Base.BaseForm.Controls;
using Insight.Base.BaseForm.Entities;
using Insight.Base.BaseForm.Forms;

namespace Insight.MTP.Client.Setting.Templates.Views
{
    public partial class TemplateDialog : BaseDialog
    {
        public TemplateDialog()
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
            Format.initLookUpEdit(lueType, list);
        }
    }
}
