using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DC00_assm;
using Infragistics.Win.UltraWinGrid;

namespace KFQS_Form
{
    public partial class BM_CheckList : DC00_WinForm.BaseMDIChildForm
    {
        // 그리드를 셋팅할 수 있도록 도와주는 함수 클래스. 
        UltraGridUtil _GridUtil = new UltraGridUtil();
        // 공장 변수 입력
        public BM_CheckList()
        {
            InitializeComponent();
        }

        private void BM_CheckList_Load(object sender, EventArgs e)
        {
            // 그리드를 셋팅한다.
            try
            {
                #region GRID SETTING

                _GridUtil.InitializeGrid(this.grid1, false, true, false, "", false);
                _GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE", "공장", true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
                _GridUtil.InitColumnUltraGrid(grid1, "CHECKCODE", "검사항목 코드", true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
                _GridUtil.InitColumnUltraGrid(grid1, "CHECKNAME", "검사항목 명", true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtil.InitColumnUltraGrid(grid1, "CHECKSPEC", "검사 스펙", true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, true);
                _GridUtil.InitColumnUltraGrid(grid1, "MEASURETYPE", "검사 방법", true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
                _GridUtil.InitColumnUltraGrid(grid1, "MAKER", "등록자", true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
                _GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE", "등록일시", true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
                _GridUtil.InitColumnUltraGrid(grid1, "EDITOR", "수정자", true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
                _GridUtil.InitColumnUltraGrid(grid1, "EDITDATE", "수정일시", true, GridColDataType_emu.VarChar, 130, 130, Infragistics.Win.HAlign.Left, true, false);
                //셋팅 내역 그리드와 바인딩                              
                _GridUtil.SetInitUltraGridBind(grid1); //셋팅 내역 그리드와 바인딩

                #endregion

                Common _Common = new Common();
                DataTable dtTemp = new DataTable();
                // PLANTCODE 기준 정보 가져와서 데이터 테이블에 추가. 
                dtTemp = _Common.Standard_CODE("PLANTCODE");
                // 데이터 테이블에 있는 데이터를 해당 콤보 박스에 추가.
                Common.FillComboboxMaster(this.cboPlantCode_H, dtTemp, dtTemp.Columns["CODE_ID"].ColumnName, dtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
                UltraGridUtil.SetComboUltraGrid(this.grid1, "PLANTCODE", dtTemp, "CODE_ID", "CODE_NAME");
            }

            catch (Exception ex)
            {
                ShowDialog(ex.Message, DC00_WinForm.DialogForm.DialogType.OK);
            }
        }
        #region < TOOL BAR AREA >
        public override void DoInquire()
        {
            base.DoInquire();
            DBHelper helper = new DBHelper(false);
            try
            {
                string sPlantcode = cboPlantCode_H.Value.ToString();
                string sCheckCode = txtCheckCode_H.Text.ToString();

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("19BM_CheckList_S1", CommandType.StoredProcedure
                                            , helper.CreateParameter("PLANTCODE", sPlantcode, DbType.String, ParameterDirection.Input)
                                            , helper.CreateParameter("CHECKCODE", sCheckCode, DbType.String, ParameterDirection.Input));
                this.ClosePrgForm();
                if (dtTemp.Rows.Count > 0)
                {
                    grid1.DataSource = dtTemp;
                    grid1.DataBinds(dtTemp);
                }
                else
                {
                    _GridUtil.Grid_Clear(grid1);
                    ShowDialog("조회할 데이터가 없습니다.", DC00_WinForm.DialogForm.DialogType.OK);
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
        public override void DoNew()
        {
            base.DoNew();
            this.grid1.InsertRow();
            this.grid1.ActiveRow.Cells["PLANTCODE"].Value = "1000";
            this.grid1.ActiveRow.Cells["MEASURETYPE"].Value = "판정";

            grid1.ActiveRow.Cells["MAKER"].Activation = Activation.NoEdit;
            grid1.ActiveRow.Cells["MAKEDATE"].Activation = Activation.NoEdit;
            grid1.ActiveRow.Cells["EDITDATE"].Activation = Activation.NoEdit;
            grid1.ActiveRow.Cells["EDITOR"].Activation = Activation.NoEdit;
        }
        public override void DoDelete()
        {
            if (ShowDialog("삭제하시겠습니까?", DC00_WinForm.DialogForm.DialogType.YESNO) == System.Windows.Forms.DialogResult.Cancel) return;
            base.DoDelete();
            this.grid1.DeleteRow(); // db에서 삭제하는 것이 아닌 사람 눈에 보이는걸 삭제하는 것.

        }
        public override void DoSave()
        {
            base.DoSave();
            DataTable dtTemp = new DataTable();
            dtTemp = grid1.chkChange();
            if (dtTemp.Rows.Count == 0) return;

            DBHelper helper = new DBHelper("", true);
            try
            {
                // 해당내역을 저장하시겠습니까?
                if (ShowDialog("해당 사항을 저장하시겠습니까?", DC00_WinForm.DialogForm.DialogType.YESNO) == System.Windows.Forms.DialogResult.Cancel)
                { return; }
                foreach (DataRow drrow in dtTemp.Rows)
                {
                    switch (drrow.RowState)
                    {
                        case DataRowState.Deleted:
                            drrow.RejectChanges();
                            helper.ExecuteNoneQuery("19BM_CheckList_D1", CommandType.StoredProcedure, helper.CreateParameter("PLANTCODE", Convert.ToString(drrow["PLANTCODE"]), DbType.String, ParameterDirection.Input),
                                helper.CreateParameter("CHECKCODE", Convert.ToString(drrow["CHECKCODE"]), DbType.String, ParameterDirection.Input));

                            break;
                        case DataRowState.Added:
                            //if (Convert.ToString(drrow["CHECKCODE"]) == string.Empty)
                            //{
                            //    this.ClosePrgForm();
                            //    this.ShowDialog("작업자 ID를 입력하세요.", DC00_WinForm.DialogForm.DialogType.OK);
                            //    return;
                            //}
                            helper.ExecuteNoneQuery("19BM_CheckList_I1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("PLANTCODE", Convert.ToString(drrow["PLANTCODE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("CHECKCODE", Convert.ToString(drrow["CHECKCODE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("CHECKNAME", Convert.ToString(drrow["CHECKNAME"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("CHECKSPEC", Convert.ToString(drrow["CHECKSPEC"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("MEASURETYPE", Convert.ToString(drrow["MEASURETYPE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("MAKER", LoginInfo.UserID, DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("MAKEDATE", Convert.ToString(drrow["MAKEDATE"]), DbType.String, ParameterDirection.Input)
                                                    );
                            break;
                        case DataRowState.Modified:
                            helper.ExecuteNoneQuery("19BM_CheckList_U1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("PLANTCODE", Convert.ToString(drrow["PLANTCODE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("CHECKCODE", Convert.ToString(drrow["CHECKCODE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("CHECKNAME", Convert.ToString(drrow["CHECKNAME"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("CHECKSPEC", Convert.ToString(drrow["CHECKSPEC"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("MEASURETYPE", Convert.ToString(drrow["MEASURETYPE"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("@EDITOR", LoginInfo.UserID, DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("EDITDATE", Convert.ToString(drrow["EDITDATE"]), DbType.String, ParameterDirection.Input)
                                                    );
                            break;
                    }
                }
                if (helper.RSCODE == "S")
                {
                    string s = helper.RSMSG;
                    helper.Commit();
                    this.ShowDialog("정상적으로 등록 되었습니다.", DC00_WinForm.DialogForm.DialogType.OK);
                    DoInquire();
                }
            }
            catch (Exception ex)
            {
                helper.Rollback();
            }
            finally
            {
                helper.Close();
            }
        }

        #endregion
    }
}