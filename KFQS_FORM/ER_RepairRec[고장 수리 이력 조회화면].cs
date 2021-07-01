#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : ER_RepairRec
//   Form Name    : 자재 재고관리 
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
using System.Drawing;

using Infragistics.Win.UltraWinGrid;
#endregion

namespace KFQS_Form
{
    public partial class ER_RepairRec : DC00_WinForm.BaseMDIChildForm
    {
        #region < MEMBER AREA >
        DataTable rtnDtTemp = new DataTable(); // 
        UltraGridUtil _GridUtil = new UltraGridUtil();  //그리드 객체 생성
        Common _Common = new Common();
        string plantCode = LoginInfo.PlantCode;

        #endregion

        #region < CONSTRUCTOR >
        public ER_RepairRec()
        {
            InitializeComponent();
        }
        #endregion

        #region < FORM EVENTS >
        private void ER_RepairRec_Load(object sender, EventArgs e)
        {
            #region ▶ GRID ◀
            _GridUtil.InitializeGrid(this.grid1, true, true, false, "", false);
            _GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE"      , "공장"           , true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left  , true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERCODE" , "작업장"         , true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left  , true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "REPAIRCNT"      , "기간별고장횟수" , true, GridColDataType_emu.VarChar, 180, 120, Infragistics.Win.HAlign.Right , true, false);


            _GridUtil.InitializeGrid(this.grid2, true, true, false, "", false);
            _GridUtil.InitColumnUltraGrid(grid2, "WORKCENTERCODE" , "작업장"       , true, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Left,   false, false);
            _GridUtil.InitColumnUltraGrid(grid2, "MAKER"          , "작업자"       , true, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "MAKEDATE"       , "고장일시"     , true, GridColDataType_emu.VarChar , 180, 120, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "REPAIRMAN"      , "수리자"       , true, GridColDataType_emu.VarChar , 120, 120, Infragistics.Win.HAlign.Center, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "REMARK"         , "수리내역"     , true, GridColDataType_emu.VarChar , 180, 120, Infragistics.Win.HAlign.Center,   true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "REPAIRDATE"     , "수리완료시간" , true, GridColDataType_emu.VarChar , 180, 120, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "REPAIRTIME"     , "수리소요시간" , true, GridColDataType_emu.Double  , 120, 120, Infragistics.Win.HAlign.Right,  true, false);

            _GridUtil.SetInitUltraGridBind(grid1);
            _GridUtil.SetInitUltraGridBind(grid2);
            #endregion

            #region ▶ COMBOBOX ◀
            rtnDtTemp = _Common.Standard_CODE("PLANTCODE");  // 사업장
            Common.FillComboboxMaster(this.cboPlantCode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");

            rtnDtTemp = _Common.GET_Workcenter_Code();  // 작업장 중요!
            Common.FillComboboxMaster(this.cboCustCode_H, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
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
                _GridUtil.Grid_Clear(grid2);

                string sPlantCode       = Convert.ToString(cboPlantCode.Value);
                string sWorkCenterCode  = Convert.ToString(cboCustCode_H.Value);
                string sStartDate       = string.Format("{0:yyyy-MM-dd}", dtStartDate.Value);
                string sEndDate         = string.Format("{0:yyyy-MM-dd}", dtEnddate.Value);
                
                rtnDtTemp = helper.FillTable("19ER_ERRORREC_S1", CommandType.StoredProcedure
                                    , helper.CreateParameter("PLANTCODE",        sPlantCode      , DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("WORKCENTERCODE",   sWorkCenterCode , DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("STARTDATE",        sStartDate      , DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("ENDDATE",          sEndDate        , DbType.String, ParameterDirection.Input)
                                    );

                this.ClosePrgForm();
                this.grid1.DataSource = rtnDtTemp;
                this.grid1.DataBinds(rtnDtTemp);

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
        #endregion

        #region GRID2 SETTING
        private void grid1_AfterRowActivate(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper(false);
            try
            {

                string sPlantCode = Convert.ToString(grid1.ActiveRow.Cells["PLANTCODE"].Value);
                string sWorkcenter = Convert.ToString(grid1.ActiveRow.Cells["WORKCENTERCODE"].Value);

                rtnDtTemp = helper.FillTable("[19ER_ERRORREC_S2]", CommandType.StoredProcedure
                                    , helper.CreateParameter("PLANTCODE", sPlantCode, DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("WORKCENTERCODE", sWorkcenter, DbType.String, ParameterDirection.Input)
                                    );

                this.grid2.DisplayLayout.Override.MergedCellContentArea = MergedCellContentArea.Default;
                this.grid2.DisplayLayout.Bands[0].Columns["WORKCENTERCODE"].MergedCellStyle = MergedCellStyle.Always;
                this.grid2.DisplayLayout.Bands[0].Columns["MAKER"].MergedCellStyle = MergedCellStyle.Always;
                this.grid2.DisplayLayout.Bands[0].Columns["MAKEDATE"].MergedCellStyle = MergedCellStyle.Always;
                this.grid2.DisplayLayout.Bands[0].Columns["REPAIRMAN"].MergedCellStyle = MergedCellStyle.Always;
                this.grid2.DisplayLayout.Bands[0].Columns["REMARK"].MergedCellStyle = MergedCellStyle.Always;
                this.grid2.DisplayLayout.Bands[0].Columns["REPAIRDATE"].MergedCellStyle = MergedCellStyle.Always;

                if (rtnDtTemp.Rows.Count != 0)
                {
                    //SUB-TOTAL
                    DataTable dtSubTotal = rtnDtTemp.Clone();
                    string sMaker = Convert.ToString(rtnDtTemp.Rows[0]["WORKCENTERCODE"]);
                    double sRepairtime = Convert.ToDouble(rtnDtTemp.Rows[0]["REPAIRTIME"]);
                    dtSubTotal.Rows.Add(new object[] {
                                                       Convert.ToString (rtnDtTemp.Rows[0]["WORKCENTERCODE"]),
                                                       Convert.ToString (rtnDtTemp.Rows[0]["MAKER"]),
                                                       Convert.ToString (rtnDtTemp.Rows[0]["MAKEDATE"]),
                                                       Convert.ToString (rtnDtTemp.Rows[0]["REPAIRMAN"]),
                                                       Convert.ToString (rtnDtTemp.Rows[0]["REMARK"]),
                                                       Convert.ToString (rtnDtTemp.Rows[0]["REPAIRDATE"]),
                                                       Convert.ToDouble (rtnDtTemp.Rows[0]["REPAIRTIME"])
                                                      });

                    for (int i = 1; i < rtnDtTemp.Rows.Count; i++)
                    {
                        if (sMaker == Convert.ToString(rtnDtTemp.Rows[i]["WORKCENTERCODE"]))
                        {
                            sRepairtime = sRepairtime + Convert.ToInt32(rtnDtTemp.Rows[i]["REPAIRTIME"]);

                            dtSubTotal.Rows.Add(new object[] {
                                                       Convert.ToString (rtnDtTemp.Rows[0]["WORKCENTERCODE"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["MAKER"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["MAKEDATE"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["REPAIRMAN"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["REMARK"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["REPAIRDATE"]),
                                                       Convert.ToDouble (rtnDtTemp.Rows[i]["REPAIRTIME"])
                                                      });
                            continue;
                        }
                        else
                        {
                            dtSubTotal.Rows.Add(new object[] { "", "", null, "", "", "합   계 :", sRepairtime });

                            dtSubTotal.Rows.Add(new object[] {
                                                       Convert.ToString (rtnDtTemp.Rows[i]["WORKCENTERCODE"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["MAKER"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["MAKEDATE"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["REPAIRMAN"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["REMARK"]),
                                                       Convert.ToString (rtnDtTemp.Rows[i]["REPAIRDATE"]),
                                                       Convert.ToDouble (rtnDtTemp.Rows[i]["REPAIRTIME"])
                                                      });
                            sMaker = Convert.ToString(rtnDtTemp.Rows[i]["WORKCENTERCODE"]);
                        }
                    }
                    dtSubTotal.Rows.Add(new object[] { "", "", null, "", "", "합   계 :", sRepairtime });

                    this.grid2.DataSource = dtSubTotal;

                    for (int i = 0; i < this.grid2.Rows.Count; i++)
                    {
                        if (Convert.ToString(grid2.Rows[i].Cells["REMARK"].Value) == "수리중")
                        {
                            grid2.Rows[i].Appearance.BackColor = Color.Orange;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowDialog(ex.Message, DC00_WinForm.DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        } 
        #endregion
    }
}