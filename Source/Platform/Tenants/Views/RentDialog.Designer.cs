namespace Insight.MTP.Client.Platform.Tenants.Views
{
    public partial class RentDialog
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
            this.labUnlockPw = new DevExpress.XtraEditors.LabelControl();
            this.datRent = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datRent.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datRent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.datRent);
            this.panel.Controls.Add(this.labUnlockPw);
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
            // labUnlockPw
            // 
            this.labUnlockPw.Appearance.Options.UseTextOptions = true;
            this.labUnlockPw.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labUnlockPw.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labUnlockPw.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labUnlockPw.Location = new System.Drawing.Point(65, 65);
            this.labUnlockPw.Name = "labUnlockPw";
            this.labUnlockPw.Size = new System.Drawing.Size(80, 21);
            this.labUnlockPw.TabIndex = 3;
            this.labUnlockPw.Text = "续租至：";
            // 
            // datRent
            // 
            this.datRent.EditValue = null;
            this.datRent.Location = new System.Drawing.Point(150, 65);
            this.datRent.Name = "datRent";
            this.datRent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datRent.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datRent.Size = new System.Drawing.Size(100, 20);
            this.datRent.TabIndex = 1;
            // 
            // ExtendDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Name = "ExtendDialog";
            this.Text = "锁定";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datRent.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datRent.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labUnlockPw;
        public DevExpress.XtraEditors.DateEdit datRent;
    }
}