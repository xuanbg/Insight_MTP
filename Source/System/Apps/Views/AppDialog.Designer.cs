namespace Insight.MTP.Client.Setting.Apps.Views
{
    partial class AppDialog
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
            this.labAlias = new DevExpress.XtraEditors.LabelControl();
            this.txtAlias = new DevExpress.XtraEditors.TextEdit();
            this.labHost = new DevExpress.XtraEditors.LabelControl();
            this.txtHost = new DevExpress.XtraEditors.TextEdit();
            this.labPermitLife = new DevExpress.XtraEditors.LabelControl();
            this.txtPermitLife = new DevExpress.XtraEditors.TextEdit();
            this.labSecond = new DevExpress.XtraEditors.LabelControl();
            this.labTokenLife = new DevExpress.XtraEditors.LabelControl();
            this.txtTokenLife = new DevExpress.XtraEditors.TextEdit();
            this.labSecond2 = new DevExpress.XtraEditors.LabelControl();
            this.cheSigninOne = new DevExpress.XtraEditors.CheckEdit();
            this.cheAutoRefresh = new DevExpress.XtraEditors.CheckEdit();
            this.labIndex = new DevExpress.XtraEditors.LabelControl();
            this.spiIndex = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPermitLife.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTokenLife.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheSigninOne.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAutoRefresh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiIndex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.spiIndex);
            this.panel.Controls.Add(this.cheAutoRefresh);
            this.panel.Controls.Add(this.cheSigninOne);
            this.panel.Controls.Add(this.labSecond2);
            this.panel.Controls.Add(this.labSecond);
            this.panel.Controls.Add(this.txtTokenLife);
            this.panel.Controls.Add(this.labIndex);
            this.panel.Controls.Add(this.labTokenLife);
            this.panel.Controls.Add(this.txtPermitLife);
            this.panel.Controls.Add(this.labPermitLife);
            this.panel.Controls.Add(this.txtAlias);
            this.panel.Controls.Add(this.txtHost);
            this.panel.Controls.Add(this.labAlias);
            this.panel.Controls.Add(this.labHost);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labName);
            this.panel.Size = new System.Drawing.Size(370, 180);
            // 
            // cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.Location = new System.Drawing.Point(200, 204);
            // 
            // confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(290, 204);
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            this.close.Location = new System.Drawing.Point(290, 154);
            // 
            // labName
            // 
            this.labName.Appearance.Options.UseTextOptions = true;
            this.labName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labName.Location = new System.Drawing.Point(0, 20);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(60, 14);
            this.labName.TabIndex = 0;
            this.labName.Text = "名称：";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(60, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 1;
            // 
            // labAlias
            // 
            this.labAlias.Appearance.Options.UseTextOptions = true;
            this.labAlias.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAlias.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAlias.Location = new System.Drawing.Point(0, 50);
            this.labAlias.Name = "labAlias";
            this.labAlias.Size = new System.Drawing.Size(60, 14);
            this.labAlias.TabIndex = 0;
            this.labAlias.Text = "简称：";
            // 
            // txtAlias
            // 
            this.txtAlias.EnterMoveNextControl = true;
            this.txtAlias.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAlias.Location = new System.Drawing.Point(60, 48);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(150, 20);
            this.txtAlias.TabIndex = 2;
            // 
            // labHost
            // 
            this.labHost.Appearance.Options.UseTextOptions = true;
            this.labHost.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labHost.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labHost.Location = new System.Drawing.Point(0, 80);
            this.labHost.Name = "labHost";
            this.labHost.Size = new System.Drawing.Size(60, 14);
            this.labHost.TabIndex = 0;
            this.labHost.Text = "域名：";
            // 
            // txtHost
            // 
            this.txtHost.EnterMoveNextControl = true;
            this.txtHost.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtHost.Location = new System.Drawing.Point(60, 78);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(150, 20);
            this.txtHost.TabIndex = 3;
            // 
            // labPermitLife
            // 
            this.labPermitLife.Appearance.Options.UseTextOptions = true;
            this.labPermitLife.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labPermitLife.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labPermitLife.Location = new System.Drawing.Point(230, 50);
            this.labPermitLife.Name = "labPermitLife";
            this.labPermitLife.Size = new System.Drawing.Size(60, 14);
            this.labPermitLife.TabIndex = 0;
            this.labPermitLife.Text = "授权周期：";
            // 
            // txtPermitLife
            // 
            this.txtPermitLife.EditValue = "300";
            this.txtPermitLife.EnterMoveNextControl = true;
            this.txtPermitLife.Location = new System.Drawing.Point(290, 48);
            this.txtPermitLife.Name = "txtPermitLife";
            this.txtPermitLife.Properties.Mask.EditMask = "d";
            this.txtPermitLife.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPermitLife.Size = new System.Drawing.Size(40, 20);
            this.txtPermitLife.TabIndex = 4;
            // 
            // labSecond
            // 
            this.labSecond.Location = new System.Drawing.Point(337, 50);
            this.labSecond.Name = "labSecond";
            this.labSecond.Size = new System.Drawing.Size(12, 14);
            this.labSecond.TabIndex = 0;
            this.labSecond.Text = "秒";
            // 
            // labTokenLife
            // 
            this.labTokenLife.Appearance.Options.UseTextOptions = true;
            this.labTokenLife.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labTokenLife.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labTokenLife.Location = new System.Drawing.Point(230, 80);
            this.labTokenLife.Name = "labTokenLife";
            this.labTokenLife.Size = new System.Drawing.Size(60, 14);
            this.labTokenLife.TabIndex = 0;
            this.labTokenLife.Text = "令牌周期：";
            // 
            // txtTokenLife
            // 
            this.txtTokenLife.EditValue = "7200";
            this.txtTokenLife.EnterMoveNextControl = true;
            this.txtTokenLife.Location = new System.Drawing.Point(290, 77);
            this.txtTokenLife.Name = "txtTokenLife";
            this.txtTokenLife.Properties.Mask.EditMask = "d";
            this.txtTokenLife.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTokenLife.Size = new System.Drawing.Size(40, 20);
            this.txtTokenLife.TabIndex = 5;
            // 
            // labSecond2
            // 
            this.labSecond2.Location = new System.Drawing.Point(337, 80);
            this.labSecond2.Name = "labSecond2";
            this.labSecond2.Size = new System.Drawing.Size(12, 14);
            this.labSecond2.TabIndex = 0;
            this.labSecond2.Text = "秒";
            // 
            // cheSigninOne
            // 
            this.cheSigninOne.EnterMoveNextControl = true;
            this.cheSigninOne.Location = new System.Drawing.Point(20, 110);
            this.cheSigninOne.Name = "cheSigninOne";
            this.cheSigninOne.Properties.Caption = "仅允许单设备登录";
            this.cheSigninOne.Size = new System.Drawing.Size(120, 19);
            this.cheSigninOne.TabIndex = 7;
            // 
            // cheAutoRefresh
            // 
            this.cheAutoRefresh.EnterMoveNextControl = true;
            this.cheAutoRefresh.Location = new System.Drawing.Point(20, 140);
            this.cheAutoRefresh.Name = "cheAutoRefresh";
            this.cheAutoRefresh.Properties.Caption = "自动刷新令牌";
            this.cheAutoRefresh.Size = new System.Drawing.Size(100, 19);
            this.cheAutoRefresh.TabIndex = 8;
            // 
            // labIndex
            // 
            this.labIndex.Appearance.Options.UseTextOptions = true;
            this.labIndex.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labIndex.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labIndex.Location = new System.Drawing.Point(230, 110);
            this.labIndex.Name = "labIndex";
            this.labIndex.Size = new System.Drawing.Size(60, 14);
            this.labIndex.TabIndex = 0;
            this.labIndex.Text = "序号：";
            // 
            // spiIndex
            // 
            this.spiIndex.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spiIndex.EnterMoveNextControl = true;
            this.spiIndex.Location = new System.Drawing.Point(290, 110);
            this.spiIndex.Name = "spiIndex";
            this.spiIndex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiIndex.Properties.IsFloatValue = false;
            this.spiIndex.Properties.Mask.EditMask = "N00";
            this.spiIndex.Size = new System.Drawing.Size(60, 20);
            this.spiIndex.TabIndex = 6;
            // 
            // AppDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 242);
            this.Name = "AppDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPermitLife.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTokenLife.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheSigninOne.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAutoRefresh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiIndex.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labPermitLife;
        private DevExpress.XtraEditors.LabelControl labAlias;
        private DevExpress.XtraEditors.LabelControl labHost;
        private DevExpress.XtraEditors.LabelControl labName;
        private DevExpress.XtraEditors.LabelControl labSecond;
        private DevExpress.XtraEditors.LabelControl labSecond2;
        private DevExpress.XtraEditors.LabelControl labTokenLife;
        private DevExpress.XtraEditors.LabelControl labIndex;
        public DevExpress.XtraEditors.TextEdit txtTokenLife;
        public DevExpress.XtraEditors.CheckEdit cheAutoRefresh;
        public DevExpress.XtraEditors.CheckEdit cheSigninOne;
        public DevExpress.XtraEditors.SpinEdit spiIndex;
        public DevExpress.XtraEditors.TextEdit txtAlias;
        public DevExpress.XtraEditors.TextEdit txtName;
        public DevExpress.XtraEditors.TextEdit txtPermitLife;
        public DevExpress.XtraEditors.TextEdit txtHost;
    }
}