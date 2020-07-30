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
            this.grdSchedule = new DevExpress.XtraGrid.GridControl();
            this.gdvSchedule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinvalid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colmethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltaskTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreatedTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgNav = new DevExpress.Utils.ImageCollection(this.components);
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.pccSchedule = new Insight.Base.BaseForm.Controls.PageControl();
            this.panMain = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repType)).BeginInit();
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
            // grdSchedule
            // 
            this.grdSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSchedule.Location = new System.Drawing.Point(2, 2);
            this.grdSchedule.MainView = this.gdvSchedule;
            this.grdSchedule.Name = "grdSchedule";
            this.grdSchedule.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repType});
            this.grdSchedule.Size = new System.Drawing.Size(1066, 520);
            this.grdSchedule.TabIndex = 0;
            this.grdSchedule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvSchedule});
            // 
            // gdvSchedule
            // 
            this.gdvSchedule.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvSchedule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colinvalid,
            this.coltype,
            this.colmethod,
            this.coltaskTime,
            this.colcount,
            this.colcreatedTime});
            this.gdvSchedule.GridControl = this.grdSchedule;
            this.gdvSchedule.Name = "gdvSchedule";
            this.gdvSchedule.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colinvalid
            // 
            this.colinvalid.Caption = "终止";
            this.colinvalid.FieldName = "invalid";
            this.colinvalid.Name = "colinvalid";
            this.colinvalid.Visible = true;
            this.colinvalid.VisibleIndex = 0;
            this.colinvalid.Width = 40;
            // 
            // coltype
            // 
            this.coltype.Caption = "任务类型";
            this.coltype.ColumnEdit = this.repType;
            this.coltype.FieldName = "type";
            this.coltype.Name = "coltype";
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 1;
            this.coltype.Width = 80;
            // 
            // repType
            // 
            this.repType.AutoHeight = false;
            this.repType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repType.DisplayMember = "name";
            this.repType.Name = "repType";
            this.repType.ValueMember = "id";
            // 
            // colmethod
            // 
            this.colmethod.Caption = "调用方法";
            this.colmethod.FieldName = "method";
            this.colmethod.Name = "colmethod";
            this.colmethod.Visible = true;
            this.colmethod.VisibleIndex = 2;
            this.colmethod.Width = 554;
            // 
            // coltaskTime
            // 
            this.coltaskTime.Caption = "执行时间";
            this.coltaskTime.FieldName = "taskTime";
            this.coltaskTime.Name = "coltaskTime";
            this.coltaskTime.Visible = true;
            this.coltaskTime.VisibleIndex = 3;
            this.coltaskTime.Width = 140;
            // 
            // colcount
            // 
            this.colcount.Caption = "失败次数";
            this.colcount.FieldName = "count";
            this.colcount.Name = "colcount";
            this.colcount.Visible = true;
            this.colcount.VisibleIndex = 4;
            this.colcount.Width = 80;
            // 
            // colcreatedTime
            // 
            this.colcreatedTime.Caption = "创建时间";
            this.colcreatedTime.FieldName = "createdTime";
            this.colcreatedTime.Name = "colcreatedTime";
            this.colcreatedTime.Visible = true;
            this.colcreatedTime.VisibleIndex = 5;
            this.colcreatedTime.Width = 140;
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
            this.panSpace.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panSpace.Appearance.Options.UseBackColor = true;
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
            // pccSchedule
            // 
            this.pccSchedule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pccSchedule.Location = new System.Drawing.Point(2, 522);
            this.pccSchedule.MaximumSize = new System.Drawing.Size(0, 22);
            this.pccSchedule.MinimumSize = new System.Drawing.Size(320, 22);
            this.pccSchedule.Name = "pccSchedule";
            this.pccSchedule.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("pccSchedule.pageSizeItems")));
            this.pccSchedule.Size = new System.Drawing.Size(1066, 22);
            this.pccSchedule.TabIndex = 0;
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.grdSchedule);
            this.panMain.Controls.Add(this.pccSchedule);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repType)).EndInit();
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
        private ImageCollection imgNav;
        private PanelControl panSpace;
        private PanelControl panSearch;
        internal SimpleButton Search;
        internal ButtonEdit KeyInput;
        public Insight.Base.BaseForm.Controls.PageControl pccSchedule;
        private PanelControl panMain;
        public GridControl grdSchedule;
        public GridView gdvSchedule;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colinvalid;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraGrid.Columns.GridColumn colmethod;
        private DevExpress.XtraGrid.Columns.GridColumn coltaskTime;
        private DevExpress.XtraGrid.Columns.GridColumn colcount;
        private DevExpress.XtraGrid.Columns.GridColumn colcreatedTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repType;
    }
}