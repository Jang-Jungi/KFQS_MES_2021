#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : BM_WorkcenterPerItem
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

using Infragistics.Win.UltraWinGrid;
#endregion

namespace KFQS_Form
{
    public partial class BM_WorkcenterPerItem : DC00_WinForm.BaseMDIChildForm
    {

        #region < MEMBER AREA >
        DataTable rtnDtTemp        = new DataTable(); // 
        UltraGridUtil _GridUtil    = new UltraGridUtil();  //그리드 객체 생성
        Common _Common             = new Common();
        string plantCode           = LoginInfo.PlantCode;

        #endregion


        #region < CONSTRUCTOR >
        public BM_WorkcenterPerItem()
        {
            InitializeComponent();
        }
        #endregion


        #region < FORM EVENTS >
        private void BM_WorkcenterPerItem_Load(object sender, EventArgs e)
        {
            #region ▶ GRID1 ◀
            _GridUtil.InitializeGrid(this.grid1, true, true, false, "", false);
            _GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE"      , "공장"      , true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERCODE" , "작업장코드", true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERNAME" , "작업장명"  , true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Left,  true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "ITEMCOUNT"      , "품목수"    , true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Right, true, false);
            _GridUtil.InitColumnUltraGrid(grid1, "ITEMCODE"       , "품목코드"  , true, GridColDataType_emu.VarChar, 120, 120, Infragistics.Win.HAlign.Right, false, false);

            _GridUtil.SetInitUltraGridBind(grid1);
            #endregion
            #region ▶ GRID2 ◀
            _GridUtil.InitializeGrid(this.grid2, true, true, false, "", false);
            _GridUtil.InitColumnUltraGrid(grid2, "PLANTCODE"      , "공장"      , true, GridColDataType_emu.VarChar   , 120, 120, Infragistics.Win.HAlign.Left, false, false);
            _GridUtil.InitColumnUltraGrid(grid2, "WORKCENTERCODE" , "작업장코드", true, GridColDataType_emu.VarChar   , 140, 120, Infragistics.Win.HAlign.Left, false, false);
            _GridUtil.InitColumnUltraGrid(grid2, "ITEMCODE"       , "품목코드"  , true, GridColDataType_emu.VarChar   , 140, 120, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "ITEMNAME"       , "품명"      , true, GridColDataType_emu.VarChar   , 120, 120, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "REMARK"         , "비고"      , true, GridColDataType_emu.VarChar   , 120, 120, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "MAKER"          , "등록자"    , true, GridColDataType_emu.VarChar   , 120, 120, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "MAKEDATE"       , "등록일시"  , true, GridColDataType_emu.DateTime24, 120, 120, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "EDITOR"         , "수정자"    , true, GridColDataType_emu.VarChar   , 120, 120, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "EDITDATE"       , "수정일시"  , true, GridColDataType_emu.DateTime24, 120, 120, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.SetInitUltraGridBind(grid2);
            #endregion

            #region ▶ COMBOBOX ◀
            rtnDtTemp = _Common.Standard_CODE("PLANTCODE");  // 사업장
            Common.FillComboboxMaster(this.cboPlantCode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
            UltraGridUtil.SetComboUltraGrid(this.grid1, "PLANTCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

            rtnDtTemp = _Common.GET_Workcenter_Code();     //작업장
            Common.FillComboboxMaster(this.cboWorkcentercode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");

            #endregion

            #region ▶ POP-UP ◀
            BizTextBoxManager btbManager = new BizTextBoxManager();
            btbManager.PopUpAdd(txtItemCode_H, txtItemName_H, "ITEM_MASTER", new object[] { cboPlantCode, "" });

            BizGridManager gridManager = new BizGridManager(grid2);
            gridManager.PopUpAdd("ITEMCODE", "ITEMNAME", "ITEM_MASTER", new string[] { "PLANTCODE", "" });
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
                string sPlantCode      = Convert.ToString(cboPlantCode.Value);
                string sWorkcentercode = Convert.ToString(cboWorkcentercode.Value);
                string sItemcode       = Convert.ToString(txtItemCode_H.Text);

                rtnDtTemp = helper.FillTable("19BM_WorkcenterPerItem_S1", CommandType.StoredProcedure
                                    , helper.CreateParameter("PLANTCODE"     , sPlantCode     , DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("WORKCENTERCODE", sWorkcentercode, DbType.String, ParameterDirection.Input)
                                    , helper.CreateParameter("ITEMCODE"      , sItemcode      , DbType.String, ParameterDirection.Input)
                                    );

                this.ClosePrgForm();
                this.grid1.DataSource = rtnDtTemp;
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
        /// <summary>
        /// ToolBar의 신규 버튼 클릭
        /// </summary>
        public override void DoNew()
        {
            //선택된거 없으면 리턴
            if (this.grid1.ActiveRow == null) return;
            if (this.grid1.Rows.Count == 0) return;

            this.grid2.InsertRow();

            this.grid2.ActiveRow.Cells["PLANTCODE"].Value = "1000";
            this.grid2.ActiveRow.Cells["WORKCENTERCODE"].Value = Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERCODE"].Value);

            //수정 불가
            grid2.ActiveRow.Cells["MAKER"].Activation    = Activation.NoEdit;
            grid2.ActiveRow.Cells["MAKEDATE"].Activation = Activation.NoEdit;
            grid2.ActiveRow.Cells["EDITOR"].Activation   = Activation.NoEdit;
            grid2.ActiveRow.Cells["EDITDATE"].Activation = Activation.NoEdit;

        }
        /// <summary>
        /// ToolBar의 삭제 버튼 Click
        /// </summary>
        public override void DoDelete()
        {
            this.grid2.DeleteRow();
        }
        /// <summary>
        /// ToolBar의 저장 버튼 Click
        /// </summary>
        public override void DoSave()
        {
            DataTable dt = new DataTable();
            dt = grid2.chkChange();
            if (dt == null)
                return;
            DBHelper helper = new DBHelper("", true);

            try
            {
                //base.DoSave();

                if (this.ShowDialog("작업장 별 품목 내역을 등록 하시겠습니까 ? ") == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }

               foreach (DataRow drrow in dt.Rows)
                {
                    switch (drrow.RowState)
                    {
                        case DataRowState.Deleted:
                            drrow.RejectChanges();
                            helper.ExecuteNoneQuery("19BM_WorkcenterPerItem_D1", CommandType.StoredProcedure,
                                                helper.CreateParameter("PLANTCODE",        Convert.ToString(drrow["PLANTCODE"]),        DbType.String, ParameterDirection.Input),
                                                helper.CreateParameter("WORKCENTERCODE",   Convert.ToString(drrow["WORKCENTERCODE"]),   DbType.String, ParameterDirection.Input),
                                                helper.CreateParameter("ITEMCODE",         Convert.ToString(drrow["ITEMCODE"]),        DbType.String, ParameterDirection.Input)
                                                );
                            break;
                        case DataRowState.Added:
                            if (Convert.ToString(drrow["ITEMCODE"]) == string.Empty)
                            { 
                                this.ShowDialog("품목을 입력 하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                                return;
                            }
                            helper.ExecuteNoneQuery("19BM_WorkcenterPerItem_I1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("PLANTCODE",        Convert.ToString(drrow["PLANTCODE"]),      DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("WORKCENTERCODE",   Convert.ToString(drrow["WORKCENTERCODE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("ITEMCODE",         Convert.ToString(drrow["ITEMCODE"]),       DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("REMARK",           Convert.ToString(drrow["REMARK"]),         DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("MAKER",            LoginInfo.UserID,                          DbType.String, ParameterDirection.Input)
                                                    );
                            break;
                        case DataRowState.Modified:
                             helper.ExecuteNoneQuery("19BM_WorkcenterPerItem_U1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("PLANTCODE",        Convert.ToString(drrow["PLANTCODE"]),      DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("WORKCENTERCODE",   Convert.ToString(drrow["WORKCENTERCODE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("ITEMCODE",         Convert.ToString(drrow["ITEMCODE"]),       DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("REMARK",           Convert.ToString(drrow["REMARK"]),         DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("EDITOR",           LoginInfo.UserID,                          DbType.String, ParameterDirection.Input)
                                                    );
                            break;
                    }
                    if (helper.RSCODE != "S")
                    {
                        break;
                    }
                }
                if (helper.RSCODE != "S")
                {
                    helper.Rollback();
                    ShowDialog(helper.RSMSG);
                    return;
                }

                helper.Commit();
                this.ShowDialog("데이터가 저장 되었습니다.", DialogForm.DialogType.OK);
                this.ClosePrgForm();
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


        private void grid1_AfterRowActivate(object sender, EventArgs e)
        {
            // 작업장 내역 조회 
            DBHelper helper = new DBHelper(false);
            try
            {
                string sPlantcode       = Convert.ToString(this.grid1.ActiveRow.Cells["PLANTCODE"].Value);
                string sWorkcenterCode  = Convert.ToString(this.grid1.ActiveRow.Cells["WORKCENTERCODE"].Value); 
                string sItemCode        = Convert.ToString(txtItemCode_H.Text);

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("19BM_WorkcenterPerItem_S2", CommandType.StoredProcedure
                                          , helper.CreateParameter("PLANTCODE",        sPlantcode,      DbType.String, ParameterDirection.Input)
                                          , helper.CreateParameter("WORKCENTERCODE",   sWorkcenterCode, DbType.String, ParameterDirection.Input)
                                          , helper.CreateParameter("ITEMCODE",         sItemCode,       DbType.String, ParameterDirection.Input)
                                          );
                if (dtTemp.Rows.Count > 0)
                {
                    grid2.DataSource = dtTemp;
                    grid2.DataBinds(dtTemp);
                }
                else
                {
                    _GridUtil.Grid_Clear(grid2);
                    //ShowDialog("조회할 데이터가 없습니다.", DC00_WinForm.DialogForm.DialogType.OK);
                }
            }
            catch(Exception ex)
            {
                ShowDialog(ex.Message, DC00_WinForm.DialogForm.DialogType.OK);
            }
            finally
            {
                helper.Close();
            }
        }
    }
}




