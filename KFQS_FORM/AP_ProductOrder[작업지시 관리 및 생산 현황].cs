#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : AP_ProductOrder
//   Form Name    : 작업지시 관리 및 생산 현황
//   Name Space   : KFQS_Form
//   Created Date : 2021/07
//   Made By      : DSH
//   Description  : 
// *---------------------------------------------------------------------------------------------*
#endregion

#region < USING AREA >
using System;
using System.Data;
using DC_POPUP;

using DC00_assm;
using DC00_WinForm;

using Infragistics.Win.UltraWinGrid;
#endregion

namespace KFQS_Form
{
    public partial class AP_ProductOrder : DC00_WinForm.BaseMDIChildForm
    {

        #region < MEMBER AREA >
        DataTable rtnDtTemp = new DataTable(); // 
        UltraGridUtil _GridUtil = new UltraGridUtil();  //그리드 객체 생성
        Common _Common = new Common();
        private string plantCode = LoginInfo.PlantCode;

        #endregion


        #region < CONSTRUCTOR >
        public AP_ProductOrder()
        {
            InitializeComponent();
        }
        #endregion`


        #region < FORM EVENTS >
        private void AP_ProductOrder_Load(object sender, EventArgs e)
        {
            #region ▶ GRID ◀
            _GridUtil.InitializeGrid(this.grid1, true, true, false, "", false);
            _GridUtil.InitColumnUltraGrid(grid1,   "PLANTCODE",      "공장",        true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "PLANNO",         "계획번호",    true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "ORDERNO",        "작업지시번호",true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "ORDERFLAG",      "확정여부",    true, GridColDataType_emu.VarChar,      100, 120, Infragistics.Win.HAlign.Left,  true, true);
            _GridUtil.InitColumnUltraGrid(grid1,   "ORDERDATE",      "지시일자",    true, GridColDataType_emu.YearMonthDay, 120, 120, Infragistics.Win.HAlign.Left,  true, true);
            _GridUtil.InitColumnUltraGrid(grid1,   "WORKCENTERCODE", "작업장",      true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Left,  true, true);
            _GridUtil.InitColumnUltraGrid(grid1,   "WORKCENTERNAME", "작업장",      true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Left,  true, true);
            _GridUtil.InitColumnUltraGrid(grid1,   "ITEMCODE",       "품목",        true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "ITEMNAME",       "품명",        true, GridColDataType_emu.VarChar,      150, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "ORDERQTY",       "지시수량",    true, GridColDataType_emu.Double,       100, 120, Infragistics.Win.HAlign.Right, true, true);
            _GridUtil.InitColumnUltraGrid(grid1,   "PRODQTY",        "양품수량",    true, GridColDataType_emu.Double,       100, 120, Infragistics.Win.HAlign.Right, true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "BADQTY",         "불량수량",    true, GridColDataType_emu.Double,       100, 120, Infragistics.Win.HAlign.Right, true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "UNITCODE",       "단위",        true, GridColDataType_emu.VarChar,      100, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "PRODRATE",       "달성률",      true, GridColDataType_emu.VarChar,      100, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "FIRSTSTARTDATE", "최초시작일시",true, GridColDataType_emu.DateTime24,   120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "ORDERCLOSEDATE", "지시종료일시",true, GridColDataType_emu.DateTime24,   120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "DIFTIME",        "지시운영시간",true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Right, true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "ORDERCLOSEFLAG", "지시종료여부",true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "MAKEDATE",       "등록일시",    true, GridColDataType_emu.DateTime24,   120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "MAKER",          "등록자",      true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "EDITDATE",       "수정일시",    true, GridColDataType_emu.DateTime24,   120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1,   "EDITOR",         "수정자",      true, GridColDataType_emu.VarChar,      120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.SetInitUltraGridBind(grid1);
            #endregion

            this.grid1.DisplayLayout.Override.MergedCellContentArea                = MergedCellContentArea.Default;
            this.grid1.DisplayLayout.Bands[0].Columns["PLANTCODE"].MergedCellStyle = MergedCellStyle.Always;
            this.grid1.DisplayLayout.Bands[0].Columns["PLANNO"].MergedCellStyle    = MergedCellStyle.Always;


            #region ▶ COMBOBOX ◀
            rtnDtTemp = _Common.Standard_CODE("PLANTCODE");  // 사업장
            Common.FillComboboxMaster(this.cboPlantCode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
            UltraGridUtil.SetComboUltraGrid(this.grid1, "PLANTCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

            rtnDtTemp = _Common.Standard_CODE("UNITCODE");     //단위
            UltraGridUtil.SetComboUltraGrid(this.grid1, "UNITCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

            rtnDtTemp = _Common.Standard_CODE("ORDERFIX");     // 지시 확정 여부
            UltraGridUtil.SetComboUltraGrid(this.grid1, "ORDERFLAG", rtnDtTemp, "CODE_ID", "CODE_NAME");
            Common.FillComboboxMaster(this.cboOrderFixFlag, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");

            rtnDtTemp = _Common.Standard_CODE("YESNO");     // 지시 종료 여부
            UltraGridUtil.SetComboUltraGrid(this.grid1, "ORDERCLOSEFLAG", rtnDtTemp, "CODE_ID", "CODE_NAME");
            

            BizTextBoxManager btbManager = new BizTextBoxManager();
            btbManager.PopUpAdd(txtItemCode,       txtItemName,       "ITEM_MASTER",      new object[] { cboPlantCode, "" });//품목
            btbManager.PopUpAdd(txtWorkcenterCode, txtWorkcenterName, "WORKCENTER_MASTER", new object[] { cboPlantCode, "" }); //작업장'

            BizGridManager gridManager = new BizGridManager(grid1);
            gridManager.PopUpAdd("WORKCENTERCODE", "WORKCENTERNAME", "WORKCENTER_MASTER", new string[] { "PLANTCODE", "ITEMCODE", "", "" });  //품목별 작업장 코드.
            gridManager.PopUpAdd("ITEMCODE",       "ITEMNAME",       "ITEM_MASTER", new string[] { "PLANTCODE", "" });

            #endregion


            #region ▶ ENTER-MOVE ◀
            cboPlantCode.Value = plantCode;
            #endregion
        }
        #endregion


        #region < TOOL BAR AREA >
        public override void DoInquire()
        {
            DoFind();
        }
        private void DoFind()
        {
            DBHelper helper = new DBHelper(false);
            try
            {
                _GridUtil.Grid_Clear(grid1);
                string sPlantcode      = Convert.ToString(cboPlantCode.Value); 
                string sItemCode       = Convert.ToString(txtItemCode.Text);
                string sPlanNo         = Convert.ToString(txtPlanNo.Text);
                string sWorkcenterCode = Convert.ToString(txtWorkcenterCode.Text);
                string sOrderNo        = Convert.ToString(txtOrderNo.Text);
                string sOrderFixFlag   = Convert.ToString(cboOrderFixFlag.Value);
                string sStartDate      = string.Format("{0:yyyy-MM-dd}", dtStartDate.Value);
                string sEndDate        = string.Format("{0:yyyy-MM-dd}", dtEnddate.Value);


                rtnDtTemp = helper.FillTable("00AP_ProductOrder_S1", CommandType.StoredProcedure
                                    , helper.CreateParameter("PLANTCODE",      sPlantcode,      DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("ITEMCODE",       sItemCode,       DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("PLANNO",         sPlanNo,         DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("ORDERFIXFLAG",   sOrderFixFlag,   DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("WORKCENTERCODE", sWorkcenterCode, DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("ORDERNO",        sOrderNo,        DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("MAKESDATE",      sStartDate,      DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("MAKEEDATE",      sEndDate,        DbType.String, ParameterDirection.Input)
                                    ); 
                this.grid1.DataSource = rtnDtTemp;
            }
            catch (Exception ex)
            {
                ShowDialog(ex.ToString(), DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        }
        /// <summary>
        /// ToolBar의 신규 버튼 클릭
        /// </summary>
        public override void DoNew()
        {
            base.DoNew();
            try
            {
                this.grid1.InsertRow();
                this.grid1.SetDefaultValue("PLANTCODE", "1000");
                this.grid1.SetDefaultValue("ORDERFLAG", "Y");

                grid1.ActiveRow.Cells["PLANNO"].Activation         = Activation.NoEdit;
                grid1.ActiveRow.Cells["ORDERNO"].Activation        = Activation.NoEdit;
                grid1.ActiveRow.Cells["PRODQTY"].Activation        = Activation.NoEdit;// "양품수량",   
                grid1.ActiveRow.Cells["BADQTY"].Activation         = Activation.NoEdit;// "불량수량",   
                grid1.ActiveRow.Cells["UNITCODE"].Activation       = Activation.NoEdit;// "단위",       
                grid1.ActiveRow.Cells["PRODRATE"].Activation       = Activation.NoEdit;// "달성률",     
                grid1.ActiveRow.Cells["FIRSTSTARTDATE"].Activation = Activation.NoEdit;// "최초시작일시"
                grid1.ActiveRow.Cells["ORDERCLOSEDATE"].Activation = Activation.NoEdit;// "지시종료일시"
                grid1.ActiveRow.Cells["DIFTIME"].Activation        = Activation.NoEdit;// "지시운영시간"
                grid1.ActiveRow.Cells["ORDERCLOSEFLAG"].Activation = Activation.NoEdit;// "지시종료여부"
                grid1.ActiveRow.Cells["MAKER"].Activation          = Activation.NoEdit;
                grid1.ActiveRow.Cells["MAKEDATE"].Activation       = Activation.NoEdit;
                grid1.ActiveRow.Cells["EDITOR"].Activation         = Activation.NoEdit;
                grid1.ActiveRow.Cells["EDITDATE"].Activation       = Activation.NoEdit;
            }
            catch (Exception ex)
            {
                ShowDialog(ex.ToString());
            }
        }
        /// <summary>
        /// ToolBar의 삭제 버튼 Click
        /// </summary>
        public override void DoDelete()
        {
            base.DoDelete();
            grid1.DeleteRow();
        }
        /// <summary>
        /// ToolBar의 저장 버튼 Click
        /// </summary>
        public override void DoSave()
        {
            // 그리드에 표현된 내용을 소스 바인딩에 포함한다.
            this.grid1.UpdateData();

            DataTable dtTemp = new DataTable();
            dtTemp = grid1.chkChange();

            if (dtTemp == null) return;
            string sErrorMsg = string.Empty;
            DBHelper helper = new DBHelper("", true);
            try
            {
                this.Focus();

                if (this.ShowDialog("등록한 데이터를 저장 하시겠습니까?") == System.Windows.Forms.DialogResult.Cancel)
                {
                    CancelProcess = true;
                    return;
                }

                base.DoSave();

                foreach (DataRow drRow in dtTemp.Rows)
                {
                    switch (drRow.RowState)
                    {
                        case DataRowState.Deleted:
                            #region 삭제
                            drRow.RejectChanges();
                            helper.ExecuteNoneQuery("00AP_ProductOrder_D1", CommandType.StoredProcedure
                                                                    , helper.CreateParameter("PLANTCODE", plantCode, DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("ORDERNO",   drRow["ORDERNO"], DbType.String, ParameterDirection.Input)
                                                                    );

                            #endregion
                            break;
                        case DataRowState.Added:
                            #region 추가
                            // 긴급 작업지시 생성 
                            sErrorMsg = "";
                            if (Convert.ToString(drRow["ITEMCODE"]) == "")
                            {
                                sErrorMsg += "품목 ";
                            }
                            if (Convert.ToString(drRow["ORDERQTY"]) == "")
                            {
                                sErrorMsg += "수량 ";
                            }
                            if (Convert.ToString(drRow["WORKCENTERCODE"]) == "")
                            {
                                sErrorMsg += "작업장 ";
                            }
                            if (Convert.ToString(drRow["ORDERDATE"]) == "")
                            {
                                sErrorMsg += "지시일자 ";
                            }
                            if (sErrorMsg != "")
                            {
                                this.ClosePrgForm();
                                ShowDialog(sErrorMsg + "을 입력하지 않았습니다", DialogForm.DialogType.OK);
                                return;
                            }
                             
                            helper.ExecuteNoneQuery("00AP_ProductOrder_I1", CommandType.StoredProcedure
                                                  , helper.CreateParameter("PLANTCODE",       drRow["PLANTCODE"].ToString(),                          DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("WORKCENTERCODE",  drRow["WORKCENTERCODE"].ToString(),                     DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("ITEMCODE",        drRow["ITEMCODE"].ToString(),                           DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("ORDERQTY",        Convert.ToString  (drRow["ORDERQTY"]).Replace(",", ""), DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("ORDERDATE",       drRow["ORDERDATE"].ToString(),                          DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("ORDERFLAG",       drRow["ORDERFLAG"].ToString(),                          DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("MAKER",           LoginInfo.UserID,                                       DbType.String, ParameterDirection.Input)
                                                  );

                            #endregion
                            break;
                        case DataRowState.Modified:
                            #region 수정
                            // 작업지시 확정 및 작업지시 내역 변경
                            sErrorMsg = "";
                            if (Convert.ToString(drRow["ORDERQTY"]) == "")
                            {
                                sErrorMsg += "수량 ";
                            }
                            if (Convert.ToString(drRow["WORKCENTERCODE"]) == "")
                            {
                                sErrorMsg += "작업장 ";
                            }
                            if (Convert.ToString(drRow["ORDERDATE"]) == "")
                            {
                                sErrorMsg += "지시일자 ";
                            }
                            if (sErrorMsg != "")
                            {
                                this.ClosePrgForm();
                                ShowDialog(sErrorMsg + "을 입력하지 않았습니다", DialogForm.DialogType.OK);
                                return;
                            }
                            helper.ExecuteNoneQuery("00AP_ProductOrder_U1", CommandType.StoredProcedure
                                                  , helper.CreateParameter("PLANTCODE",       drRow["PLANTCODE"].ToString(),                          DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("WORKCENTERCODE",  drRow["WORKCENTERCODE"].ToString(),                     DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("ORDERQTY",        Convert.ToString  (drRow["ORDERQTY"]).Replace(",", ""), DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("ORDERDATE",       drRow["ORDERDATE"].ToString(),                          DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("ORDERFLAG",       drRow["ORDERFLAG"].ToString(),                          DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("ORDERNO",         drRow["ORDERNO"].ToString(),                            DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("PLANNO",          drRow["PLANNO"].ToString(),                             DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("EDITOR",          LoginInfo.UserID,                                       DbType.String, ParameterDirection.Input)
                                                  );
                            #endregion
                            break;
                    }
                }
                if (helper.RSCODE != "S")
                {
                    this.ClosePrgForm();
                    helper.Rollback();
                    this.ShowDialog(helper.RSMSG, DialogForm.DialogType.OK);
                    return;
                }
                helper.Commit();
                this.ClosePrgForm();
                this.ShowDialog("R00002", DialogForm.DialogType.OK);    // 데이터가 저장 되었습니다.
                DoInquire();
            }
            catch (Exception ex)
            {
                CancelProcess = true;
                helper.Rollback();
                ShowDialog(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
        }
        #endregion
    }

}




