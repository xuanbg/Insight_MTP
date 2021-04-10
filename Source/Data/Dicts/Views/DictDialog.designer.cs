using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Insight.MTP.Client.Data.Dicts.Views
{
    partial class DictDialog
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
            this.mmeRemark = new DevExpress.XtraEditors.MemoEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labCode = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.labApp = new DevExpress.XtraEditors.LabelControl();
            this.lueApp = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmeRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labApp);
            this.panel.Controls.Add(this.lueApp);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labName);
            this.panel.Controls.Add(this.txtCode);
            this.panel.Controls.Add(this.labCode);
            this.panel.Controls.Add(this.mmeRemark);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Size = new System.Drawing.Size(370, 148);
            // 
            // cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.TabIndex = 3;
            // 
            // confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(290, 172);
            this.confirm.TabIndex = 4;
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            // 
            // mmeRemark
            // 
            this.mmeRemark.Location = new System.Drawing.Point(80, 85);
            this.mmeRemark.Name = "mmeRemark";
            this.mmeRemark.Size = new System.Drawing.Size(270, 50);
            this.mmeRemark.TabIndex = 4;
            // 
            // labRemark
            // 
            this.labRemark.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labRemark.Appearance.Options.UseForeColor = true;
            this.labRemark.Appearance.Options.UseTextOptions = true;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(0, 85);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(80, 21);
            this.labRemark.TabIndex = 0;
            this.labRemark.Text = "备注：";
            // 
            // txtCode
            // 
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Location = new System.Drawing.Point(80, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 2;
            // 
            // labCode
            // 
            this.labCode.Appearance.Options.UseTextOptions = true;
            this.labCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labCode.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labCode.Location = new System.Drawing.Point(0, 50);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(80, 21);
            this.labCode.TabIndex = 0;
            this.labCode.Text = "键名：";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.Location = new System.Drawing.Point(240, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 20);
            this.txtName.TabIndex = 3;
            // 
            // labName
            // 
            this.labName.Appearance.Options.UseTextOptions = true;
            this.labName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labName.Location = new System.Drawing.Point(180, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(60, 21);
            this.labName.TabIndex = 0;
            this.labName.Text = "名称：";
            // 
            // labApp
            // 
            this.labApp.Appearance.Options.UseTextOptions = true;
            this.labApp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labApp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labApp.Location = new System.Drawing.Point(0, 20);
            this.labApp.Name = "labApp";
            this.labApp.Size = new System.Drawing.Size(80, 14);
            this.labApp.TabIndex = 0;
            this.labApp.Text = "所属应用：";
            // 
            // lueApp
            // 
            this.lueApp.EnterMoveNextControl = true;
            this.lueApp.Location = new System.Drawing.Point(80, 20);
            this.lueApp.Name = "lueApp";
            this.lueApp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueApp.Properties.NullText = "";
            this.lueApp.Properties.PopupSizeable = false;
            this.lueApp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueApp.Size = new System.Drawing.Size(270, 20);
            this.lueApp.TabIndex = 1;
            // 
            // DictDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Name = "DictDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmeRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public TextEdit txtName;
        private LabelControl labName;
        public TextEdit txtCode;
        private LabelControl labCode;
        public MemoEdit mmeRemark;
        private LabelControl labRemark;
        private LabelControl labApp;
        public LookUpEdit lueApp;
    }
}