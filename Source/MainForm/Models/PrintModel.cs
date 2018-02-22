using System.Collections.Generic;
using System.Drawing.Printing;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Views;

namespace Insight.MTP.Client.MainForm.Models
{
    public class PrintModel
    {
        public PrintSet View = new PrintSet();

        private readonly List<object> _Prints = new List<object>();

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public PrintModel()
        {
            // 读取系统安装打印机列表
            var prints = PrinterSettings.InstalledPrinters;
            _Prints.Add("请设置默认打印机…");
            foreach (var p in prints)
            {
                _Prints.Add(p);
            }

            // 使用系统安装打印机列表初始化下拉列表
            View.DocPrint.Properties.Items.AddRange(_Prints);
            View.TagPrint.Properties.Items.AddRange(_Prints);
            View.BilPrint.Properties.Items.AddRange(_Prints);

            // 初始化控件初值
            View.DocPrint.EditValue = string.IsNullOrEmpty(Params.DocPrint) ? _Prints[0] : Params.DocPrint;
            View.TagPrint.EditValue = string.IsNullOrEmpty(Params.TagPrint) ? _Prints[0] : Params.TagPrint;
            View.BilPrint.EditValue = string.IsNullOrEmpty(Params.BilPrint) ? _Prints[0] : Params.BilPrint;
            View.MergerPrint.Checked = Params.IsMergerPrint;

            // 订阅下拉列表事件绑定数据
            View.DocPrint.EditValueChanged += (sender, args) => Params.DocPrint = View.DocPrint.SelectedIndex < 1 ? "" : View.DocPrint.Text;
            View.BilPrint.EditValueChanged += (sender, args) => Params.BilPrint = View.DocPrint.SelectedIndex < 1 ? "" : View.BilPrint.Text;
            View.TagPrint.EditValueChanged += (sender, args) => Params.TagPrint = View.DocPrint.SelectedIndex < 1 ? "" : View.TagPrint.Text;
            View.MergerPrint.CheckedChanged += (sender, args) => Params.IsMergerPrint = View.MergerPrint.Checked;
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        public void Save()
        {
            Config.SavePrinter("docPrint", Params.DocPrint);
            Config.SavePrinter("tagPrint", Params.TagPrint);
            Config.SavePrinter("bilPrint", Params.BilPrint);
            Config.SaveIsMergerPrint(Params.IsMergerPrint);
        }
    }
}
