using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;

namespace Insight.MTP.Client.Base.Tenants.Views
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
            this.splMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.palTenant = new DevExpress.XtraEditors.PanelControl();
            this.grdTenant = new DevExpress.XtraGrid.GridControl();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvTenant = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexpireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfullAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabTenant = new Insight.Utils.Controls.PageControl();
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.splMember = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpMember = new DevExpress.XtraEditors.GroupControl();
            this.grdApp = new DevExpress.XtraGrid.GridControl();
            this.appBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvApp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalias1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpUser = new DevExpress.XtraEditors.GroupControl();
            this.grdUser = new DevExpress.XtraGrid.GridControl();
            this.gdvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabUser = new Insight.Utils.Controls.PageControl();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palTenant)).BeginInit();
            this.palTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).BeginInit();
            this.splMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).BeginInit();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Controls.Add(this.splMain);
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
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splMain.Horizontal = false;
            this.splMain.Location = new System.Drawing.Point(5, 5);
            this.splMain.Name = "splMain";
            this.splMain.Panel1.Controls.Add(this.palTenant);
            this.splMain.Panel1.Controls.Add(this.panSpace);
            this.splMain.Panel1.Controls.Add(this.panSearch);
            this.splMain.Panel1.MinSize = 200;
            this.splMain.Panel2.Controls.Add(this.splMember);
            this.splMain.Panel2.MinSize = 200;
            this.splMain.ScrollBarSmallChange = 1;
            this.splMain.Size = new System.Drawing.Size(1070, 590);
            this.splMain.SplitterPosition = 300;
            this.splMain.TabIndex = 0;
            // 
            // palTenant
            // 
            this.palTenant.Controls.Add(this.grdTenant);
            this.palTenant.Controls.Add(this.tabTenant);
            this.palTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palTenant.Location = new System.Drawing.Point(0, 44);
            this.palTenant.Name = "palTenant";
            this.palTenant.Size = new System.Drawing.Size(1070, 256);
            this.palTenant.TabIndex = 0;
            // 
            // grdTenant
            // 
            this.grdTenant.DataSource = this.tenantBindingSource;
            this.grdTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTenant.Location = new System.Drawing.Point(2, 2);
            this.grdTenant.MainView = this.gdvTenant;
            this.grdTenant.Name = "grdTenant";
            this.grdTenant.Size = new System.Drawing.Size(1066, 230);
            this.grdTenant.TabIndex = 0;
            this.grdTenant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvTenant});
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataSource = typeof(Insight.MTP.Client.Common.Entity.Tenant);
            // 
            // gdvTenant
            // 
            this.gdvTenant.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvTenant.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colexpireDate,
            this.colname,
            this.colalias,
            this.colcontact,
            this.colmobile,
            this.colemail,
            this.colfullAdd,
            this.colremark});
            this.gdvTenant.GridControl = this.grdTenant;
            this.gdvTenant.Name = "gdvTenant";
            this.gdvTenant.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colname
            // 
            this.colname.Caption = "名称";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 240;
            // 
            // colalias
            // 
            this.colalias.Caption = "简称";
            this.colalias.FieldName = "alias";
            this.colalias.Name = "colalias";
            this.colalias.Visible = true;
            this.colalias.VisibleIndex = 2;
            this.colalias.Width = 120;
            // 
            // colexpireDate
            // 
            this.colexpireDate.Caption = "到期日期";
            this.colexpireDate.FieldName = "expireDate";
            this.colexpireDate.Name = "colexpireDate";
            this.colexpireDate.Visible = true;
            this.colexpireDate.VisibleIndex = 0;
            this.colexpireDate.Width = 80;
            // 
            // colcontact
            // 
            this.colcontact.Caption = "联系人";
            this.colcontact.FieldName = "contact";
            this.colcontact.Name = "colcontact";
            this.colcontact.Visible = true;
            this.colcontact.VisibleIndex = 3;
            this.colcontact.Width = 60;
            // 
            // colmobile
            // 
            this.colmobile.Caption = "联系电话";
            this.colmobile.FieldName = "mobile";
            this.colmobile.Name = "colmobile";
            this.colmobile.Visible = true;
            this.colmobile.VisibleIndex = 4;
            this.colmobile.Width = 100;
            // 
            // colemail
            // 
            this.colemail.Caption = "邮箱";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            // 
            // colfullAdd
            // 
            this.colfullAdd.Caption = "地址";
            this.colfullAdd.FieldName = "fullAdd";
            this.colfullAdd.Name = "colfullAdd";
            this.colfullAdd.OptionsColumn.ReadOnly = true;
            this.colfullAdd.Visible = true;
            this.colfullAdd.VisibleIndex = 5;
            this.colfullAdd.Width = 300;
            // 
            // colremark
            // 
            this.colremark.Caption = "备注";
            this.colremark.FieldName = "remark";
            this.colremark.Name = "colremark";
            this.colremark.Visible = true;
            this.colremark.VisibleIndex = 6;
            this.colremark.Width = 114;
            // 
            // tabTenant
            // 
            this.tabTenant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabTenant.FocusedRowHandle = 0;
            this.tabTenant.Location = new System.Drawing.Point(2, 232);
            this.tabTenant.MaximumSize = new System.Drawing.Size(0, 22);
            this.tabTenant.MinimumSize = new System.Drawing.Size(300, 22);
            this.tabTenant.Name = "tabTenant";
            this.tabTenant.PageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("tabTenant.PageSizeItems")));
            this.tabTenant.Size = new System.Drawing.Size(1066, 22);
            this.tabTenant.TabIndex = 0;
            this.tabTenant.TotalRows = 0;
            // 
            // panSpace
            // 
            this.panSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSpace.Location = new System.Drawing.Point(0, 39);
            this.panSpace.Name = "panSpace";
            this.panSpace.Size = new System.Drawing.Size(1070, 5);
            this.panSpace.TabIndex = 4;
            // 
            // panSearch
            // 
            this.panSearch.Controls.Add(this.Search);
            this.panSearch.Controls.Add(this.KeyInput);
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Location = new System.Drawing.Point(0, 0);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1070, 39);
            this.panSearch.TabIndex = 5;
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
            // splMember
            // 
            this.splMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMember.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splMember.Location = new System.Drawing.Point(0, 0);
            this.splMember.Name = "splMember";
            this.splMember.Panel1.Controls.Add(this.grpMember);
            this.splMember.Panel1.MinSize = 400;
            this.splMember.Panel2.Controls.Add(this.grpUser);
            this.splMember.Panel2.MinSize = 500;
            this.splMember.Size = new System.Drawing.Size(1070, 285);
            this.splMember.SplitterPosition = 480;
            this.splMember.TabIndex = 0;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.grdApp);
            this.grpMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMember.Location = new System.Drawing.Point(0, 0);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(481, 285);
            this.grpMember.TabIndex = 0;
            this.grpMember.Text = "绑定应用";
            // 
            // grdApp
            // 
            this.grdApp.DataSource = this.appBindingSource;
            this.grdApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdApp.Location = new System.Drawing.Point(2, 21);
            this.grdApp.MainView = this.gdvApp;
            this.grdApp.Name = "grdApp";
            this.grdApp.Size = new System.Drawing.Size(477, 262);
            this.grdApp.TabIndex = 0;
            this.grdApp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvApp});
            // 
            // appBindingSource
            // 
            this.appBindingSource.DataSource = typeof(Insight.MTP.Client.Common.Entity.App);
            // 
            // gdvApp
            // 
            this.gdvApp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname2,
            this.colalias1});
            this.gdvApp.GridControl = this.grdApp;
            this.gdvApp.Name = "gdvApp";
            // 
            // colname2
            // 
            this.colname2.Caption = "名称";
            this.colname2.FieldName = "name";
            this.colname2.Name = "colname2";
            this.colname2.Visible = true;
            this.colname2.VisibleIndex = 0;
            this.colname2.Width = 280;
            // 
            // colalias1
            // 
            this.colalias1.Caption = "简称";
            this.colalias1.FieldName = "alias";
            this.colalias1.Name = "colalias1";
            this.colalias1.Visible = true;
            this.colalias1.VisibleIndex = 1;
            this.colalias1.Width = 145;
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdUser);
            this.grpUser.Controls.Add(this.tabUser);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(584, 285);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "关联用户";
            // 
            // grdUser
            // 
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.Location = new System.Drawing.Point(2, 21);
            this.grdUser.MainView = this.gdvUser;
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(580, 240);
            this.grdUser.TabIndex = 0;
            this.grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUser});
            // 
            // gdvUser
            // 
            this.gdvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colLoginName,
            this.colDescription1,
            this.colValidity});
            this.gdvUser.GridControl = this.grdUser;
            this.gdvUser.Name = "gdvUser";
            this.gdvUser.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colName1
            // 
            this.colName1.Caption = "用户姓名";
            this.colName1.FieldName = "name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 120;
            // 
            // colLoginName
            // 
            this.colLoginName.Caption = "登录账号";
            this.colLoginName.FieldName = "account";
            this.colLoginName.Name = "colLoginName";
            this.colLoginName.Visible = true;
            this.colLoginName.VisibleIndex = 1;
            this.colLoginName.Width = 100;
            // 
            // colDescription1
            // 
            this.colDescription1.Caption = "描述";
            this.colDescription1.FieldName = "remark";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 2;
            this.colDescription1.Width = 205;
            // 
            // colValidity
            // 
            this.colValidity.Caption = "封禁";
            this.colValidity.FieldName = "isInvalid";
            this.colValidity.Name = "colValidity";
            this.colValidity.Visible = true;
            this.colValidity.VisibleIndex = 3;
            this.colValidity.Width = 40;
            // 
            // tabUser
            // 
            this.tabUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabUser.FocusedRowHandle = 0;
            this.tabUser.Location = new System.Drawing.Point(2, 261);
            this.tabUser.MaximumSize = new System.Drawing.Size(0, 22);
            this.tabUser.MinimumSize = new System.Drawing.Size(320, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.PageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("tabUser.PageSizeItems")));
            this.tabUser.Size = new System.Drawing.Size(580, 22);
            this.tabUser.TabIndex = 0;
            this.tabUser.TotalRows = 0;
            // 
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1080, 631);
            this.Name = "Manager";
            this.xtraScrollable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.palTenant)).EndInit();
            this.palTenant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTenant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTenant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).EndInit();
            this.panSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).EndInit();
            this.splMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).EndInit();
            this.grpMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal Utils.Controls.PageControl tabUser;
        internal GridControl grdUser;
        internal GridView gdvUser;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private GroupControl grpMember;
        private GroupControl grpUser;
        private SplitContainerControl splMain;
        private SplitContainerControl splMember;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colValidity;
        private PanelControl palTenant;
        internal GridControl grdTenant;
        internal GridView gdvTenant;
        internal Utils.Controls.PageControl tabTenant;
        internal GridControl grdApp;
        internal GridView gdvApp;
        private PanelControl panSpace;
        private PanelControl panSearch;
        internal SimpleButton Search;
        internal ButtonEdit KeyInput;
        private System.Windows.Forms.BindingSource appBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colname2;
        private DevExpress.XtraGrid.Columns.GridColumn colalias1;
        private System.Windows.Forms.BindingSource tenantBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colalias;
        private DevExpress.XtraGrid.Columns.GridColumn colexpireDate;
        private DevExpress.XtraGrid.Columns.GridColumn colcontact;
        private DevExpress.XtraGrid.Columns.GridColumn colmobile;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colfullAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colremark;
    }
}