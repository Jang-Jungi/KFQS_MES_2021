
namespace KFQS_Form
{
    partial class PP_STockHALBrec
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton4 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            this.cboPlantCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.cboItemCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.grid1 = new DC00_Component.Grid(this.components);
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.txtLOTNo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.dtpEnd = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.dtpStart = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            ((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).BeginInit();
            this.gbxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxBody)).BeginInit();
            this.gbxBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOTNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxHeader
            // 
            this.gbxHeader.ContentPadding.Bottom = 2;
            this.gbxHeader.ContentPadding.Left = 2;
            this.gbxHeader.ContentPadding.Right = 2;
            this.gbxHeader.ContentPadding.Top = 4;
            this.gbxHeader.Controls.Add(this.ultraLabel2);
            this.gbxHeader.Controls.Add(this.ultraLabel3);
            this.gbxHeader.Controls.Add(this.dtpEnd);
            this.gbxHeader.Controls.Add(this.dtpStart);
            this.gbxHeader.Controls.Add(this.ultraLabel5);
            this.gbxHeader.Controls.Add(this.txtLOTNo);
            this.gbxHeader.Controls.Add(this.ultraLabel4);
            this.gbxHeader.Controls.Add(this.cboItemCode);
            this.gbxHeader.Controls.Add(this.ultraLabel1);
            this.gbxHeader.Controls.Add(this.cboPlantCode);
            this.gbxHeader.Size = new System.Drawing.Size(1136, 109);
            // 
            // gbxBody
            // 
            this.gbxBody.ContentPadding.Bottom = 4;
            this.gbxBody.ContentPadding.Left = 4;
            this.gbxBody.ContentPadding.Right = 4;
            this.gbxBody.ContentPadding.Top = 6;
            this.gbxBody.Controls.Add(this.grid1);
            this.gbxBody.Location = new System.Drawing.Point(0, 109);
            this.gbxBody.Size = new System.Drawing.Size(1136, 716);
            // 
            // cboPlantCode
            // 
            this.cboPlantCode.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPlantCode.Location = new System.Drawing.Point(105, 31);
            this.cboPlantCode.Name = "cboPlantCode";
            this.cboPlantCode.Size = new System.Drawing.Size(128, 28);
            this.cboPlantCode.TabIndex = 0;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(45, 35);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(54, 27);
            this.ultraLabel1.TabIndex = 1;
            this.ultraLabel1.Text = "공장";
            // 
            // cboItemCode
            // 
            this.cboItemCode.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemCode.Location = new System.Drawing.Point(302, 31);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Size = new System.Drawing.Size(138, 28);
            this.cboItemCode.TabIndex = 6;
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel4.Location = new System.Drawing.Point(248, 35);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(53, 27);
            this.ultraLabel4.TabIndex = 7;
            this.ultraLabel4.Text = "품목";
            // 
            // grid1
            // 
            this.grid1.AutoResizeColumn = true;
            this.grid1.AutoUserColumn = true;
            this.grid1.ContextMenuCopyEnabled = true;
            this.grid1.ContextMenuDeleteEnabled = true;
            this.grid1.ContextMenuExcelEnabled = true;
            this.grid1.ContextMenuInsertEnabled = true;
            this.grid1.ContextMenuPasteEnabled = true;
            this.grid1.DeleteButtonEnable = true;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid1.DisplayLayout.Appearance = appearance1;
            this.grid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.grid1.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.grid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.grid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grid1.DisplayLayout.GroupByBox.Hidden = true;
            appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance3.BackColor2 = System.Drawing.SystemColors.Control;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grid1.DisplayLayout.GroupByBox.PromptAppearance = appearance3;
            this.grid1.DisplayLayout.MaxColScrollRegions = 1;
            this.grid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            appearance7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grid1.DisplayLayout.Override.ActiveCellAppearance = appearance7;
            appearance10.BackColor = System.Drawing.SystemColors.Highlight;
            appearance10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grid1.DisplayLayout.Override.ActiveRowAppearance = appearance10;
            this.grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.grid1.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)(((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste)));
            this.grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.grid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.grid1.DisplayLayout.Override.CardAreaAppearance = appearance12;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.grid1.DisplayLayout.Override.CellAppearance = appearance8;
            this.grid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.grid1.DisplayLayout.Override.CellPadding = 0;
            appearance6.BackColor = System.Drawing.SystemColors.Control;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance6.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance6.BorderColor = System.Drawing.SystemColors.Window;
            this.grid1.DisplayLayout.Override.GroupByRowAppearance = appearance6;
            appearance5.TextHAlignAsString = "Left";
            this.grid1.DisplayLayout.Override.HeaderAppearance = appearance5;
            this.grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.grid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.grid1.DisplayLayout.Override.RowAppearance = appearance11;
            this.grid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance9;
            this.grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grid1.DisplayLayout.SelectionOverlayBorderThickness = 2;
            this.grid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.EnterNextRowEnable = true;
            this.grid1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grid1.Location = new System.Drawing.Point(6, 6);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(1124, 704);
            this.grid1.TabIndex = 0;
            this.grid1.Text = "출고 창고";
            this.grid1.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
            this.grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
            this.grid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
            this.grid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel5.Location = new System.Drawing.Point(455, 35);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(83, 27);
            this.ultraLabel5.TabIndex = 17;
            this.ultraLabel5.Text = "LOT NO.";
            // 
            // txtLOTNo
            // 
            this.txtLOTNo.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLOTNo.Location = new System.Drawing.Point(544, 30);
            this.txtLOTNo.Name = "txtLOTNo";
            this.txtLOTNo.Size = new System.Drawing.Size(131, 28);
            this.txtLOTNo.TabIndex = 16;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(671, 37);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(109, 23);
            this.ultraLabel2.TabIndex = 21;
            this.ultraLabel2.Text = "입/출 일자";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(939, 34);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(24, 24);
            this.ultraLabel3.TabIndex = 20;
            this.ultraLabel3.Text = "~";
            // 
            // dtpEnd
            // 
            this.dtpEnd.DateButtons.Add(dateButton3);
            this.dtpEnd.Location = new System.Drawing.Point(969, 35);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.NonAutoSizeHeight = 32;
            this.dtpEnd.Size = new System.Drawing.Size(146, 32);
            this.dtpEnd.TabIndex = 19;
            // 
            // dtpStart
            // 
            this.dtpStart.DateButtons.Add(dateButton4);
            this.dtpStart.Location = new System.Drawing.Point(782, 33);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.NonAutoSizeHeight = 32;
            this.dtpStart.Size = new System.Drawing.Size(151, 32);
            this.dtpStart.TabIndex = 18;
            this.dtpStart.Value = "2021-06-01";
            // 
            // PP_STockHALBrec
            // 
            this.ClientSize = new System.Drawing.Size(1136, 825);
            this.Name = "PP_STockHALBrec";
            this.Text = "재공 재고 입출고 이력조회";
            this.Load += new System.EventHandler(this.PP_STockHALBrec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).EndInit();
            this.gbxHeader.ResumeLayout(false);
            this.gbxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxBody)).EndInit();
            this.gbxBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLOTNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboItemCode;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCode;
        private DC00_Component.Grid grid1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtLOTNo;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtpEnd;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtpStart;
    }
}
