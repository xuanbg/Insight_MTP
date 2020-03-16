﻿using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Setting.Scenes.Views
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
            this.grdScene = new DevExpress.XtraGrid.GridControl();
            this.gdvScene = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ppcScene = new Insight.Utils.Controls.PageControl();
            this.panSpace = new DevExpress.XtraEditors.PanelControl();
            this.panSearch = new DevExpress.XtraEditors.PanelControl();
            this.Search = new DevExpress.XtraEditors.SimpleButton();
            this.KeyInput = new DevExpress.XtraEditors.ButtonEdit();
            this.grpUser = new DevExpress.XtraEditors.GroupControl();
            this.grdTemplate = new DevExpress.XtraGrid.GridControl();
            this.gdvTemplate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ppcTemplate = new Insight.Utils.Controls.PageControl();
            this.xtraScrollable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palTenant)).BeginInit();
            this.palTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).BeginInit();
            this.grpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTemplate)).BeginInit();
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
            this.splMain.Panel2.Controls.Add(this.grpUser);
            this.splMain.Panel2.MinSize = 200;
            this.splMain.ScrollBarSmallChange = 1;
            this.splMain.Size = new System.Drawing.Size(1070, 590);
            this.splMain.SplitterPosition = 320;
            this.splMain.TabIndex = 0;
            // 
            // palTenant
            // 
            this.palTenant.Controls.Add(this.grdScene);
            this.palTenant.Controls.Add(this.ppcScene);
            this.palTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palTenant.Location = new System.Drawing.Point(0, 44);
            this.palTenant.Name = "palTenant";
            this.palTenant.Size = new System.Drawing.Size(1070, 276);
            this.palTenant.TabIndex = 0;
            // 
            // grdScene
            // 
            this.grdScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdScene.Location = new System.Drawing.Point(2, 2);
            this.grdScene.MainView = this.gdvScene;
            this.grdScene.Name = "grdScene";
            this.grdScene.Size = new System.Drawing.Size(1066, 250);
            this.grdScene.TabIndex = 0;
            this.grdScene.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvScene});
            // 
            // gdvScene
            // 
            this.gdvScene.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvScene.GridControl = this.grdScene;
            this.gdvScene.Name = "gdvScene";
            this.gdvScene.OptionsDetail.EnableMasterViewMode = false;
            // 
            // ppcScene
            // 
            this.ppcScene.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppcScene.focusedRowHandle = 0;
            this.ppcScene.Location = new System.Drawing.Point(2, 252);
            this.ppcScene.MaximumSize = new System.Drawing.Size(0, 22);
            this.ppcScene.MinimumSize = new System.Drawing.Size(300, 22);
            this.ppcScene.Name = "ppcScene";
            this.ppcScene.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("ppcScene.pageSizeItems")));
            this.ppcScene.Size = new System.Drawing.Size(1066, 22);
            this.ppcScene.TabIndex = 0;
            // 
            // panSpace
            // 
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
            // grpUser
            // 
            this.grpUser.Controls.Add(this.grdTemplate);
            this.grpUser.Controls.Add(this.ppcTemplate);
            this.grpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUser.Location = new System.Drawing.Point(0, 0);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(1070, 265);
            this.grpUser.TabIndex = 0;
            this.grpUser.Text = "关联模板";
            // 
            // grdTemplate
            // 
            this.grdTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTemplate.Location = new System.Drawing.Point(2, 21);
            this.grdTemplate.MainView = this.gdvTemplate;
            this.grdTemplate.Name = "grdTemplate";
            this.grdTemplate.Size = new System.Drawing.Size(1066, 220);
            this.grdTemplate.TabIndex = 0;
            this.grdTemplate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvTemplate});
            // 
            // gdvTemplate
            // 
            this.gdvTemplate.GridControl = this.grdTemplate;
            this.gdvTemplate.Name = "gdvTemplate";
            this.gdvTemplate.OptionsDetail.EnableMasterViewMode = false;
            // 
            // ppcTemplate
            // 
            this.ppcTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppcTemplate.focusedRowHandle = 0;
            this.ppcTemplate.Location = new System.Drawing.Point(2, 241);
            this.ppcTemplate.MaximumSize = new System.Drawing.Size(0, 22);
            this.ppcTemplate.MinimumSize = new System.Drawing.Size(320, 22);
            this.ppcTemplate.Name = "ppcTemplate";
            this.ppcTemplate.pageSizeItems = ((System.Collections.ObjectModel.Collection<string>)(resources.GetObject("ppcTemplate.pageSizeItems")));
            this.ppcTemplate.Size = new System.Drawing.Size(1066, 22);
            this.ppcTemplate.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.grdScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearch)).EndInit();
            this.panSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpUser)).EndInit();
            this.grpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private GroupControl grpUser;
        private SplitContainerControl splMain;
        private PanelControl palTenant;
        private PanelControl panSpace;
        private PanelControl panSearch;
        internal SimpleButton Search;
        internal ButtonEdit KeyInput;
        public Utils.Controls.PageControl ppcTemplate;
        public Utils.Controls.PageControl ppcScene;
        public GridControl grdScene;
        public GridView gdvScene;
        public GridControl grdTemplate;
        public GridView gdvTemplate;
    }
}