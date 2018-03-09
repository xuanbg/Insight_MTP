namespace Insight.MTP.Client.Base.Tenants.Views
{
    public partial class ExtendDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtendDialog));
            this.labUnlockPw = new DevExpress.XtraEditors.LabelControl();
            this.speDays = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speDays.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labUnlockPw);
            this.panel.Controls.Add(this.speDays);
            // 
            // Cancel
            // 
            this.Cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Appearance.Options.UseFont = true;
            this.Cancel.Visible = false;
            // 
            // Confirm
            // 
            this.Confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Appearance.Options.UseFont = true;
            // 
            // FolderNode
            // 
            this.FolderNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("FolderNode.ImageStream")));
            this.FolderNode.Images.SetKeyName(0, "Item.png");
            this.FolderNode.Images.SetKeyName(1, "Folder.png");
            this.FolderNode.Images.SetKeyName(2, "FolderOpen.png");
            // 
            // CategoryNode
            // 
            this.CategoryNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("CategoryNode.ImageStream")));
            this.CategoryNode.Images.SetKeyName(0, "Doc.png");
            this.CategoryNode.Images.SetKeyName(1, "Folder.png");
            this.CategoryNode.Images.SetKeyName(2, "FolderOpen.png");
            // 
            // OrgTreeNode
            // 
            this.OrgTreeNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("OrgTreeNode.ImageStream")));
            this.OrgTreeNode.Images.SetKeyName(0, "NodeOrg.png");
            this.OrgTreeNode.Images.SetKeyName(1, "NodeDept.png");
            this.OrgTreeNode.Images.SetKeyName(2, "NodePost.png");
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
            this.labUnlockPw.Text = "续租天数：";
            // 
            // speDays
            // 
            this.speDays.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.speDays.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.speDays.Location = new System.Drawing.Point(145, 65);
            this.speDays.Name = "speDays";
            this.speDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speDays.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.speDays.Properties.IsFloatValue = false;
            this.speDays.Properties.Mask.EditMask = "N00";
            this.speDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.speDays.Properties.MaxValue = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.speDays.Properties.MinValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.speDays.Size = new System.Drawing.Size(100, 20);
            this.speDays.TabIndex = 1;
            // 
            // ExtendDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Name = "ExtendDialog";
            this.Text = "锁定";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speDays.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labUnlockPw;
        internal DevExpress.XtraEditors.SpinEdit speDays;
    }
}