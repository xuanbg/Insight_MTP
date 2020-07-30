using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Setting.Scenes.Views
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.splMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.palTenant = new DevExpress.XtraEditors.PanelControl();
            this.grdScene = new DevExpress.XtraGrid.GridControl();
            this.gdvScene = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ppcScene = new Insight.Base.BaseForm.Controls.PageControl();
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.grpUser = new DevExpress.XtraEditors.GroupControl();
            this.grdTemplate = new DevExpress.XtraGrid.GridControl();
            this.gdvTemplate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsceneId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltemplateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltemplate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colappId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colappName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartnerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsign = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ppcTemplate = new Insight.Base.BaseForm.Controls.PageControl();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palTenant)).BeginInit();
            this.palTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Controls.Add(this.splMain);
            this.xtraScrollable.Location = new System.Drawing.Point(0, 31);
            this.xtraScrollable.Padding = new System.Windows.Forms.Padding(5);
            this.xtraScrollable.Size = new System.Drawing.Size(1080, 600);
            // 
            // splMain
            // 
            this.splMain.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.splMain.Appearance.Options.UseBackColor = true;
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splMain.Horizontal = false;
            this.splMain.Location = new System.Drawing.Point(5, 5);
            this.splMain.Name = "splMain";
            this.splMain.Panel1.Controls.Add(this.palTenant);
            this.splMain.Panel1.Controls.Add(this.panSpace);
            this.splMain.Panel1.Controls.Add(this.panSearch);
            this.splMain.Panel1.MinSize = 200;
            this.splMain.Panel2.Controls.Add(this.grpUser);
            this.splMain.Panel2.MinSize = 200;
            this.splMain.ScrollBarSmallChange = 1;
            this.splMain.Size = new System.Drawing.Size(1070, 590);
            this.splMain.SplitterPosition = 320;
            this.splMain.TabIndex = 0;
            // 
            // palTenant
            // 
            this.palTenant.Controls.Add(this.grdScene);
            this.palTenant.Controls.Add(this.ppcScene);
            this.palTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palTenant.Location = new System.Drawing.Point(0, 44);
            this.palTenant.Name = "palTenant";
            this.palTenant.Size = new System.Drawing.Size(1070, 276);
            this.palTenant.TabIndex = 0;
            // 
            // grdScene
            // 
            this.grdScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdScene.Location = new System.Drawing.Point(2, 2);
            this.grdScene.MainView = this.gdvScene;
            this.grdScene.Name = "grdScene";
            this.grdScene.Size = new System.Drawing.Size(1066, 250);
            this.grdScene.TabIndex = 0;
            this.grdScene.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvScene});
            // 
            // gdvScene
            // 
            this.gdvScene.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvScene.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcode,
            this.colname,
            this.colremark});
            this.gdvScene.GridControl = this.grdScene;
            this.gdvScene.Name = "gdvScene";
            this.gdvScene.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcode
            // 
            this.colcode.Caption = "编码";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            this.colcode.Width = 80;
            // 
            // colname
            // 
            this.colname.Caption = "场景名称";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 320;
            // 
            // colremark
            // 
            this.colremark.Caption = "场景描述";
            this.colremark.FieldName = "remark";
            this.colremark.Name = "colremark";
            this.colremark.Visible = true;
            this.colremark.VisibleIndex = 2;
            this.colremark.Width = 634;
            // 
            // ppcScene
            // 
            this.ppcScene.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppcScene.Location = new System.Drawing.Point(2, 252);
            this.ppcScene.MaximumSize = new System.Drawing.Size(0, 22);
            this.ppcScene.MinimumSize = new System.Drawing.Size(300, 22);
            this.ppcScene.Name = "ppcScene";
            this.ppcScene.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("ppcScene.pageSizeItems")));
            this.ppcScene.Size = new System.Drawing.Size(1066, 22);
            this.ppcScene.TabIndex = 0;
            // 
            // panSpace
            // 
            this.panSpace.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panSpace.Appearance.Options.UseBackColor = true;
            this.panSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSpace.Location = new System.Drawing.Point(0, 39);
            this.panSpace.Name = "panSpace";
            this.panSpace.Size = new System.Drawing.Size(1070, 5);
            this.panSpace.TabIndex = 0;
            // 
            // panSearch
            // 
            this.panSearch.Controls.Add(this.Search);
            this.panSearch.Controls.Add(this.KeyInput);
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(0, 0);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1070, 39);
            this.panSearch.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Appearance.Options.UseFont = true;
            this.Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Search.ImageOptions.Image")));
            this.Search.Location = new System.Drawing.Point(992, 8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(70, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "查  询";
            // 
            // KeyInput
            // 
            this.KeyInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyInput.Location = new System.Drawing.Point(9, 9);
            this.KeyInput.Name = "KeyInput";
            this.KeyInput.Properties.AutoHeight = false;
            this.KeyInput.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.KeyInput.Properties.NullText = "在此输入查询关键词……";
            this.KeyInput.Size = new System.Drawing.Size(976, 21);
            this.KeyInput.TabIndex = 1;
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdTemplate);
            this.grpUser.Controls.Add(this.ppcTemplate);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(1070, 265);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "关联模板";
            // 
            // grdTemplate
            // 
            this.grdTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTemplate.Location = new System.Drawing.Point(2, 21);
            this.grdTemplate.MainView = this.gdvTemplate;
            this.grdTemplate.Name = "grdTemplate";
            this.grdTemplate.Size = new System.Drawing.Size(1066, 220);
            this.grdTemplate.TabIndex = 0;
            this.grdTemplate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvTemplate});
            // 
            // gdvTemplate
            // 
            this.gdvTemplate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colsceneId,
            this.coltemplateId,
            this.coltemplate,
            this.colappId,
            this.colappName,
            this.colpartnerCode,
            this.colpartner,
            this.colsign});
            this.gdvTemplate.GridControl = this.grdTemplate;
            this.gdvTemplate.Name = "gdvTemplate";
            this.gdvTemplate.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colsceneId
            // 
            this.colsceneId.FieldName = "sceneId";
            this.colsceneId.Name = "colsceneId";
            // 
            // coltemplateId
            // 
            this.coltemplateId.FieldName = "templateId";
            this.coltemplateId.Name = "coltemplateId";
            // 
            // coltemplate
            // 
            this.coltemplate.Caption = "模板名称";
            this.coltemplate.FieldName = "template";
            this.coltemplate.Name = "coltemplate";
            this.coltemplate.Visible = true;
            this.coltemplate.VisibleIndex = 0;
            this.coltemplate.Width = 240;
            // 
            // colappId
            // 
            this.colappId.FieldName = "appId";
            this.colappId.Name = "colappId";
            // 
            // colappName
            // 
            this.colappName.Caption = "绑定应用";
            this.colappName.FieldName = "appName";
            this.colappName.Name = "colappName";
            this.colappName.Visible = true;
            this.colappName.VisibleIndex = 1;
            this.colappName.Width = 240;
            // 
            // colpartnerCode
            // 
            this.colpartnerCode.Caption = "合作伙伴编码";
            this.colpartnerCode.FieldName = "partnerCode";
            this.colpartnerCode.Name = "colpartnerCode";
            this.colpartnerCode.Visible = true;
            this.colpartnerCode.VisibleIndex = 2;
            this.colpartnerCode.Width = 100;
            // 
            // colpartner
            // 
            this.colpartner.Caption = "合作伙伴名称";
            this.colpartner.FieldName = "partner";
            this.colpartner.Name = "colpartner";
            this.colpartner.Visible = true;
            this.colpartner.VisibleIndex = 3;
            this.colpartner.Width = 374;
            // 
            // colsign
            // 
            this.colsign.Caption = "消息签名";
            this.colsign.FieldName = "sign";
            this.colsign.Name = "colsign";
            this.colsign.Visible = true;
            this.colsign.VisibleIndex = 4;
            this.colsign.Width = 80;
            // 
            // ppcTemplate
            // 
            this.ppcTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppcTemplate.Location = new System.Drawing.Point(2, 241);
            this.ppcTemplate.MaximumSize = new System.Drawing.Size(0, 22);
            this.ppcTemplate.MinimumSize = new System.Drawing.Size(320, 22);
            this.ppcTemplate.Name = "ppcTemplate";
            this.ppcTemplate.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("ppcTemplate.pageSizeItems")));
            this.ppcTemplate.Size = new System.Drawing.Size(1066, 22);
            this.ppcTemplate.TabIndex = 0;
            // 
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1080, 631);
            this.Name = "Manager";
            this.xtraScrollable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.palTenant)).EndInit();
            this.palTenant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).EndInit();
            this.panSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupControl grpUser;
        private SplitContainerControl splMain;
        private PanelControl palTenant;
        private PanelControl panSpace;
        private PanelControl panSearch;
        internal SimpleButton Search;
        internal ButtonEdit KeyInput;
        public Insight.Base.BaseForm.Controls.PageControl ppcTemplate;
        public Insight.Base.BaseForm.Controls.PageControl ppcScene;
        public GridControl grdScene;
        public GridView gdvScene;
        public GridControl grdTemplate;
        public GridView gdvTemplate;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colremark;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colsceneId;
        private DevExpress.XtraGrid.Columns.GridColumn coltemplateId;
        private DevExpress.XtraGrid.Columns.GridColumn coltemplate;
        private DevExpress.XtraGrid.Columns.GridColumn colappId;
        private DevExpress.XtraGrid.Columns.GridColumn colappName;
        private DevExpress.XtraGrid.Columns.GridColumn colpartnerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colpartner;
        private DevExpress.XtraGrid.Columns.GridColumn colsign;
    }
}