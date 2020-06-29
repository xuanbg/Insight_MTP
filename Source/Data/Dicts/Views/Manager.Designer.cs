using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Data.Dicts.Views
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
            this.sccMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.pceDict = new DevExpress.XtraEditors.PanelControl();
            this.grdDict = new DevExpress.XtraGrid.GridControl();
            this.gdvDict = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colappName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.upcDict = new Insight.Base.BaseForm.Controls.PageControl();
            this.pceKey = new DevExpress.XtraEditors.PanelControl();
            this.grdKey = new DevExpress.XtraGrid.GridControl();
            this.gdvKey = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colextend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).BeginInit();
            this.sccMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceDict)).BeginInit();
            this.pceDict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceKey)).BeginInit();
            this.pceKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Controls.Add(this.sccMain);
            this.xtraScrollable.Controls.Add(this.panSpace);
            this.xtraScrollable.Controls.Add(this.panSearch);
            this.xtraScrollable.Location = new System.Drawing.Point(0, 31);
            this.xtraScrollable.Padding = new System.Windows.Forms.Padding(5);
            this.xtraScrollable.Size = new System.Drawing.Size(1080, 598);
            // 
            // FolderNode
            // 
            this.FolderNode.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("FolderNode.ImageStream")));
            this.FolderNode.Images.SetKeyName(0, "Item.png");
            this.FolderNode.Images.SetKeyName(1, "Folder.png");
            this.FolderNode.Images.SetKeyName(2, "FolderOpen.png");
            // 
            // sccMain
            // 
            this.sccMain.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.sccMain.Appearance.Options.UseBackColor = true;
            this.sccMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sccMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.sccMain.Location = new System.Drawing.Point(5, 49);
            this.sccMain.Name = "sccMain";
            this.sccMain.Panel1.Controls.Add(this.pceDict);
            this.sccMain.Panel1.MinSize = 400;
            this.sccMain.Panel2.Controls.Add(this.pceKey);
            this.sccMain.Panel2.MinSize = 500;
            this.sccMain.Size = new System.Drawing.Size(1070, 544);
            this.sccMain.SplitterPosition = 502;
            this.sccMain.TabIndex = 0;
            this.sccMain.Text = "splitContainerControl1";
            // 
            // pceDict
            // 
            this.pceDict.Controls.Add(this.grdDict);
            this.pceDict.Controls.Add(this.upcDict);
            this.pceDict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceDict.Location = new System.Drawing.Point(0, 0);
            this.pceDict.Name = "pceDict";
            this.pceDict.Size = new System.Drawing.Size(502, 544);
            this.pceDict.TabIndex = 0;
            // 
            // grdDict
            // 
            this.grdDict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDict.Location = new System.Drawing.Point(2, 2);
            this.grdDict.MainView = this.gdvDict;
            this.grdDict.Name = "grdDict";
            this.grdDict.Size = new System.Drawing.Size(498, 518);
            this.grdDict.TabIndex = 0;
            this.grdDict.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDict});
            // 
            // gdvDict
            // 
            this.gdvDict.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvDict.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colappName,
            this.colcode,
            this.colname,
            this.colremark});
            this.gdvDict.GridControl = this.grdDict;
            this.gdvDict.Name = "gdvDict";
            this.gdvDict.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colappName
            // 
            this.colappName.Caption = "应用";
            this.colappName.FieldName = "appName";
            this.colappName.Name = "colappName";
            this.colappName.Visible = true;
            this.colappName.VisibleIndex = 0;
            this.colappName.Width = 200;
            // 
            // colcode
            // 
            this.colcode.Caption = "键名";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 1;
            this.colcode.Width = 140;
            // 
            // colname
            // 
            this.colname.Caption = "名称";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 140;
            // 
            // colremark
            // 
            this.colremark.FieldName = "remark";
            this.colremark.Name = "colremark";
            // 
            // upcDict
            // 
            this.upcDict.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.upcDict.focusedRowHandle = -1;
            this.upcDict.Location = new System.Drawing.Point(2, 520);
            this.upcDict.MaximumSize = new System.Drawing.Size(0, 22);
            this.upcDict.MinimumSize = new System.Drawing.Size(320, 22);
            this.upcDict.Name = "upcDict";
            this.upcDict.page = 1;
            this.upcDict.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("upcDict.pageSizeItems")));
            this.upcDict.Size = new System.Drawing.Size(498, 22);
            this.upcDict.TabIndex = 0;
            // 
            // pceKey
            // 
            this.pceKey.Controls.Add(this.grdKey);
            this.pceKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceKey.Location = new System.Drawing.Point(0, 0);
            this.pceKey.Name = "pceKey";
            this.pceKey.Size = new System.Drawing.Size(563, 544);
            this.pceKey.TabIndex = 0;
            // 
            // grdKey
            // 
            this.grdKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKey.Location = new System.Drawing.Point(2, 2);
            this.grdKey.MainView = this.gdvKey;
            this.grdKey.Name = "grdKey";
            this.grdKey.Size = new System.Drawing.Size(559, 540);
            this.grdKey.TabIndex = 0;
            this.grdKey.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvKey});
            // 
            // gdvKey
            // 
            this.gdvKey.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvKey.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.coltenantId,
            this.colindex,
            this.colcode1,
            this.colvalue,
            this.colextend,
            this.colremark1});
            this.gdvKey.GridControl = this.grdKey;
            this.gdvKey.Name = "gdvKey";
            this.gdvKey.OptionsDetail.EnableMasterViewMode = false;
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
            // colindex
            // 
            this.colindex.Caption = "序号";
            this.colindex.FieldName = "index";
            this.colindex.Name = "colindex";
            this.colindex.Visible = true;
            this.colindex.VisibleIndex = 0;
            this.colindex.Width = 40;
            // 
            // colcode1
            // 
            this.colcode1.Caption = "编码";
            this.colcode1.FieldName = "code";
            this.colcode1.Name = "colcode1";
            this.colcode1.Visible = true;
            this.colcode1.VisibleIndex = 1;
            this.colcode1.Width = 120;
            // 
            // colvalue
            // 
            this.colvalue.Caption = "键值";
            this.colvalue.FieldName = "value";
            this.colvalue.Name = "colvalue";
            this.colvalue.Visible = true;
            this.colvalue.VisibleIndex = 2;
            this.colvalue.Width = 160;
            // 
            // colextend
            // 
            this.colextend.FieldName = "extend";
            this.colextend.Name = "colextend";
            // 
            // colremark1
            // 
            this.colremark1.Caption = "备注";
            this.colremark1.FieldName = "remark";
            this.colremark1.Name = "colremark1";
            this.colremark1.Visible = true;
            this.colremark1.VisibleIndex = 3;
            this.colremark1.Width = 200;
            // 
            // panSpace
            // 
            this.panSpace.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panSpace.Appearance.Options.UseBackColor = true;
            this.panSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSpace.Location = new System.Drawing.Point(5, 44);
            this.panSpace.Name = "panSpace";
            this.panSpace.Size = new System.Drawing.Size(1070, 5);
            this.panSpace.TabIndex = 0;
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
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1080, 629);
            this.Name = "Manager";
            this.Text = "字典管理";
            this.xtraScrollable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).EndInit();
            this.sccMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pceDict)).EndInit();
            this.pceDict.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceKey)).EndInit();
            this.pceKey.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).EndInit();
            this.panSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PanelControl panSpace;
        private PanelControl panSearch;
        public SimpleButton Search;
        public ButtonEdit KeyInput;
        public GridControl grdDict;
        public Base.BaseForm.Controls.PageControl upcDict;
        public GridView gdvDict;
        private SplitContainerControl sccMain;
        private PanelControl pceDict;
        private PanelControl pceKey;
        public GridControl grdKey;
        public GridView gdvKey;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colappName;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colremark;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn coltenantId;
        private DevExpress.XtraGrid.Columns.GridColumn colindex;
        private DevExpress.XtraGrid.Columns.GridColumn colcode1;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue;
        private DevExpress.XtraGrid.Columns.GridColumn colextend;
        private DevExpress.XtraGrid.Columns.GridColumn colremark1;
    }
}