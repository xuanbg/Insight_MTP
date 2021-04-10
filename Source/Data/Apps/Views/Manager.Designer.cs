using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;

namespace Insight.MTP.Client.Data.Apps.Views
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
            this.pceApp = new DevExpress.XtraEditors.PanelControl();
            this.pccApp = new Insight.Base.BaseForm.Controls.PageControl();
            this.grdApp = new DevExpress.XtraGrid.GridControl();
            this.gdvApp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colicon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpermitLife = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltokenLife = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsigninOne = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colautoRefresh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colautoTenant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splMember = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpMember = new DevExpress.XtraEditors.GroupControl();
            this.TreNav = new DevExpress.XtraTreeList.TreeList();
            this.colNavType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNavName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgNav = new DevExpress.Utils.ImageCollection();
            this.grpUser = new DevExpress.XtraEditors.GroupControl();
            this.grdFunc = new DevExpress.XtraGrid.GridControl();
            this.gdvFunc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFunid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnavId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunindex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauthCodes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunIconUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeginGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunHideText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceApp)).BeginInit();
            this.pceApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).BeginInit();
            this.splMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).BeginInit();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraScrollable.Appearance.Options.UseBackColor = true;
            this.xtraScrollable.Controls.Add(this.splMain);
            this.xtraScrollable.Controls.Add(this.panSpace);
            this.xtraScrollable.Controls.Add(this.panSearch);
            this.xtraScrollable.Location = new System.Drawing.Point(0, 31);
            this.xtraScrollable.Size = new System.Drawing.Size(1420, 829);
            // 
            // splMain
            // 
            this.splMain.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.splMain.Appearance.Options.UseBackColor = true;
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splMain.Horizontal = false;
            this.splMain.Location = new System.Drawing.Point(5, 49);
            this.splMain.Name = "splMain";
            this.splMain.Panel1.Controls.Add(this.pceApp);
            this.splMain.Panel1.MinSize = 200;
            this.splMain.Panel2.Controls.Add(this.splMember);
            this.splMain.Panel2.MinSize = 200;
            this.splMain.ScrollBarSmallChange = 1;
            this.splMain.Size = new System.Drawing.Size(1410, 775);
            this.splMain.SplitterPosition = 395;
            this.splMain.TabIndex = 0;
            // 
            // pceApp
            // 
            this.pceApp.Controls.Add(this.pccApp);
            this.pceApp.Controls.Add(this.grdApp);
            this.pceApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceApp.Location = new System.Drawing.Point(0, 0);
            this.pceApp.Name = "pceApp";
            this.pceApp.Size = new System.Drawing.Size(1410, 395);
            this.pceApp.TabIndex = 0;
            // 
            // pccApp
            // 
            this.pccApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pccApp.Location = new System.Drawing.Point(2, 371);
            this.pccApp.MaximumSize = new System.Drawing.Size(0, 22);
            this.pccApp.MinimumSize = new System.Drawing.Size(320, 22);
            this.pccApp.Name = "pccApp";
            this.pccApp.orderBy = Insight.Base.BaseForm.Controls.OrderBy.POSITIVE;
            this.pccApp.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("pccApp.pageSizeItems")));
            this.pccApp.Size = new System.Drawing.Size(1406, 22);
            this.pccApp.TabIndex = 0;
            // 
            // grdApp
            // 
            this.grdApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdApp.Location = new System.Drawing.Point(2, 2);
            this.grdApp.MainView = this.gdvApp;
            this.grdApp.Name = "grdApp";
            this.grdApp.Size = new System.Drawing.Size(1406, 391);
            this.grdApp.TabIndex = 0;
            this.grdApp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvApp});
            // 
            // gdvApp
            // 
            this.gdvApp.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvApp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colindex,
            this.colname,
            this.colalias,
            this.colicon,
            this.coldomain,
            this.colpermitLife,
            this.coltokenLife,
            this.colsigninOne,
            this.colautoRefresh,
            this.colautoTenant});
            this.gdvApp.GridControl = this.grdApp;
            this.gdvApp.Name = "gdvApp";
            this.gdvApp.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colindex
            // 
            this.colindex.FieldName = "index";
            this.colindex.Name = "colindex";
            // 
            // colname
            // 
            this.colname.Caption = "名称";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 360;
            // 
            // colalias
            // 
            this.colalias.Caption = "简称";
            this.colalias.FieldName = "alias";
            this.colalias.Name = "colalias";
            this.colalias.Visible = true;
            this.colalias.VisibleIndex = 1;
            this.colalias.Width = 160;
            // 
            // colicon
            // 
            this.colicon.FieldName = "icon";
            this.colicon.Name = "colicon";
            // 
            // coldomain
            // 
            this.coldomain.Caption = "域名";
            this.coldomain.FieldName = "domain";
            this.coldomain.Name = "coldomain";
            this.coldomain.Visible = true;
            this.coldomain.VisibleIndex = 2;
            this.coldomain.Width = 234;
            // 
            // colpermitLife
            // 
            this.colpermitLife.Caption = "权限生命期";
            this.colpermitLife.FieldName = "permitLife";
            this.colpermitLife.Name = "colpermitLife";
            this.colpermitLife.Visible = true;
            this.colpermitLife.VisibleIndex = 3;
            this.colpermitLife.Width = 80;
            // 
            // coltokenLife
            // 
            this.coltokenLife.Caption = "令牌生命期";
            this.coltokenLife.FieldName = "tokenLife";
            this.coltokenLife.Name = "coltokenLife";
            this.coltokenLife.Visible = true;
            this.coltokenLife.VisibleIndex = 4;
            this.coltokenLife.Width = 80;
            // 
            // colsigninOne
            // 
            this.colsigninOne.Caption = "是否单点";
            this.colsigninOne.FieldName = "signinOne";
            this.colsigninOne.Name = "colsigninOne";
            this.colsigninOne.Visible = true;
            this.colsigninOne.VisibleIndex = 5;
            this.colsigninOne.Width = 60;
            // 
            // colautoRefresh
            // 
            this.colautoRefresh.Caption = "自动刷新";
            this.colautoRefresh.FieldName = "autoRefresh";
            this.colautoRefresh.Name = "colautoRefresh";
            this.colautoRefresh.Visible = true;
            this.colautoRefresh.VisibleIndex = 6;
            this.colautoRefresh.Width = 60;
            // 
            // colautoTenant
            // 
            this.colautoTenant.Caption = "自动登录到机构";
            this.colautoTenant.FieldName = "autoTenant";
            this.colautoTenant.Name = "colautoTenant";
            // 
            // splMember
            // 
            this.splMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMember.Location = new System.Drawing.Point(0, 0);
            this.splMember.Name = "splMember";
            this.splMember.Panel1.Controls.Add(this.grpMember);
            this.splMember.Panel1.MinSize = 300;
            this.splMember.Panel2.Controls.Add(this.grpUser);
            this.splMember.Panel2.MinSize = 500;
            this.splMember.Size = new System.Drawing.Size(1410, 375);
            this.splMember.SplitterPosition = 300;
            this.splMember.TabIndex = 0;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.TreNav);
            this.grpMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMember.Location = new System.Drawing.Point(0, 0);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(300, 375);
            this.grpMember.TabIndex = 0;
            this.grpMember.Text = "导航";
            // 
            // TreNav
            // 
            this.TreNav.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TreNav.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNavType,
            this.colNavName});
            this.TreNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreNav.KeyFieldName = "id";
            this.TreNav.Location = new System.Drawing.Point(2, 21);
            this.TreNav.Name = "TreNav";
            this.TreNav.OptionsView.ShowColumns = false;
            this.TreNav.ParentFieldName = "parentId";
            this.TreNav.PreviewFieldName = "name";
            this.TreNav.SelectImageList = this.imgNav;
            this.TreNav.Size = new System.Drawing.Size(296, 352);
            this.TreNav.TabIndex = 0;
            // 
            // colNavType
            // 
            this.colNavType.FieldName = "type";
            this.colNavType.Name = "colNavType";
            this.colNavType.Width = 67;
            // 
            // colNavName
            // 
            this.colNavName.FieldName = "name";
            this.colNavName.MinWidth = 33;
            this.colNavName.Name = "colNavName";
            this.colNavName.Visible = true;
            this.colNavName.VisibleIndex = 0;
            this.colNavName.Width = 99;
            // 
            // imgNav
            // 
            this.imgNav.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgNav.ImageStream")));
            this.imgNav.InsertGalleryImage("properties_16x16.png", "images/setup/properties_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/setup/properties_16x16.png"), 0);
            this.imgNav.Images.SetKeyName(0, "properties_16x16.png");
            this.imgNav.Images.SetKeyName(1, "open_16x16.png");
            this.imgNav.Images.SetKeyName(2, "openhyperlink_16x16.png");
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdFunc);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(1105, 375);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "模块功能";
            // 
            // grdFunc
            // 
            this.grdFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFunc.Location = new System.Drawing.Point(2, 21);
            this.grdFunc.MainView = this.gdvFunc;
            this.grdFunc.Name = "grdFunc";
            this.grdFunc.Size = new System.Drawing.Size(1101, 352);
            this.grdFunc.TabIndex = 0;
            this.grdFunc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvFunc,
            this.gridView1});
            // 
            // gdvFunc
            // 
            this.gdvFunc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFunid,
            this.colnavId,
            this.coltype,
            this.colFunindex,
            this.colFunname,
            this.colauthCodes,
            this.colFunIconUrl,
            this.colBeginGroup,
            this.colFunHideText});
            this.gdvFunc.GridControl = this.grdFunc;
            this.gdvFunc.Name = "gdvFunc";
            // 
            // colFunid
            // 
            this.colFunid.FieldName = "id";
            this.colFunid.Name = "colFunid";
            // 
            // colnavId
            // 
            this.colnavId.FieldName = "navId";
            this.colnavId.Name = "colnavId";
            // 
            // coltype
            // 
            this.coltype.FieldName = "type";
            this.coltype.Name = "coltype";
            // 
            // colFunindex
            // 
            this.colFunindex.FieldName = "index";
            this.colFunindex.Name = "colFunindex";
            // 
            // colFunname
            // 
            this.colFunname.Caption = "功能名称";
            this.colFunname.FieldName = "name";
            this.colFunname.Name = "colFunname";
            this.colFunname.Visible = true;
            this.colFunname.VisibleIndex = 0;
            this.colFunname.Width = 160;
            // 
            // colauthCodes
            // 
            this.colauthCodes.Caption = "授权码";
            this.colauthCodes.FieldName = "authCodes";
            this.colauthCodes.Name = "colauthCodes";
            this.colauthCodes.Visible = true;
            this.colauthCodes.VisibleIndex = 1;
            this.colauthCodes.Width = 200;
            // 
            // colFunIconUrl
            // 
            this.colFunIconUrl.Caption = "图标URL";
            this.colFunIconUrl.FieldName = "funcInfo.iconUrl";
            this.colFunIconUrl.Name = "colFunIconUrl";
            this.colFunIconUrl.Visible = true;
            this.colFunIconUrl.VisibleIndex = 2;
            this.colFunIconUrl.Width = 245;
            // 
            // colBeginGroup
            // 
            this.colBeginGroup.Caption = "是否分组";
            this.colBeginGroup.FieldName = "funcInfo.beginGroup";
            this.colBeginGroup.Name = "colBeginGroup";
            this.colBeginGroup.Visible = true;
            this.colBeginGroup.VisibleIndex = 3;
            this.colBeginGroup.Width = 60;
            // 
            // colFunHideText
            // 
            this.colFunHideText.Caption = "隐藏文字";
            this.colFunHideText.FieldName = "funcInfo.hideText";
            this.colFunHideText.Name = "colFunHideText";
            this.colFunHideText.Visible = true;
            this.colFunHideText.VisibleIndex = 4;
            this.colFunHideText.Width = 60;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdFunc;
            this.gridView1.Name = "gridView1";
            // 
            // panSpace
            // 
            this.panSpace.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panSpace.Appearance.Options.UseBackColor = true;
            this.panSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSpace.Location = new System.Drawing.Point(5, 44);
            this.panSpace.Name = "panSpace";
            this.panSpace.Size = new System.Drawing.Size(1410, 5);
            this.panSpace.TabIndex = 3;
            // 
            // panSearch
            // 
            this.panSearch.Controls.Add(this.Search);
            this.panSearch.Controls.Add(this.KeyInput);
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(5, 5);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1410, 39);
            this.panSearch.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Appearance.Options.UseFont = true;
            this.Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Search.ImageOptions.Image")));
            this.Search.Location = new System.Drawing.Point(1332, 8);
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
            this.KeyInput.Size = new System.Drawing.Size(1316, 21);
            this.KeyInput.TabIndex = 1;
            // 
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1420, 860);
            this.Name = "Manager";
            this.xtraScrollable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pceApp)).EndInit();
            this.pceApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).EndInit();
            this.splMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).EndInit();
            this.grpMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).EndInit();
            this.panSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal TreeList TreNav;
        private SplitContainerControl splMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNavType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNavName;
        internal GridControl grdApp;
        internal GridView gdvApp;
        private SplitContainerControl splMember;
        private GroupControl grpMember;
        private GroupControl grpUser;
        internal GridControl grdFunc;
        internal GridView gdvFunc;
        private GridView gridView1;
        private ImageCollection imgNav;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colindex;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colalias;
        private DevExpress.XtraGrid.Columns.GridColumn colicon;
        private DevExpress.XtraGrid.Columns.GridColumn coldomain;
        private DevExpress.XtraGrid.Columns.GridColumn colpermitLife;
        private DevExpress.XtraGrid.Columns.GridColumn coltokenLife;
        private DevExpress.XtraGrid.Columns.GridColumn colsigninOne;
        private DevExpress.XtraGrid.Columns.GridColumn colautoRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colautoTenant;
        public Insight.Base.BaseForm.Controls.PageControl pccApp;
        private PanelControl panSpace;
        private PanelControl panSearch;
        internal SimpleButton Search;
        internal ButtonEdit KeyInput;
        private DevExpress.XtraGrid.Columns.GridColumn colFunid;
        private DevExpress.XtraGrid.Columns.GridColumn colnavId;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraGrid.Columns.GridColumn colFunindex;
        private DevExpress.XtraGrid.Columns.GridColumn colFunname;
        private DevExpress.XtraGrid.Columns.GridColumn colauthCodes;
        private DevExpress.XtraGrid.Columns.GridColumn colFunIconUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colBeginGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colFunHideText;
        private PanelControl pceApp;
    }
}