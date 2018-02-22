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
            this.labRemark = new DevExpress.XtraEditors.LabelControl();
            this.labName = new DevExpress.XtraEditors.LabelControl();
            this.Description = new DevExpress.XtraEditors.MemoEdit();
            this.NameInput = new DevExpress.XtraEditors.TextEdit();
            this.PagAction = new DevExpress.XtraWizard.WizardPage();
            this.splModule = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpModule = new DevExpress.XtraEditors.GroupControl();
            this.TreModule = new DevExpress.XtraTreeList.TreeList();
            this.colIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAction = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgAction = new DevExpress.Utils.ImageCollection(this.components);
            this.grpAction = new DevExpress.XtraEditors.GroupControl();
            this.TreAction = new DevExpress.XtraTreeList.TreeList();
            this.colIndex1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAction1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermit1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.PagData = new DevExpress.XtraWizard.WizardPage();
            this.splData = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpDataModule = new DevExpress.XtraEditors.GroupControl();
            this.TreDataModule = new DevExpress.XtraTreeList.TreeList();
            this.colIndex2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermit2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colState = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgData = new DevExpress.Utils.ImageCollection(this.components);
            this.grpDataPerm = new DevExpress.XtraEditors.GroupControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDept = new DevExpress.XtraEditors.SimpleButton();
            this.TreDataPerm = new DevExpress.XtraTreeList.TreeList();
            this.colIndex3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colType3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModel1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPermit3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colState1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgTreeNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WizRole)).BeginInit();
            this.WizRole.SuspendLayout();
            this.PagInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameInput.Properties)).BeginInit();
            this.PagAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splModule)).BeginInit();
            this.splModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpModule)).BeginInit();
            this.grpModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAction)).BeginInit();
            this.grpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreAction)).BeginInit();
            this.PagData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splData)).BeginInit();
            this.splData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDataModule)).BeginInit();
            this.grpDataModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreDataModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDataPerm)).BeginInit();
            this.grpDataPerm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreDataPerm)).BeginInit();
            this.SuspendLayout();
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
            this.PagInfo.Controls.Add(this.labRemark);
            this.PagInfo.Controls.Add(this.labName);
            this.PagInfo.Controls.Add(this.Description);
            this.PagInfo.Controls.Add(this.NameInput);
            this.PagInfo.DescriptionText = "欢迎使用角色设置向导。在输入必要的基础信息后，请点击下一步设置该角色的功能权限。";
            this.PagInfo.Name = "PagInfo";
            this.PagInfo.Size = new System.Drawing.Size(592, 297);
            this.PagInfo.Text = "基本信息";
            // 
            // labRemark
            // 
            this.labRemark.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRemark.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labRemark.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labRemark.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labRemark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labRemark.Location = new System.Drawing.Point(30, 80);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(60, 21);
            this.labRemark.TabIndex = 10;
            this.labRemark.Text = "备注：";
            // 
            // labName
            // 
            this.labName.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Appearance.ForeColor = System.Drawing.Color.Black;
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
            this.Description.Location = new System.Drawing.Point(90, 80);
            this.Description.Name = "Description";
            this.Description.Properties.NullText = "请输入备注信息…";
            this.Description.Size = new System.Drawing.Size(450, 180);
            this.Description.TabIndex = 2;
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
            this.grpModule.Controls.Add(this.TreModule);
            this.grpModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpModule.Location = new System.Drawing.Point(0, 0);
            this.grpModule.Name = "grpModule";
            this.grpModule.Size = new System.Drawing.Size(275, 297);
            this.grpModule.TabIndex = 0;
            this.grpModule.Text = "业务模块";
            // 
            // TreModule
            // 
            this.TreModule.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIndex,
            this.colType,
            this.colAction,
            this.colDescription,
            this.colPermit});
            this.TreModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreModule.Location = new System.Drawing.Point(2, 21);
            this.TreModule.Name = "TreModule";
            this.TreModule.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.TreModule.OptionsSelection.MultiSelect = true;
            this.TreModule.OptionsView.ShowCheckBoxes = true;
            this.TreModule.ParentFieldName = "ParentId";
            this.TreModule.SelectImageList = this.imgAction;
            this.TreModule.Size = new System.Drawing.Size(271, 274);
            this.TreModule.TabIndex = 0;
            // 
            // colIndex
            // 
            this.colIndex.FieldName = "Index";
            this.colIndex.Name = "colIndex";
            this.colIndex.Width = 62;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 36;
            // 
            // colAction
            // 
            this.colAction.FieldName = "Name";
            this.colAction.MinWidth = 49;
            this.colAction.Name = "colAction";
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 0;
            this.colAction.Width = 36;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 36;
            // 
            // colPermit
            // 
            this.colPermit.FieldName = "Permit";
            this.colPermit.Name = "colPermit";
            this.colPermit.Width = 37;
            // 
            // imgAction
            // 
            this.imgAction.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgAction.ImageStream")));
            this.imgAction.Images.SetKeyName(0, "Navigation.png");
            this.imgAction.Images.SetKeyName(1, "Module.png");
            this.imgAction.Images.SetKeyName(2, "Action.png");
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.TreAction);
            this.grpAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAction.Location = new System.Drawing.Point(0, 0);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(312, 297);
            this.grpAction.TabIndex = 0;
            this.grpAction.Text = "功能操作";
            // 
            // TreAction
            // 
            this.TreAction.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIndex1,
            this.colType1,
            this.colAction1,
            this.colDescription1,
            this.colPermit1});
            this.TreAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreAction.Location = new System.Drawing.Point(2, 21);
            this.TreAction.Name = "TreAction";
            this.TreAction.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.TreAction.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.TreAction.OptionsSelection.MultiSelect = true;
            this.TreAction.OptionsView.ShowCheckBoxes = true;
            this.TreAction.ParentFieldName = "ParentId";
            this.TreAction.SelectImageList = this.imgAction;
            this.TreAction.Size = new System.Drawing.Size(308, 274);
            this.TreAction.TabIndex = 0;
            // 
            // colIndex1
            // 
            this.colIndex1.FieldName = "Index";
            this.colIndex1.Name = "colIndex1";
            this.colIndex1.Width = 72;
            // 
            // colType1
            // 
            this.colType1.FieldName = "Type";
            this.colType1.Name = "colType1";
            this.colType1.Width = 85;
            // 
            // colAction1
            // 
            this.colAction1.FieldName = "Name";
            this.colAction1.MinWidth = 49;
            this.colAction1.Name = "colAction1";
            this.colAction1.Visible = true;
            this.colAction1.VisibleIndex = 0;
            this.colAction1.Width = 210;
            // 
            // colDescription1
            // 
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 1;
            this.colDescription1.Width = 80;
            // 
            // colPermit1
            // 
            this.colPermit1.FieldName = "Permit";
            this.colPermit1.Name = "colPermit1";
            this.colPermit1.Width = 63;
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
            this.colIndex2,
            this.colType2,
            this.colModel,
            this.colDescription2,
            this.colPermit2,
            this.colState});
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
            // colIndex2
            // 
            this.colIndex2.FieldName = "Index";
            this.colIndex2.Name = "colIndex2";
            this.colIndex2.Width = 61;
            // 
            // colType2
            // 
            this.colType2.FieldName = "Type";
            this.colType2.Name = "colType2";
            this.colType2.Width = 69;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Name";
            this.colModel.MinWidth = 49;
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 0;
            this.colModel.Width = 78;
            // 
            // colDescription2
            // 
            this.colDescription2.FieldName = "Description";
            this.colDescription2.Name = "colDescription2";
            this.colDescription2.Width = 44;
            // 
            // colPermit2
            // 
            this.colPermit2.FieldName = "Permit";
            this.colPermit2.Name = "colPermit2";
            this.colPermit2.Width = 44;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Width = 43;
            // 
            // imgData
            // 
            this.imgData.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgData.ImageStream")));
            this.imgData.Images.SetKeyName(0, "Navigation.png");
            this.imgData.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 1);
            this.imgData.Images.SetKeyName(1, "database_16x16.png");
            this.imgData.Images.SetKeyName(2, "Item.png");
            this.imgData.InsertGalleryImage("customer_16x16.png", "images/people/customer_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/customer_16x16.png"), 3);
            this.imgData.Images.SetKeyName(3, "customer_16x16.png");
            this.imgData.Images.SetKeyName(4, "NodeDept.png");
            this.imgData.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 5);
            this.imgData.Images.SetKeyName(5, "home_16x16.png");
            this.imgData.Images.SetKeyName(6, "NodeOrg.png");
            this.imgData.InsertGalleryImage("documentmap_16x16.png", "images/navigation/documentmap_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/documentmap_16x16.png"), 7);
            this.imgData.Images.SetKeyName(7, "documentmap_16x16.png");
            // 
            // grpDataPerm
            // 
            this.grpDataPerm.Controls.Add(this.btnRemove);
            this.grpDataPerm.Controls.Add(this.btnAddUser);
            this.grpDataPerm.Controls.Add(this.btnAddDept);
            this.grpDataPerm.Controls.Add(this.TreDataPerm);
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
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
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
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
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
            this.btnAddDept.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDept.Image")));
            this.btnAddDept.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddDept.Location = new System.Drawing.Point(265, 0);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(20, 20);
            this.btnAddDept.TabIndex = 2;
            // 
            // TreDataPerm
            // 
            this.TreDataPerm.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIndex3,
            this.colType3,
            this.colModel1,
            this.colDescription3,
            this.colPermit3,
            this.colState1});
            this.TreDataPerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreDataPerm.Location = new System.Drawing.Point(2, 21);
            this.TreDataPerm.Name = "TreDataPerm";
            this.TreDataPerm.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.TreDataPerm.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.TreDataPerm.OptionsSelection.MultiSelect = true;
            this.TreDataPerm.OptionsView.ShowCheckBoxes = true;
            this.TreDataPerm.ParentFieldName = "ParentId";
            this.TreDataPerm.SelectImageList = this.imgData;
            this.TreDataPerm.Size = new System.Drawing.Size(308, 274);
            this.TreDataPerm.TabIndex = 1;
            // 
            // colIndex3
            // 
            this.colIndex3.FieldName = "Index";
            this.colIndex3.Name = "colIndex3";
            this.colIndex3.Width = 67;
            // 
            // colType3
            // 
            this.colType3.FieldName = "Type";
            this.colType3.Name = "colType3";
            this.colType3.Width = 76;
            // 
            // colModel1
            // 
            this.colModel1.FieldName = "Name";
            this.colModel1.MinWidth = 49;
            this.colModel1.Name = "colModel1";
            this.colModel1.Visible = true;
            this.colModel1.VisibleIndex = 0;
            this.colModel1.Width = 210;
            // 
            // colDescription3
            // 
            this.colDescription3.FieldName = "Description";
            this.colDescription3.Name = "colDescription3";
            this.colDescription3.Visible = true;
            this.colDescription3.VisibleIndex = 1;
            this.colDescription3.Width = 80;
            // 
            // colPermit3
            // 
            this.colPermit3.FieldName = "Permit";
            this.colPermit3.Name = "colPermit3";
            this.colPermit3.Width = 51;
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.Width = 50;
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
            ((System.ComponentModel.ISupportInitialize)(this.Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameInput.Properties)).EndInit();
            this.PagAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splModule)).EndInit();
            this.splModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpModule)).EndInit();
            this.grpModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAction)).EndInit();
            this.grpAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreAction)).EndInit();
            this.PagData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splData)).EndInit();
            this.splData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDataModule)).EndInit();
            this.grpDataModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreDataModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDataPerm)).EndInit();
            this.grpDataPerm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreDataPerm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal TextEdit NameInput;
        internal MemoEdit Description;
        internal TreeList TreModule;
        internal TreeList TreAction;
        internal TreeList TreDataModule;
        internal TreeList TreDataPerm;
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
        private TreeListColumn colIndex;
        private TreeListColumn colType;
        private TreeListColumn colAction;
        private TreeListColumn colDescription;
        private TreeListColumn colPermit;
        private TreeListColumn colIndex1;
        private TreeListColumn colType1;
        private TreeListColumn colAction1;
        private TreeListColumn colDescription1;
        private TreeListColumn colPermit1;
        private TreeListColumn colIndex2;
        private TreeListColumn colType2;
        private TreeListColumn colModel;
        private TreeListColumn colDescription2;
        private TreeListColumn colPermit2;
        private TreeListColumn colState;
        private TreeListColumn colIndex3;
        private TreeListColumn colType3;
        private TreeListColumn colModel1;
        private TreeListColumn colDescription3;
        private TreeListColumn colPermit3;
        private TreeListColumn colState1;
        private SimpleButton btnRemove;
        private SimpleButton btnAddUser;
        private SimpleButton btnAddDept;
    }
}
