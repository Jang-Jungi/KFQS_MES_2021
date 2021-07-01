#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : PP_BadStock
//   Form Name    : 제품 재고 관리
//   Name Space   : DC_WM
//   Created Date : 2021.05
//   Made By      : 
//   Description  : 제품관리 제품 재고 관리.
// *---------------------------------------------------------------------------------------------*
#endregion

#region <USING AREA>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using DC00_assm;
using DC_POPUP;
using DC00_WinForm;
using DC00_Component;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinEditors;
#endregion

namespace KFQS_Form
{
    public partial class PP_BadStock : DC00_WinForm.BaseMDIChildForm
    {
        #region [ 생성자 ]
        DataTable rtnDtTemp = new DataTable(); // return DataTable 공통
        UltraGridUtil _GridUtil = new UltraGridUtil();  //그리드 객체 생성
        #endregion

        #region [ 선언자 ]
        public PP_BadStock()
        {
            InitializeComponent();
            BizTextBoxManager btbManager = new BizTextBoxManager();
            btbManager.PopUpAdd(txtItemCode_H, txtItemName_H, "ITEM_MASTER",  new object[] { "1000", "" }); 
        }

        #endregion

        #region [ Form Load ]
        private void PP_BadStock_Load(object sender, EventArgs e)
        {
            #region ▶ GRID ◀
            _GridUtil.InitializeGrid(this.grid1, true, true, false, "", false);
            _GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE",           "공장",       true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left,  true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "BADSEQ",               "SEQ",       true, GridColDataType_emu.VarChar, 60, 120, Infragistics.Win.HAlign.Left,  true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "ORDERNO",              "주문번호",  true, GridColDataType_emu.VarChar, 60, 120, Infragistics.Win.HAlign.Left,  true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "ITEMCODE",            "품목",       true, GridColDataType_emu.VarChar,  90, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "ITEMNAME",            "품명",       true, GridColDataType_emu.VarChar,  90, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "BADQTY_TOTAL",        "최초 불량수량",   true, GridColDataType_emu.Double,   90, 120, Infragistics.Win.HAlign.Right,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "BADQTY",              "현재 불량수량",   true, GridColDataType_emu.VarChar, 90, 120, Infragistics.Win.HAlign.Right, true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "BADTYPE",             "불량사유",   true, GridColDataType_emu.VarChar, 140, 120, Infragistics.Win.HAlign.Center, true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "CHECKNUM",            "재검사 횟수",true, GridColDataType_emu.VarChar,  100, 120, Infragistics.Win.HAlign.Right,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "WORKSTATUS",          "재검사상태", true, GridColDataType_emu.VarChar,  100, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "COMFLAG",             "판정종료", true, GridColDataType_emu.CheckBox, 100, 120, Infragistics.Win.HAlign.Center, true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "INLOTNO",             "INLOTNO",    true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "WORKER",              "작업자",     true, GridColDataType_emu.VarChar,  120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERNAME",      "작업장",     true, GridColDataType_emu.VarChar,  120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE",            "등록일시",   true, GridColDataType_emu.VarChar,  150, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "MAKER",               "등록자",     true, GridColDataType_emu.VarChar,  100, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "EDITDATE",            "수정일시",   true, GridColDataType_emu.VarChar,  150, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "EDITOR",              "수정자",     true, GridColDataType_emu.VarChar,  100, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.SetInitUltraGridBind(grid1);
            #endregion

            #region ▶ COMBOBOX ◀
            Common _Common = new Common();
            rtnDtTemp = _Common.Standard_CODE("PLANTCODE");  // 사업장
            Common.FillComboboxMaster(this.cboPlantCode_H, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
            UltraGridUtil.SetComboUltraGrid(this.grid1, "PLANTCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

            //수정하기
            rtnDtTemp = _Common.Standard_CODE("BADTYPE");  // 불량사유
            Common.FillComboboxMaster(this.cboBadType, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
            UltraGridUtil.SetComboUltraGrid(this.grid1, "BADTYPE", rtnDtTemp, "CODE_ID", "CODE_NAME");

            rtnDtTemp = _Common.Standard_CODE("UNITCODE");     //단위
            UltraGridUtil.SetComboUltraGrid(this.grid1, "UNITCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");


            //rtnDtTemp = _Common.Standard_CODE("YESNO");     //상차 여부
            //UltraGridUtil.SetComboUltraGrid(this.grid1, "YESCOM", rtnDtTemp, "CODE_ID", "CODE_NAME");

            //rtnDtTemp = _Common.Standard_CODE("YESNO");     //상차 여부
            //UltraGridUtil.SetComboUltraGrid(this.grid1, "COMFLAG", rtnDtTemp, "CODE_ID", "CODE_NAME");

            //rtnDtTemp = _Common.Standard_CODE("WHCODE");     //입고 창고
            //UltraGridUtil.SetComboUltraGrid(this.grid1, "WHCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");


            #endregion

            #region ▶ POP-UP ◀
            BizTextBoxManager btbManager = new BizTextBoxManager();
            //btbManager.PopUpAdd(txtWorker_H, txtWorkerName_H, "WORKER_MASTER", new object[] { "", "", "", "", "" });
            //btbManager.PopUpAdd(txtCustCode_H, txtCustName_H, "CUST_MASTER", new object[] { cboPlantCode_H, "", "", "" });
            #endregion

            #region ▶ ENTER-MOVE ◀
            cboPlantCode_H.Value = "1000";
            #endregion
        }
        #endregion

        #region [ TOOL BAR AREA ]
        /// <summary>
        /// ToolBar의 조회 버튼 클릭
        /// </summary>

        public override void DoInquire()
        {
            DBHelper helper = new DBHelper(false);

            try
            {   
                string sPlantCode = Convert.ToString(this.cboPlantCode_H.Value);
                string sBadType = Convert.ToString(this.cboBadType.Value);
                string sItemCode  = Convert.ToString(txtItemCode_H.Text);
                string sStartDate = string.Format("{0:yyyy-MM-dd}", dtStartDate.Value);
                string sEndDate   = string.Format("{0:yyyy-MM-dd}", dtEnddate.Value);

                rtnDtTemp = helper.FillTable("02QM_BadsStock_S1", CommandType.StoredProcedure
                                                             , helper.CreateParameter("PLANTCODE",  sPlantCode,  DbType.String, ParameterDirection.Input)
                                                             , helper.CreateParameter("BADTYPE",    sBadType,    DbType.String, ParameterDirection.Input)
                                                             , helper.CreateParameter("ITEMCODE",   sItemCode,   DbType.String, ParameterDirection.Input)
                                                             , helper.CreateParameter("STARTDATE",  sStartDate,  DbType.String, ParameterDirection.Input)
                                                             , helper.CreateParameter("ENDDATE",    sEndDate,    DbType.String, ParameterDirection.Input)
                                                             );
                if (rtnDtTemp.Rows.Count > 0)
                {
                    grid1.DataSource = rtnDtTemp;
                    grid1.DataBinds(rtnDtTemp);
                    //this.ShowDialog("조회가 완료 되었습니다.", DialogForm.DialogType.OK);
                }
                else
                {
                    _GridUtil.Grid_Clear(grid1);
                    this.ShowDialog("R00111", DialogForm.DialogType.OK);    // 조회할 데이터가 없습니다.
                    return;
                }
            }
            catch (Exception ex)
            {
                this.ShowDialog(ex.Message, DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        }
        public override void DoSave()
        {
            this.grid1.UpdateData();
            DataTable dt = grid1.chkChange();
            if (dt == null)
                return;
            DBHelper helper = new DBHelper("", true);
            try
            {
                if (this.ShowDialog("변경 내용을 저장하시겠습니까 ?") == System.Windows.Forms.DialogResult.Cancel) return;

                string sBadRemark     = cboBadType.Text;
                if (sBadRemark == "")
                {
                    ShowDialog("불량사유를 입력하지 않았습니다.", DialogForm.DialogType.OK);
                    return;
                }

                string sShipNo = string.Empty;
                foreach (DataRow drRow in dt.Rows)
                {
                    switch (drRow.RowState)
                    {
                        case DataRowState.Deleted:
                            #region 삭제 
                            #endregion
                            break;
                        case DataRowState.Added:
                            #region 추가

                            #endregion
                            break;
                        case DataRowState.Modified:
                            #region 수정 
                            helper.ExecuteNoneQuery("02QM_BADSSTOCK_U2", CommandType.StoredProcedure
                                                  , helper.CreateParameter("PLANTCODE",  Convert.ToString(drRow["PLANTCODE"]), DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("BADSEQ",      Convert.ToString(drRow["BADSEQ"]),     DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("BADTYPE",   Convert.ToString(drRow["BADTYPE"]),  DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("COMFLAG",    Convert.ToString(drRow["COMFLAG"]),  DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("MAKER",      LoginInfo.UserID,                     DbType.String, ParameterDirection.Input)
                                                  );

                            if (helper.RSCODE == "S")
                            {
                                sShipNo = helper.RSMSG;
                            }
                            else break;
                            #endregion
                            break;
                    }
                    if (helper.RSCODE != "S") break;
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
                this.ShowDialog("데이터가 저장 되었습니다.", DialogForm.DialogType.OK);
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

        #region [ User Method Area ]
        #endregion

        private void grid1_AfterRowActivate(object sender, EventArgs e)
        {
            if (Convert.ToString(this.grid1.ActiveRow.Cells["WORKSTATUS"].Value) == "Wait")
            {
                btnReTest.Text = "재검사 시작";
            }
            else btnReTest.Text = "재검사 중";
                    }

        private void btnRetest_Click(object sender, EventArgs e)
        {
            // 재검사시작 재검사중 등록
            DBHelper helper = new DBHelper("", true);
            try
            {
                string sStatus = "Wait";
                if (btnReTest.Text == "재검사 시작") sStatus = "Ing";
                helper.ExecuteNoneQuery("PP_ActureOutput_U1", CommandType.StoredProcedure
                                                                    , helper.CreateParameter("PLANTCODE", "1000", DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("INLOTNO", Convert.ToString(this.grid1.ActiveRow.Cells["INLOTNO"].Value), DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("STATUS", sStatus, DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("BADSEQ", Convert.ToString(this.grid1.ActiveRow.Cells["BADSEQ"].Value), DbType.Int32, ParameterDirection.Input)
                                                                    );
                if (helper.RSCODE == "S")
                {
                    helper.Commit();
                    ShowDialog("정상적으로 등록되었습니다.", DC00_WinForm.DialogForm.DialogType.OK);
                    DoInquire();
                }
                else
                {
                    helper.Rollback();
                    ShowDialog("데이터 등록 중 오류가 발생 하였습니다." + helper.RSMSG, DC00_WinForm.DialogForm.DialogType.OK);
                }
            }
            catch (Exception ex)
            {
                helper.Rollback();
                ShowDialog(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
        }

        private void btnQty_Click(object sender, EventArgs e)
        
        {
            //재검사 수량 등록
            if (this.grid1.ActiveRow == null)    //ActiveRow가 널이면 그리드안에서 뭐고를지 클릭을 안해놓은거
            {
                ShowDialog("수량을 입력할 로트를 선택하세요", DC00_WinForm.DialogForm.DialogType.OK);
                return;
            }

            double dTProdQty = 0; //입력 양품수량
            string sTProdQty = Convert.ToString(txtProduct.Text);
            double.TryParse(sTProdQty, out dTProdQty);

            if ((dTProdQty) == 0)
            {
                ShowDialog("실적수량을 입력하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                return;
            }

            if (Convert.ToInt32(this.grid1.ActiveRow.Cells["BADQTY"].Value) < Convert.ToInt32(sTProdQty) || Convert.ToInt32(sTProdQty) < 0)
            {
                ShowDialog("합격수량이 남은 불량 수량 보다 많습니다.", DC00_WinForm.DialogForm.DialogType.OK);
                return;
            }
            if (Convert.ToString(btnReTest.Text) == "재검사 시작")
            {
                ShowDialog("불량 재검사 후 재검사 실적을 등록하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                return;
            }

            DBHelper helper = new DBHelper("", true);
            try
            {
                helper.ExecuteNoneQuery("02QM_BadsStock_U1", CommandType.StoredProcedure
                                                                  , helper.CreateParameter("PLANTCODE",      "1000", DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("INLOTNO",          Convert.ToString(this.grid1.ActiveRow.Cells["INLOTNO"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("BADSEQ",          Convert.ToString(this.grid1.ActiveRow.Cells["BADSEQ"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("ITEMCODE",       Convert.ToString(this.grid1.ActiveRow.Cells["ITEMCODE"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("ITEMNAME",       Convert.ToString(this.grid1.ActiveRow.Cells["ITEMNAME"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("PRODQTY",         dTProdQty, DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("BADQTY ",        Convert.ToString(this.grid1.ActiveRow.Cells["BADQTY"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("BADTYPE  ",      Convert.ToString(this.grid1.ActiveRow.Cells["BADTYPE"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("COMFLAG  ",      Convert.ToString(this.grid1.ActiveRow.Cells["COMFLAG"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("WORKER   ",      Convert.ToString(this.grid1.ActiveRow.Cells["WORKER"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("WORKCENTERNAME", Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERNAME"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("EDITDATE",       Convert.ToString(this.grid1.ActiveRow.Cells["EDITDATE"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("EDITOR  ",       Convert.ToString(this.grid1.ActiveRow.Cells["EDITOR"].Value), DbType.String, ParameterDirection.Input)
                                                                  , helper.CreateParameter("ORDERNO  ",       Convert.ToString(this.grid1.ActiveRow.Cells["ORDERNO"].Value), DbType.String, ParameterDirection.Input)
                                                                  );
                                                                 
                if (helper.RSCODE != "S")
                {
                    helper.Rollback();
                    ShowDialog(helper.RSMSG);
                    return;
                }
                helper.Commit();
                ShowDialog("재검사실적 등록을 완료 하였습니다.", DC00_WinForm.DialogForm.DialogType.OK);
                DoInquire();
                txtProduct.Text = "";
                
            }
            catch (Exception ex)
            {
                helper.Rollback();
                ShowDialog(ex.ToString(), DC00_WinForm.DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        }
    }
}