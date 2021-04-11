namespace Insight.MTP.Client.Platform.Scenes.Views
{
    partial class SceneDialog
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
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.labCode = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labType = new DevExpress.XtraEditors.LabelControl();
            this.labTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.cbeType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labTag = new DevExpress.XtraEditors.LabelControl();
            this.txtTag = new DevExpress.XtraEditors.TextEdit();
            this.labParam = new DevExpress.XtraEditors.LabelControl();
            this.txtParam = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.txtCode);
            this.panel.Controls.Add(this.labType);
            this.panel.Controls.Add(this.txtParam);
            this.panel.Controls.Add(this.txtTag);
            this.panel.Controls.Add(this.txtTitle);
            this.panel.Controls.Add(this.labParam);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labTag);
            this.panel.Controls.Add(this.labCode);
            this.panel.Controls.Add(this.labTitle);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Controls.Add(this.labName);
            this.panel.Controls.Add(this.cbeType);
            this.panel.Size = new System.Drawing.Size(370, 238);
            // 
            // cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.Location = new System.Drawing.Point(200, 263);
            // 
            // confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(290, 262);
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            this.close.Location = new System.Drawing.Point(290, 263);
            // 
            // labName
            // 
            this.labName.Appearance.Options.UseTextOptions = true;
            this.labName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labName.Location = new System.Drawing.Point(0, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(80, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "场景名称：";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(80, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 20);
            this.txtName.TabIndex = 3;
            // 
            // labRemark
            // 
            this.labRemark.Appearance.Options.UseTextOptions = true;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(0, 170);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(80, 14);
            this.labRemark.TabIndex = 0;
            this.labRemark.Text = "备注：";
            // 
            // memRemark
            // 
            this.memRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.memRemark.Location = new System.Drawing.Point(80, 170);
            this.memRemark.Name = "memRemark";
            this.memRemark.Size = new System.Drawing.Size(270, 45);
            this.memRemark.TabIndex = 7;
            // 
            // labCode
            // 
            this.labCode.Appearance.Options.UseTextOptions = true;
            this.labCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labCode.Location = new System.Drawing.Point(0, 20);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(80, 20);
            this.labCode.TabIndex = 0;
            this.labCode.Text = "编码：";
            // 
            // txtCode
            // 
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtCode.Location = new System.Drawing.Point(80, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            // 
            // labType
            // 
            this.labType.Appearance.Options.UseTextOptions = true;
            this.labType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labType.Location = new System.Drawing.Point(180, 20);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(60, 20);
            this.labType.TabIndex = 0;
            this.labType.Text = "类型：";
            // 
            // labTitle
            // 
            this.labTitle.Appearance.Options.UseTextOptions = true;
            this.labTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labTitle.Location = new System.Drawing.Point(0, 80);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(80, 20);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "消息标题：";
            // 
            // txtTitle
            // 
            this.txtTitle.EnterMoveNextControl = true;
            this.txtTitle.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTitle.Location = new System.Drawing.Point(80, 80);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(270, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // cbeType
            // 
            this.cbeType.EnterMoveNextControl = true;
            this.cbeType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbeType.Location = new System.Drawing.Point(240, 20);
            this.cbeType.Name = "cbeType";
            this.cbeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeType.Properties.Items.AddRange(new object[] {
            "不发送",
            "仅消息",
            "仅推送",
            "推送|消息",
            "仅短信",
            "短信|消息",
            "短信|推送",
            "全部"});
            this.cbeType.Size = new System.Drawing.Size(110, 20);
            this.cbeType.TabIndex = 2;
            // 
            // labTag
            // 
            this.labTag.Appearance.Options.UseTextOptions = true;
            this.labTag.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labTag.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labTag.Location = new System.Drawing.Point(0, 110);
            this.labTag.Name = "labTag";
            this.labTag.Size = new System.Drawing.Size(80, 20);
            this.labTag.TabIndex = 0;
            this.labTag.Text = "消息标签：";
            // 
            // txtTag
            // 
            this.txtTag.EnterMoveNextControl = true;
            this.txtTag.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTag.Location = new System.Drawing.Point(80, 110);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(270, 20);
            this.txtTag.TabIndex = 5;
            // 
            // labParam
            // 
            this.labParam.Appearance.Options.UseTextOptions = true;
            this.labParam.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labParam.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labParam.Location = new System.Drawing.Point(0, 140);
            this.labParam.Name = "labParam";
            this.labParam.Size = new System.Drawing.Size(80, 20);
            this.labParam.TabIndex = 0;
            this.labParam.Text = "消息参数：";
            // 
            // txtParam
            // 
            this.txtParam.EnterMoveNextControl = true;
            this.txtParam.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtParam.Location = new System.Drawing.Point(80, 140);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(270, 20);
            this.txtParam.TabIndex = 6;
            // 
            // SceneDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Name = "SceneDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labName;
        public DevExpress.XtraEditors.TextEdit txtName;
        public DevExpress.XtraEditors.MemoEdit memRemark;
        public DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labCode;
        private DevExpress.XtraEditors.LabelControl labType;
        public DevExpress.XtraEditors.TextEdit txtParam;
        public DevExpress.XtraEditors.TextEdit txtTag;
        public DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LabelControl labParam;
        private DevExpress.XtraEditors.LabelControl labTag;
        private DevExpress.XtraEditors.LabelControl labTitle;
        public DevExpress.XtraEditors.ComboBoxEdit cbeType;
    }
}