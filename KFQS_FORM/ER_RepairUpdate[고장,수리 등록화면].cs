#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : ER_RepairUpdate
//   Form Name    : 작업장 비가동 현황 및 사유관리
//   Name Space   : KFQS_Form
//   Created Date : 2020/08
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
    public partial class ER_RepairUpdate : DC00_WinForm.BaseMDIChildForm
    {
        #region < MEMBER AREA >
        DataTable rtnDtTemp        = new DataTable(); // 
        UltraGridUtil _GridUtil    = new UltraGridUtil();  //그리드 객체 생성
        Common _Common             = new Common();
        string plantCode           = LoginInfo.PlantCode;

        #endregion

        #region < CONSTRUCTOR >
        public ER_RepairUpdate()
        {
            InitializeComponent();
        }
        #endregion 

        #region < FORM EVENTS >
        private void ER_RepairUpdate_Load(object sender, EventArgs e)
        {
            #region ▶ GRID ◀
            _GridUtil.InitializeGrid(this.grid1, false, true, false, "", false);
            _GridUtil.InitColumnUltraGrid(grid1, "CHK",            "수리여부",          true, GridColDataType_emu.CheckBox ,  80, 130, Infragistics.Win.HAlign.Center, true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE",      "공장",              true, GridColDataType_emu.VarChar  , 130, 130, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERCODE", "작업장",            true, GridColDataType_emu.VarChar  , 150, 130, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERNAME", "작업장명",          true, GridColDataType_emu.VarChar  , 150, 130, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "MAKER",          "등록자",            true, GridColDataType_emu.VarChar  , 150, 130, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE",       "고장 시간",         true, GridColDataType_emu.DateTime , 150, 130, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "REMARK",         "수리내역",          true, GridColDataType_emu.VarChar  , 200, 130, Infragistics.Win.HAlign.Left, true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "REPAIRDATE",     "수리 완료 시간",    true, GridColDataType_emu.DateTime , 150, 130, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "REPAIRMAN",      "수리자",            true, GridColDataType_emu.VarChar  , 150, 130, Infragistics.Win.HAlign.Left, true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "REPAIRMAKER",    "수리 등록자",       true, GridColDataType_emu.VarChar  , 150, 130, Infragistics.Win.HAlign.Left, true, true);
            _GridUtil.InitColumnUltraGrid(grid1, "ERRORSEQ",       "고장순번",          true, GridColDataType_emu.VarChar  , 150, 130, Infragistics.Win.HAlign.Left, false, true);
            _GridUtil.SetInitUltraGridBind(grid1);


            #endregion

            #region ▶ COMBOBOX ◀
            rtnDtTemp = _Common.Standard_CODE("PLANTCODE");  // 사업장
            Common.FillComboboxMaster(this.cboPlantCode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
            UltraGridUtil.SetComboUltraGrid(this.grid1, "PLANTCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

            rtnDtTemp = _Common.GET_Workcenter_Code();  //작업장
            Common.FillComboboxMaster(this.cboWorkcenterCode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");

            #endregion

            #region ▶ POP-UP ◀
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
                base.DoInquire();
                _GridUtil.Grid_Clear(grid1);
                
                
                string sPlantCode      = Convert.ToString(this.cboPlantCode.Value);
                string sWorkcenterCode = Convert.ToString(this.cboWorkcenterCode.Value);
                string sStartDate      = string.Format("{0:yyyy-MM-dd}" ,dtStart_H.Value);
                string sSendDate       = string.Format("{0:yyyy-MM-dd}", dtEnd_H.Value);

                rtnDtTemp = helper.FillTable("19ER_REPAIRUPDATE_S1", CommandType.StoredProcedure
                                    , helper.CreateParameter("PLANTCODE"     , sPlantCode      , DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("WORKCENTERCODE", sWorkcenterCode , DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("STARTDATE"     , sStartDate      , DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("ENDDATE"       , sSendDate       , DbType.String, ParameterDirection.Input)
                                    );

               this.ClosePrgForm();
                if (rtnDtTemp.Rows.Count != 0)
                {
                    this.grid1.DataSource = rtnDtTemp;
                }
            }
            catch (Exception ex)
            {
                ShowDialog(ex.ToString(),DialogForm.DialogType.OK);    
            }
            finally
            {
                helper.Close();
            }
        }

        public override void DoNew()
        {
            
        }

        public override void DoDelete()
        {   
           
        }

        public override void DoSave()
        {
            this.grid1.UpdateData();
            DataTable dt = grid1.chkChange();
            if (dt== null)
            {
                return;
            }
            DBHelper helper = new DBHelper("", true);
            try
            {  
                if (this.ShowDialog("수리 내역을 등록 하시겠습니까 ?") == System.Windows.Forms.DialogResult.Cancel)
                {
                    CancelProcess = true;
                    return;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToString(dt.Rows[i]["REMARK"]) == "")
                    {
                        ShowDialog("수리 내역을 등록해주세요.");
                        helper.Rollback();
                        return;
                    }

                    if (Convert.ToString(dt.Rows[i]["REPAIRMAN"]) == "")

                    {
                        ShowDialog("수리자를 등록해주세요.");
                        helper.Rollback();
                        return;
                    }
                    if (Convert.ToString(dt.Rows[i]["CHK"]) == "0")
                    {
                        ShowDialog("수리 내역을 선택해주세요.");
                        helper.Rollback();
                        return;
                    }

                    helper.ExecuteNoneQuery("19ER_RepairUpdate_U1"
                                            , CommandType.StoredProcedure
                                            , helper.CreateParameter("PLANTCODE",      Convert.ToString(dt.Rows[i]["PLANTCODE"])      , DbType.String, ParameterDirection.Input)
                                            , helper.CreateParameter("WORKCENTERCODE", Convert.ToString(dt.Rows[i]["WORKCENTERCODE"]) , DbType.String, ParameterDirection.Input)
                                            , helper.CreateParameter("MAKER",          Convert.ToString(dt.Rows[i]["MAKER"])          , DbType.String, ParameterDirection.Input)
                                            , helper.CreateParameter("MAKEDATE",       Convert.ToString(dt.Rows[i]["MAKEDATE"])       , DbType.String, ParameterDirection.Input)
                                            , helper.CreateParameter("REMARK",         Convert.ToString(dt.Rows[i]["REMARK"])         , DbType.String, ParameterDirection.Input)
                                            , helper.CreateParameter("REPAIRDATE",     Convert.ToString(dt.Rows[i]["REPAIRDATE"])     , DbType.String, ParameterDirection.Input)
                                            , helper.CreateParameter("REPAIRMAN",      Convert.ToString(dt.Rows[i]["REPAIRMAN"])      , DbType.String, ParameterDirection.Input)
                                            , helper.CreateParameter("ERRORSEQ",       Convert.ToString(dt.Rows[i]["ERRORSEQ"])       , DbType.String, ParameterDirection.Input)
                                            , helper.CreateParameter("REPAIRMAKER",    this.WorkerID                                  , DbType.String, ParameterDirection.Input)

                                            );
        
                    if (helper.RSCODE == "E")
                    {
                        this.ShowDialog(helper.RSMSG, DialogForm.DialogType.OK);
                        helper.Rollback();
                        return;
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
    }
}




