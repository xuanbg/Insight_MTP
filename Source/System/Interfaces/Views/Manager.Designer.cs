using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Setting.Interfaces.Views
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
            this.grdInterface = new DevExpress.XtraGrid.GridControl();
            this.gdvInterface = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauthCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collimitGap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collimitCycle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collimitMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colneedToken = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisVerify = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisLogResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgNav = new DevExpress.Utils.ImageCollection();
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.pccInterface = new Insight.Base.BaseForm.Controls.PageControl();
            this.panMain = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInterface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInterface)).BeginInit();
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
            // grdInterface
            // 
            this.grdInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdInterface.Location = new System.Drawing.Point(2, 2);
            this.grdInterface.MainView = this.gdvInterface;
            this.grdInterface.Name = "grdInterface";
            this.grdInterface.Size = new System.Drawing.Size(1066, 520);
            this.grdInterface.TabIndex = 0;
            this.grdInterface.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvInterface});
            // 
            // gdvInterface
            // 
            this.gdvInterface.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvInterface.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colmethod,
            this.colurl,
            this.colauthCode,
            this.collimitGap,
            this.collimitCycle,
            this.collimitMax,
            this.colmessage,
            this.colremark,
            this.colneedToken,
            this.colisVerify,
            this.colisLimit,
            this.colisLogResult});
            this.gdvInterface.GridControl = this.grdInterface;
            this.gdvInterface.Name = "gdvInterface";
            this.gdvInterface.OptionsDetail.EnableMasterViewMode = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colname
            // 
            this.colname.Caption = "接口名称";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 300;
            // 
            // colmethod
            // 
            this.colmethod.Caption = "请求方法";
            this.colmethod.FieldName = "method";
            this.colmethod.Name = "colmethod";
            this.colmethod.Visible = true;
            this.colmethod.VisibleIndex = 1;
            this.colmethod.Width = 60;
            // 
            // colurl
            // 
            this.colurl.Caption = "URL";
            this.colurl.FieldName = "url";
            this.colurl.Name = "colurl";
            this.colurl.Visible = true;
            this.colurl.VisibleIndex = 2;
            this.colurl.Width = 394;
            // 
            // colauthCode
            // 
            this.colauthCode.Caption = "授权码";
            this.colauthCode.FieldName = "authCode";
            this.colauthCode.Name = "colauthCode";
            this.colauthCode.Visible = true;
            this.colauthCode.VisibleIndex = 3;
            this.colauthCode.Width = 160;
            // 
            // collimitGap
            // 
            this.collimitGap.FieldName = "limitGap";
            this.collimitGap.Name = "collimitGap";
            // 
            // collimitCycle
            // 
            this.collimitCycle.FieldName = "limitCycle";
            this.collimitCycle.Name = "collimitCycle";
            // 
            // collimitMax
            // 
            this.collimitMax.FieldName = "limitMax";
            this.collimitMax.Name = "collimitMax";
            // 
            // colmessage
            // 
            this.colmessage.FieldName = "message";
            this.colmessage.Name = "colmessage";
            // 
            // colremark
            // 
            this.colremark.FieldName = "remark";
            this.colremark.Name = "colremark";
            // 
            // colneedToken
            // 
            this.colneedToken.FieldName = "needToken";
            this.colneedToken.Name = "colneedToken";
            // 
            // colisVerify
            // 
            this.colisVerify.Caption = "验证令牌";
            this.colisVerify.FieldName = "verify";
            this.colisVerify.Name = "colisVerify";
            this.colisVerify.Visible = true;
            this.colisVerify.VisibleIndex = 4;
            this.colisVerify.Width = 60;
            // 
            // colisLimit
            // 
            this.colisLimit.Caption = "访问限流";
            this.colisLimit.FieldName = "limit";
            this.colisLimit.Name = "colisLimit";
            this.colisLimit.Visible = true;
            this.colisLimit.VisibleIndex = 5;
            this.colisLimit.Width = 60;
            // 
            // colisLogResult
            // 
            this.colisLogResult.FieldName = "isLogResult";
            this.colisLogResult.Name = "colisLogResult";
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
            // pccInterface
            // 
            this.pccInterface.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pccInterface.focusedRowHandle = -1;
            this.pccInterface.Location = new System.Drawing.Point(2, 522);
            this.pccInterface.MaximumSize = new System.Drawing.Size(0, 22);
            this.pccInterface.MinimumSize = new System.Drawing.Size(320, 22);
            this.pccInterface.Name = "pccInterface";
            this.pccInterface.page = 1;
            this.pccInterface.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("pccInterface.pageSizeItems")));
            this.pccInterface.Size = new System.Drawing.Size(1066, 22);
            this.pccInterface.TabIndex = 0;
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.grdInterface);
            this.panMain.Controls.Add(this.pccInterface);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdInterface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInterface)).EndInit();
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
        private PanelControl panSpace;
        private PanelControl panSearch;
        internal SimpleButton Search;
        internal ButtonEdit KeyInput;
        public Insight.Base.BaseForm.Controls.PageControl pccInterface;
        private PanelControl panMain;
        public GridControl grdInterface;
        public GridView gdvInterface;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colmethod;
        private DevExpress.XtraGrid.Columns.GridColumn colurl;
        private DevExpress.XtraGrid.Columns.GridColumn colauthCode;
        private DevExpress.XtraGrid.Columns.GridColumn collimitGap;
        private DevExpress.XtraGrid.Columns.GridColumn collimitCycle;
        private DevExpress.XtraGrid.Columns.GridColumn collimitMax;
        private DevExpress.XtraGrid.Columns.GridColumn colmessage;
        private DevExpress.XtraGrid.Columns.GridColumn colremark;
        private DevExpress.XtraGrid.Columns.GridColumn colneedToken;
        private DevExpress.XtraGrid.Columns.GridColumn colisVerify;
        private DevExpress.XtraGrid.Columns.GridColumn colisLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colisLogResult;
    }
}