using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DC00_assm;
using DC00_WinForm;



namespace DC_POPUP
{
    public partial class POP_ORDERNO : DC00_WinForm.BasePopupForm
    {
        string[] argument;

        #region [ 선언자 ]
        //그리드 객체 생성
        UltraGridUtil _GridUtil = new UltraGridUtil();

        //임시로 사용할 데이터테이블 생성
        DataTable _DtTemp = new DataTable();
        private string sWorkcenterCode = string.Empty;
        private string sWorkcenterName = string.Empty;


        #endregion

        public POP_ORDERNO(string WorkcenterCode, string WorkcenterName)
        {
            InitializeComponent();

            sWorkcenterCode = WorkcenterCode;
            sWorkcenterName = WorkcenterName;
            txtWorkcenterCode.Text = sWorkcenterCode;
            txtWorkcenterName.Text = sWorkcenterName;

            Common _Common = new Common();
            DataTable rtnDtTemp = _Common.Standard_CODE("PLANTCODE");  //사업장
            Common.FillComboboxMaster(this.cboPlantCode_H, rtnDtTemp, rtnDtTemp.Columns["CODE_ID"].ColumnName, rtnDtTemp.Columns["CODE_NAME"].ColumnName, "ALL", "");
            UltraGridUtil.SetComboUltraGrid(this.Grid1, "PlantCode", rtnDtTemp, "CODE_ID", "CODE_NAME");
        }

        private void POP_ORDERNO_Load(object sender, EventArgs e)
        {
            DataTable rtnDtTemp = new DataTable(); // return DataTable 공통
            Common _Common = new Common();
            _GridUtil.InitializeGrid(this.Grid1);

            _GridUtil.InitColumnUltraGrid(Grid1, "PlantCode",       "사업장",          false, GridColDataType_emu.VarChar,  90, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(Grid1, "WORKCENTERCODE",  "작업장코드",      false, GridColDataType_emu.VarChar, 110, 100, Infragistics.Win.HAlign.Center, true, false);
            _GridUtil.InitColumnUltraGrid(Grid1, "WORKCENTERNAME",  "작업장명",        false, GridColDataType_emu.VarChar, 130, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(Grid1, "ORDERNO",         "작업지시 번호",   false, GridColDataType_emu.VarChar, 140, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(Grid1, "ORDERDATE",       "작업지시 일자",   false, GridColDataType_emu.VarChar, 120, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(Grid1, "ITEMCODE",        "지시 품목",       false, GridColDataType_emu.VarChar, 120, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(Grid1, "ITEMNAME",        "지시 품명",       false, GridColDataType_emu.VarChar, 160, 100, Infragistics.Win.HAlign.Left,   true, false);
            _GridUtil.InitColumnUltraGrid(Grid1, "ORDERQTY",        "지시 수량",       false, GridColDataType_emu.Double,  100, 100, Infragistics.Win.HAlign.Right,  true, false);
            _GridUtil.SetInitUltraGridBind(Grid1);
            search();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            string RS_CODE    = string.Empty, RS_MSG = string.Empty;
            string sPlantCode      = Convert.ToString(cboPlantCode_H.Value);
            string sWorkcenterCode = txtWorkcenterCode.Text;
            string sWorkcenterNamr = txtWorkcenterName.Text;
            string sStartDate      = string.Format("{0:yyyy-MM-dd}", dtStartDate.Value);
            string sEndDate        = string.Format("{0:yyyy-MM-dd}", dtEnddate.Value);

            DataTable rtnDtTemp = new DataTable(); // return DataTable 공통
            DBHelper helper = new DBHelper(false);
            try
            {
                rtnDtTemp = helper.FillTable("00POP_OrderNo", CommandType.StoredProcedure
                , helper.CreateParameter("PLANTCODE",      sPlantCode,      DbType.String, ParameterDirection.Input)
                , helper.CreateParameter("WORKCENTERCODE", sWorkcenterCode, DbType.String, ParameterDirection.Input)
                , helper.CreateParameter("WORKCENTERNAME", sWorkcenterNamr, DbType.String, ParameterDirection.Input)
                , helper.CreateParameter("STARTDATE",      sStartDate,      DbType.String, ParameterDirection.Input)
                , helper.CreateParameter("ENDDATE",        sEndDate,        DbType.String, ParameterDirection.Input));

                if (rtnDtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("조회 할 작업지시가 없습니다.");
                }
                else
                {
                    this.Grid1.DataSource = rtnDtTemp;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                helper.Close();
            }
        }
        private void Grid1_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            this.Tag = Convert.ToString(this.Grid1.ActiveRow.Cells["ORDERNO"].Value);
            this.Close();
        }

  


    }
}
