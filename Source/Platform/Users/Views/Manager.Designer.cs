using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Platform.Users.Views
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
            this.tabPermission = new DevExpress.XtraTab.XtraTabControl();
            this.pagData = new DevExpress.XtraTab.XtraTabPage();
            this.panData = new DevExpress.XtraEditors.PanelControl();
            this.treData = new DevExpress.XtraTreeList.TreeList();
            this.colIndexD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescriptionD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermission = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgData = new DevExpress.Utils.ImageCollection(this.components);
            this.pagAction = new DevExpress.XtraTab.XtraTabPage();
            this.panAction = new DevExpress.XtraEditors.PanelControl();
            this.treAction = new DevExpress.XtraTreeList.TreeList();
            this.colIndexA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTypeA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNameA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescriptionA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermitA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgPermission = new DevExpress.Utils.ImageCollection(this.components);
            this.panMain = new DevExpress.XtraEditors.PanelControl();
            this.panUser = new DevExpress.XtraEditors.PanelControl();
            this.grdUser = new DevExpress.XtraGrid.GridControl();
            this.gdvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuiltIn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ppcUser = new Insight.Utils.Controls.PageControl();
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.spcMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPermission)).BeginInit();
            this.tabPermission.SuspendLayout();
            this.pagData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panData)).BeginInit();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).BeginInit();
            this.pagAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panAction)).BeginInit();
            this.panAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).BeginInit();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panUser)).BeginInit();
            this.panUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Controls.Add(this.spcMain);
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
            // tabPermission
            // 
            this.tabPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPermission.Location = new System.Drawing.Point(0, 0);
            this.tabPermission.Name = "tabPermission";
            this.tabPermission.SelectedTabPage = this.pagData;
            this.tabPermission.Size = new System.Drawing.Size(304, 594);
            this.tabPermission.TabIndex = 0;
            this.tabPermission.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pagAction,
            this.pagData});
            // 
            // pagData
            // 
            this.pagData.Controls.Add(this.panData);
            this.pagData.Name = "pagData";
            this.pagData.Size = new System.Drawing.Size(298, 565);
            this.pagData.Text = "数据权限";
            // 
            // panData
            // 
            this.panData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panData.Controls.Add(this.treData);
            this.panData.Location = new System.Drawing.Point(2, 2);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(294, 561);
            this.panData.TabIndex = 0;
            // 
            // treData
            // 
            this.treData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIndexD,
            this.treeListColumn1,
            this.colModel,
            this.colDescriptionD,
            this.colPermit,
            this.colPermission});
            this.treData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treData.Location = new System.Drawing.Point(2, 2);
            this.treData.Name = "treData";
            this.treData.OptionsView.ShowHorzLines = false;
            this.treData.OptionsView.ShowIndicator = false;
            this.treData.OptionsView.ShowVertLines = false;
            this.treData.ParentFieldName = "ParentId";
            this.treData.SelectImageList = this.imgData;
            this.treData.Size = new System.Drawing.Size(290, 557);
            this.treData.TabIndex = 0;
            // 
            // colIndexD
            // 
            this.colIndexD.FieldName = "Index";
            this.colIndexD.Name = "colIndexD";
            this.colIndexD.Width = 50;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.FieldName = "nodeType";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Width = 51;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Name";
            this.colModel.MinWidth = 33;
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 0;
            this.colModel.Width = 245;
            // 
            // colDescriptionD
            // 
            this.colDescriptionD.FieldName = "Description";
            this.colDescriptionD.Name = "colDescriptionD";
            this.colDescriptionD.Visible = true;
            this.colDescriptionD.VisibleIndex = 1;
            this.colDescriptionD.Width = 60;
            // 
            // colPermit
            // 
            this.colPermit.FieldName = "Permit";
            this.colPermit.Name = "colPermit";
            this.colPermit.Width = 61;
            // 
            // colPermission
            // 
            this.colPermission.FieldName = "Permission";
            this.colPermission.Name = "colPermission";
            this.colPermission.Width = 61;
            // 
            // imgData
            // 
            this.imgData.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgData.ImageStream")));
            this.imgData.Images.SetKeyName(0, "Navigation.png");
            this.imgData.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 1);
            this.imgData.Images.SetKeyName(1, "database_16x16.png");
            this.imgData.InsertGalleryImage("new_16x16.png", "images/actions/new_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/new_16x16.png"), 2);
            this.imgData.Images.SetKeyName(2, "new_16x16.png");
            this.imgData.InsertGalleryImage("customer_16x16.png", "images/people/customer_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/customer_16x16.png"), 3);
            this.imgData.Images.SetKeyName(3, "customer_16x16.png");
            this.imgData.Images.SetKeyName(4, "NodeDept.png");
            this.imgData.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 5);
            this.imgData.Images.SetKeyName(5, "home_16x16.png");
            this.imgData.Images.SetKeyName(6, "NodeOrg.png");
            this.imgData.InsertGalleryImage("documentmap_16x16.png", "images/navigation/documentmap_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/documentmap_16x16.png"), 7);
            this.imgData.Images.SetKeyName(7, "documentmap_16x16.png");
            // 
            // pagAction
            // 
            this.pagAction.Controls.Add(this.panAction);
            this.pagAction.Name = "pagAction";
            this.pagAction.Size = new System.Drawing.Size(298, 565);
            this.pagAction.Text = "功能权限";
            // 
            // panAction
            // 
            this.panAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAction.Controls.Add(this.treAction);
            this.panAction.Location = new System.Drawing.Point(2, 2);
            this.panAction.Name = "panAction";
            this.panAction.Size = new System.Drawing.Size(294, 561);
            this.panAction.TabIndex = 0;
            // 
            // treAction
            // 
            this.treAction.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treAction.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIndexA,
            this.colTypeA,
            this.colNameA,
            this.colDescriptionA,
            this.colPermitA});
            this.treAction.Cursor = System.Windows.Forms.Cursors.Default;
            this.treAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treAction.Location = new System.Drawing.Point(2, 2);
            this.treAction.Name = "treAction";
            this.treAction.OptionsView.ShowHorzLines = false;
            this.treAction.OptionsView.ShowIndicator = false;
            this.treAction.OptionsView.ShowVertLines = false;
            this.treAction.ParentFieldName = "ParentId";
            this.treAction.SelectImageList = this.imgPermission;
            this.treAction.Size = new System.Drawing.Size(290, 557);
            this.treAction.TabIndex = 0;
            // 
            // colIndexA
            // 
            this.colIndexA.FieldName = "index";
            this.colIndexA.Name = "colIndexA";
            this.colIndexA.Width = 50;
            // 
            // colTypeA
            // 
            this.colTypeA.FieldName = "nodeType";
            this.colTypeA.Name = "colTypeA";
            this.colTypeA.Width = 51;
            // 
            // colNameA
            // 
            this.colNameA.FieldName = "name";
            this.colNameA.MinWidth = 33;
            this.colNameA.Name = "colNameA";
            this.colNameA.Visible = true;
            this.colNameA.VisibleIndex = 0;
            this.colNameA.Width = 245;
            // 
            // colDescriptionA
            // 
            this.colDescriptionA.FieldName = "remark";
            this.colDescriptionA.Name = "colDescriptionA";
            this.colDescriptionA.Visible = true;
            this.colDescriptionA.VisibleIndex = 1;
            this.colDescriptionA.Width = 60;
            // 
            // colPermitA
            // 
            this.colPermitA.FieldName = "permit";
            this.colPermitA.Name = "colPermitA";
            this.colPermitA.Width = 61;
            // 
            // imgPermission
            // 
            this.imgPermission.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgPermission.ImageStream")));
            this.imgPermission.Images.SetKeyName(0, "Module.png");
            this.imgPermission.InsertGalleryImage("openhyperlink_16x16.png", "images/actions/openhyperlink_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_16x16.png"), 1);
            this.imgPermission.Images.SetKeyName(1, "openhyperlink_16x16.png");
            this.imgPermission.Images.SetKeyName(2, "Action.png");
            this.imgPermission.InsertGalleryImage("close_16x16.png", "images/actions/close_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_16x16.png"), 3);
            this.imgPermission.Images.SetKeyName(3, "close_16x16.png");
            this.imgPermission.InsertGalleryImage("checkbox_16x16.png", "images/content/checkbox_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/checkbox_16x16.png"), 4);
            this.imgPermission.Images.SetKeyName(4, "checkbox_16x16.png");
            // 
            // panMain
            // 
            this.panMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panMain.Controls.Add(this.panUser);
            this.panMain.Controls.Add(this.panSpace);
            this.panMain.Controls.Add(this.panSearch);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(765, 590);
            this.panMain.TabIndex = 0;
            // 
            // panUser
            // 
            this.panUser.Controls.Add(this.grdUser);
            this.panUser.Controls.Add(this.ppcUser);
            this.panUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panUser.Location = new System.Drawing.Point(0, 44);
            this.panUser.Name = "panUser";
            this.panUser.Size = new System.Drawing.Size(765, 546);
            this.panUser.TabIndex = 0;
            // 
            // grdUser
            // 
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.Location = new System.Drawing.Point(2, 2);
            this.grdUser.MainView = this.gdvUser;
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(761, 520);
            this.grdUser.TabIndex = 0;
            this.grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUser});
            // 
            // gdvUser
            // 
            this.gdvUser.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colBuiltIn1,
            this.colName,
            this.colLoginName,
            this.colMobile,
            this.colEmail,
            this.colDescription,
            this.colValidity});
            this.gdvUser.GridControl = this.grdUser;
            this.gdvUser.Name = "gdvUser";
            this.gdvUser.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colID
            // 
            this.colID.FieldName = "id";
            this.colID.Name = "colID";
            // 
            // colBuiltIn1
            // 
            this.colBuiltIn1.Caption = "内置";
            this.colBuiltIn1.FieldName = "isBuiltin";
            this.colBuiltIn1.Name = "colBuiltIn1";
            this.colBuiltIn1.Visible = true;
            this.colBuiltIn1.VisibleIndex = 0;
            this.colBuiltIn1.Width = 40;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 100;
            // 
            // colLoginName
            // 
            this.colLoginName.Caption = "登录账号";
            this.colLoginName.FieldName = "account";
            this.colLoginName.Name = "colLoginName";
            this.colLoginName.Visible = true;
            this.colLoginName.VisibleIndex = 2;
            this.colLoginName.Width = 100;
            // 
            // colMobile
            // 
            this.colMobile.Caption = "手机号码";
            this.colMobile.FieldName = "mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 3;
            this.colMobile.Width = 100;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "电子邮箱";
            this.colEmail.FieldName = "email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 160;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "描述";
            this.colDescription.FieldName = "remark";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            this.colDescription.Width = 154;
            // 
            // colValidity
            // 
            this.colValidity.Caption = "封禁";
            this.colValidity.FieldName = "isInvalid";
            this.colValidity.Name = "colValidity";
            this.colValidity.Visible = true;
            this.colValidity.VisibleIndex = 6;
            this.colValidity.Width = 40;
            // 
            // ppcUser
            // 
            this.ppcUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppcUser.focusedRowHandle = 0;
            this.ppcUser.Location = new System.Drawing.Point(2, 522);
            this.ppcUser.MaximumSize = new System.Drawing.Size(0, 22);
            this.ppcUser.MinimumSize = new System.Drawing.Size(320, 22);
            this.ppcUser.Name = "ppcUser";
            this.ppcUser.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("ppcUser.pageSizeItems")));
            this.ppcUser.Size = new System.Drawing.Size(761, 22);
            this.ppcUser.TabIndex = 0;
            // 
            // panSpace
            // 
            this.panSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSpace.Location = new System.Drawing.Point(0, 39);
            this.panSpace.Name = "panSpace";
            this.panSpace.Size = new System.Drawing.Size(765, 5);
            this.panSpace.TabIndex = 0;
            // 
            // panSearch
            // 
            this.panSearch.Controls.Add(this.Search);
            this.panSearch.Controls.Add(this.KeyInput);
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(0, 0);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(765, 39);
            this.panSearch.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.Appearance.Options.UseFont = true;
            this.Search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Search.ImageOptions.Image")));
            this.Search.Location = new System.Drawing.Point(687, 8);
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
            this.KeyInput.Size = new System.Drawing.Size(671, 21);
            this.KeyInput.TabIndex = 1;
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.spcMain.Location = new System.Drawing.Point(5, 5);
            this.spcMain.Name = "spcMain";
            this.spcMain.Panel1.Controls.Add(this.panMain);
            this.spcMain.Panel1.MinSize = 750;
            this.spcMain.Panel2.Controls.Add(this.tabPermission);
            this.spcMain.Panel2.MinSize = 300;
            this.spcMain.Size = new System.Drawing.Size(1070, 590);
            this.spcMain.SplitterPosition = 300;
            this.spcMain.TabIndex = 1;
            // 
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1080, 631);
            this.Name = "Manager";
            this.xtraScrollable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPermission)).EndInit();
            this.tabPermission.ResumeLayout(false);
            this.pagData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panData)).EndInit();
            this.panData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).EndInit();
            this.pagAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panAction)).EndInit();
            this.panAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).EndInit();
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panUser)).EndInit();
            this.panUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).EndInit();
            this.panSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage pagData;
        private PanelControl panData;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndexD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colModel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescriptionD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPermit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPermission;
        private DevExpress.XtraTab.XtraTabPage pagAction;
        private PanelControl panAction;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndexA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTypeA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNameA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescriptionA;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPermitA;
        private DevExpress.Utils.ImageCollection imgData;
        private DevExpress.Utils.ImageCollection imgPermission;
        private PanelControl panMain;
        private PanelControl panSearch;
        private PanelControl panUser;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBuiltIn1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colValidity;
        private PanelControl panSpace;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private SplitContainerControl spcMain;
        public GridControl grdUser;
        public GridView gdvUser;
        public Utils.Controls.PageControl ppcUser;
        public DevExpress.XtraTreeList.TreeList treData;
        public DevExpress.XtraTreeList.TreeList treAction;
        public DevExpress.XtraTab.XtraTabControl tabPermission;
        public SimpleButton Search;
        public ButtonEdit KeyInput;
    }
}