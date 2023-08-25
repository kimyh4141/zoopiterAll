
namespace AMIS3.ZZ.AN.MU004
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.aPanelControl11 = new AMIS3.UIFramework.UI.Controls.APanelControl();
            this.aSimpleButton1 = new AMIS3.UIFramework.UI.Controls.ASimpleButton();
            this.aLabelControl7 = new AMIS3.UIFramework.UI.Controls.ALabelControl();
            this.nursCommonDtlCd = new AMIS3.UIFramework.UI.Controls.ATextEdit();
            this.aPanelControl12 = new AMIS3.UIFramework.UI.Controls.APanelControl();
            this.aSimpleButton2 = new AMIS3.UIFramework.UI.Controls.ASimpleButton();
            this.aPanelControl1 = new AMIS3.UIFramework.UI.Controls.APanelControl();
            this.gridRsamStat = new AMIS3.UIFramework.UI.Controls.AGridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aPanelControl11)).BeginInit();
            this.aPanelControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nursCommonDtlCd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPanelControl12)).BeginInit();
            this.aPanelControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPanelControl1)).BeginInit();
            this.aPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRsamStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanelControl11
            // 
            this.aPanelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.aPanelControl11.Controls.Add(this.aSimpleButton1);
            this.aPanelControl11.Controls.Add(this.aLabelControl7);
            this.aPanelControl11.Controls.Add(this.nursCommonDtlCd);
            this.aPanelControl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanelControl11.Location = new System.Drawing.Point(0, 0);
            this.aPanelControl11.Name = "aPanelControl11";
            this.aPanelControl11.Size = new System.Drawing.Size(559, 67);
            this.aPanelControl11.TabIndex = 20;
            // 
            // aSimpleButton1
            // 
            this.aSimpleButton1.AButtonType = AMIS3.UIFramework.DataModel.AmisButtonType.Import;
            this.aSimpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aSimpleButton1.APermission = "R";
            this.aSimpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(147)))));
            this.aSimpleButton1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(147)))));
            this.aSimpleButton1.Appearance.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSimpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.aSimpleButton1.Appearance.Options.UseBackColor = true;
            this.aSimpleButton1.Appearance.Options.UseBorderColor = true;
            this.aSimpleButton1.Appearance.Options.UseFont = true;
            this.aSimpleButton1.Appearance.Options.UseForeColor = true;
            this.aSimpleButton1.Appearance.Options.UseImage = true;
            this.aSimpleButton1.Appearance.Options.UseTextOptions = true;
            this.aSimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.aSimpleButton1.Location = new System.Drawing.Point(435, 29);
            this.aSimpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.aSimpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.aSimpleButton1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.aSimpleButton1.MultiLanguageResourceID = null;
            this.aSimpleButton1.Name = "aSimpleButton1";
            this.aSimpleButton1.Size = new System.Drawing.Size(70, 23);
            this.aSimpleButton1.TabIndex = 15;
            this.aSimpleButton1.Text = "조회";
            this.aSimpleButton1.Click += new System.EventHandler(this.btnNursCommonDtlCdSearch_Click);
            // 
            // aLabelControl7
            // 
            this.aLabelControl7.Appearance.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabelControl7.Appearance.Options.UseFont = true;
            this.aLabelControl7.Appearance.Options.UseTextOptions = true;
            this.aLabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.aLabelControl7.FieldValue = "간호코드";
            this.aLabelControl7.Location = new System.Drawing.Point(54, 33);
            this.aLabelControl7.MultiLanguageResourceID = null;
            this.aLabelControl7.Name = "aLabelControl7";
            this.aLabelControl7.Size = new System.Drawing.Size(48, 15);
            this.aLabelControl7.TabIndex = 14;
            this.aLabelControl7.Text = "간호코드";
            // 
            // nursCommonDtlCd
            // 
            this.nursCommonDtlCd.EnterMoveNextControl = true;
            this.nursCommonDtlCd.FieldName = null;
            this.nursCommonDtlCd.Location = new System.Drawing.Point(119, 30);
            this.nursCommonDtlCd.Name = "nursCommonDtlCd";
            this.nursCommonDtlCd.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.nursCommonDtlCd.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nursCommonDtlCd.Properties.Appearance.Options.UseBorderColor = true;
            this.nursCommonDtlCd.Properties.Appearance.Options.UseFont = true;
            this.nursCommonDtlCd.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(177)))));
            this.nursCommonDtlCd.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.nursCommonDtlCd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.nursCommonDtlCd.Size = new System.Drawing.Size(100, 22);
            this.nursCommonDtlCd.TabIndex = 3;
            this.nursCommonDtlCd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nursCommonDtlCd_KeyPress);
            // 
            // aPanelControl12
            // 
            this.aPanelControl12.Controls.Add(this.aSimpleButton2);
            this.aPanelControl12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanelControl12.Location = new System.Drawing.Point(0, 245);
            this.aPanelControl12.Name = "aPanelControl12";
            this.aPanelControl12.Size = new System.Drawing.Size(559, 55);
            this.aPanelControl12.TabIndex = 22;
            // 
            // aSimpleButton2
            // 
            this.aSimpleButton2.AButtonType = AMIS3.UIFramework.DataModel.AmisButtonType.Import;
            this.aSimpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aSimpleButton2.APermission = "R";
            this.aSimpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(147)))));
            this.aSimpleButton2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(131)))), ((int)(((byte)(147)))));
            this.aSimpleButton2.Appearance.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSimpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.aSimpleButton2.Appearance.Options.UseBackColor = true;
            this.aSimpleButton2.Appearance.Options.UseBorderColor = true;
            this.aSimpleButton2.Appearance.Options.UseFont = true;
            this.aSimpleButton2.Appearance.Options.UseForeColor = true;
            this.aSimpleButton2.Appearance.Options.UseImage = true;
            this.aSimpleButton2.Appearance.Options.UseTextOptions = true;
            this.aSimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.aSimpleButton2.Location = new System.Drawing.Point(204, 15);
            this.aSimpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.aSimpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.aSimpleButton2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.aSimpleButton2.MultiLanguageResourceID = null;
            this.aSimpleButton2.Name = "aSimpleButton2";
            this.aSimpleButton2.Size = new System.Drawing.Size(70, 23);
            this.aSimpleButton2.TabIndex = 16;
            this.aSimpleButton2.Text = "확인";
            // 
            // aPanelControl1
            // 
            this.aPanelControl1.Controls.Add(this.gridRsamStat);
            this.aPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPanelControl1.Location = new System.Drawing.Point(0, 67);
            this.aPanelControl1.Name = "aPanelControl1";
            this.aPanelControl1.Size = new System.Drawing.Size(559, 178);
            this.aPanelControl1.TabIndex = 16;
            // 
            // gridRsamStat
            // 
            this.gridRsamStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRsamStat.Location = new System.Drawing.Point(2, 2);
            this.gridRsamStat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridRsamStat.MainView = this.gridView3;
            this.gridRsamStat.Name = "gridRsamStat";
            this.gridRsamStat.Size = new System.Drawing.Size(555, 174);
            this.gridRsamStat.TabIndex = 22;
            this.gridRsamStat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn12});
            this.gridView3.GridControl = this.gridRsamStat;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView3.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsView.ShowIndicator = false;
            this.gridView3.RowHeight = 20;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "간호공통세부코드";
            this.gridColumn1.FieldName = "nursCommonDtlCd";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 130;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "간호공통세부코드명";
            this.gridColumn2.FieldName = "nursCommonDtlCdNm";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 150;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "간호공통그룹코드";
            this.gridColumn3.FieldName = "nursCommonGrpCd";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 130;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "간호공통관리코드";
            this.gridColumn12.FieldName = "nursCommonManageCd";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            this.gridColumn12.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aPanelControl1);
            this.Controls.Add(this.aPanelControl12);
            this.Controls.Add(this.aPanelControl11);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(90, 68);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(559, 300);
            ((System.ComponentModel.ISupportInitialize)(this.aPanelControl11)).EndInit();
            this.aPanelControl11.ResumeLayout(false);
            this.aPanelControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nursCommonDtlCd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPanelControl12)).EndInit();
            this.aPanelControl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aPanelControl1)).EndInit();
            this.aPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRsamStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIFramework.UI.Controls.APanelControl aPanelControl11;
        private UIFramework.UI.Controls.ASimpleButton aSimpleButton1;
        private UIFramework.UI.Controls.ALabelControl aLabelControl7;
        private UIFramework.UI.Controls.ATextEdit nursCommonDtlCd;
        private UIFramework.UI.Controls.APanelControl aPanelControl12;
        private UIFramework.UI.Controls.ASimpleButton aSimpleButton2;
        private UIFramework.UI.Controls.APanelControl aPanelControl1;
        private UIFramework.UI.Controls.AGridControl gridRsamStat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}