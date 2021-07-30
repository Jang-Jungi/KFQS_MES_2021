namespace KFQS_Form
{
    partial class AP_ProductOrder
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
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            this.lblPlantCode = new DC00_Component.SLabel();
            this.cboPlantCode = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.txtItemName = new DC00_Component.STextBox(this.components);
            this.txtItemCode = new DC00_Component.SBtnTextEditor();
            this.lblCustName_H = new DC00_Component.SLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.grid1 = new DC00_Component.Grid(this.components);
            this.txtPlanNo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblWorkerName_H = new DC00_Component.SLabel();
            this.txtWorkcenterName = new DC00_Component.STextBox(this.components);
            this.txtWorkcenterCode = new DC00_Component.SBtnTextEditor();
            this.sLabel1 = new DC00_Component.SLabel();
            this.txtOrderNo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.sLabel2 = new DC00_Component.SLabel();
            this.cboOrderFixFlag = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.sLabel3 = new DC00_Component.SLabel();
            this.sLabel4 = new DC00_Component.SLabel();
            this.dtEnddate = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.dtStartDate = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            ((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).BeginInit();
            this.gbxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxBody)).BeginInit();
            this.gbxBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkcenterName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkcenterCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrderFixFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnddate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxHeader
            // 
            this.gbxHeader.ContentPadding.Bottom = 2;
            this.gbxHeader.ContentPadding.Left = 2;
            this.gbxHeader.ContentPadding.Right = 2;
            this.gbxHeader.ContentPadding.Top = 4;
            this.gbxHeader.Controls.Add(this.sLabel3);
            this.gbxHeader.Controls.Add(this.sLabel4);
            this.gbxHeader.Controls.Add(this.dtEnddate);
            this.gbxHeader.Controls.Add(this.dtStartDate);
            this.gbxHeader.Controls.Add(this.cboOrderFixFlag);
            this.gbxHeader.Controls.Add(this.txtOrderNo);
            this.gbxHeader.Controls.Add(this.txtWorkcenterName);
            this.gbxHeader.Controls.Add(this.txtWorkcenterCode);
            this.gbxHeader.Controls.Add(this.sLabel1);
            this.gbxHeader.Controls.Add(this.txtPlanNo);
            this.gbxHeader.Controls.Add(this.lblWorkerName_H);
            this.gbxHeader.Controls.Add(this.ultraLabel5);
            this.gbxHeader.Controls.Add(this.txtItemName);
            this.gbxHeader.Controls.Add(this.txtItemCode);
            this.gbxHeader.Controls.Add(this.lblCustName_H);
            this.gbxHeader.Controls.Add(this.cboPlantCode);
            this.gbxHeader.Controls.Add(this.lblPlantCode);
            this.gbxHeader.Controls.Add(this.sLabel2);
            this.gbxHeader.Location = new System.Drawing.Point(3, 3);
            this.gbxHeader.Size = new System.Drawing.Size(1292, 142);
            // 
            // gbxBody
            // 
            this.gbxBody.ContentPadding.Bottom = 4;
            this.gbxBody.ContentPadding.Left = 4;
            this.gbxBody.ContentPadding.Right = 4;
            this.gbxBody.ContentPadding.Top = 6;
            this.gbxBody.Controls.Add(this.grid1);
            this.gbxBody.Location = new System.Drawing.Point(3, 145);
            this.gbxBody.Size = new System.Drawing.Size(1292, 630);
            // 
            // lblPlantCode
            // 
            appearance8.FontData.BoldAsString = "False";
            appearance8.FontData.UnderlineAsString = "False";
            appearance8.ForeColor = System.Drawing.Color.Black;
            appearance8.TextHAlignAsString = "Right";
            appearance8.TextVAlignAsString = "Middle";
            this.lblPlantCode.Appearance = appearance8;
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
            appearance5.FontData.BoldAsString = "False";
            appearance5.FontData.UnderlineAsString = "False";
            appearance5.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.Appearance = appearance5;
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
            appearance6.FontData.BoldAsString = "False";
            appearance6.FontData.Name = "맑은 고딕";
            appearance6.FontData.SizeInPoints = 10F;
            appearance6.FontData.UnderlineAsString = "False";
            appearance6.ForeColor = System.Drawing.Color.Black;
            this.txtItemCode.Appearance = appearance6;
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
            appearance9.FontData.BoldAsString = "False";
            appearance9.FontData.UnderlineAsString = "False";
            appearance9.ForeColor = System.Drawing.Color.Black;
            appearance9.TextHAlignAsString = "Right";
            appearance9.TextVAlignAsString = "Middle";
            this.lblCustName_H.Appearance = appearance9;
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
            this.ultraLabel5.Location = new System.Drawing.Point(46, 100);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(73, 23);
            this.ultraLabel5.TabIndex = 222;
            this.ultraLabel5.Text = "확정 여부";
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
            this.grid1.Size = new System.Drawing.Size(1280, 618);
            this.grid1.TabIndex = 8;
            this.grid1.TabStop = false;
            this.grid1.Text = "grid1";
            this.grid1.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDI;
            this.grid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnCellChange;
            this.grid1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
            this.grid1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.AutoSize = false;
            this.txtPlanNo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.txtPlanNo.Location = new System.Drawing.Point(125, 62);
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(145, 27);
            this.txtPlanNo.TabIndex = 223;
            // 
            // lblWorkerName_H
            // 
            appearance1.FontData.BoldAsString = "False";
            appearance1.FontData.UnderlineAsString = "False";
            appearance1.ForeColor = System.Drawing.Color.Black;
            appearance1.TextHAlignAsString = "Right";
            appearance1.TextVAlignAsString = "Middle";
            this.lblWorkerName_H.Appearance = appearance1;
            this.lblWorkerName_H.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.lblWorkerName_H.DbField = "cboUseFlag";
            this.lblWorkerName_H.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkerName_H.Location = new System.Drawing.Point(2, 65);
            this.lblWorkerName_H.Name = "lblWorkerName_H";
            this.lblWorkerName_H.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
            this.lblWorkerName_H.Size = new System.Drawing.Size(117, 23);
            this.lblWorkerName_H.TabIndex = 224;
            this.lblWorkerName_H.Text = "생산계획 번호";
            // 
            // txtWorkcenterName
            // 
            appearance18.FontData.BoldAsString = "False";
            appearance18.FontData.UnderlineAsString = "False";
            appearance18.ForeColor = System.Drawing.Color.Black;
            this.txtWorkcenterName.Appearance = appearance18;
            this.txtWorkcenterName.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkcenterName.Location = new System.Drawing.Point(515, 60);
            this.txtWorkcenterName.Name = "txtWorkcenterName";
            this.txtWorkcenterName.RequireFlag = DC00_Component.STextBox.RequireFlagEnum.NO;
            this.txtWorkcenterName.RequirePop = DC00_Component.STextBox.RequireFlagEnum.NO;
            this.txtWorkcenterName.Size = new System.Drawing.Size(252, 32);
            this.txtWorkcenterName.TabIndex = 227;
            // 
            // txtWorkcenterCode
            // 
            appearance4.FontData.BoldAsString = "False";
            appearance4.FontData.Name = "맑은 고딕";
            appearance4.FontData.SizeInPoints = 10F;
            appearance4.FontData.UnderlineAsString = "False";
            appearance4.ForeColor = System.Drawing.Color.Black;
            this.txtWorkcenterCode.Appearance = appearance4;
            this.txtWorkcenterCode.btnImgType = DC00_Component.SBtnTextEditor.ButtonImgTypeEnum.Type1;
            this.txtWorkcenterCode.btnWidth = 26;
            this.txtWorkcenterCode.Location = new System.Drawing.Point(365, 60);
            this.txtWorkcenterCode.Name = "txtWorkcenterCode";
            this.txtWorkcenterCode.RequireFlag = DC00_Component.SBtnTextEditor.RequireFlagEnum.NO;
            this.txtWorkcenterCode.RequirePop = DC00_Component.SBtnTextEditor.RequireFlagEnum.NO;
            this.txtWorkcenterCode.Size = new System.Drawing.Size(145, 32);
            this.txtWorkcenterCode.TabIndex = 226;
            // 
            // sLabel1
            // 
            appearance2.FontData.BoldAsString = "False";
            appearance2.FontData.UnderlineAsString = "False";
            appearance2.ForeColor = System.Drawing.Color.Black;
            appearance2.TextHAlignAsString = "Right";
            appearance2.TextVAlignAsString = "Middle";
            this.sLabel1.Appearance = appearance2;
            this.sLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.sLabel1.DbField = "cboUseFlag";
            this.sLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sLabel1.Location = new System.Drawing.Point(276, 64);
            this.sLabel1.Name = "sLabel1";
            this.sLabel1.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
            this.sLabel1.Size = new System.Drawing.Size(83, 23);
            this.sLabel1.TabIndex = 225;
            this.sLabel1.Text = "작업장";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.AutoSize = false;
            this.txtOrderNo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.txtOrderNo.Location = new System.Drawing.Point(896, 58);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(145, 27);
            this.txtOrderNo.TabIndex = 228;
            // 
            // sLabel2
            // 
            appearance3.FontData.BoldAsString = "False";
            appearance3.FontData.UnderlineAsString = "False";
            appearance3.ForeColor = System.Drawing.Color.Black;
            appearance3.TextHAlignAsString = "Right";
            appearance3.TextVAlignAsString = "Middle";
            this.sLabel2.Appearance = appearance3;
            this.sLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.sLabel2.DbField = "cboUseFlag";
            this.sLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sLabel2.Location = new System.Drawing.Point(773, 61);
            this.sLabel2.Name = "sLabel2";
            this.sLabel2.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
            this.sLabel2.Size = new System.Drawing.Size(117, 23);
            this.sLabel2.TabIndex = 229;
            this.sLabel2.Text = "작업지시 번호";
            // 
            // cboOrderFixFlag
            // 
            this.cboOrderFixFlag.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cboOrderFixFlag.Location = new System.Drawing.Point(125, 95);
            this.cboOrderFixFlag.Name = "cboOrderFixFlag";
            this.cboOrderFixFlag.Size = new System.Drawing.Size(145, 32);
            this.cboOrderFixFlag.TabIndex = 230;
            // 
            // sLabel3
            // 
            appearance10.FontData.BoldAsString = "False";
            appearance10.FontData.UnderlineAsString = "False";
            appearance10.ForeColor = System.Drawing.Color.Black;
            appearance10.TextHAlignAsString = "Right";
            appearance10.TextVAlignAsString = "Middle";
            this.sLabel3.Appearance = appearance10;
            this.sLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.sLabel3.DbField = "cboUseFlag";
            this.sLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sLabel3.Location = new System.Drawing.Point(773, 30);
            this.sLabel3.Name = "sLabel3";
            this.sLabel3.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
            this.sLabel3.Size = new System.Drawing.Size(117, 23);
            this.sLabel3.TabIndex = 234;
            this.sLabel3.Text = "계획 생성 일자";
            // 
            // sLabel4
            // 
            appearance7.FontData.BoldAsString = "False";
            appearance7.FontData.UnderlineAsString = "False";
            appearance7.ForeColor = System.Drawing.Color.Black;
            appearance7.TextHAlignAsString = "Right";
            appearance7.TextVAlignAsString = "Middle";
            this.sLabel4.Appearance = appearance7;
            this.sLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.sLabel4.DbField = "cboUseFlag";
            this.sLabel4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sLabel4.Location = new System.Drawing.Point(1017, 30);
            this.sLabel4.Name = "sLabel4";
            this.sLabel4.RequireFlag = DC00_Component.SLabel.RequireFlagEnum.NO;
            this.sLabel4.Size = new System.Drawing.Size(16, 23);
            this.sLabel4.TabIndex = 233;
            this.sLabel4.Text = "~";
            // 
            // dtEnddate
            // 
            this.dtEnddate.DateButtons.Add(dateButton1);
            this.dtEnddate.Location = new System.Drawing.Point(1039, 27);
            this.dtEnddate.Name = "dtEnddate";
            this.dtEnddate.NonAutoSizeHeight = 32;
            this.dtEnddate.Size = new System.Drawing.Size(121, 32);
            this.dtEnddate.TabIndex = 232;
            // 
            // dtStartDate
            // 
            this.dtStartDate.DateButtons.Add(dateButton2);
            this.dtStartDate.Location = new System.Drawing.Point(896, 27);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.NonAutoSizeHeight = 32;
            this.dtStartDate.Size = new System.Drawing.Size(121, 32);
            this.dtStartDate.TabIndex = 231;
            // 
            // AP_ProductOrder
            // 
            this.ClientSize = new System.Drawing.Size(1298, 778);
            this.Name = "AP_ProductOrder";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "작업지시 관리 및 생산 현황";
            this.Load += new System.EventHandler(this.AP_ProductOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxHeader)).EndInit();
            this.gbxHeader.ResumeLayout(false);
            this.gbxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxBody)).EndInit();
            this.gbxBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboPlantCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkcenterName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkcenterCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrderFixFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnddate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStartDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DC00_Component.SLabel lblPlantCode;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboPlantCode;
        private DC00_Component.STextBox txtItemName;
        private DC00_Component.SBtnTextEditor txtItemCode;
        private DC00_Component.SLabel lblCustName_H;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private DC00_Component.Grid grid1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPlanNo;
        private DC00_Component.SLabel lblWorkerName_H;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtOrderNo;
        private DC00_Component.STextBox txtWorkcenterName;
        private DC00_Component.SBtnTextEditor txtWorkcenterCode;
        private DC00_Component.SLabel sLabel1;
        private DC00_Component.SLabel sLabel2;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboOrderFixFlag;
        private DC00_Component.SLabel sLabel3;
        private DC00_Component.SLabel sLabel4;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtEnddate;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtStartDate;
    }
}
