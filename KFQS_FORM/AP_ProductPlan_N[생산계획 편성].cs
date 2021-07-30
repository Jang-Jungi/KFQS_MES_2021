#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : AP_ProductPlan_N
//   Form Name    : 생산 계획 편성
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
    public partial class AP_ProductPlan_N : DC00_WinForm.BaseMDIChildForm
    {

        #region < MEMBER AREA >
        DataTable rtnDtTemp = new DataTable(); // 
        UltraGridUtil _GridUtil = new UltraGridUtil();  //그리드 객체 생성
        Common _Common = new Common();
        private string plantCode = LoginInfo.PlantCode;

        #endregion


        #region < CONSTRUCTOR >
        public AP_ProductPlan_N()
        {
            InitializeComponent();
        }
        #endregion


        #region < FORM EVENTS >
        private void AP_ProductPlan_N_Load(object sender, EventArgs e)
        {
            #region ▶ GRID ◀
            _GridUtil.InitializeGrid(this.grid1, true, true, false, "", false);
 

            _GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE", "공장",         true, GridColDataType_emu.VarChar,     120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "PLANNO",    "계획번호",     true, GridColDataType_emu.VarChar,     120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "ITEMCODE",  "생산품목",     true, GridColDataType_emu.VarChar,     130, 120, Infragistics.Win.HAlign.Left,  true, false); 
            _GridUtil.InitColumnUltraGrid(grid1, "ITEMNAME",  "품명",         true, GridColDataType_emu.VarChar,     150, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "PLANQTY",   "계획수량",     true, GridColDataType_emu.Double,      100, 120, Infragistics.Win.HAlign.Right, true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "UNITCODE",  "단위",         true, GridColDataType_emu.VarChar,     100, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "PLANDATE",  "계획일자",     true, GridColDataType_emu.YearMonthDay,130, 120, Infragistics.Win.HAlign.Left,  true, false); 
            _GridUtil.InitColumnUltraGrid(grid1, "ORDERFLAG", "지시확정여부", true, GridColDataType_emu.VarChar,     100, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "MAKER",     "등록자",       true, GridColDataType_emu.VarChar,     100, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE",  "등록일시",     true, GridColDataType_emu.DateTime24,  160, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "EDITOR",    "수정자",       true, GridColDataType_emu.VarChar,     100, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "EDITDATE",  "수정일시",     true, GridColDataType_emu.DateTime24,  160, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.SetInitUltraGridBind(grid1);
            #endregion


            #region ▶ COMBOBOX ◀
            rtnDtTemp = _Common.Standard_CODE("PLANTCODE");  // 사업장
            Common.FillComboboxMaster(this.cboPlantCode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
            UltraGridUtil.SetComboUltraGrid(this.grid1, "PLANTCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

            rtnDtTemp = _Common.Standard_CODE("UNITCODE");     //단위
            UltraGridUtil.SetComboUltraGrid(this.grid1, "UNITCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

            rtnDtTemp = _Common.Standard_CODE("ORDERFIX");     // 지시 확정 여부
            UltraGridUtil.SetComboUltraGrid(this.grid1, "ORDERFLAG", rtnDtTemp, "CODE_ID", "CODE_NAME");


            BizGridManager gridManager = new BizGridManager(grid1);
            gridManager.PopUpAdd("ITEMCODE", "ITEMNAME", "ITEM_MASTER", new string[] { "PLANTCODE", "FERT" });

            BizTextBoxManager btbManager = new BizTextBoxManager();
            btbManager.PopUpAdd(txtItemCode, txtItemName, "ITEM_MASTER", new object[] { cboPlantCode, "FERT" });

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
                string sPlantcode = Convert.ToString(cboPlantCode.Value); 
                string sItemCode  = Convert.ToString(txtItemCode.Text);
                string sStartDate = string.Format("{0:yyyy-MM-dd}", dtpStart.Value);
                string sEndDate   = string.Format("{0:yyyy-MM-dd}", dtpEnd.Value);

                rtnDtTemp = helper.FillTable("19AP_ProductPlan_N_S1", CommandType.StoredProcedure
                                    , helper.CreateParameter("PLANTCODE", sPlantcode, DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("ITEMCODE",  sItemCode,  DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("STARTDATE", sStartDate, DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("ENDDATE",   sEndDate,   DbType.String, ParameterDirection.Input)
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
                this.grid1.SetDefaultValue("ORDERFLAG", "N");
                this.grid1.SetDefaultValue("PLANDATE", string.Format("{0:yyyy-MM-dd}", DateTime.Now));

                grid1.ActiveRow.Cells["PLANNO"].Activation    = Activation.NoEdit;
                grid1.ActiveRow.Cells["ORDERFLAG"].Activation = Activation.NoEdit;
                grid1.ActiveRow.Cells["MAKER"].Activation     = Activation.NoEdit;
                grid1.ActiveRow.Cells["MAKEDATE"].Activation  = Activation.NoEdit;
                grid1.ActiveRow.Cells["EDITOR"].Activation    = Activation.NoEdit;
                grid1.ActiveRow.Cells["EDITDATE"].Activation  = Activation.NoEdit;
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
                            helper.ExecuteNoneQuery("19AP_ProductPlan_N_D1", CommandType.StoredProcedure
                                                                    , helper.CreateParameter("PLANTCODE", plantCode, DbType.String, ParameterDirection.Input)
                                                                    , helper.CreateParameter("PLANNO", drRow["PLANNO"], DbType.String, ParameterDirection.Input)
                                                                    );

                            #endregion
                            break;
                        case DataRowState.Added:
                            #region 추가
                            string sErrorMsg = string.Empty;
                            if (Convert.ToString(drRow["ITEMCODE"]) == "")
                            {
                                sErrorMsg += "품목 ";
                            }
                            if (Convert.ToString(drRow["PLANQTY"]) == "")
                            {
                                sErrorMsg += "수량 ";
                            } 
                            if (sErrorMsg != "")
                            {
                                this.ClosePrgForm();
                                ShowDialog(sErrorMsg + "을 입력하지 않았습니다", DialogForm.DialogType.OK);
                                return;
                            }
                            helper.ExecuteNoneQuery("19AP_ProductPlan_N_I1", CommandType.StoredProcedure
                                                  , helper.CreateParameter("PLANTCODE", drRow["PLANTCODE"].ToString(),                       DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("ITEMCODE",  drRow["ITEMCODE"].ToString(),                        DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("PLANQTY",   Convert.ToString(drRow["PLANQTY"]).Replace(",", ""), DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("UNITCODE",  drRow["UNITCODE"].ToString(),                        DbType.String, ParameterDirection.Input)
                                                  , helper.CreateParameter("MAKER",     LoginInfo.UserID,                                    DbType.String, ParameterDirection.Input)
                                                  );

                            #endregion
                            break;
                        case DataRowState.Modified:
                            #region 수정 
                            // 수정은 삭제하고 다시하라~~
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




