using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Insight.MTP.Client.Data.Dicts.Views
{
    partial class DictKeyDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labExtend = new DevExpress.XtraEditors.LabelControl();
            this.labIndex = new DevExpress.XtraEditors.LabelControl();
            this.mmeExtend = new DevExpress.XtraEditors.MemoEdit();
            this.mmeRemark = new DevExpress.XtraEditors.MemoEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labCode = new DevExpress.XtraEditors.LabelControl();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.labValue = new DevExpress.XtraEditors.LabelControl();
            this.spiIndex = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmeExtend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiIndex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtValue);
            this.panel.Controls.Add(this.labValue);
            this.panel.Controls.Add(this.txtCode);
            this.panel.Controls.Add(this.labCode);
            this.panel.Controls.Add(this.mmeRemark);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Controls.Add(this.mmeExtend);
            this.panel.Controls.Add(this.labExtend);
            this.panel.Controls.Add(this.labIndex);
            this.panel.Controls.Add(this.spiIndex);
            this.panel.Size = new System.Drawing.Size(450, 220);
            // 
            // cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.Location = new System.Drawing.Point(280, 244);
            this.cancel.TabIndex = 3;
            // 
            // confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(370, 244);
            this.confirm.TabIndex = 4;
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            this.close.Location = new System.Drawing.Point(370, 244);
            // 
            // labExtend
            // 
            this.labExtend.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labExtend.Appearance.Options.UseForeColor = true;
            this.labExtend.Appearance.Options.UseTextOptions = true;
            this.labExtend.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labExtend.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labExtend.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labExtend.Location = new System.Drawing.Point(0, 50);
            this.labExtend.Name = "labExtend";
            this.labExtend.Size = new System.Drawing.Size(60, 21);
            this.labExtend.TabIndex = 0;
            this.labExtend.Text = "扩展：";
            // 
            // labIndex
            // 
            this.labIndex.Appearance.Options.UseTextOptions = true;
            this.labIndex.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labIndex.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labIndex.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labIndex.Location = new System.Drawing.Point(0, 20);
            this.labIndex.Name = "labIndex";
            this.labIndex.Size = new System.Drawing.Size(60, 21);
            this.labIndex.TabIndex = 0;
            this.labIndex.Text = "序号：";
            // 
            // mmeExtend
            // 
            this.mmeExtend.Location = new System.Drawing.Point(60, 50);
            this.mmeExtend.Name = "mmeExtend";
            this.mmeExtend.Size = new System.Drawing.Size(360, 90);
            this.mmeExtend.TabIndex = 4;
            // 
            // mmeRemark
            // 
            this.mmeRemark.Location = new System.Drawing.Point(60, 150);
            this.mmeRemark.Name = "mmeRemark";
            this.mmeRemark.Size = new System.Drawing.Size(360, 50);
            this.mmeRemark.TabIndex = 5;
            // 
            // labRemark
            // 
            this.labRemark.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labRemark.Appearance.Options.UseForeColor = true;
            this.labRemark.Appearance.Options.UseTextOptions = true;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(0, 150);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(60, 21);
            this.labRemark.TabIndex = 0;
            this.labRemark.Text = "备注：";
            // 
            // txtCode
            // 
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Location = new System.Drawing.Point(180, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(80, 20);
            this.txtCode.TabIndex = 2;
            // 
            // labCode
            // 
            this.labCode.Appearance.Options.UseTextOptions = true;
            this.labCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labCode.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labCode.Location = new System.Drawing.Point(120, 20);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(60, 21);
            this.labCode.TabIndex = 0;
            this.labCode.Text = "编码：";
            // 
            // txtValue
            // 
            this.txtValue.EnterMoveNextControl = true;
            this.txtValue.Location = new System.Drawing.Point(320, 20);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 3;
            // 
            // labValue
            // 
            this.labValue.Appearance.Options.UseTextOptions = true;
            this.labValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labValue.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labValue.Location = new System.Drawing.Point(260, 20);
            this.labValue.Name = "labValue";
            this.labValue.Size = new System.Drawing.Size(60, 21);
            this.labValue.TabIndex = 0;
            this.labValue.Text = "键值：";
            // 
            // spiIndex
            // 
            this.spiIndex.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spiIndex.EnterMoveNextControl = true;
            this.spiIndex.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spiIndex.Location = new System.Drawing.Point(60, 20);
            this.spiIndex.Name = "spiIndex";
            this.spiIndex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiIndex.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spiIndex.Properties.IsFloatValue = false;
            this.spiIndex.Properties.Mask.EditMask = "N00";
            this.spiIndex.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spiIndex.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spiIndex.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spiIndex.Size = new System.Drawing.Size(60, 20);
            this.spiIndex.TabIndex = 1;
            // 
            // DictKeyDialog
            // 
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Name = "DictKeyDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmeExtend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiIndex.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelControl labExtend;
        private LabelControl labIndex;
        public MemoEdit mmeExtend;
        public TextEdit txtValue;
        private LabelControl labValue;
        public TextEdit txtCode;
        private LabelControl labCode;
        public MemoEdit mmeRemark;
        private LabelControl labRemark;
        public SpinEdit spiIndex;
    }
}