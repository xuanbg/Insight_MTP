using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Platform.Scenes.Views
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
            this.pceMaster = new DevExpress.XtraEditors.PanelControl();
            this.grdMaster = new DevExpress.XtraGrid.GridControl();
            this.gdvMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pucMaster = new Insight.Base.BaseForm.Controls.PageControl();
            this.pceSpace = new DevExpress.XtraEditors.PanelControl();
            this.pceSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.grdDetail = new DevExpress.XtraGrid.GridControl();
            this.gdvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colappId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colappName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsign = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexpire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreatedTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceMaster)).BeginInit();
            this.pceMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceSearch)).BeginInit();
            this.pceSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleType)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollable
            // 
            this.xtraScrollable.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraScrollable.Appearance.Options.UseBackColor = true;
            this.xtraScrollable.Controls.Add(this.splMain);
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
            this.splMain.Location = new System.Drawing.Point(5, 5);
            this.splMain.Name = "splMain";
            this.splMain.Panel1.Controls.Add(this.pceMaster);
            this.splMain.Panel1.Controls.Add(this.pceSpace);
            this.splMain.Panel1.Controls.Add(this.pceSearch);
            this.splMain.Panel1.MinSize = 500;
            this.splMain.Panel2.Controls.Add(this.grdDetail);
            this.splMain.Panel2.MinSize = 200;
            this.splMain.ScrollBarSmallChange = 1;
            this.splMain.Size = new System.Drawing.Size(1410, 819);
            this.splMain.SplitterPosition = 540;
            this.splMain.TabIndex = 0;
            // 
            // pceMaster
            // 
            this.pceMaster.Controls.Add(this.grdMaster);
            this.pceMaster.Controls.Add(this.pucMaster);
            this.pceMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pceMaster.Location = new System.Drawing.Point(0, 44);
            this.pceMaster.Name = "pceMaster";
            this.pceMaster.Size = new System.Drawing.Size(1410, 496);
            this.pceMaster.TabIndex = 0;
            // 
            // grdMaster
            // 
            this.grdMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaster.Location = new System.Drawing.Point(2, 2);
            this.grdMaster.MainView = this.gdvMaster;
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rleType});
            this.grdMaster.Size = new System.Drawing.Size(1406, 470);
            this.grdMaster.TabIndex = 0;
            this.grdMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvMaster});
            // 
            // gdvMaster
            // 
            this.gdvMaster.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcode,
            this.coltype,
            this.colname,
            this.coltitle,
            this.coltag,
            this.colparam,
            this.colremark});
            this.gdvMaster.GridControl = this.grdMaster;
            this.gdvMaster.Name = "gdvMaster";
            this.gdvMaster.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colcode
            // 
            this.colcode.Caption = "场景编码";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            this.colcode.Width = 60;
            // 
            // coltype
            // 
            this.coltype.Caption = "发送类型";
            this.coltype.ColumnEdit = this.rleType;
            this.coltype.FieldName = "type";
            this.coltype.Name = "coltype";
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 1;
            this.coltype.Width = 80;
            // 
            // colname
            // 
            this.colname.Caption = "场景名称";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 200;
            // 
            // coltitle
            // 
            this.coltitle.Caption = "消息标题";
            this.coltitle.FieldName = "title";
            this.coltitle.Name = "coltitle";
            this.coltitle.Visible = true;
            this.coltitle.VisibleIndex = 3;
            this.coltitle.Width = 240;
            // 
            // coltag
            // 
            this.coltag.Caption = "消息标签";
            this.coltag.FieldName = "tag";
            this.coltag.Name = "coltag";
            this.coltag.Visible = true;
            this.coltag.VisibleIndex = 4;
            this.coltag.Width = 100;
            // 
            // colparam
            // 
            this.colparam.Caption = "消息参数";
            this.colparam.FieldName = "paramVal";
            this.colparam.Name = "colparam";
            this.colparam.Visible = true;
            this.colparam.VisibleIndex = 5;
            this.colparam.Width = 320;
            // 
            // colremark
            // 
            this.colremark.Caption = "备注";
            this.colremark.FieldName = "remark";
            this.colremark.Name = "colremark";
            this.colremark.Visible = true;
            this.colremark.VisibleIndex = 6;
            this.colremark.Width = 354;
            // 
            // pucMaster
            // 
            this.pucMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pucMaster.Location = new System.Drawing.Point(2, 472);
            this.pucMaster.MaximumSize = new System.Drawing.Size(0, 22);
            this.pucMaster.MinimumSize = new System.Drawing.Size(300, 22);
            this.pucMaster.Name = "pucMaster";
            this.pucMaster.orderBy = Insight.Base.BaseForm.Controls.OrderBy.POSITIVE;
            this.pucMaster.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("pucMaster.pageSizeItems")));
            this.pucMaster.Size = new System.Drawing.Size(1406, 22);
            this.pucMaster.TabIndex = 0;
            // 
            // pceSpace
            // 
            this.pceSpace.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pceSpace.Appearance.Options.UseBackColor = true;
            this.pceSpace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pceSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.pceSpace.Location = new System.Drawing.Point(0, 39);
            this.pceSpace.Name = "pceSpace";
            this.pceSpace.Size = new System.Drawing.Size(1410, 5);
            this.pceSpace.TabIndex = 0;
            // 
            // pceSearch
            // 
            this.pceSearch.Controls.Add(this.Search);
            this.pceSearch.Controls.Add(this.KeyInput);
            this.pceSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pceSearch.Location = new System.Drawing.Point(0, 0);
            this.pceSearch.Name = "pceSearch";
            this.pceSearch.Size = new System.Drawing.Size(1410, 39);
            this.pceSearch.TabIndex = 0;
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
            // grdDetail
            // 
            this.grdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetail.Location = new System.Drawing.Point(0, 0);
            this.grdDetail.MainView = this.gdvDetail;
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.Size = new System.Drawing.Size(1410, 274);
            this.grdDetail.TabIndex = 0;
            this.grdDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDetail});
            // 
            // gdvDetail
            // 
            this.gdvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid1,
            this.colappId,
            this.colappName,
            this.colcontent,
            this.colsign,
            this.colexpire,
            this.colremark1,
            this.colcreator,
            this.colcreatedTime});
            this.gdvDetail.GridControl = this.grdDetail;
            this.gdvDetail.Name = "gdvDetail";
            this.gdvDetail.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid1
            // 
            this.colid1.FieldName = "id";
            this.colid1.Name = "colid1";
            // 
            // colappId
            // 
            this.colappId.FieldName = "appId";
            this.colappId.Name = "colappId";
            // 
            // colappName
            // 
            this.colappName.Caption = "应用名称";
            this.colappName.FieldName = "appName";
            this.colappName.Name = "colappName";
            this.colappName.Visible = true;
            this.colappName.VisibleIndex = 0;
            this.colappName.Width = 200;
            // 
            // colcontent
            // 
            this.colcontent.Caption = "消息内容";
            this.colcontent.FieldName = "content";
            this.colcontent.Name = "colcontent";
            this.colcontent.Visible = true;
            this.colcontent.VisibleIndex = 1;
            this.colcontent.Width = 816;
            // 
            // colsign
            // 
            this.colsign.Caption = "签名";
            this.colsign.FieldName = "sign";
            this.colsign.Name = "colsign";
            this.colsign.Visible = true;
            this.colsign.VisibleIndex = 2;
            this.colsign.Width = 80;
            // 
            // colexpire
            // 
            this.colexpire.Caption = "有效时长";
            this.colexpire.FieldName = "expire";
            this.colexpire.Name = "colexpire";
            this.colexpire.Visible = true;
            this.colexpire.VisibleIndex = 3;
            this.colexpire.Width = 60;
            // 
            // colremark1
            // 
            this.colremark1.FieldName = "remark";
            this.colremark1.Name = "colremark1";
            this.colremark1.Width = 76;
            // 
            // colcreator
            // 
            this.colcreator.Caption = "创建人";
            this.colcreator.FieldName = "creator";
            this.colcreator.Name = "colcreator";
            this.colcreator.Visible = true;
            this.colcreator.VisibleIndex = 4;
            this.colcreator.Width = 80;
            // 
            // colcreatedTime
            // 
            this.colcreatedTime.Caption = "创建时间";
            this.colcreatedTime.FieldName = "createdTime";
            this.colcreatedTime.Name = "colcreatedTime";
            this.colcreatedTime.Visible = true;
            this.colcreatedTime.VisibleIndex = 5;
            this.colcreatedTime.Width = 120;
            // 
            // rleType
            // 
            this.rleType.AutoHeight = false;
            this.rleType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleType.Name = "rleType";
            // 
            // Manager
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(1420, 860);
            this.Name = "Manager";
            this.xtraScrollable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pceMaster)).EndInit();
            this.pceMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pceSearch)).EndInit();
            this.pceSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SplitContainerControl splMain;
        private PanelControl pceMaster;
        private PanelControl pceSpace;
        private PanelControl pceSearch;
        public Insight.Base.BaseForm.Controls.PageControl pucMaster;
        public GridControl grdMaster;
        public GridView gdvMaster;
        public GridControl grdDetail;
        public GridView gdvDetail;
        public SimpleButton Search;
        public ButtonEdit KeyInput;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coltitle;
        private DevExpress.XtraGrid.Columns.GridColumn coltag;
        private DevExpress.XtraGrid.Columns.GridColumn colparam;
        private DevExpress.XtraGrid.Columns.GridColumn colremark;
        private DevExpress.XtraGrid.Columns.GridColumn colid1;
        private DevExpress.XtraGrid.Columns.GridColumn colappId;
        private DevExpress.XtraGrid.Columns.GridColumn colappName;
        private DevExpress.XtraGrid.Columns.GridColumn colcontent;
        private DevExpress.XtraGrid.Columns.GridColumn colsign;
        private DevExpress.XtraGrid.Columns.GridColumn colexpire;
        private DevExpress.XtraGrid.Columns.GridColumn colremark1;
        private DevExpress.XtraGrid.Columns.GridColumn colcreator;
        private DevExpress.XtraGrid.Columns.GridColumn colcreatedTime;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleType;
    }
}