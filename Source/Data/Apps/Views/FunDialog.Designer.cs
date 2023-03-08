namespace Insight.MTP.Client.Data.Apps.Views
{
    partial class FunDialog
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
            this.labIcon = new DevExpress.XtraEditors.LabelControl();
            this.txtIcon = new DevExpress.XtraEditors.TextEdit();
            this.labAlias = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthCode = new DevExpress.XtraEditors.TextEdit();
            this.labIndex = new DevExpress.XtraEditors.LabelControl();
            this.speIndex = new DevExpress.XtraEditors.SpinEdit();
            this.labMethod = new DevExpress.XtraEditors.LabelControl();
            this.txtMethod = new DevExpress.XtraEditors.TextEdit();
            this.chkGroup = new DevExpress.XtraEditors.CheckEdit();
            this.chkHideText = new DevExpress.XtraEditors.CheckEdit();
            this.labType = new DevExpress.XtraEditors.LabelControl();
            this.comType = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHideText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.comType);
            this.panel.Controls.Add(this.chkHideText);
            this.panel.Controls.Add(this.chkGroup);
            this.panel.Controls.Add(this.labIndex);
            this.panel.Controls.Add(this.txtIcon);
            this.panel.Controls.Add(this.txtMethod);
            this.panel.Controls.Add(this.txtAuthCode);
            this.panel.Controls.Add(this.labMethod);
            this.panel.Controls.Add(this.labIcon);
            this.panel.Controls.Add(this.labAlias);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labType);
            this.panel.Controls.Add(this.labName);
            this.panel.Controls.Add(this.speIndex);
            this.panel.Size = new System.Drawing.Size(370, 148);
            // 
            // cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            // 
            // confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(290, 172);
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            // 
            // labName
            // 
            this.labName.Appearance.Options.UseTextOptions = true;
            this.labName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labName.Location = new System.Drawing.Point(0, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(60, 14);
            this.labName.TabIndex = 0;
            this.labName.Text = "名称：";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(60, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 3;
            // 
            // labIcon
            // 
            this.labIcon.Appearance.Options.UseTextOptions = true;
            this.labIcon.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labIcon.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labIcon.Location = new System.Drawing.Point(0, 115);
            this.labIcon.Name = "labIcon";
            this.labIcon.Size = new System.Drawing.Size(60, 14);
            this.labIcon.TabIndex = 0;
            this.labIcon.Text = "图标Url：";
            // 
            // txtIcon
            // 
            this.txtIcon.EnterMoveNextControl = true;
            this.txtIcon.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtIcon.Location = new System.Drawing.Point(60, 112);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(160, 20);
            this.txtIcon.TabIndex = 6;
            // 
            // labAlias
            // 
            this.labAlias.Appearance.Options.UseTextOptions = true;
            this.labAlias.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAlias.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAlias.Location = new System.Drawing.Point(220, 50);
            this.labAlias.Name = "labAlias";
            this.labAlias.Size = new System.Drawing.Size(60, 14);
            this.labAlias.TabIndex = 0;
            this.labAlias.Text = "标识码：";
            // 
            // txtAuthCode
            // 
            this.txtAuthCode.EnterMoveNextControl = true;
            this.txtAuthCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAuthCode.Location = new System.Drawing.Point(280, 47);
            this.txtAuthCode.Name = "txtAuthCode";
            this.txtAuthCode.Size = new System.Drawing.Size(70, 20);
            this.txtAuthCode.TabIndex = 4;
            // 
            // labIndex
            // 
            this.labIndex.Appearance.Options.UseTextOptions = true;
            this.labIndex.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labIndex.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labIndex.Location = new System.Drawing.Point(220, 21);
            this.labIndex.Name = "labIndex";
            this.labIndex.Size = new System.Drawing.Size(60, 14);
            this.labIndex.TabIndex = 0;
            this.labIndex.Text = "序号：";
            // 
            // speIndex
            // 
            this.speIndex.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speIndex.EnterMoveNextControl = true;
            this.speIndex.Location = new System.Drawing.Point(280, 18);
            this.speIndex.Name = "speIndex";
            this.speIndex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speIndex.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.speIndex.Properties.IsFloatValue = false;
            this.speIndex.Properties.Mask.EditMask = "d";
            this.speIndex.Size = new System.Drawing.Size(70, 20);
            this.speIndex.TabIndex = 2;
            // 
            // labMethod
            // 
            this.labMethod.Appearance.Options.UseTextOptions = true;
            this.labMethod.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labMethod.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labMethod.Location = new System.Drawing.Point(0, 85);
            this.labMethod.Name = "labMethod";
            this.labMethod.Size = new System.Drawing.Size(60, 14);
            this.labMethod.TabIndex = 0;
            this.labMethod.Text = "方法名：";
            // 
            // txtMethod
            // 
            this.txtMethod.EnterMoveNextControl = true;
            this.txtMethod.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtMethod.Location = new System.Drawing.Point(60, 82);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(160, 20);
            this.txtMethod.TabIndex = 5;
            // 
            // chkGroup
            // 
            this.chkGroup.EnterMoveNextControl = true;
            this.chkGroup.Location = new System.Drawing.Point(280, 83);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Properties.Caption = "开始分组";
            this.chkGroup.Size = new System.Drawing.Size(75, 19);
            this.chkGroup.TabIndex = 7;
            // 
            // chkHideText
            // 
            this.chkHideText.EnterMoveNextControl = true;
            this.chkHideText.Location = new System.Drawing.Point(280, 113);
            this.chkHideText.Name = "chkHideText";
            this.chkHideText.Properties.Caption = "隐藏文字";
            this.chkHideText.Size = new System.Drawing.Size(75, 19);
            this.chkHideText.TabIndex = 8;
            // 
            // labType
            // 
            this.labType.Appearance.Options.UseTextOptions = true;
            this.labType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labType.Location = new System.Drawing.Point(0, 20);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(60, 14);
            this.labType.TabIndex = 0;
            this.labType.Text = "类型：";
            // 
            // comType
            // 
            this.comType.EnterMoveNextControl = true;
            this.comType.Location = new System.Drawing.Point(60, 17);
            this.comType.Name = "comType";
            this.comType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comType.Properties.Items.AddRange(new object[] {
            "全局功能",
            "数据项功能",
            "其他功能"});
            this.comType.Size = new System.Drawing.Size(160, 20);
            this.comType.TabIndex = 1;
            // 
            // FunDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Name = "FunDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHideText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labIndex;
        private DevExpress.XtraEditors.LabelControl labIcon;
        private DevExpress.XtraEditors.LabelControl labAlias;
        private DevExpress.XtraEditors.LabelControl labName;
        private DevExpress.XtraEditors.LabelControl labMethod;
        private DevExpress.XtraEditors.LabelControl labType;
        public DevExpress.XtraEditors.TextEdit txtIcon;
        public DevExpress.XtraEditors.TextEdit txtMethod;
        public DevExpress.XtraEditors.CheckEdit chkHideText;
        public DevExpress.XtraEditors.CheckEdit chkGroup;
        public DevExpress.XtraEditors.ComboBoxEdit comType;
        public DevExpress.XtraEditors.TextEdit txtName;
        public DevExpress.XtraEditors.TextEdit txtAuthCode;
        public DevExpress.XtraEditors.SpinEdit speIndex;
    }
}