namespace Insight.MTP.Client.Platform.Scenes.Views
{
    partial class ConfigDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.labSign = new DevExpress.XtraEditors.LabelControl();
            this.txtSign = new DevExpress.XtraEditors.TextEdit();
            this.labApp = new DevExpress.XtraEditors.LabelControl();
            this.lueApp = new DevExpress.XtraEditors.LookUpEdit();
            this.memContent = new DevExpress.XtraEditors.MemoEdit();
            this.labContent = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.labExpire = new DevExpress.XtraEditors.LabelControl();
            this.speExpire = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speExpire.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Controls.Add(this.memContent);
            this.panel.Controls.Add(this.labContent);
            this.panel.Controls.Add(this.txtSign);
            this.panel.Controls.Add(this.labExpire);
            this.panel.Controls.Add(this.labApp);
            this.panel.Controls.Add(this.labSign);
            this.panel.Controls.Add(this.lueApp);
            this.panel.Controls.Add(this.speExpire);
            this.panel.Size = new System.Drawing.Size(370, 278);
            // 
            // cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.Location = new System.Drawing.Point(200, 303);
            // 
            // confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(290, 302);
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            this.close.Location = new System.Drawing.Point(290, 303);
            // 
            // labSign
            // 
            this.labSign.Appearance.Options.UseTextOptions = true;
            this.labSign.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labSign.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labSign.Location = new System.Drawing.Point(0, 180);
            this.labSign.Name = "labSign";
            this.labSign.Size = new System.Drawing.Size(80, 20);
            this.labSign.TabIndex = 0;
            this.labSign.Text = "签名：";
            // 
            // txtSign
            // 
            this.txtSign.EnterMoveNextControl = true;
            this.txtSign.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSign.Location = new System.Drawing.Point(80, 180);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(100, 20);
            this.txtSign.TabIndex = 3;
            // 
            // labApp
            // 
            this.labApp.Appearance.Options.UseTextOptions = true;
            this.labApp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labApp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labApp.Location = new System.Drawing.Point(0, 20);
            this.labApp.Name = "labApp";
            this.labApp.Size = new System.Drawing.Size(80, 20);
            this.labApp.TabIndex = 0;
            this.labApp.Text = "绑定应用：";
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
            // memContent
            // 
            this.memContent.EnterMoveNextControl = true;
            this.memContent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.memContent.Location = new System.Drawing.Point(80, 50);
            this.memContent.Name = "memContent";
            this.memContent.Size = new System.Drawing.Size(270, 120);
            this.memContent.TabIndex = 2;
            // 
            // labContent
            // 
            this.labContent.Appearance.Options.UseTextOptions = true;
            this.labContent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labContent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labContent.Location = new System.Drawing.Point(0, 50);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(80, 20);
            this.labContent.TabIndex = 0;
            this.labContent.Text = "内容模板：";
            // 
            // memRemark
            // 
            this.memRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.memRemark.Location = new System.Drawing.Point(80, 210);
            this.memRemark.Name = "memRemark";
            this.memRemark.Size = new System.Drawing.Size(270, 45);
            this.memRemark.TabIndex = 5;
            // 
            // labRemark
            // 
            this.labRemark.Appearance.Options.UseTextOptions = true;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(0, 210);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(80, 14);
            this.labRemark.TabIndex = 0;
            this.labRemark.Text = "备注：";
            // 
            // labExpire
            // 
            this.labExpire.Appearance.Options.UseTextOptions = true;
            this.labExpire.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labExpire.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labExpire.Location = new System.Drawing.Point(180, 180);
            this.labExpire.Name = "labExpire";
            this.labExpire.Size = new System.Drawing.Size(80, 20);
            this.labExpire.TabIndex = 0;
            this.labExpire.Text = "有效时长：";
            // 
            // speExpire
            // 
            this.speExpire.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speExpire.EnterMoveNextControl = true;
            this.speExpire.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.speExpire.Location = new System.Drawing.Point(263, 180);
            this.speExpire.Name = "speExpire";
            this.speExpire.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speExpire.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.speExpire.Properties.IsFloatValue = false;
            this.speExpire.Properties.Mask.EditMask = "N00";
            this.speExpire.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.speExpire.Properties.MaxValue = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.speExpire.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speExpire.Size = new System.Drawing.Size(87, 20);
            this.speExpire.TabIndex = 4;
            // 
            // ConfigDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Name = "ConfigDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speExpire.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labSign;
        private DevExpress.XtraEditors.LabelControl labApp;
        public DevExpress.XtraEditors.TextEdit txtSign;
        public DevExpress.XtraEditors.LookUpEdit lueApp;
        public DevExpress.XtraEditors.MemoEdit memRemark;
        private DevExpress.XtraEditors.LabelControl labRemark;
        public DevExpress.XtraEditors.MemoEdit memContent;
        private DevExpress.XtraEditors.LabelControl labContent;
        private DevExpress.XtraEditors.LabelControl labExpire;
        public DevExpress.XtraEditors.SpinEdit speExpire;
    }
}