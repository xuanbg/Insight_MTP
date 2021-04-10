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
            this.lueTemplate = new DevExpress.XtraEditors.LookUpEdit();
            this.labTemplate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTemplate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtSign);
            this.panel.Controls.Add(this.labTemplate);
            this.panel.Controls.Add(this.labApp);
            this.panel.Controls.Add(this.labSign);
            this.panel.Controls.Add(this.lueTemplate);
            this.panel.Controls.Add(this.lueApp);
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
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            // 
            // labSign
            // 
            this.labSign.Appearance.Options.UseTextOptions = true;
            this.labSign.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labSign.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labSign.Location = new System.Drawing.Point(0, 100);
            this.labSign.Name = "labSign";
            this.labSign.Size = new System.Drawing.Size(80, 14);
            this.labSign.TabIndex = 0;
            this.labSign.Text = "签名：";
            // 
            // txtSign
            // 
            this.txtSign.EnterMoveNextControl = true;
            this.txtSign.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSign.Location = new System.Drawing.Point(80, 97);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(270, 20);
            this.txtSign.TabIndex = 3;
            // 
            // labApp
            // 
            this.labApp.Appearance.Options.UseTextOptions = true;
            this.labApp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labApp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labApp.Location = new System.Drawing.Point(0, 65);
            this.labApp.Name = "labApp";
            this.labApp.Size = new System.Drawing.Size(80, 14);
            this.labApp.TabIndex = 0;
            this.labApp.Text = "绑定应用：";
            // 
            // lueApp
            // 
            this.lueApp.EnterMoveNextControl = true;
            this.lueApp.Location = new System.Drawing.Point(80, 62);
            this.lueApp.Name = "lueApp";
            this.lueApp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueApp.Properties.NullText = "";
            this.lueApp.Properties.PopupSizeable = false;
            this.lueApp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueApp.Size = new System.Drawing.Size(270, 20);
            this.lueApp.TabIndex = 2;
            // 
            // lueTemplate
            // 
            this.lueTemplate.EnterMoveNextControl = true;
            this.lueTemplate.Location = new System.Drawing.Point(80, 27);
            this.lueTemplate.Name = "lueTemplate";
            this.lueTemplate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTemplate.Properties.NullText = "";
            this.lueTemplate.Properties.PopupSizeable = false;
            this.lueTemplate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTemplate.Size = new System.Drawing.Size(270, 20);
            this.lueTemplate.TabIndex = 1;
            // 
            // labTemplate
            // 
            this.labTemplate.Appearance.Options.UseTextOptions = true;
            this.labTemplate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labTemplate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labTemplate.Location = new System.Drawing.Point(0, 30);
            this.labTemplate.Name = "labTemplate";
            this.labTemplate.Size = new System.Drawing.Size(80, 14);
            this.labTemplate.TabIndex = 0;
            this.labTemplate.Text = "消息模板：";
            // 
            // ConfigDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Name = "ConfigDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTemplate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labSign;
        private DevExpress.XtraEditors.LabelControl labApp;
        public DevExpress.XtraEditors.TextEdit txtSign;
        public DevExpress.XtraEditors.LookUpEdit lueApp;
        private DevExpress.XtraEditors.LabelControl labTemplate;
        public DevExpress.XtraEditors.LookUpEdit lueTemplate;
    }
}