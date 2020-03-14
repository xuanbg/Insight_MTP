using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;

namespace Insight.MTP.Client.Setting.Roles.Views
{
    partial class MemberDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDialog));
            this.tabMember = new DevExpress.XtraTab.XtraTabControl();
            this.pagTitle = new DevExpress.XtraTab.XtraTabPage();
            this.palTitle = new DevExpress.XtraEditors.PanelControl();
            this.treOrg = new DevExpress.XtraTreeList.TreeList();
            this.colIndex = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNodeType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pagUser = new DevExpress.XtraTab.XtraTabPage();
            this.grdUser = new DevExpress.XtraGrid.GridControl();
            this.gdvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pagGroup = new DevExpress.XtraTab.XtraTabPage();
            this.grdGroup = new DevExpress.XtraGrid.GridControl();
            this.gdvGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMember)).BeginInit();
            this.tabMember.SuspendLayout();
            this.pagTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palTitle)).BeginInit();
            this.palTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treOrg)).BeginInit();
            this.pagUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUser)).BeginInit();
            this.pagGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Size = new System.Drawing.Size(370, 400);
            this.panel.Visible = false;
            // 
            // Cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.Location = new System.Drawing.Point(200, 424);
            // 
            // Confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(290, 424);
            // 
            // tabMember
            // 
            this.tabMember.Location = new System.Drawing.Point(7, 7);
            this.tabMember.Name = "tabMember";
            this.tabMember.SelectedTabPage = this.pagUser;
            this.tabMember.Size = new System.Drawing.Size(374, 404);
            this.tabMember.TabIndex = 100;
            this.tabMember.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pagUser,
            this.pagGroup,
            this.pagTitle});
            // 
            // pagTitle
            // 
            this.pagTitle.Controls.Add(this.palTitle);
            this.pagTitle.Name = "pagTitle";
            this.pagTitle.Size = new System.Drawing.Size(368, 375);
            this.pagTitle.Text = "添加职位成员";
            // 
            // palTitle
            // 
            this.palTitle.Controls.Add(this.treOrg);
            this.palTitle.Location = new System.Drawing.Point(3, 3);
            this.palTitle.Name = "palTitle";
            this.palTitle.Size = new System.Drawing.Size(362, 369);
            this.palTitle.TabIndex = 0;
            // 
            // treOrg
            // 
            this.treOrg.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIndex,
            this.colNodeType,
            this.colName2});
            this.treOrg.DataSource = null;
            this.treOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treOrg.Location = new System.Drawing.Point(2, 2);
            this.treOrg.Name = "treOrg";
            this.treOrg.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treOrg.OptionsSelection.MultiSelect = true;
            this.treOrg.OptionsView.ShowCheckBoxes = true;
            this.treOrg.ParentFieldName = "ParentId";
            this.treOrg.Size = new System.Drawing.Size(358, 365);
            this.treOrg.TabIndex = 0;
            // 
            // colIndex
            // 
            this.colIndex.FieldName = "index";
            this.colIndex.Name = "colIndex";
            this.colIndex.Width = 85;
            // 
            // colNodeType
            // 
            this.colNodeType.FieldName = "nodeType";
            this.colNodeType.Name = "colNodeType";
            this.colNodeType.Width = 146;
            // 
            // colName2
            // 
            this.colName2.FieldName = "name";
            this.colName2.MinWidth = 49;
            this.colName2.Name = "colName2";
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 0;
            this.colName2.Width = 186;
            // 
            // pagUser
            // 
            this.pagUser.Controls.Add(this.grdUser);
            this.pagUser.Name = "pagUser";
            this.pagUser.Size = new System.Drawing.Size(368, 375);
            this.pagUser.Text = "添加用户成员";
            // 
            // grdUser
            // 
            this.grdUser.Location = new System.Drawing.Point(3, 3);
            this.grdUser.MainView = this.gdvUser;
            this.grdUser.Name = "grdUser";
            this.grdUser.Size = new System.Drawing.Size(362, 369);
            this.grdUser.TabIndex = 1;
            this.grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUser});
            // 
            // gdvUser
            // 
            this.gdvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colName1,
            this.colLoginName,
            this.colDescription1});
            this.gdvUser.GridControl = this.grdUser;
            this.gdvUser.Name = "gdvUser";
            this.gdvUser.OptionsFind.AlwaysVisible = true;
            this.gdvUser.OptionsFind.FindDelay = 100;
            this.gdvUser.OptionsFind.FindNullPrompt = "输入关键字进行查询…";
            this.gdvUser.OptionsFind.HighlightFindResults = false;
            this.gdvUser.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gdvUser.OptionsSelection.MultiSelect = true;
            this.gdvUser.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colID1
            // 
            this.colID1.FieldName = "id";
            this.colID1.Name = "colID1";
            // 
            // colName1
            // 
            this.colName1.Caption = "用户姓名";
            this.colName1.FieldName = "name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            this.colName1.Width = 100;
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
            // colDescription1
            // 
            this.colDescription1.Caption = "描述";
            this.colDescription1.FieldName = "remark";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 3;
            this.colDescription1.Width = 140;
            // 
            // pagGroup
            // 
            this.pagGroup.Controls.Add(this.grdGroup);
            this.pagGroup.Name = "pagGroup";
            this.pagGroup.Size = new System.Drawing.Size(368, 375);
            this.pagGroup.Text = "添加用户组成员";
            // 
            // grdGroup
            // 
            this.grdGroup.Location = new System.Drawing.Point(3, 3);
            this.grdGroup.MainView = this.gdvGroup;
            this.grdGroup.Name = "grdGroup";
            this.grdGroup.Size = new System.Drawing.Size(362, 369);
            this.grdGroup.TabIndex = 0;
            this.grdGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvGroup});
            // 
            // gdvGroup
            // 
            this.gdvGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colDescription});
            this.gdvGroup.GridControl = this.grdGroup;
            this.gdvGroup.Name = "gdvGroup";
            this.gdvGroup.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gdvGroup.OptionsSelection.MultiSelect = true;
            this.gdvGroup.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colID
            // 
            this.colID.FieldName = "id";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "描述";
            this.colDescription.FieldName = "remark";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 220;
            // 
            // Member
            // 
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.tabMember);
            this.Name = "Member";
            this.Text = "添加角色成员";
            this.Controls.SetChildIndex(this.panel, 0);
            this.Controls.SetChildIndex(this.tabMember, 0);
            this.Controls.SetChildIndex(this.cancel, 0);
            this.Controls.SetChildIndex(this.confirm, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMember)).EndInit();
            this.tabMember.ResumeLayout(false);
            this.pagTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.palTitle)).EndInit();
            this.palTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treOrg)).EndInit();
            this.pagUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUser)).EndInit();
            this.pagGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraTabControl tabMember;
        private XtraTabPage pagTitle;
        private XtraTabPage pagGroup;
        private XtraTabPage pagUser;
        private PanelControl palTitle;
        internal TreeList treOrg;
        internal GridControl grdGroup;
        internal GridView gdvGroup;
        internal GridControl grdUser;
        internal GridView gdvUser;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndex;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNodeType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName2;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
    }
}
