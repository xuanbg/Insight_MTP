using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraWizard;
using WizardPage = DevExpress.XtraWizard.WizardPage;

namespace Insight.MTP.Client.Base.Roles.Views
{
    partial class Wizard
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard));
            this.WizRole = new DevExpress.XtraWizard.WizardControl();
            this.PagInfo = new DevExpress.XtraWizard.WizardPage();
            this.lueApp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.Description = new DevExpress.XtraEditors.MemoEdit();
            this.NameInput = new DevExpress.XtraEditors.TextEdit();
            this.PagAction = new DevExpress.XtraWizard.WizardPage();
            this.splModule = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpModule = new DevExpress.XtraEditors.GroupControl();
            this.TreFuncModule = new DevExpress.XtraTreeList.TreeList();
            this.colNavIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNav = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgAction = new DevExpress.Utils.ImageCollection(this.components);
            this.grpAction = new DevExpress.XtraEditors.GroupControl();
            this.TreFunc = new DevExpress.XtraTreeList.TreeList();
            this.colFuncIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFunc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFuncRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.PagData = new DevExpress.XtraWizard.WizardPage();
            this.splData = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpDataModule = new DevExpress.XtraEditors.GroupControl();
            this.TreDataModule = new DevExpress.XtraTreeList.TreeList();
            this.colModelIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgData = new DevExpress.Utils.ImageCollection(this.components);
            this.grpDataPerm = new DevExpress.XtraEditors.GroupControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDept = new DevExpress.XtraEditors.SimpleButton();
            this.TreData = new DevExpress.XtraTreeList.TreeList();
            this.colDataIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDataRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WizRole)).BeginInit();
            this.WizRole.SuspendLayout();
            this.PagInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameInput.Properties)).BeginInit();
            this.PagAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splModule)).BeginInit();
            this.splModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpModule)).BeginInit();
            this.grpModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreFuncModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAction)).BeginInit();
            this.grpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreFunc)).BeginInit();
            this.PagData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splData)).BeginInit();
            this.splData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDataModule)).BeginInit();
            this.grpDataModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreDataModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDataPerm)).BeginInit();
            this.grpDataPerm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreData)).BeginInit();
            this.SuspendLayout();
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
            // WizRole
            // 
            this.WizRole.Appearance.PageTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WizRole.Appearance.PageTitle.Options.UseFont = true;
            this.WizRole.CancelText = "取 消";
            this.WizRole.Controls.Add(this.PagInfo);
            this.WizRole.Controls.Add(this.PagAction);
            this.WizRole.Controls.Add(this.PagData);
            this.WizRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WizRole.FinishText = "完 成";
            this.WizRole.HeaderImage = ((System.Drawing.Image)(resources.GetObject("WizRole.HeaderImage")));
            this.WizRole.HelpText = "帮 助";
            this.WizRole.Location = new System.Drawing.Point(0, 0);
            this.WizRole.Name = "WizRole";
            this.WizRole.NextText = "下一步";
            this.WizRole.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.PagInfo,
            this.PagAction,
            this.PagData});
            this.WizRole.PreviousText = "上一步";
            this.WizRole.Size = new System.Drawing.Size(624, 442);
            // 
            // PagInfo
            // 
            this.PagInfo.Controls.Add(this.lueApp);
            this.PagInfo.Controls.Add(this.labelControl1);
            this.PagInfo.Controls.Add(this.labRemark);
            this.PagInfo.Controls.Add(this.labName);
            this.PagInfo.Controls.Add(this.Description);
            this.PagInfo.Controls.Add(this.NameInput);
            this.PagInfo.DescriptionText = "欢迎使用角色设置向导。在输入必要的基础信息后，请点击下一步设置该角色的功能权限。";
            this.PagInfo.Name = "PagInfo";
            this.PagInfo.Size = new System.Drawing.Size(592, 297);
            this.PagInfo.Text = "基本信息";
            // 
            // lueApp
            // 
            this.lueApp.Location = new System.Drawing.Point(90, 80);
            this.lueApp.Name = "lueApp";
            this.lueApp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueApp.Properties.NullText = "请选择……";
            this.lueApp.Size = new System.Drawing.Size(450, 20);
            this.lueApp.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(30, 120);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 21);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "备注：";
            // 
            // labRemark
            // 
            this.labRemark.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRemark.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labRemark.Appearance.Options.UseFont = true;
            this.labRemark.Appearance.Options.UseForeColor = true;
            this.labRemark.Appearance.Options.UseTextOptions = true;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(30, 80);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(60, 21);
            this.labRemark.TabIndex = 10;
            this.labRemark.Text = "所属应用：";
            // 
            // labName
            // 
            this.labName.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labName.Appearance.Options.UseFont = true;
            this.labName.Appearance.Options.UseForeColor = true;
            this.labName.Appearance.Options.UseTextOptions = true;
            this.labName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labName.Location = new System.Drawing.Point(30, 40);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(60, 21);
            this.labName.TabIndex = 11;
            this.labName.Text = "角色名称：";
            // 
            // Description
            // 
            this.Description.EnterMoveNextControl = true;
            this.Description.Location = new System.Drawing.Point(90, 120);
            this.Description.Name = "Description";
            this.Description.Properties.NullText = "请输入备注信息…";
            this.Description.Size = new System.Drawing.Size(450, 140);
            this.Description.TabIndex = 3;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(90, 40);
            this.NameInput.Name = "NameInput";
            this.NameInput.Properties.NullText = "请输入角色名称…";
            this.NameInput.Size = new System.Drawing.Size(450, 20);
            this.NameInput.TabIndex = 1;
            // 
            // PagAction
            // 
            this.PagAction.Controls.Add(this.splModule);
            this.PagAction.DescriptionText = "请先勾选需要授权的功能所属模块，然后设置功能权限。点击下一步进行数据权限设置。";
            this.PagAction.Name = "PagAction";
            this.PagAction.Size = new System.Drawing.Size(592, 297);
            this.PagAction.Text = "设置功能权限";
            // 
            // splModule
            // 
            this.splModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splModule.Location = new System.Drawing.Point(0, 0);
            this.splModule.Name = "splModule";
            this.splModule.Panel1.Controls.Add(this.grpModule);
            this.splModule.Panel1.MinSize = 275;
            this.splModule.Panel2.Controls.Add(this.grpAction);
            this.splModule.Panel2.MinSize = 312;
            this.splModule.Size = new System.Drawing.Size(592, 297);
            this.splModule.SplitterPosition = 275;
            this.splModule.TabIndex = 0;
            // 
            // grpModule
            // 
            this.grpModule.Controls.Add(this.TreFuncModule);
            this.grpModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpModule.Location = new System.Drawing.Point(0, 0);
            this.grpModule.Name = "grpModule";
            this.grpModule.Size = new System.Drawing.Size(275, 297);
            this.grpModule.TabIndex = 0;
            this.grpModule.Text = "业务模块";
            // 
            // TreFuncModule
            // 
            this.TreFuncModule.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNavIndex,
            this.colNav});
            this.TreFuncModule.DataSource = null;
            this.TreFuncModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreFuncModule.Location = new System.Drawing.Point(2, 21);
            this.TreFuncModule.Name = "TreFuncModule";
            this.TreFuncModule.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.TreFuncModule.OptionsSelection.MultiSelect = true;
            this.TreFuncModule.OptionsView.ShowCheckBoxes = true;
            this.TreFuncModule.ParentFieldName = "ParentId";
            this.TreFuncModule.SelectImageList = this.imgAction;
            this.TreFuncModule.Size = new System.Drawing.Size(271, 274);
            this.TreFuncModule.TabIndex = 0;
            // 
            // colNavIndex
            // 
            this.colNavIndex.FieldName = "index";
            this.colNavIndex.Name = "colNavIndex";
            // 
            // colNav
            // 
            this.colNav.FieldName = "name";
            this.colNav.MinWidth = 49;
            this.colNav.Name = "colNav";
            this.colNav.Visible = true;
            this.colNav.VisibleIndex = 0;
            this.colNav.Width = 49;
            // 
            // imgAction
            // 
            this.imgAction.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgAction.ImageStream")));
            this.imgAction.Images.SetKeyName(0, "Module.png");
            this.imgAction.InsertGalleryImage("openhyperlink_16x16.png", "images/actions/openhyperlink_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_16x16.png"), 1);
            this.imgAction.Images.SetKeyName(1, "openhyperlink_16x16.png");
            this.imgAction.Images.SetKeyName(2, "Action.png");
            this.imgAction.InsertGalleryImage("technology_16x16.png", "images/programming/technology_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/technology_16x16.png"), 3);
            this.imgAction.Images.SetKeyName(3, "technology_16x16.png");
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.TreFunc);
            this.grpAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAction.Location = new System.Drawing.Point(0, 0);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(312, 297);
            this.grpAction.TabIndex = 0;
            this.grpAction.Text = "功能操作";
            // 
            // TreFunc
            // 
            this.TreFunc.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colFuncIndex,
            this.colFunc,
            this.colFuncRemark});
            this.TreFunc.DataSource = null;
            this.TreFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreFunc.Location = new System.Drawing.Point(2, 21);
            this.TreFunc.Name = "TreFunc";
            this.TreFunc.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.TreFunc.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.TreFunc.OptionsSelection.MultiSelect = true;
            this.TreFunc.OptionsView.ShowCheckBoxes = true;
            this.TreFunc.ParentFieldName = "ParentId";
            this.TreFunc.SelectImageList = this.imgAction;
            this.TreFunc.Size = new System.Drawing.Size(308, 274);
            this.TreFunc.TabIndex = 0;
            // 
            // colFuncIndex
            // 
            this.colFuncIndex.FieldName = "index";
            this.colFuncIndex.Name = "colFuncIndex";
            // 
            // colFunc
            // 
            this.colFunc.FieldName = "name";
            this.colFunc.MinWidth = 49;
            this.colFunc.Name = "colFunc";
            this.colFunc.Visible = true;
            this.colFunc.VisibleIndex = 0;
            this.colFunc.Width = 210;
            // 
            // colFuncRemark
            // 
            this.colFuncRemark.FieldName = "remark";
            this.colFuncRemark.Name = "colFuncRemark";
            this.colFuncRemark.Visible = true;
            this.colFuncRemark.VisibleIndex = 1;
            this.colFuncRemark.Width = 80;
            // 
            // PagData
            // 
            this.PagData.Controls.Add(this.splData);
            this.PagData.DescriptionText = "请为该角色设置相应的数据权限，如权限重叠，以高权限（读写）为优先。";
            this.PagData.Name = "PagData";
            this.PagData.Size = new System.Drawing.Size(592, 297);
            this.PagData.Text = "设置数据权限";
            // 
            // splData
            // 
            this.splData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splData.Location = new System.Drawing.Point(0, 0);
            this.splData.Name = "splData";
            this.splData.Panel1.Controls.Add(this.grpDataModule);
            this.splData.Panel1.MinSize = 275;
            this.splData.Panel2.Controls.Add(this.grpDataPerm);
            this.splData.Panel2.MinSize = 312;
            this.splData.Size = new System.Drawing.Size(592, 297);
            this.splData.SplitterPosition = 275;
            this.splData.TabIndex = 0;
            // 
            // grpDataModule
            // 
            this.grpDataModule.Controls.Add(this.TreDataModule);
            this.grpDataModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDataModule.Location = new System.Drawing.Point(0, 0);
            this.grpDataModule.Name = "grpDataModule";
            this.grpDataModule.Size = new System.Drawing.Size(275, 297);
            this.grpDataModule.TabIndex = 0;
            this.grpDataModule.Text = "业务模块";
            // 
            // TreDataModule
            // 
            this.TreDataModule.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colModelIndex,
            this.colModel});
            this.TreDataModule.DataSource = null;
            this.TreDataModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreDataModule.Location = new System.Drawing.Point(2, 21);
            this.TreDataModule.Name = "TreDataModule";
            this.TreDataModule.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.TreDataModule.OptionsSelection.MultiSelect = true;
            this.TreDataModule.OptionsView.ShowCheckBoxes = true;
            this.TreDataModule.ParentFieldName = "ParentId";
            this.TreDataModule.SelectImageList = this.imgData;
            this.TreDataModule.Size = new System.Drawing.Size(271, 274);
            this.TreDataModule.TabIndex = 1;
            // 
            // colModelIndex
            // 
            this.colModelIndex.FieldName = "index";
            this.colModelIndex.Name = "colModelIndex";
            // 
            // colModel
            // 
            this.colModel.FieldName = "name";
            this.colModel.MinWidth = 49;
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 0;
            this.colModel.Width = 78;
            // 
            // imgData
            // 
            this.imgData.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgData.ImageStream")));
            this.imgData.InsertGalleryImage("operatingsystem_16x16.png", "images/programming/operatingsystem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/operatingsystem_16x16.png"), 0);
            this.imgData.Images.SetKeyName(0, "operatingsystem_16x16.png");
            this.imgData.InsertGalleryImage("openhyperlink_16x16.png", "images/actions/openhyperlink_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/openhyperlink_16x16.png"), 1);
            this.imgData.Images.SetKeyName(1, "openhyperlink_16x16.png");
            this.imgData.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 2);
            this.imgData.Images.SetKeyName(2, "database_16x16.png");
            this.imgData.Images.SetKeyName(3, "Item.png");
            this.imgData.InsertGalleryImage("customer_16x16.png", "images/people/customer_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/customer_16x16.png"), 4);
            this.imgData.Images.SetKeyName(4, "customer_16x16.png");
            this.imgData.Images.SetKeyName(5, "NodeDept.png");
            this.imgData.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 6);
            this.imgData.Images.SetKeyName(6, "home_16x16.png");
            this.imgData.Images.SetKeyName(7, "NodeOrg.png");
            this.imgData.InsertGalleryImage("documentmap_16x16.png", "images/navigation/documentmap_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/documentmap_16x16.png"), 8);
            this.imgData.Images.SetKeyName(8, "documentmap_16x16.png");
            // 
            // grpDataPerm
            // 
            this.grpDataPerm.Controls.Add(this.btnRemove);
            this.grpDataPerm.Controls.Add(this.btnAddUser);
            this.grpDataPerm.Controls.Add(this.btnAddDept);
            this.grpDataPerm.Controls.Add(this.TreData);
            this.grpDataPerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDataPerm.Location = new System.Drawing.Point(0, 0);
            this.grpDataPerm.Name = "grpDataPerm";
            this.grpDataPerm.Size = new System.Drawing.Size(312, 297);
            this.grpDataPerm.TabIndex = 1;
            this.grpDataPerm.Text = "数据权限";
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Appearance.Options.UseBackColor = true;
            this.btnRemove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRemove.Enabled = false;
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRemove.Location = new System.Drawing.Point(291, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(20, 20);
            this.btnRemove.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Appearance.Options.UseBackColor = true;
            this.btnAddUser.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAddUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.ImageOptions.Image")));
            this.btnAddUser.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddUser.Location = new System.Drawing.Point(239, 0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(20, 20);
            this.btnAddUser.TabIndex = 2;
            // 
            // btnAddDept
            // 
            this.btnAddDept.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDept.Appearance.Options.UseBackColor = true;
            this.btnAddDept.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAddDept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDept.ImageOptions.Image")));
            this.btnAddDept.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddDept.Location = new System.Drawing.Point(265, 0);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(20, 20);
            this.btnAddDept.TabIndex = 2;
            // 
            // TreData
            // 
            this.TreData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDataIndex,
            this.colData,
            this.colDataRemark});
            this.TreData.DataSource = null;
            this.TreData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreData.Location = new System.Drawing.Point(2, 21);
            this.TreData.Name = "TreData";
            this.TreData.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.TreData.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.TreData.OptionsSelection.MultiSelect = true;
            this.TreData.OptionsView.ShowCheckBoxes = true;
            this.TreData.ParentFieldName = "ParentId";
            this.TreData.SelectImageList = this.imgData;
            this.TreData.Size = new System.Drawing.Size(308, 274);
            this.TreData.TabIndex = 1;
            // 
            // colDataIndex
            // 
            this.colDataIndex.Name = "colDataIndex";
            // 
            // colData
            // 
            this.colData.FieldName = "name";
            this.colData.MinWidth = 49;
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            this.colData.Width = 210;
            // 
            // colDataRemark
            // 
            this.colDataRemark.FieldName = "remark";
            this.colDataRemark.Name = "colDataRemark";
            this.colDataRemark.Visible = true;
            this.colDataRemark.VisibleIndex = 1;
            this.colDataRemark.Width = 80;
            // 
            // Wizard
            // 
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.WizRole);
            this.Name = "Wizard";
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WizRole)).EndInit();
            this.WizRole.ResumeLayout(false);
            this.PagInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueApp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameInput.Properties)).EndInit();
            this.PagAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splModule)).EndInit();
            this.splModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpModule)).EndInit();
            this.grpModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreFuncModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAction)).EndInit();
            this.grpAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreFunc)).EndInit();
            this.PagData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splData)).EndInit();
            this.splData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDataModule)).EndInit();
            this.grpDataModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreDataModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDataPerm)).EndInit();
            this.grpDataPerm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal TextEdit NameInput;
        internal MemoEdit Description;
        internal TreeList TreFuncModule;
        internal TreeList TreFunc;
        internal TreeList TreDataModule;
        internal TreeList TreData;
        internal WizardControl WizRole;
        internal WizardPage PagInfo;
        private WizardPage PagAction;
        private WizardPage PagData;
        private LabelControl labRemark;
        private LabelControl labName;
        private SplitContainerControl splModule;
        private SplitContainerControl splData;
        private ImageCollection imgAction;
        private ImageCollection imgData;
        private GroupControl grpModule;
        private GroupControl grpAction;
        private GroupControl grpDataModule;
        private GroupControl grpDataPerm;
        private TreeListColumn colNavIndex;
        private TreeListColumn colNav;
        private TreeListColumn colFuncIndex;
        private TreeListColumn colFunc;
        private TreeListColumn colFuncRemark;
        private TreeListColumn colModelIndex;
        private TreeListColumn colModel;
        private TreeListColumn colDataIndex;
        private TreeListColumn colData;
        private TreeListColumn colDataRemark;
        private SimpleButton btnRemove;
        private SimpleButton btnAddUser;
        private SimpleButton btnAddDept;
        internal LookUpEdit lueApp;
        private LabelControl labelControl1;
    }
}
