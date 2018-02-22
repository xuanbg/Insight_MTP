using System.Collections.Generic;
using System.Drawing.Printing;
using Insight.MTP.Client.Common.Utils;
using Insight.MTP.Client.MainForm.Views;

namespace Insight.MTP.Client.MainForm.Models
{
    public class PrintModel
    {
        public PrintSet view = new PrintSet();

        private readonly List<object> prints = new List<object>();

        /// <summary>
        /// 构造函数，初始化视图
        /// 通过订阅事件实现双向数据绑定
        /// </summary>
        public PrintModel()
        {
            // 读取系统安装打印机列表
            prints.Add("请设置默认打印机…");
            foreach (var p in PrinterSettings.InstalledPrinters)
            {
                prints.Add(p);
            }

            // 使用系统安装打印机列表初始化下拉列表
            view.DocPrint.Properties.Items.AddRange(prints);
            view.TagPrint.Properties.Items.AddRange(prints);
            view.BilPrint.Properties.Items.AddRange(prints);

            // 初始化控件初值
            view.DocPrint.EditValue = string.IsNullOrEmpty(Params.docPrint) ? prints[0] : Params.docPrint;
            view.TagPrint.EditValue = string.IsNullOrEmpty(Params.tagPrint) ? prints[0] : Params.tagPrint;
            view.BilPrint.EditValue = string.IsNullOrEmpty(Params.bilPrint) ? prints[0] : Params.bilPrint;
            view.MergerPrint.Checked = Params.isMergerPrint;

            // 订阅下拉列表事件绑定数据
            view.DocPrint.EditValueChanged += (sender, args) => Params.docPrint = view.DocPrint.SelectedIndex < 1 ? "" : view.DocPrint.Text;
            view.BilPrint.EditValueChanged += (sender, args) => Params.bilPrint = view.DocPrint.SelectedIndex < 1 ? "" : view.BilPrint.Text;
            view.TagPrint.EditValueChanged += (sender, args) => Params.tagPrint = view.DocPrint.SelectedIndex < 1 ? "" : view.TagPrint.Text;
            view.MergerPrint.CheckedChanged += (sender, args) => Params.isMergerPrint = view.MergerPrint.Checked;
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        public void Save()
        {
            Config.SavePrinter("docPrint", Params.docPrint);
            Config.SavePrinter("tagPrint", Params.tagPrint);
            Config.SavePrinter("bilPrint", Params.bilPrint);
            Config.SaveIsMergerPrint(Params.isMergerPrint);
        }
    }
}
