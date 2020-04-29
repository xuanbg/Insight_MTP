using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Platform.Tenants.Views
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.palTenant = new DevExpress.XtraEditors.PanelControl();
            this.grdTenant = new DevExpress.XtraGrid.GridControl();
            this.gdvTenant = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colisInvalid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ppcTenant = new Insight.Base.BaseForm.Controls.PageControl();
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.splMember = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpMember = new DevExpress.XtraEditors.GroupControl();
            this.grdApp = new DevExpress.XtraGrid.GridControl();
            this.gdvApp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colappId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexpireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpUser = new DevExpress.XtraEditors.GroupControl();
            this.grdUser = new DevExpress.XtraGrid.GridControl();
            this.gdvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisInvalid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ppcUser = new Insight.Base.BaseForm.Controls.PageControl();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palTenant)).BeginInit();
            this.palTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).BeginInit();
            this.splMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).BeginInit();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).BeginInit();
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
            this.palTenant.Controls.Add(this.ppcTenant);
            this.palTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palTenant.Location = new System.Drawing.Point(0, 44);
            this.palTenant.Name = "palTenant";
            this.palTenant.Size = new System.Drawing.Size(1070, 256);
            this.palTenant.TabIndex = 0;
            // 
            // grdTenant
            // 
            this.grdTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTenant.Location = new System.Drawing.Point(2, 2);
            this.grdTenant.MainView = this.gdvTenant;
            this.grdTenant.Name = "grdTenant";
            this.grdTenant.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repStatus});
            this.grdTenant.Size = new System.Drawing.Size(1066, 230);
            this.grdTenant.TabIndex = 0;
            this.grdTenant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvTenant});
            // 
            // gdvTenant
            // 
            this.gdvTenant.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvTenant.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcode,
            this.colname,
            this.colalias,
            this.colremark,
            this.colstatus,
            this.colisInvalid});
            this.gdvTenant.GridControl = this.grdTenant;
            this.gdvTenant.Name = "gdvTenant";
            this.gdvTenant.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcode
            // 
            this.colcode.Caption = "编号";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            this.colcode.Width = 80;
            // 
            // colname
            // 
            this.colname.Caption = "名称";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 320;
            // 
            // colalias
            // 
            this.colalias.Caption = "简称";
            this.colalias.FieldName = "alias";
            this.colalias.Name = "colalias";
            this.colalias.Visible = true;
            this.colalias.VisibleIndex = 2;
            this.colalias.Width = 160;
            // 
            // colremark
            // 
            this.colremark.Caption = "备注";
            this.colremark.FieldName = "remark";
            this.colremark.Name = "colremark";
            this.colremark.Visible = true;
            this.colremark.VisibleIndex = 3;
            this.colremark.Width = 374;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "状态";
            this.colstatus.ColumnEdit = this.repStatus;
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 4;
            this.colstatus.Width = 60;
            // 
            // repStatus
            // 
            this.repStatus.AutoHeight = false;
            this.repStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStatus.DisplayMember = "name";
            this.repStatus.Name = "repStatus";
            this.repStatus.ValueMember = "id";
            // 
            // colisInvalid
            // 
            this.colisInvalid.Caption = "禁用";
            this.colisInvalid.FieldName = "invalid";
            this.colisInvalid.Name = "colisInvalid";
            this.colisInvalid.Visible = true;
            this.colisInvalid.VisibleIndex = 5;
            this.colisInvalid.Width = 40;
            // 
            // ppcTenant
            // 
            this.ppcTenant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppcTenant.focusedRowHandle = -1;
            this.ppcTenant.Location = new System.Drawing.Point(2, 232);
            this.ppcTenant.MaximumSize = new System.Drawing.Size(0, 22);
            this.ppcTenant.MinimumSize = new System.Drawing.Size(300, 22);
            this.ppcTenant.Name = "ppcTenant";
            this.ppcTenant.page = 1;
            this.ppcTenant.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("ppcTenant.pageSizeItems")));
            this.ppcTenant.Size = new System.Drawing.Size(1066, 22);
            this.ppcTenant.TabIndex = 0;
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
            this.splMember.SplitterPosition = 400;
            this.splMember.TabIndex = 0;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.grdApp);
            this.grpMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMember.Location = new System.Drawing.Point(0, 0);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(400, 285);
            this.grpMember.TabIndex = 0;
            this.grpMember.Text = "绑定应用";
            // 
            // grdApp
            // 
            this.grdApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdApp.Location = new System.Drawing.Point(2, 21);
            this.grdApp.MainView = this.gdvApp;
            this.grdApp.Name = "grdApp";
            this.grdApp.Size = new System.Drawing.Size(396, 262);
            this.grdApp.TabIndex = 0;
            this.grdApp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvApp});
            // 
            // gdvApp
            // 
            this.gdvApp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coltenantId,
            this.colappId,
            this.colname2,
            this.colexpireDate});
            this.gdvApp.GridControl = this.grdApp;
            this.gdvApp.Name = "gdvApp";
            this.gdvApp.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // coltenantId
            // 
            this.coltenantId.FieldName = "tenantId";
            this.coltenantId.Name = "coltenantId";
            // 
            // colappId
            // 
            this.colappId.FieldName = "appId";
            this.colappId.Name = "colappId";
            // 
            // colname2
            // 
            this.colname2.Caption = "应用名称";
            this.colname2.FieldName = "name";
            this.colname2.Name = "colname2";
            this.colname2.Visible = true;
            this.colname2.VisibleIndex = 0;
            this.colname2.Width = 284;
            // 
            // colexpireDate
            // 
            this.colexpireDate.Caption = "到期日期";
            this.colexpireDate.FieldName = "expireDate";
            this.colexpireDate.Name = "colexpireDate";
            this.colexpireDate.Visible = true;
            this.colexpireDate.VisibleIndex = 1;
            this.colexpireDate.Width = 80;
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdUser);
            this.grpUser.Controls.Add(this.ppcUser);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(665, 285);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "关联用户";
            // 
            // grdUser
            // 
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.Location = new System.Drawing.Point(2, 21);
            this.grdUser.MainView = this.gdvUser;
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(661, 240);
            this.grdUser.TabIndex = 0;
            this.grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUser});
            // 
            // gdvUser
            // 
            this.gdvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid2,
            this.colcode1,
            this.colname1,
            this.colaccount,
            this.colmobile,
            this.colemail,
            this.colremark1,
            this.colisInvalid1});
            this.gdvUser.GridControl = this.grdUser;
            this.gdvUser.Name = "gdvUser";
            this.gdvUser.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid2
            // 
            this.colid2.FieldName = "id";
            this.colid2.Name = "colid2";
            // 
            // colcode1
            // 
            this.colcode1.Caption = "用户编码";
            this.colcode1.FieldName = "code";
            this.colcode1.Name = "colcode1";
            this.colcode1.Visible = true;
            this.colcode1.VisibleIndex = 0;
            this.colcode1.Width = 80;
            // 
            // colname1
            // 
            this.colname1.Caption = "姓名";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            this.colname1.Width = 100;
            // 
            // colaccount
            // 
            this.colaccount.Caption = "账号";
            this.colaccount.FieldName = "account";
            this.colaccount.Name = "colaccount";
            this.colaccount.Visible = true;
            this.colaccount.VisibleIndex = 2;
            this.colaccount.Width = 120;
            // 
            // colmobile
            // 
            this.colmobile.Caption = "手机号";
            this.colmobile.FieldName = "mobile";
            this.colmobile.Name = "colmobile";
            this.colmobile.Visible = true;
            this.colmobile.VisibleIndex = 3;
            this.colmobile.Width = 120;
            // 
            // colemail
            // 
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            // 
            // colremark1
            // 
            this.colremark1.Caption = "备注";
            this.colremark1.FieldName = "remark";
            this.colremark1.Name = "colremark1";
            this.colremark1.Visible = true;
            this.colremark1.VisibleIndex = 4;
            this.colremark1.Width = 165;
            // 
            // colisInvalid1
            // 
            this.colisInvalid1.Caption = "封禁";
            this.colisInvalid1.FieldName = "invalid";
            this.colisInvalid1.Name = "colisInvalid1";
            this.colisInvalid1.Visible = true;
            this.colisInvalid1.VisibleIndex = 5;
            this.colisInvalid1.Width = 40;
            // 
            // ppcUser
            // 
            this.ppcUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppcUser.focusedRowHandle = -1;
            this.ppcUser.Location = new System.Drawing.Point(2, 261);
            this.ppcUser.MaximumSize = new System.Drawing.Size(0, 22);
            this.ppcUser.MinimumSize = new System.Drawing.Size(320, 22);
            this.ppcUser.Name = "ppcUser";
            this.ppcUser.page = 1;
            this.ppcUser.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("ppcUser.pageSizeItems")));
            this.ppcUser.Size = new System.Drawing.Size(661, 22);
            this.ppcUser.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.gdvTenant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).EndInit();
            this.panSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMember)).EndInit();
            this.splMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMember)).EndInit();
            this.grpMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private PanelControl palTenant;
        internal GridControl grdTenant;
        internal GridView gdvTenant;
        internal GridControl grdApp;
        internal GridView gdvApp;
        private PanelControl panSpace;
        private PanelControl panSearch;
        internal SimpleButton Search;
        internal ButtonEdit KeyInput;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colalias;
        private DevExpress.XtraGrid.Columns.GridColumn colremark;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colisInvalid;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coltenantId;
        private DevExpress.XtraGrid.Columns.GridColumn colappId;
        private DevExpress.XtraGrid.Columns.GridColumn colname2;
        private DevExpress.XtraGrid.Columns.GridColumn colexpireDate;
        private DevExpress.XtraGrid.Columns.GridColumn colid2;
        private DevExpress.XtraGrid.Columns.GridColumn colcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn colaccount;
        private DevExpress.XtraGrid.Columns.GridColumn colmobile;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colremark1;
        private DevExpress.XtraGrid.Columns.GridColumn colisInvalid1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repStatus;
        public Insight.Base.BaseForm.Controls.PageControl ppcUser;
        public Insight.Base.BaseForm.Controls.PageControl ppcTenant;
    }
}