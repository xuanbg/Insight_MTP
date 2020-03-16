using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Insight.MTP.Client.Setting.Scenes.Views
{
    partial class BindDialog
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
            this.grdApp = new DevExpress.XtraGrid.GridControl();
            this.gdvApp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.grdApp);
            this.panel.Size = new System.Drawing.Size(510, 300);
            // 
            // cancel
            // 
            this.cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Appearance.Options.UseFont = true;
            this.cancel.Location = new System.Drawing.Point(340, 324);
            // 
            // confirm
            // 
            this.confirm.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Appearance.Options.UseFont = true;
            this.confirm.Location = new System.Drawing.Point(430, 324);
            // 
            // close
            // 
            this.close.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close.Appearance.Options.UseFont = true;
            this.close.Location = new System.Drawing.Point(430, 324);
            // 
            // grdApp
            // 
            this.grdApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdApp.Location = new System.Drawing.Point(2, 2);
            this.grdApp.MainView = this.gdvApp;
            this.grdApp.Name = "grdApp";
            this.grdApp.Size = new System.Drawing.Size(506, 296);
            this.grdApp.TabIndex = 0;
            this.grdApp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvApp});
            // 
            // gdvApp
            // 
            this.gdvApp.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gdvApp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colAlias});
            this.gdvApp.GridControl = this.grdApp;
            this.gdvApp.Name = "gdvApp";
            this.gdvApp.OptionsDetail.EnableMasterViewMode = false;
            this.gdvApp.OptionsFind.AlwaysVisible = true;
            this.gdvApp.OptionsFind.FindDelay = 100;
            this.gdvApp.OptionsFind.FindNullPrompt = "输入关键字进行查询…";
            this.gdvApp.OptionsFind.HighlightFindResults = false;
            this.gdvApp.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gdvApp.OptionsSelection.MultiSelect = true;
            this.gdvApp.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 240;
            // 
            // colAlias
            // 
            this.colAlias.Caption = "简称";
            this.colAlias.FieldName = "alias";
            this.colAlias.Name = "colAlias";
            this.colAlias.Visible = true;
            this.colAlias.VisibleIndex = 2;
            this.colAlias.Width = 160;
            // 
            // BindDialog
            // 
            this.ClientSize = new System.Drawing.Size(524, 362);
            this.Name = "BindDialog";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal GridControl grdApp;
        internal GridView gdvApp;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAlias;
    }
}
