using DC_POPUP;
using DC00_assm;
using DC00_WinForm;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KFQS_Form
{
    public partial class PP_ActureOutPut_N : DC00_WinForm.BaseMDIChildForm
    {
        //그리드 셋팅 할 수 있도록 도와주는 함수 클래스
        UltraGridUtil _GridUtill = new UltraGridUtil();
        //공장 변수 입력
        //private sPlantCode = LoginInfo
        bool sFormLoad = true; // 화면이 오픈 될 때 조회 할지 여부를 결정.
        public PP_ActureOutPut_N()
        {
            InitializeComponent();
        }

        private void PP_ActureOutPut_N_Load(object sender, EventArgs e)
        {
            try
            {
                #region GRID
                _GridUtill.InitializeGrid(this.grid1, true, true, false, "", false);
                _GridUtill.InitColumnUltraGrid(grid1, "PLANTCODE"     , "공장"          , true, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Left, false, false);
                _GridUtill.InitColumnUltraGrid(grid1, "WORKCENTERCODE", "작업장 코드"   , true, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Left, false, false);
                _GridUtill.InitColumnUltraGrid(grid1, "WORKCENTERNAME", "작업장명"      , true, GridColDataType_emu.VarChar , 150, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "ORDERNO"       , "작업지시번호"  , true, GridColDataType_emu.VarChar , 180, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "ITEMCODE"      , "품목"          , true, GridColDataType_emu.VarChar , 150, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "ITEMNAME"      , "품명"          , true, GridColDataType_emu.VarChar , 220, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "ORDERQTY"      , "지시수량"      , true, GridColDataType_emu.Double  , 100, 120, Infragistics.Win.HAlign.Right, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "PRODQTY"       , "양품수량"      , true, GridColDataType_emu.Double  , 100, 120, Infragistics.Win.HAlign.Right, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "BADQTY"        , "불량수량"      , true, GridColDataType_emu.Double  , 100, 120, Infragistics.Win.HAlign.Right, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "UNITCODE"      , "단위"          , true, GridColDataType_emu.VarChar , 100, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "WORKSTATUSCODE", "가동비가동코드", true, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Left, false, false);
                _GridUtill.InitColumnUltraGrid(grid1, "WORKSTATUS"    , "상태"          , true, GridColDataType_emu.VarChar , 100, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "INLOTQTY"      , "투입LOT수"     , true, GridColDataType_emu.Double  , 120, 120, Infragistics.Win.HAlign.Right, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "WORKER"        , "작업자코드"    , true, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Left, false, false);
                _GridUtill.InitColumnUltraGrid(grid1, "WORKERNAME"    , "작업자"        , true, GridColDataType_emu.VarChar , 100, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "STARTDATE"     , "지시시작일시"  , true, GridColDataType_emu.VarChar , 220, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid1, "ENDDATE"       , "지시종료일시"  , true, GridColDataType_emu.VarChar , 220, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.SetInitUltraGridBind(grid1);

                _GridUtill.InitializeGrid(this.grid2, true, true, false, "", false);
                _GridUtill.InitColumnUltraGrid(grid2, "CHK"           , "투입취소"    , true, GridColDataType_emu.CheckBox, 100, 120, Infragistics.Win.HAlign.Left, true, true);
                _GridUtill.InitColumnUltraGrid(grid2, "PLANTCODE"     , "공장"        , true, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Left, false, false);
                _GridUtill.InitColumnUltraGrid(grid2, "WORKCENTERCODE", "작업장 코드" , true, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Left, false, false);
                _GridUtill.InitColumnUltraGrid(grid2, "ORDERNO"       , "작업지시번호", true, GridColDataType_emu.VarChar , 180, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid2, "LOTNO"         , "LOTNO"       , true, GridColDataType_emu.VarChar , 150, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid2, "ITEMCODE"      , "품목"        , true, GridColDataType_emu.VarChar , 150, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid2, "ITEMNAME"      , "품명"        , true, GridColDataType_emu.VarChar , 220, 120, Infragistics.Win.HAlign.Left, true, false);
                _GridUtill.InitColumnUltraGrid(grid2, "STOCKQTY"      , "잔량"        , true, GridColDataType_emu.Double  , 100, 120, Infragistics.Win.HAlign.Right, true, false);
                _GridUtill.InitColumnUltraGrid(grid2, "UNITCODE"      , "단위"        , true, GridColDataType_emu.VarChar , 100, 120, Infragistics.Win.HAlign.Left, true, false);

                _GridUtill.SetInitUltraGridBind(grid2);
                #endregion

                #region COMBOBOX
                //콤보 박스 셋팅
                Common _Common = new Common();
                DataTable dtTemp = new DataTable();

                //공장 콤보 박스
                dtTemp = _Common.Standard_CODE("PLANTCODE");
                Common.FillComboboxMaster(this.cboPlantCode_H, dtTemp, dtTemp.Columns["CODE_ID"].ColumnName, dtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
                UltraGridUtil.SetComboUltraGrid(this.grid1, "PLANTCODE", dtTemp, "CODE_ID", "CODE_NAME");


                //공정 창고 콤보 박스
                dtTemp = _Common.GET_Workcenter_Code();
                Common.FillComboboxMaster(this.cboWorkCentercode, dtTemp, dtTemp.Columns["CODE_ID"].ColumnName, dtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");

                //단위 콤보 박스
                dtTemp = _Common.Standard_CODE("UNITCODE");
                UltraGridUtil.SetComboUltraGrid(this.grid1, "UNITCODE", dtTemp, "CODE_ID", "CODE_NAME");
                #endregion

                #region POP-UP

                BizTextBoxManager btManager = new BizTextBoxManager();
                btManager.PopUpAdd(txtWorkerID, txtWorkerName, "WORKER_MASTER", new object[] { "", "", "", "", "" });
                #endregion
                
                sFormLoad = false;
            }
            catch (Exception ex)
            {
                ShowDialog(ex.Message, DC00_WinForm.DialogForm.DialogType.OK);
            }

        }
        public override void DoInquire()
        {
            cboWorkCentercode_ValueChanged(null, null);
        }

        #region < 1. 작업장 선택 >
        private void cboWorkCentercode_ValueChanged(object sender, EventArgs e)
        {
            // 작업장 변경 시 작업장 현재 상태 내역 조회
            // 폼 로드시이벤트 타지 않게 하기
            if (sFormLoad == true) return;

            // 조회 후 이전에 선택했던 작업장 다시 선택 하도록 하기
            string sSelectWorkcentercode = string.Empty;
            if (this.grid1.Rows.Count != 0)
            {
                if (this.grid1.ActiveRow != null)
                {
                    sSelectWorkcentercode = Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERCODE"].Value);
                }
            }
            DBHelper helper = new DBHelper(false);
            try
            {
                _GridUtill.Grid_Clear(grid1);
                string sPlantCode = DBHelper.nvlString(this.cboPlantCode_H.Value);
                string sWorkcenterCode = DBHelper.nvlString(this.cboWorkCentercode.Value);

                DataTable rtnDtTemp = helper.FillTable("00PP_ActureOutput_N_S1", CommandType.StoredProcedure
                                    , helper.CreateParameter("PLANTCODE", sPlantCode, DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("WORKCENTERCODE", sWorkcenterCode, DbType.String, ParameterDirection.Input)
                                    );

                this.ClosePrgForm();
                this.grid1.DataSource = rtnDtTemp;
                if (this.grid1.Rows.Count == 1)
                {
                    this.grid1.Rows[0].Activated = true;
                }
                else
                {
                    for (int i = 0; i < this.grid1.Rows.Count; i++)
                    {
                        if (Convert.ToString(grid1.Rows[i].Cells["WORKCENTERCODE"].Value) == sSelectWorkcentercode)
                        {
                            grid1.Rows[i].Activated = true;
                            break;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowDialog(ex.ToString(), DC00_WinForm.DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        }
        #endregion
        
        #region < 2. 작업자 등록 >
        private void btnWorker_Click(object sender, EventArgs e)
        {
            if (grid1.Rows.Count == 0) return;
            if (grid1.ActiveRow == null)
            {
                ShowDialog("작업장을 선택 후 진행하세요");
                return;
            }

            string sWorkerID = txtWorkerID.Text.ToString();
            if (sWorkerID == "")
            {
                ShowDialog("작업자를 선택 후 진행하세요");
                return;
            }

            string sPlantCode = grid1.ActiveRow.Cells["PLANTCODE"].Value.ToString();
            string sWorkcenterCode = grid1.ActiveRow.Cells["WORKCENTERCODE"].Value.ToString();



            DBHelper helper = new DBHelper(true);
            try
            {
                //해당 공정에 작업을 진행할 작업자를 등록한다.
                helper.ExecuteNoneQuery("00PP_ActureOutput_N_I1", CommandType.StoredProcedure
                    , helper.CreateParameter("PLANTCODE", sPlantCode, DbType.String, ParameterDirection.Input)
                    , helper.CreateParameter("WORKER", sWorkerID, DbType.String, ParameterDirection.Input)
                    , helper.CreateParameter("WORKCENTERCODE", sWorkcenterCode, DbType.String, ParameterDirection.Input)
                    );
                if (helper.RSCODE == "S")
                {
                    helper.Commit();
                    ShowDialog(helper.RSMSG, DC00_WinForm.DialogForm.DialogType.OK);
                    DoInquire();
                }
                else
                {
                    helper.Rollback();
                    ShowDialog(helper.RSMSG, DC00_WinForm.DialogForm.DialogType.OK);
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
        #endregion
        
        #region < 3. 작업지시 선택 >

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (grid1.Rows.Count == 0) return;
            if (grid1.ActiveRow == null) return;
            // 작업자 등록 상태 확인
            string SWorker = Convert.ToString(grid1.ActiveRow.Cells["WORKER"].Value);
            if (SWorker == "")
            {
                ShowDialog("현재 작업장에 등록된 작업자 가 없습니다.\r\n작업자 등록 후 진행 하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                return;
            }
            string sRunStop = Convert.ToString(grid1.ActiveRow.Cells["WORKSTATUSCODE"].Value);
            if (sRunStop == "R")
            {
                ShowDialog("작업장이 현재 가동 상태 입니다.\r\n비가동 등록 후 진행 하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                return;
            }
            string sInlotNo = Convert.ToString(grid1.ActiveRow.Cells["INLOTQTY"].Value);
            if (sInlotNo != "")
            {
                ShowDialog("현재 투입된 LOT 가 있습니다.\r\n투입 LOT 를 취소후 진행하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                return;
            }

            string sWorkcenterCode = Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERCODE"].Value);
            string sWorkcenterName = Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERNAME"].Value);

            //작업지시 팝업 호출
            POP_ORDERNO orderPop = new POP_ORDERNO(sWorkcenterCode,sWorkcenterName);
            orderPop.ShowDialog();

            //작업지시 팝업 호출 후 작업지시 내역이 없으면 리턴
            if (orderPop.Tag == null) return;
            string sOrderNo = Convert.ToString(orderPop.Tag);

            //작업장 현재 상태 테이블에 작업지시 등록
            // 작업장 현재상태 테이블에 작업지시 등록 또는 업데이트  
            DBHelper helper = new DBHelper("", true);
            try
            {
                string sPlantCode = Convert.ToString(this.grid1.ActiveRow.Cells["PLANTCODE"].Value);

                // 작업지시 등록 및 단위코드 받아오기 스칼라 function 생성 
                helper.ExecuteNoneQuery("00PP_ActureOutput_N_I2", CommandType.StoredProcedure
                                   , helper.CreateParameter("PLANTCODE"     , sPlantCode     , DbType.String, ParameterDirection.Input)
                                   , helper.CreateParameter("WORKCENTERCODE", sWorkcenterCode, DbType.String, ParameterDirection.Input)
                                   , helper.CreateParameter("ORDERNO"       , sOrderNo       , DbType.String, ParameterDirection.Input)
                                   , helper.CreateParameter("WORKER"        , SWorker        , DbType.String, ParameterDirection.Input)
                                   );
                if (helper.RSCODE == "S")
                {
                    helper.Commit();
                    ShowDialog("정상적으로 등록 되었습니다.");
                    DoInquire();
                }
                else
                {
                    helper.Rollback();
                    ShowDialog(helper.RSMSG, DC00_WinForm.DialogForm.DialogType.OK);
                    DoInquire();
                    return;
                }
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
        #endregion

        #region < 4. LOT 투입 >

        private void btnLotIn_Click(object sender, EventArgs e)
        {
            if (this.grid1.ActiveRow == null) return;
            // LOT 의 상태 확인
            DBHelper helper = new DBHelper("", true);
            try
            {
                string sPlantCode      = Convert.ToString(this.grid1.ActiveRow.Cells["PLANTCODE"].Value);
                string sItemCode       = Convert.ToString(this.grid1.ActiveRow.Cells["ITEMCODE"].Value);
                string sLotNo          = DBHelper.nvlString(txtInLotNo.Text);
                string sWorkcenterCode = Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERCODE"].Value);
                string sOrderNo        = Convert.ToString(this.grid1.ActiveRow.Cells["ORDERNO"].Value);
                if (sOrderNo == "")
                {
                    ShowDialog("등록된 작업지시가 없습니다.\r\n작업지시를 등록 후 진행하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                    return;
                }
                string sUnitCode = Convert.ToString(this.grid1.ActiveRow.Cells["UNITCODE"].Value);
                string sInFlag   = "IN";
                string sWorker   = Convert.ToString(grid1.ActiveRow.Cells["WORKER"].Value);
                if (sWorker == "")
                {
                    ShowDialog("등록된 작업자가 없습니다.\r\n작업자를 등록 후 진행하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                    return;
                }
                // 투입 LOT 등록
                helper.ExecuteNoneQuery("00PP_ActureOutput_N_I3", CommandType.StoredProcedure
                                   , helper.CreateParameter("PLANTCODE"     , sPlantCode      , DbType.String, ParameterDirection.Input)
                                   , helper.CreateParameter("ITEMCODE"      , sItemCode       , DbType.String, ParameterDirection.Input)
                                   , helper.CreateParameter("LOTNO"         , sLotNo          , DbType.String, ParameterDirection.Input)
                                   , helper.CreateParameter("WORKCENTERCODE", sWorkcenterCode , DbType.String, ParameterDirection.Input)
                                   , helper.CreateParameter("UNITCODE"      , sUnitCode       , DbType.String, ParameterDirection.Input)
                                   , helper.CreateParameter("INFLAG"        , sInFlag         , DbType.String, ParameterDirection.Input)
                                   , helper.CreateParameter("WORKER"        , sWorker         , DbType.String, ParameterDirection.Input)
                                   );
                if (helper.RSCODE == "S")
                {
                    helper.Commit();
                    ShowDialog("정상적으로 등록 되었습니다.");
                    txtInLotNo.Text = "";
                    DoInquire();
                }
                else
                {
                    helper.Rollback();
                    ShowDialog(helper.RSMSG, DC00_WinForm.DialogForm.DialogType.OK);
                    DoInquire();
                    return;
                }
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
        #endregion

        #region < GRID 2 SETTING >
        private void grid1_AfterRowActivate(object sender, EventArgs e)
        {
            // 작업장 선택 후 grid2에서 투입된 LOT의 정보를 확인한다.
            if (Convert.ToString(this.grid1.ActiveRow.Cells["WORKSTATUSCODE"].Value) == "R")
                this.btnRunStop.Text = "(5) 비가동";
            else this.btnRunStop.Text = "(5) 가동";

            txtWorkerID.Text = grid1.ActiveRow.Cells["WORKER"].Value.ToString();
            txtWorkerName.Text = grid1.ActiveRow.Cells["WORKERNAME"].Value.ToString();


            // 작업장 투입 LOT 현황 
            DBHelper helper = new DBHelper(false);
            try
            {
                _GridUtill.Grid_Clear(grid2);
                string sPlantCode = Convert.ToString(this.grid1.ActiveRow.Cells["PLANTCODE"].Value);
                string sWorkcenterCode = Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERCODE"].Value);


                DataTable rtnDtTemp = helper.FillTable("00PP_ActureOutput_N_S2", CommandType.StoredProcedure
                                                                   , helper.CreateParameter("PLANTCODE", sPlantCode, DbType.String, ParameterDirection.Input)
                                                                   , helper.CreateParameter("WORKCENTERCODE", sWorkcenterCode, DbType.String, ParameterDirection.Input)
                                                                   );
                this.grid2.DataSource = rtnDtTemp;
            }
            catch (Exception ex)
            {
                ShowDialog(ex.ToString(), DC00_WinForm.DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        } 
        #endregion

        #region < 4. LOT 투입취소>
        private void btnLotOut_Click(object sender, EventArgs e)
        {
            if (grid1.ActiveRow == null)
            {
                ShowDialog("작업지시를 선택 후 진행하세요.", DialogForm.DialogType.OK);
                return;
            }
            if (Convert.ToString(grid1.ActiveRow.Cells["INLOTQTY"].Value) == "")
            {
                ShowDialog("투입 된 LOT 의 정보가 없습니다.", DialogForm.DialogType.OK);
                return;
            }
            if (this.ShowDialog("해당 작업장에 투입한 LOT 를 취소 하시겠습니까?") == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            grid2.UpdateGridData();
            DBHelper helper = new DBHelper("", true);
            try
            {
                for (int i = 0; i < this.grid2.Rows.Count; i++)
                {
                    if (Convert.ToString(this.grid2.Rows[i].Cells["CHK"].Value) == "0") continue;

                    string sPlantCode = Convert.ToString(this.grid2.Rows[i].Cells["PLANTCODE"].Value);
                    string sItemCode = Convert.ToString(this.grid2.Rows[i].Cells["ITEMCODE"].Value);
                    string sLotNo = Convert.ToString(this.grid2.Rows[i].Cells["LOTNO"].Value);
                    string sWorkcenterCode = Convert.ToString(this.grid2.Rows[i].Cells["WORKCENTERCODE"].Value);
                    string sUnitCode = Convert.ToString(this.grid2.Rows[i].Cells["UNITCODE"].Value);
                    string sInFlag = "OUT";
                    string sWorker = Convert.ToString(grid1.ActiveRow.Cells["WORKER"].Value);

                    // 투입 LOT 등록
                    helper.ExecuteNoneQuery("00PP_ActureOutput_N_I3", CommandType.StoredProcedure
                                       , helper.CreateParameter("PLANTCODE", sPlantCode, DbType.String, ParameterDirection.Input)
                                       , helper.CreateParameter("ITEMCODE", sItemCode, DbType.String, ParameterDirection.Input)
                                       , helper.CreateParameter("LOTNO", sLotNo, DbType.String, ParameterDirection.Input)
                                       , helper.CreateParameter("WORKCENTERCODE", sWorkcenterCode, DbType.String, ParameterDirection.Input)
                                       , helper.CreateParameter("UNITCODE", sUnitCode, DbType.String, ParameterDirection.Input)
                                       , helper.CreateParameter("INFLAG", sInFlag, DbType.String, ParameterDirection.Input)
                                       , helper.CreateParameter("WORKER", sWorker, DbType.String, ParameterDirection.Input)
                                       );

                    if (helper.RSCODE != "S")
                    {
                        helper.Rollback();
                        ShowDialog(helper.RSMSG, DialogForm.DialogType.OK);
                        DoInquire();
                        return;
                    }
                }
                if (helper.RSCODE == "S")
                {
                    helper.Commit();
                    ShowDialog("정상적으로 취소 되었습니다.");
                    DoInquire();
                }
            }
            catch (Exception ex)
            {
                helper.Rollback();
                ShowDialog(ex.ToString(), DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        }
        #endregion

        #region < 5. 가동 비가동 버튼 >
        private void btnRunStop_Click(object sender, EventArgs e)
        {
            if (grid1.ActiveRow == null)
            {
                ShowDialog("작업지시를 선택 후 진행하세요.", DialogForm.DialogType.OK);
                return;
            }
            DBHelper helper = new DBHelper("", true);

            try
            {
                string sStatus = "R";
                if (this.btnRunStop.Text == "(5) 비가동")
                {
                    sStatus = "S";
                }
                string sPlantCode = Convert.ToString(this.grid1.ActiveRow.Cells["PLANTCODE"].Value);
                helper.ExecuteNoneQuery("00PP_ActureOutput_N_I4", CommandType.StoredProcedure
                                                                    , helper.CreateParameter("PLANTCODE", sPlantCode, DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("WORKCENTERCODE", Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERCODE"].Value), DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("ORDERNO", Convert.ToString(this.grid1.ActiveRow.Cells["ORDERNO"].Value), DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("ITEMCODE", Convert.ToString(this.grid1.ActiveRow.Cells["ITEMCODE"].Value), DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("STATUS", sStatus, DbType.String, ParameterDirection.Input)
                                                                    );
                if (helper.RSCODE != "S")
                {
                    helper.Rollback();
                    ShowDialog(helper.RSMSG);
                    return;
                }
                helper.Commit();
                ShowDialog("상태 등록을 완료 하였습니다.", DialogForm.DialogType.OK);
                DoInquire();
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
        #endregion

        #region < 6. 생산 실적 등록 >
        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (this.grid1.ActiveRow == null)
            {
                ShowDialog("작업지시를 선택 하세요.", DialogForm.DialogType.OK);
                return;
            }

            string sPlantCode = Convert.ToString(this.grid1.ActiveRow.Cells["PLANTCODE"].Value);
            double dProdQty = 0;   // 누적 양품 수량
            double dErrorQty = 0;   // 누적 불량 수량
            double dTProdQty = 0;   // 입력 양품 수량
            double dTErrorQty = 0;   // 입력 불량 수량
            double dOrderQty = 0;   // 작업지시 수량
            double dinQty = 0;   // 원자재 잔량 수량

            string sProdQty = Convert.ToString(this.grid1.ActiveRow.Cells["PRODQTY"].Value).Replace(",", "");
            Double.TryParse(sProdQty, out dProdQty);

            string sBadQty = Convert.ToString(this.grid1.ActiveRow.Cells["BADQTY"].Value).Replace(",", "");
            Double.TryParse(sBadQty, out dErrorQty);

            string sTProdQty = Convert.ToString(txtProduct.Text);
            Double.TryParse(sTProdQty, out dTProdQty);

            string sTbadQty = Convert.ToString(txtBad.Text);
            Double.TryParse(sTbadQty, out dTErrorQty);

            string sOrderQty = Convert.ToString(this.grid1.ActiveRow.Cells["ORDERQTY"].Value).Replace(",", "");
            Double.TryParse(sOrderQty, out dOrderQty);

            string sMatLotNo = Convert.ToString(this.grid1.ActiveRow.Cells["INLOTQTY"].Value);
            if (sMatLotNo == "")
            {
                ShowDialog("투입한 LOT 이 존재 하지 않습니다.", DialogForm.DialogType.OK);
                return;
            }
            if ((dTProdQty + dTErrorQty) == 0)
            {
                ShowDialog("실적 수량을 입력 하세요.", DialogForm.DialogType.OK);
                return;

            }
            if (dOrderQty < dProdQty + dTProdQty)
            {
                ShowDialog("총 생산수량이 지시수량 보다 많습니다.", DialogForm.DialogType.OK);
                return;
            }
            DBHelper helper = new DBHelper("", true);
            try
            {

                helper.ExecuteNoneQuery("00PP_ActureOutput_N_I5", CommandType.StoredProcedure
                                                                    , helper.CreateParameter("PLANTCODE"     , sPlantCode, DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("WORKCENTERCODE", Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERCODE"].Value), DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("ORDERNO"       , Convert.ToString(this.grid1.ActiveRow.Cells["ORDERNO"].Value), DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("ITEMCODE"      , Convert.ToString(this.grid1.ActiveRow.Cells["ITEMCODE"].Value), DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("UNITCODE"      , Convert.ToString(this.grid1.ActiveRow.Cells["UNITCODE"].Value), DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("PRODQTY"       , dTProdQty, DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("BADQTY"        , dTErrorQty, DbType.String, ParameterDirection.Input)
                                                                    );
                if (helper.RSCODE != "S")
                {
                    helper.Rollback();
                    ShowDialog(helper.RSMSG);
                    return;
                }
                helper.Commit();
                ShowDialog("생산 실적 등록을 완료 하였습니다.", DialogForm.DialogType.OK);
                DoInquire();
                txtInLotNo.Text = "";
                txtProduct.Text = "";
                txtBad.Text = "";
            }
            catch (Exception ex)
            {
                helper.Rollback();
                ShowDialog(ex.ToString(), DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        }

        #endregion

        #region < 7. 작업 지시 종료 >
        private void btnOrderClose_Click(object sender, EventArgs e)
        {
            if (grid1.Rows.Count == 0) return;
            if (grid1.ActiveRow == null) return;
            // 투입 LOT 있을경우 종료 안됨
            if (grid1.ActiveRow.Cells["INLOTQTY"].Value.ToString() != "")
            {
                ShowDialog("LOT 투입 취소 후 진행하세요", DialogForm.DialogType.OK);
                return;
            }
            // 가동 일 경우 종료 안되도록 확인
            if (grid1.ActiveRow.Cells["WORKSTATUSCODE"].Value.ToString() == "R")
            {
                ShowDialog("비가동 등록 후 진행하세요.", DialogForm.DialogType.OK);
                return;
            }
            string sPlantCode = Convert.ToString(this.grid1.ActiveRow.Cells["PLANTCODE"].Value);
            // 작업지시 종료 
            DBHelper helper = new DBHelper("", true);
            try
            {

                helper.ExecuteNoneQuery("00PP_ActureOutput_N_I6", CommandType.StoredProcedure
                                                                    , helper.CreateParameter("PLANTCODE", sPlantCode, DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("WORKCENTERCODE", Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERCODE"].Value), DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("ORDERNO", Convert.ToString(this.grid1.ActiveRow.Cells["ORDERNO"].Value), DbType.String, ParameterDirection.Input)
                                                                    );
                if (helper.RSCODE != "S")
                {
                    helper.Rollback();
                    ShowDialog(helper.RSMSG);
                    return;
                }
                helper.Commit();
                ShowDialog("상태 등록을 완료 하였습니다.", DialogForm.DialogType.OK);
                DoInquire();
                txtInLotNo.Text = "";
                txtProduct.Text = "";
                txtBad.Text = "";
            }
            catch (Exception ex)
            {
                helper.Rollback();
                ShowDialog(ex.ToString(), DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        } 
        #endregion
    }


 }