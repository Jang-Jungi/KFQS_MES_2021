namespace KFQS_Form
{
    partial class AP_ProductPlan_N
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            this.lblPlantCode = new DC00_Component.SLabel();
            this.cboPlantCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.txtItemName = new DC00_Component.STextBox(this.components);
            this.txtItemCode = new DC00_Component.SBtnTextEditor();
            this.lblCustName_H = new DC00_Component.SLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.dtpEnd = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.dtpStart = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.grid1 = new DC00_Component.Grid(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).BeginInit();
            this.gbxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxBody)).BeginInit();
            this.gbxBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxHeader
            // 
            this.gbxHeader.ContentPadding.Bottom = 2;
            this.gbxHeader.ContentPadding.Left = 2;
            this.gbxHeader.ContentPadding.Right = 2;
            this.gbxHeader.ContentPadding.Top = 4;
            this.gbxHeader.Controls.Add(this.ultraLabel5);
            this.gbxHeader.Controls.Add(this.dtpEnd);
            this.gbxHeader.Controls.Add(this.ultraLabel2);
            this.gbxHeader.Controls.Add(this.dtpStart);
            this.gbxHeader.Controls.Add(this.txtItemName);
            this.gbxHeader.Controls.Add(this.txtItemCode);
            this.gbxHeader.Controls.Add(this.lblCustName_H);
            this.gbxHeader.Controls.Add(this.cboPlantCode);
            this.gbxHeader.Controls.Add(this.lblPlantCode);
            this.gbxHeader.Location = new System.Drawing.Point(3, 3);
            this.gbxHeader.Size = new System.Drawing.Size(1292, 80);
            // 
            // gbxBody
            // 
            this.gbxBody.ContentPadding.Bottom = 4;
            this.gbxBody.ContentPadding.Left = 4;
            this.gbxBody.ContentPadding.Right = 4;
            this.gbxBody.ContentPadding.Top = 6;
            this.gbxBody.Controls.Add(this.grid1);
            this.gbxBody.Location = new System.Drawing.Point(3, 83);
            this.gbxBody.Size = new System.Drawing.Size(1292, 692);
            // 
            // lblPlantCode
            // 
            appearance1.FontData.BoldAsString = "False";
            appearance1.FontData.UnderlineAsString = "False";
            appearance1.ForeColor = System.Drawing.Color.Black;
            appearance1.TextHAlignAsString = "Right";
            appearance1.TextVAlignAsString = "Middle";
            this.lblPlantCode.Appearance = appearance1;
            this.lblPlantCode.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.lblPlantCode.DbField = null;
            this.lblPlantCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPlantCode.Location = new System.Drawing.Point(36, 30);
            this.lblPlantCode.Name = "lblPlantCode";
            this.lblPlantCode.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
            this.lblPlantCode.Size = new System.Drawing.Size(83, 23);
            this.lblPlantCode.TabIndex = 181;
            this.lblPlantCode.Text = "공장";
            // 
            // cboPlantCode
            // 
            this.cboPlantCode.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cboPlantCode.Location = new System.Drawing.Point(125, 29);
            this.cboPlantCode.Name = "cboPlantCode";
            this.cboPlantCode.Size = new System.Drawing.Size(145, 32);
            this.cboPlantCode.TabIndex = 0;
            // 
            // txtItemName
            // 
            appearance18.FontData.BoldAsString = "False";
            appearance18.FontData.UnderlineAsString = "False";
            appearance18.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.Appearance = appearance18;
            this.txtItemName.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.Location = new System.Drawing.Point(515, 27);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.RequireFlag = DC00_Component.STextBox.RequireFlagEnum.NO;
            this.txtItemName.RequirePop = DC00_Component.STextBox.RequireFlagEnum.NO;
            this.txtItemName.Size = new System.Drawing.Size(252, 32);
            this.txtItemName.TabIndex = 218;
            // 
            // txtItemCode
            // 
            appearance3.FontData.BoldAsString = "False";
            appearance3.FontData.Name = "맑은 고딕";
            appearance3.FontData.SizeInPoints = 10F;
            appearance3.FontData.UnderlineAsString = "False";
            appearance3.ForeColor = System.Drawing.Color.Black;
            this.txtItemCode.Appearance = appearance3;
            this.txtItemCode.btnImgType = DC00_Component.SBtnTextEditor.ButtonImgTypeEnum.Type1;
            this.txtItemCode.btnWidth = 26;
            this.txtItemCode.Location = new System.Drawing.Point(365, 27);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.RequireFlag = DC00_Component.SBtnTextEditor.RequireFlagEnum.NO;
            this.txtItemCode.RequirePop = DC00_Component.SBtnTextEditor.RequireFlagEnum.NO;
            this.txtItemCode.Size = new System.Drawing.Size(145, 32);
            this.txtItemCode.TabIndex = 217;
            // 
            // lblCustName_H
            // 
            appearance2.FontData.BoldAsString = "False";
            appearance2.FontData.UnderlineAsString = "False";
            appearance2.ForeColor = System.Drawing.Color.Black;
            appearance2.TextHAlignAsString = "Right";
            appearance2.TextVAlignAsString = "Middle";
            this.lblCustName_H.Appearance = appearance2;
            this.lblCustName_H.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.lblCustName_H.DbField = "cboUseFlag";
            this.lblCustName_H.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCustName_H.Location = new System.Drawing.Point(276, 31);
            this.lblCustName_H.Name = "lblCustName_H";
            this.lblCustName_H.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
            this.lblCustName_H.Size = new System.Drawing.Size(83, 23);
            this.lblCustName_H.TabIndex = 216;
            this.lblCustName_H.Text = "품목";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ultraLabel5.Location = new System.Drawing.Point(794, 34);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(73, 23);
            this.ultraLabel5.TabIndex = 222;
            this.ultraLabel5.Text = "계획 일자";
            // 
            // dtpEnd
            // 
            this.dtpEnd.DateButtons.Add(dateButton1);
            this.dtpEnd.Location = new System.Drawing.Point(1055, 27);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.NonAutoSizeHeight = 26;
            this.dtpEnd.Size = new System.Drawing.Size(148, 32);
            this.dtpEnd.TabIndex = 220;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(1027, 29);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(22, 23);
            this.ultraLabel2.TabIndex = 221;
            this.ultraLabel2.Text = "~";
            // 
            // dtpStart
            // 
            this.dtpStart.DateButtons.Add(dateButton2);
            this.dtpStart.Location = new System.Drawing.Point(873, 27);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.NonAutoSizeHeight = 26;
            this.dtpStart.Size = new System.Drawing.Size(148, 32);
            this.dtpStart.TabIndex = 219;
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
            appearance28.BackColor = System.Drawing.SystemColors.Window;
            appearance28.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid1.DisplayLayout.Appearance = appearance28;
            this.grid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.grid1.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty;
            appearance29.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance29.BorderColor = System.Drawing.SystemColors.Window;
            this.grid1.DisplayLayout.GroupByBox.Appearance = appearance29;
            appearance30.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance30;
            this.grid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.grid1.DisplayLayout.GroupByBox.Hidden = true;
            appearance31.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance31.BackColor2 = System.Drawing.SystemColors.Control;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance31.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grid1.DisplayLayout.GroupByBox.PromptAppearance = appearance31;
            this.grid1.DisplayLayout.MaxColScrollRegions = 1;
            this.grid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance32.BackColor = System.Drawing.SystemColors.Window;
            appearance32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grid1.DisplayLayout.Override.ActiveCellAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.Highlight;
            appearance33.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grid1.DisplayLayout.Override.ActiveRowAppearance = appearance33;
            this.grid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.grid1.DisplayLayout.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)((((((((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.CopyWithHeaders) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Delete) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Undo) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Redo) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Reserved)));
            this.grid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.grid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance34.BackColor = System.Drawing.SystemColors.Window;
            this.grid1.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance35.BorderColor = System.Drawing.Color.Silver;
            appearance35.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.grid1.DisplayLayout.Override.CellAppearance = appearance35;
            this.grid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.grid1.DisplayLayout.Override.CellPadding = 0;
            appearance36.BackColor = System.Drawing.SystemColors.Control;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance36.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance36.BorderColor = System.Drawing.SystemColors.Window;
            this.grid1.DisplayLayout.Override.GroupByRowAppearance = appearance36;
            this.grid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.grid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance37.BackColor = System.Drawing.SystemColors.Window;
            appearance37.BorderColor = System.Drawing.Color.Silver;
            this.grid1.DisplayLayout.Override.RowAppearance = appearance37;
            this.grid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance38.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance38;
            this.grid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grid1.DisplayLayout.SelectionOverlayBorderThickness = 2;
            this.grid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.EnterNextRowEnable = true;
            this.grid1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grid1.Location = new System.Drawing.Point(6, 6);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(1280, 680);
            this.grid1.TabIndex = 8;
            this.grid1.TabStop = false;
            this.grid1.Text = "grid1";
            this.grid1.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
            this.grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
            this.grid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
            this.grid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // AP_ProductPlan_N
            // 
            this.ClientSize = new System.Drawing.Size(1298, 778);
            this.Name = "AP_ProductPlan_N";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "생산 계획 관리";
            this.Load += new System.EventHandler(this.AP_ProductPlan_N_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).EndInit();
            this.gbxHeader.ResumeLayout(false);
            this.gbxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxBody)).EndInit();
            this.gbxBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DC00_Component.SLabel lblPlantCode;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCode;
        private DC00_Component.STextBox txtItemName;
        private DC00_Component.SBtnTextEditor txtItemCode;
        private DC00_Component.SLabel lblCustName_H;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtpEnd;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtpStart;
        private DC00_Component.Grid grid1;
    }
}
