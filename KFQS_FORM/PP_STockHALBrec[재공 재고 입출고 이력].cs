using DC00_assm;
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
    public partial class PP_STockHALBrec : DC00_WinForm.BaseMDIChildForm
    {
        //그리드 셋팅 할 수 있도록 도와주는 함수 클래스
        UltraGridUtil _GridUtill = new UltraGridUtil();
        //공장 변수 입력
        //private sPlantCode = LoginInfo
        public PP_STockHALBrec()
        {
            InitializeComponent();
        }
        private void PP_STockHALBrec_Load(object sender, EventArgs e)
        {   // 그리드 셋팅하고 시작한다.
            try
            {
                #region ▶ GRID ◀

                _GridUtill.InitializeGrid(this.grid1, false, true, false, "", false);
                _GridUtill.InitColumnUltraGrid(grid1, "PLANTCODE"      , "공장"      , true, GridColDataType_emu.VarChar    , 120, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "LOTNO"          , "LOTNO"     , true, GridColDataType_emu.VarChar    , 140, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "ITEMCODE"       , "품목코드"  , true, GridColDataType_emu.VarChar    , 140, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "ITEMNAME"       , "품목명"    , true, GridColDataType_emu.VarChar    , 120, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "INOUTDATE"      , "입/출일자" , true, GridColDataType_emu.VarChar    , 150, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "WORKCENTERCODE" , "작업장"    , true, GridColDataType_emu.VarChar    , 120, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "INOUTCODE"      , "입출유형"  , true, GridColDataType_emu.VarChar    , 120, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "INOUTFLAG"      , "입출구분"  , true, GridColDataType_emu.VarChar    , 100, 120, Infragistics.Win.HAlign.Left , false, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "INOUTQTY"       , "입출수량"  , true, GridColDataType_emu.Double     , 100, 120, Infragistics.Win.HAlign.Right, false, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "BASEUNIT"       , "단위"      , true, GridColDataType_emu.VarChar    , 100, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "MAKER"          , "등록자"    , true, GridColDataType_emu.VarChar    , 100, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);
                _GridUtill.InitColumnUltraGrid(grid1, "MAKEDATE"       , "등록일시"  , true, GridColDataType_emu.DateTime24 , 160, 120, Infragistics.Win.HAlign.Left , true, false, null, null, null, null, null);

                //셋팅 내역을 바인딩
                _GridUtill.SetInitUltraGridBind(grid1);
                #endregion

                #region ▶ COMBOBOX ◀

                Common _Common = new Common();
                DataTable rtnDtTemp = _Common.Standard_CODE("PLANTCODE");  //사업장
                Common.FillComboboxMaster(this.cboPlantCode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
                UltraGridUtil.SetComboUltraGrid(this.grid1, "PlantCode", rtnDtTemp, "CODE_ID", "CODE_NAME");

                rtnDtTemp = _Common.Standard_CODE("UNITCODE");  //단위
                UltraGridUtil.SetComboUltraGrid(this.grid1, "BASEUNIT", rtnDtTemp, "CODE_ID", "CODE_NAME");

                rtnDtTemp = _Common.GET_Workcenter_Code();  //작업장
                UltraGridUtil.SetComboUltraGrid(this.grid1, "WORKCENTERCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

                rtnDtTemp = _Common.Standard_CODE("INOUTCODE");  //입출 유형
                UltraGridUtil.SetComboUltraGrid(this.grid1, "INOUTCODE", rtnDtTemp, "CODE_ID", "CODE_NAME");

                rtnDtTemp = _Common.Standard_CODE("INOUTTYPE");  //입출 구분
                UltraGridUtil.SetComboUltraGrid(this.grid1, "INOUTFLAG", rtnDtTemp, "CODE_ID", "CODE_NAME");

                rtnDtTemp = _Common.Get_ItemForCus("1000");  //품목 코드(품목 전체)
                Common.FillComboboxMaster(this.cboItemCode, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
                #endregion

                #region ▶ POPUP ◀

                #endregion

                //string sPlantCode = Convert.ToString(this.cboPlantCode.Value);
                //this.cboPlantCode.Value = "1000";

            }
            catch (Exception ex)
            {
                ShowDialog(ex.Message, DC00_WinForm.DialogForm.DialogType.OK);
            }
        }
     
        public override void DoInquire()
        {
            DBHelper helper = new DBHelper(false);
            try
            {
                string sPlantCode = Convert.ToString(cboPlantCode.Value);
                string sItemCode  = Convert.ToString(cboItemCode.Value);
                string sLotNo     = Convert.ToString(txtLOTNo.Text);
                string sStart     = string.Format("{0:yyyy-MM-dd}", dtpStart.Value);
                string sEnd       = string.Format("{0:yyyy-MM-dd}", dtpEnd.Value);

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("19PP_STockHALBrec_S1", CommandType.StoredProcedure
                                              , helper.CreateParameter("PLANTCODE" , sPlantCode , DbType.String, ParameterDirection.Input)
                                              , helper.CreateParameter("ITEMCODE"  , sItemCode  , DbType.String, ParameterDirection.Input)
                                              , helper.CreateParameter("LOTNO"     , sLotNo     , DbType.String, ParameterDirection.Input)
                                              , helper.CreateParameter("STARTDATE" , sStart     , DbType.String, ParameterDirection.Input)
                                              , helper.CreateParameter("ENDDATE"   , sEnd       , DbType.String, ParameterDirection.Input)
                                              );
                grid1.DataSource = dtTemp;
                grid1.DataBinds();
                this.ClosePrgForm();
            }


            catch (Exception ex)
            {
                ShowDialog(ex.Message, DC00_WinForm.DialogForm.DialogType.OK);
            }
            finally { helper.Close(); }

        }
      
        
    }
}
