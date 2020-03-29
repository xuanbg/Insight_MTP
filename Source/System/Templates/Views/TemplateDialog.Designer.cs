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
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labAlias = new DevExpress.XtraEditors.LabelControl();
            this.txtUrl = new DevExpress.XtraEditors.TextEdit();
            this.labAuth = new DevExpress.XtraEditors.LabelControl();
            this.txtAuth = new DevExpress.XtraEditors.TextEdit();
            this.labCycle = new DevExpress.XtraEditors.LabelControl();
            this.txtCycle = new DevExpress.XtraEditors.TextEdit();
            this.labSecond2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMax = new DevExpress.XtraEditors.TextEdit();
            this.cheVerify = new DevExpress.XtraEditors.CheckEdit();
            this.cheLimit = new DevExpress.XtraEditors.CheckEdit();
            this.cheNeedToken = new DevExpress.XtraEditors.CheckEdit();
            this.labGap = new DevExpress.XtraEditors.LabelControl();
            this.spiGap = new DevExpress.XtraEditors.SpinEdit();
            this.cheLogResult = new DevExpress.XtraEditors.CheckEdit();
            this.cbeMethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lablabSecond1 = new DevExpress.XtraEditors.LabelControl();
            this.labPreCycle = new DevExpress.XtraEditors.LabelControl();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.memRemark = new DevExpress.XtraEditors.MemoEdit();
            this.labMessage = new DevExpress.XtraEditors.LabelControl();
            this.panLimit = new DevExpress.XtraEditors.PanelControl();
            this.txtMessage = new DevExpress.XtraEditors.TextEdit();
            this.sepLimit = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCycle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheVerify.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheNeedToken.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiGap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLogResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panLimit)).BeginInit();
            this.panLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.sepLimit);
            this.panel.Controls.Add(this.memRemark);
            this.panel.Controls.Add(this.cbeMethod);
            this.panel.Controls.Add(this.cheLogResult);
            this.panel.Controls.Add(this.cheNeedToken);
            this.panel.Controls.Add(this.cheLimit);
            this.panel.Controls.Add(this.cheVerify);
            this.panel.Controls.Add(this.labRemark);
            this.panel.Controls.Add(this.txtUrl);
            this.panel.Controls.Add(this.txtAuth);
            this.panel.Controls.Add(this.labAlias);
            this.panel.Controls.Add(this.labAuth);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.labName);
            this.panel.Controls.Add(this.panLimit);
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
            // labName
            // 
            this.labName.Appearance.Options.UseTextOptions = true;
            this.labName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labName.Location = new System.Drawing.Point(0, 25);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(80, 14);
            this.labName.TabIndex = 0;
            this.labName.Text = "名称：";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(80, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 1;
            // 
            // labAlias
            // 
            this.labAlias.Appearance.Options.UseTextOptions = true;
            this.labAlias.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAlias.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAlias.Location = new System.Drawing.Point(0, 55);
            this.labAlias.Name = "labAlias";
            this.labAlias.Size = new System.Drawing.Size(80, 14);
            this.labAlias.TabIndex = 0;
            this.labAlias.Text = "接口URL：";
            // 
            // txtUrl
            // 
            this.txtUrl.EnterMoveNextControl = true;
            this.txtUrl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtUrl.Location = new System.Drawing.Point(170, 53);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(380, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // labAuth
            // 
            this.labAuth.Appearance.Options.UseTextOptions = true;
            this.labAuth.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labAuth.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labAuth.Location = new System.Drawing.Point(360, 25);
            this.labAuth.Name = "labAuth";
            this.labAuth.Size = new System.Drawing.Size(80, 14);
            this.labAuth.TabIndex = 0;
            this.labAuth.Text = "授权码：";
            // 
            // txtAuth
            // 
            this.txtAuth.EnterMoveNextControl = true;
            this.txtAuth.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAuth.Location = new System.Drawing.Point(440, 23);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(110, 20);
            this.txtAuth.TabIndex = 2;
            // 
            // labCycle
            // 
            this.labCycle.Appearance.Options.UseTextOptions = true;
            this.labCycle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labCycle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labCycle.Location = new System.Drawing.Point(160, 10);
            this.labCycle.Name = "labCycle";
            this.labCycle.Size = new System.Drawing.Size(20, 14);
            this.labCycle.TabIndex = 0;
            this.labCycle.Text = "在";
            // 
            // txtCycle
            // 
            this.txtCycle.EnterMoveNextControl = true;
            this.txtCycle.Location = new System.Drawing.Point(185, 8);
            this.txtCycle.Name = "txtCycle";
            this.txtCycle.Properties.Mask.EditMask = "d";
            this.txtCycle.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCycle.Size = new System.Drawing.Size(60, 20);
            this.txtCycle.TabIndex = 11;
            // 
            // labSecond2
            // 
            this.labSecond2.Location = new System.Drawing.Point(250, 10);
            this.labSecond2.Name = "labSecond2";
            this.labSecond2.Size = new System.Drawing.Size(84, 14);
            this.labSecond2.TabIndex = 0;
            this.labSecond2.Text = "秒内最多可访问";
            // 
            // txtMax
            // 
            this.txtMax.EnterMoveNextControl = true;
            this.txtMax.Location = new System.Drawing.Point(340, 8);
            this.txtMax.Name = "txtMax";
            this.txtMax.Properties.Mask.EditMask = "d";
            this.txtMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMax.Size = new System.Drawing.Size(59, 20);
            this.txtMax.TabIndex = 12;
            // 
            // cheVerify
            // 
            this.cheVerify.EnterMoveNextControl = true;
            this.cheVerify.Location = new System.Drawing.Point(20, 145);
            this.cheVerify.Name = "cheVerify";
            this.cheVerify.Properties.Caption = "验证令牌";
            this.cheVerify.Size = new System.Drawing.Size(100, 19);
            this.cheVerify.TabIndex = 6;
            // 
            // cheLimit
            // 
            this.cheLimit.EnterMoveNextControl = true;
            this.cheLimit.Location = new System.Drawing.Point(20, 195);
            this.cheLimit.Name = "cheLimit";
            this.cheLimit.Properties.Caption = "访问限流";
            this.cheLimit.Size = new System.Drawing.Size(80, 19);
            this.cheLimit.TabIndex = 9;
            // 
            // cheNeedToken
            // 
            this.cheNeedToken.EnterMoveNextControl = true;
            this.cheNeedToken.Location = new System.Drawing.Point(300, 145);
            this.cheNeedToken.Name = "cheNeedToken";
            this.cheNeedToken.Properties.Caption = "需要一次性提交数据Token";
            this.cheNeedToken.Size = new System.Drawing.Size(160, 19);
            this.cheNeedToken.TabIndex = 8;
            // 
            // labGap
            // 
            this.labGap.Appearance.Options.UseTextOptions = true;
            this.labGap.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labGap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labGap.Location = new System.Drawing.Point(0, 10);
            this.labGap.Name = "labGap";
            this.labGap.Size = new System.Drawing.Size(70, 14);
            this.labGap.TabIndex = 0;
            this.labGap.Text = "最小间隔：";
            // 
            // spiGap
            // 
            this.spiGap.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spiGap.EnterMoveNextControl = true;
            this.spiGap.Location = new System.Drawing.Point(70, 8);
            this.spiGap.Name = "spiGap";
            this.spiGap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiGap.Properties.IsFloatValue = false;
            this.spiGap.Properties.Mask.EditMask = "N00";
            this.spiGap.Size = new System.Drawing.Size(60, 20);
            this.spiGap.TabIndex = 10;
            // 
            // cheLogResult
            // 
            this.cheLogResult.EnterMoveNextControl = true;
            this.cheLogResult.Location = new System.Drawing.Point(140, 145);
            this.cheLogResult.Name = "cheLogResult";
            this.cheLogResult.Properties.Caption = "日志输出返回值";
            this.cheLogResult.Size = new System.Drawing.Size(140, 19);
            this.cheLogResult.TabIndex = 7;
            // 
            // cbeMethod
            // 
            this.cbeMethod.EditValue = "GET";
            this.cbeMethod.Location = new System.Drawing.Point(80, 53);
            this.cbeMethod.Name = "cbeMethod";
            this.cbeMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeMethod.Properties.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cbeMethod.Size = new System.Drawing.Size(85, 20);
            this.cbeMethod.TabIndex = 3;
            // 
            // lablabSecond1
            // 
            this.lablabSecond1.Location = new System.Drawing.Point(135, 10);
            this.lablabSecond1.Name = "lablabSecond1";
            this.lablabSecond1.Size = new System.Drawing.Size(12, 14);
            this.lablabSecond1.TabIndex = 0;
            this.lablabSecond1.Text = "秒";
            // 
            // labPreCycle
            // 
            this.labPreCycle.Location = new System.Drawing.Point(405, 10);
            this.labPreCycle.Name = "labPreCycle";
            this.labPreCycle.Size = new System.Drawing.Size(12, 14);
            this.labPreCycle.TabIndex = 0;
            this.labPreCycle.Text = "次";
            // 
            // labRemark
            // 
            this.labRemark.Appearance.Options.UseTextOptions = true;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(0, 85);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(80, 14);
            this.labRemark.TabIndex = 0;
            this.labRemark.Text = "备注：";
            // 
            // memRemark
            // 
            this.memRemark.Location = new System.Drawing.Point(80, 83);
            this.memRemark.Name = "memRemark";
            this.memRemark.Size = new System.Drawing.Size(470, 50);
            this.memRemark.TabIndex = 5;
            // 
            // labMessage
            // 
            this.labMessage.Appearance.Options.UseTextOptions = true;
            this.labMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labMessage.Location = new System.Drawing.Point(0, 40);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(70, 14);
            this.labMessage.TabIndex = 0;
            this.labMessage.Text = "限流消息：";
            // 
            // panLimit
            // 
            this.panLimit.Controls.Add(this.labGap);
            this.panLimit.Controls.Add(this.labCycle);
            this.panLimit.Controls.Add(this.txtCycle);
            this.panLimit.Controls.Add(this.spiGap);
            this.panLimit.Controls.Add(this.labMessage);
            this.panLimit.Controls.Add(this.txtMax);
            this.panLimit.Controls.Add(this.labSecond2);
            this.panLimit.Controls.Add(this.txtMessage);
            this.panLimit.Controls.Add(this.labPreCycle);
            this.panLimit.Controls.Add(this.lablabSecond1);
            this.panLimit.Location = new System.Drawing.Point(120, 195);
            this.panLimit.Name = "panLimit";
            this.panLimit.Size = new System.Drawing.Size(430, 65);
            this.panLimit.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.EnterMoveNextControl = true;
            this.txtMessage.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMessage.Location = new System.Drawing.Point(70, 37);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(347, 20);
            this.txtMessage.TabIndex = 13;
            // 
            // sepLimit
            // 
            this.sepLimit.Location = new System.Drawing.Point(5, 170);
            this.sepLimit.Name = "sepLimit";
            this.sepLimit.Size = new System.Drawing.Size(560, 21);
            this.sepLimit.TabIndex = 0;
            // 
            // InterfaceDialog
            // 
            this.ClientSize = new System.Drawing.Size(584, 342);
            this.Name = "InterfaceDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCycle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheVerify.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheNeedToken.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiGap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheLogResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panLimit)).EndInit();
            this.panLimit.ResumeLayout(false);
            this.panLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labCycle;
        private DevExpress.XtraEditors.LabelControl labAlias;
        private DevExpress.XtraEditors.LabelControl labAuth;
        private DevExpress.XtraEditors.LabelControl labName;
        private DevExpress.XtraEditors.LabelControl labSecond2;
        private DevExpress.XtraEditors.LabelControl labGap;
        public DevExpress.XtraEditors.TextEdit txtMax;
        public DevExpress.XtraEditors.CheckEdit cheNeedToken;
        public DevExpress.XtraEditors.CheckEdit cheLimit;
        public DevExpress.XtraEditors.CheckEdit cheVerify;
        public DevExpress.XtraEditors.SpinEdit spiGap;
        public DevExpress.XtraEditors.TextEdit txtUrl;
        public DevExpress.XtraEditors.TextEdit txtName;
        public DevExpress.XtraEditors.TextEdit txtCycle;
        public DevExpress.XtraEditors.TextEdit txtAuth;
        public DevExpress.XtraEditors.CheckEdit cheLogResult;
        public DevExpress.XtraEditors.ComboBoxEdit cbeMethod;
        private DevExpress.XtraEditors.LabelControl lablabSecond1;
        private DevExpress.XtraEditors.LabelControl labPreCycle;
        public DevExpress.XtraEditors.MemoEdit memRemark;
        private DevExpress.XtraEditors.LabelControl labRemark;
        private DevExpress.XtraEditors.LabelControl labMessage;
        public DevExpress.XtraEditors.TextEdit txtMessage;
        private DevExpress.XtraEditors.SeparatorControl sepLimit;
        public DevExpress.XtraEditors.PanelControl panLimit;
    }
}