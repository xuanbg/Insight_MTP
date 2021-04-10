namespace Insight.MTP.Client.Setting.Roles.Views
{
    partial class RoleDialog
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
            this.labMethod = new DevExpress.XtraEditors.LabelControl();
            this.labType = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.lueApp = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labMethod);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labType);
            this.panel.Controls.Add(this.labName);
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.lueApp);
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
            this.labName.Size = new System.Drawing.Size(80, 14);
            this.labName.TabIndex = 0;
            this.labName.Text = "名称：";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(80, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 20);
            this.txtName.TabIndex = 2;
            // 
            // labMethod
            // 
            this.labMethod.Appearance.Options.UseTextOptions = true;
            this.labMethod.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labMethod.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labMethod.Location = new System.Drawing.Point(0, 85);
            this.labMethod.Name = "labMethod";
            this.labMethod.Size = new System.Drawing.Size(80, 14);
            this.labMethod.TabIndex = 0;
            this.labMethod.Text = "备注：";
            // 
            // labType
            // 
            this.labType.Appearance.Options.UseTextOptions = true;
            this.labType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labType.Location = new System.Drawing.Point(0, 20);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(80, 14);
            this.labType.TabIndex = 0;
            this.labType.Text = "所属应用：";
            // 
            // memRemark
            // 
            this.memRemark.EnterMoveNextControl = true;
            this.memRemark.ImeMode = System.Windows.Forms.ImeMode.On;
            this.memRemark.Location = new System.Drawing.Point(80, 83);
            this.memRemark.Name = "memRemark";
            this.memRemark.Size = new System.Drawing.Size(270, 45);
            this.memRemark.TabIndex = 3;
            // 
            // lueApp
            // 
            this.lueApp.EnterMoveNextControl = true;
            this.lueApp.Location = new System.Drawing.Point(80, 17);
            this.lueApp.Name = "lueApp";
            this.lueApp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueApp.Properties.NullText = "";
            this.lueApp.Properties.PopupSizeable = false;
            this.lueApp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueApp.Size = new System.Drawing.Size(270, 20);
            this.lueApp.TabIndex = 1;
            // 
            // RoleDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Name = "RoleDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labName;
        private DevExpress.XtraEditors.LabelControl labMethod;
        private DevExpress.XtraEditors.LabelControl labType;
        public DevExpress.XtraEditors.TextEdit txtName;
        public DevExpress.XtraEditors.LookUpEdit lueApp;
        public DevExpress.XtraEditors.MemoEdit memRemark;
    }
}