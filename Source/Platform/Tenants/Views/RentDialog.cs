using Insight.Base.BaseForm.Forms;
using System.Windows.Forms;

namespace Insight.MTP.Client.Platform.Tenants.Views
{
    public partial class RentDialog : BaseDialog
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public RentDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 拦截Alt-F4
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | 0x200;
                return cp;
            }
        }
    }
}
