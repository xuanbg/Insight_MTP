using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Insight.MTP.Client.MainApp.Views
{
    public partial class view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view));
            this.labUser = new DevExpress.XtraEditors.LabelControl();
            this.labPassword = new DevExpress.XtraEditors.LabelControl();
            this.UserNameInput = new DevExpress.XtraEditors.TextEdit();
            this.PassWordInput = new DevExpress.XtraEditors.TextEdit();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.SetButton = new DevExpress.XtraEditors.SimpleButton();
            this.LoginButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWordInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labUser
            // 
            this.labUser.Appearance.Options.UseTextOptions = true;
            this.labUser.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labUser.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labUser.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labUser.Location = new System.Drawing.Point(130, 145);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(80, 21);
            this.labUser.TabIndex = 0;
            this.labUser.Text = "用 户 名：";
            // 
            // labPassword
            // 
            this.labPassword.Appearance.Options.UseTextOptions = true;
            this.labPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labPassword.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labPassword.CausesValidation = false;
            this.labPassword.Location = new System.Drawing.Point(130, 180);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(80, 21);
            this.labPassword.TabIndex = 0;
            this.labPassword.Text = "密 码：";
            // 
            // UserNameInput
            // 
            this.UserNameInput.EnterMoveNextControl = true;
            this.UserNameInput.Location = new System.Drawing.Point(210, 145);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Properties.AutoHeight = false;
            this.UserNameInput.Size = new System.Drawing.Size(160, 21);
            this.UserNameInput.TabIndex = 0;
            // 
            // PassWordInput
            // 
            this.PassWordInput.EditValue = "";
            this.PassWordInput.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PassWordInput.Location = new System.Drawing.Point(210, 180);
            this.PassWordInput.Name = "PassWordInput";
            this.PassWordInput.Properties.AutoHeight = false;
            this.PassWordInput.Properties.PasswordChar = '○';
            this.PassWordInput.Size = new System.Drawing.Size(160, 21);
            this.PassWordInput.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.Appearance.Options.UseFont = true;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(130, 230);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "取  消";
            // 
            // SetButton
            // 
            this.SetButton.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetButton.Appearance.Options.UseFont = true;
            this.SetButton.Location = new System.Drawing.Point(220, 230);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(80, 23);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "设  置";
            // 
            // LoginButton
            // 
            this.LoginButton.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginButton.Appearance.Options.UseFont = true;
            this.LoginButton.Location = new System.Drawing.Point(310, 230);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(80, 23);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "登  录";
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Zoom;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PassWordInput);
            this.Controls.Add(this.UserNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insight Workstation 3";
            ((System.ComponentModel.ISupportInitialize)(this.UserNameInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWordInput.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LabelControl labUser;
        private LabelControl labPassword;
        internal TextEdit UserNameInput;
        internal TextEdit PassWordInput;
        internal SimpleButton CloseButton;
        internal SimpleButton SetButton;
        internal SimpleButton LoginButton;
    }
}