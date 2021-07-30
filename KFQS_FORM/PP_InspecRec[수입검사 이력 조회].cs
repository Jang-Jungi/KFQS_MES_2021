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
using System.Windows.Forms.VisualStyles;

namespace KFQS_Form
{
    public partial class PP_InspecRec : DC00_WinForm.BaseMDIChildForm
    {
        #region <MEMBER AREA>

        DataTable table = new DataTable();
        DataTable rtnDtTemp = new DataTable();
        UltraGridUtil _GridUtil = new UltraGridUtil();
        #endregion

        #region < CONSTRUCTOR >

        public PP_InspecRec()
        {
            InitializeComponent();
        }
        #endregion

        #region  PP_InspecRec
        private void PP_InspecRec_Load(object sender, EventArgs e)
        {
            //그리드 객체 생성
            #region 

            _GridUtil.InitializeGrid(this.grid2, false, true, false, "", false);
            _GridUtil.InitColumnUltraGrid(grid2, "PLANTCODE",  "공장",           true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "ITEMCDOE",   "품목",           true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "ITEMNAME",   "품명",           true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "INSPNO",     "수입검사 번호",  true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "LOTNO",      "LOTNO",          true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "STOCKQTY",   "수량",           true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "WHCODE",     "창고",           true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "INSPRESULT", "최종 검사 결과", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "MAKER",      "생성자",         true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.InitColumnUltraGrid(grid2, "MAKEDATE", " 생성일시",        true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left, true, false);
            _GridUtil.SetInitUltraGridBind(grid2);
            #endregion

            _GridUtil.InitializeGrid(this.grid3, false, true, false, "", false);
            _GridUtil.InitColumnUltraGrid(grid3, "SHIPSEQ",      "검사순번",  true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Center, true, false);
            _GridUtil.InitColumnUltraGrid(grid3, "ITEMCODE",     "품목",      true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(grid3, "ITEMNAME",     "품명",      true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(grid3, "LOTNO",        "LOTNO",     true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(grid3, "INSP",         "검사항목",  true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(grid3, "INSPRESULT_B", "검사 결과", true, GridColDataType_emu.VarChar, 100, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.SetInitUltraGridBind(grid3);

            #region 콤보박스
            Common _Common = new Common();
            DataTable rtnDtTemp = _Common.Standard_CODE("PLANTCODE");    //공장
            Common.FillComboboxMaster(this.cboPlantCode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
            UltraGridUtil.SetComboUltraGrid(this.grid2, "PLANTCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

            rtnDtTemp = _Common.Standard_CODE("INSPRESULT"); // 합/불여부
            Common.FillComboboxMaster(this.cboINSPRESULT, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
            UltraGridUtil.SetComboUltraGrid(this.grid2, "INSPRESULT",   rtnDtTemp, "CODE_ID", "CODE_NAME");
            UltraGridUtil.SetComboUltraGrid(this.grid3, "INSPRESULT_B", rtnDtTemp, "CODE_ID", "CODE_NAME");


            #region 팝업
            BizTextBoxManager btbManager = new BizTextBoxManager();
            btbManager.PopUpAdd(txtItemCode_H, txtItemName_H, "ITEM_MASTER", new object[] { cboPlantCode, "FERT", "KFQS" + "", "" });
            #endregion

            this.cboPlantCode.Value = "1000";
            dtStartDate.Value = string.Format("{0:yyyy-MM-01}", DateTime.Now);
            #endregion
        }
        #endregion  PP_InspecRec_Load

        #region <DoInquire>
        public override void DoInquire()
        {


            DBHelper helper = new DBHelper(false);

            try
            {
                this._GridUtil.Grid_Clear(grid2);
                this._GridUtil.Grid_Clear(grid3);


                string sPlantCode = Convert.ToString(cboPlantCode.Value);
                string sItemCode  = Convert.ToString(txtItemCode_H.Text);
                string sINFlag    = Convert.ToString(cboINSPRESULT.Value); //왜 Value로 해야하지?? Text로 하면 [Y] 합격 이런식이로 뜨는데.....
                string sStartDate = string.Format("{0:yyyy-MM-dd}", dtStartDate.Value);
                string sEndtDate  = string.Format("{0:yyyy-MM-dd}", dtEnddate.Value);

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("19PP_InspecRec_S1", CommandType.StoredProcedure
                                              , helper.CreateParameter("PLANTCODE",  sPlantCode, DbType.String, ParameterDirection.Input)
                                              , helper.CreateParameter("ITEMCODE",   sItemCode, DbType.String, ParameterDirection.Input)
                                              , helper.CreateParameter("STARTDATE",  sStartDate, DbType.String, ParameterDirection.Input)
                                              , helper.CreateParameter("ENDDATE",    sEndtDate, DbType.String, ParameterDirection.Input)
                                              , helper.CreateParameter("INSPRESULT", sINFlag, DbType.String, ParameterDirection.Input)
                                              );
                this.ClosePrgForm();

                grid2.DataSource = dtTemp;
                grid2.DataBinds(dtTemp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
        }
        #endregion

        private void grid2_AfterRowActivate(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper(false);

            try
            {
                string sPlantCode = Convert.ToString(grid2.ActiveRow.Cells["PLANTCODE"].Value);
                string sInspNo   = Convert.ToString(grid2.ActiveRow.Cells["INSPNO"].Value);

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("19PP_InspecRec_S2", CommandType.StoredProcedure
                                              , helper.CreateParameter("PLANTCODE", sPlantCode, DbType.String, ParameterDirection.Input)
                                              , helper.CreateParameter("INSPNO",    sInspNo, DbType.String, ParameterDirection.Input)
                                              );
                this.ClosePrgForm();
                grid3.DataSource = dtTemp;
                grid3.DataBinds(dtTemp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
        }
    }
}

