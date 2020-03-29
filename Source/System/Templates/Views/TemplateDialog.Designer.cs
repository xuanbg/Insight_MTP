namespace Insight.MTP.Client.Setting.Templates.Views
{
    partial class TemplateDialog
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
            this.labTag = new DevExpress.XtraEditors.LabelControl();
            this.txtTag = new DevExpress.XtraEditors.TextEdit();
            this.labAlias = new DevExpress.XtraEditors.LabelControl();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.labExpire = new DevExpress.XtraEditors.LabelControl();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.lueType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labHouse = new DevExpress.XtraEditors.LabelControl();
            this.spiExpire = new DevExpress.XtraEditors.SpinEdit();
            this.labContent = new DevExpress.XtraEditors.LabelControl();
            this.memContent = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiExpire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memContent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.memContent);
            this.panel.Controls.Add(this.labContent);
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Controls.Add(this.txtTitle);
            this.panel.Controls.Add(this.labAlias);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.labHouse);
            this.panel.Controls.Add(this.labExpire);
            this.panel.Controls.Add(this.txtTag);
            this.panel.Controls.Add(this.labTag);
            this.panel.Controls.Add(this.lueType);
            this.panel.Controls.Add(this.spiExpire);
            this.panel.Size = new System.Drawing.Size(570, 280);
            // 
            // cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.Location = new System.Drawing.Point(400, 304);
            // 
            // confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(490, 304);
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            this.close.Location = new System.Drawing.Point(490, 304);
            // 
            // labTag
            // 
            this.labTag.Appearance.Options.UseTextOptions = true;
            this.labTag.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labTag.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labTag.Location = new System.Drawing.Point(160, 25);
            this.labTag.Name = "labTag";
            this.labTag.Size = new System.Drawing.Size(60, 14);
            this.labTag.TabIndex = 0;
            this.labTag.Text = "标签：";
            // 
            // txtTag
            // 
            this.txtTag.EnterMoveNextControl = true;
            this.txtTag.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTag.Location = new System.Drawing.Point(220, 23);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(160, 20);
            this.txtTag.TabIndex = 2;
            // 
            // labAlias
            // 
            this.labAlias.Appearance.Options.UseTextOptions = true;
            this.labAlias.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAlias.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAlias.Location = new System.Drawing.Point(0, 25);
            this.labAlias.Name = "labAlias";
            this.labAlias.Size = new System.Drawing.Size(60, 14);
            this.labAlias.TabIndex = 0;
            this.labAlias.Text = "类型：";
            // 
            // txtTitle
            // 
            this.txtTitle.EnterMoveNextControl = true;
            this.txtTitle.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTitle.Location = new System.Drawing.Point(60, 53);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(490, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // labExpire
            // 
            this.labExpire.Appearance.Options.UseTextOptions = true;
            this.labExpire.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labExpire.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labExpire.Location = new System.Drawing.Point(380, 25);
            this.labExpire.Name = "labExpire";
            this.labExpire.Size = new System.Drawing.Size(80, 14);
            this.labExpire.TabIndex = 0;
            this.labExpire.Text = "有效时长：";
            // 
            // labRemark
            // 
            this.labRemark.Appearance.Options.UseTextOptions = true;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(0, 210);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(60, 14);
            this.labRemark.TabIndex = 0;
            this.labRemark.Text = "备注：";
            // 
            // memRemark
            // 
            this.memRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.memRemark.Location = new System.Drawing.Point(60, 208);
            this.memRemark.Name = "memRemark";
            this.memRemark.Size = new System.Drawing.Size(490, 50);
            this.memRemark.TabIndex = 6;
            // 
            // lueType
            // 
            this.lueType.EnterMoveNextControl = true;
            this.lueType.Location = new System.Drawing.Point(60, 23);
            this.lueType.Name = "lueType";
            this.lueType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueType.Properties.NullText = "";
            this.lueType.Properties.PopupSizeable = false;
            this.lueType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueType.Size = new System.Drawing.Size(100, 20);
            this.lueType.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "标题：";
            // 
            // labHouse
            // 
            this.labHouse.Location = new System.Drawing.Point(525, 25);
            this.labHouse.Name = "labHouse";
            this.labHouse.Size = new System.Drawing.Size(24, 14);
            this.labHouse.TabIndex = 0;
            this.labHouse.Text = "小时";
            // 
            // spiExpire
            // 
            this.spiExpire.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spiExpire.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.spiExpire.Location = new System.Drawing.Point(460, 23);
            this.spiExpire.Name = "spiExpire";
            this.spiExpire.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiExpire.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spiExpire.Properties.IsFloatValue = false;
            this.spiExpire.Properties.Mask.EditMask = "N00";
            this.spiExpire.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spiExpire.Size = new System.Drawing.Size(60, 20);
            this.spiExpire.TabIndex = 3;
            // 
            // labContent
            // 
            this.labContent.Appearance.Options.UseTextOptions = true;
            this.labContent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labContent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labContent.Location = new System.Drawing.Point(0, 85);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(60, 14);
            this.labContent.TabIndex = 0;
            this.labContent.Text = "文案：";
            // 
            // memContent
            // 
            this.memContent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.memContent.Location = new System.Drawing.Point(60, 83);
            this.memContent.Name = "memContent";
            this.memContent.Size = new System.Drawing.Size(490, 115);
            this.memContent.TabIndex = 5;
            // 
            // TemplateDialog
            // 
            this.ClientSize = new System.Drawing.Size(584, 342);
            this.Name = "TemplateDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiExpire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memContent.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labAlias;
        private DevExpress.XtraEditors.LabelControl labExpire;
        private DevExpress.XtraEditors.LabelControl labTag;
        public DevExpress.XtraEditors.TextEdit txtTitle;
        public DevExpress.XtraEditors.TextEdit txtTag;
        public DevExpress.XtraEditors.MemoEdit memRemark;
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LookUpEdit lueType;
        private DevExpress.XtraEditors.LabelControl labHouse;
        public DevExpress.XtraEditors.SpinEdit spiExpire;
        public DevExpress.XtraEditors.MemoEdit memContent;
        private DevExpress.XtraEditors.LabelControl labContent;
    }
}