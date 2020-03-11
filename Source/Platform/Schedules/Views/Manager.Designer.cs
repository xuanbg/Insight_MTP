using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;

namespace Insight.MTP.Client.Platform.Schedules.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grdSchedule = new DevExpress.XtraGrid.GridControl();
            this.gdvSchedule = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.imgNav = new DevExpress.Utils.ImageCollection(this.components);
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.pccApp = new Insight.Utils.Controls.PageControl();
            this.panMain = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).BeginInit();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Controls.Add(this.panMain);
            this.xtraScrollable.Controls.Add(this.panSpace);
            this.xtraScrollable.Controls.Add(this.panSearch);
            this.xtraScrollable.Location = new System.Drawing.Point(0, 31);
            this.xtraScrollable.Padding = new System.Windows.Forms.Padding(5);
            this.xtraScrollable.Size = new System.Drawing.Size(1080, 600);
            // 
            // FolderNode
            // 
            this.FolderNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("FolderNode.ImageStream")));
            this.FolderNode.Images.SetKeyName(0, "Item.png");
            this.FolderNode.Images.SetKeyName(1, "Folder.png");
            this.FolderNode.Images.SetKeyName(2, "FolderOpen.png");
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 0);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Location = new System.Drawing.Point(0, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // grdSchedule
            // 
            this.grdSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSchedule.Location = new System.Drawing.Point(2, 2);
            this.grdSchedule.MainView = this.gdvSchedule;
            this.grdSchedule.Name = "grdSchedule";
            this.grdSchedule.Size = new System.Drawing.Size(1066, 520);
            this.grdSchedule.TabIndex = 0;
            this.grdSchedule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSchedule});
            // 
            // gdvSchedule
            // 
            this.gdvSchedule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gdvSchedule.GridControl = this.grdSchedule;
            this.gdvSchedule.Name = "gdvSchedule";
            this.gdvSchedule.OptionsDetail.EnableMasterViewMode = false;
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
            // imgNav
            // 
            this.imgNav.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgNav.ImageStream")));
            this.imgNav.InsertGalleryImage("properties_16x16.png", "images/setup/properties_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/setup/properties_16x16.png"), 0);
            this.imgNav.Images.SetKeyName(0, "properties_16x16.png");
            this.imgNav.Images.SetKeyName(1, "open_16x16.png");
            this.imgNav.Images.SetKeyName(2, "openhyperlink_16x16.png");
            // 
            // panSpace
            // 
            this.panSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSpace.Location = new System.Drawing.Point(5, 44);
            this.panSpace.Name = "panSpace";
            this.panSpace.Size = new System.Drawing.Size(1070, 5);
            this.panSpace.TabIndex = 3;
            // 
            // panSearch
            // 
            this.panSearch.Controls.Add(this.Search);
            this.panSearch.Controls.Add(this.KeyInput);
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(5, 5);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1070, 39);
            this.panSearch.TabIndex = 2;
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
            // pccApp
            // 
            this.pccApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pccApp.focusedRowHandle = 0;
            this.pccApp.Location = new System.Drawing.Point(2, 522);
            this.pccApp.MaximumSize = new System.Drawing.Size(0, 22);
            this.pccApp.MinimumSize = new System.Drawing.Size(320, 22);
            this.pccApp.Name = "pccApp";
            this.pccApp.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("pccApp.pageSizeItems")));
            this.pccApp.Size = new System.Drawing.Size(1066, 22);
            this.pccApp.TabIndex = 4;
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.grdSchedule);
            this.panMain.Controls.Add(this.pccApp);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(5, 49);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1070, 546);
            this.panMain.TabIndex = 0;
            // 
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1080, 631);
            this.Name = "Manager";
            this.xtraScrollable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).EndInit();
            this.panSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).EndInit();
            this.panMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
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
        private PanelControl panSpace;
        private PanelControl panSearch;
        internal SimpleButton Search;
        internal ButtonEdit KeyInput;
        public Utils.Controls.PageControl pccApp;
        private PanelControl panMain;
        public GridControl grdSchedule;
        public GridView gdvSchedule;
    }
}