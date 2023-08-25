using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMIS3.UIFramework;
using AMIS3.UIFramework.DataModel;
using AMIS3.UIFramework.FxExtension;
using AMIS3.UIFramework.UI;
using AMIS3.ZZ.EP.CHLIB001;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace AMIS3.ZZ.AN.MU004
{
    public partial class VZZANMU004S : ScreenBase, ISmartToolbar
    {
        public List<ActionButtonItem> ActionButtonItems { get; set; } = new List<ActionButtonItem>();

        private AmcData resData = new AmcData();
        private AmcData reqData = new AmcData();
        private PreData param = new PreData();
        private PreDatas preDatas = new PreDatas();
        private RecordSets recordSets = new RecordSets();

        public VZZANMU004S()
        {
            InitializeComponent();    // 화면 오픈시 기본
            ActionBtnSetting();      // action버튼 셋팅

            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.HeaderText = "체크박스 열"; // 열 헤더 텍스트 설정
            //checkBoxColumn.Name = "CheckboxColumnName"; // 열 이름 설정
            //checkBoxColumn.DataPropertyName = "IsChecked"; // 데이터 바인딩할 열 이름 설정

            //gridView2.Columns.Add(); // DataGridView에 열 추가
            //gridView2.Columns["chk"].FieldName = "chk";
        }
        private void OnPrint()
        {

        }
        private void gridRsamStat_Click(object sender, EventArgs e)
        {
            InitGrid();
        }

        public void InitGrid()
        {         
            // 그리드 초기화 작업
        }
   
        private void aTableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aTableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        //private void AddCheckBoxColumn()
        //{
        //    GridView gridView = gridView2; // 해당하는 GridView 인스턴스로 설정해야 합니다.

        //    // CheckBox 열을 추가합니다.
        //    GridColumn checkBoxColumn = gridView.Columns.AddVisible("chk");
        //    checkBoxColumn.Caption = "Check Column";
        //    checkBoxColumn.FieldName = "IsChecked"; // 데이터 소스의 필드 이름

        //    // CheckBox 열에 사용될 CheckEdit를 설정합니다.
        //    RepositoryItemCheckEdit repositoryCheckEdit = new RepositoryItemCheckEdit();
        //    repositoryCheckEdit.ValueChecked = true; // 체크된 상태 값
        //    repositoryCheckEdit.ValueUnchecked = false; // 체크되지 않은 상태 값
        //    checkBoxColumn.ColumnEdit = repositoryCheckEdit;
        //}

        //private void ChangeCheckFocusedBehavior()
        //{
        //    GridView gridView = gridView2;

        //    gridView.OptionsBehavior.CheckFocusedDefault = false;
        //}

        #region ====== ActionButton 설정 ======
        private void ActionBtnSetting()
        {

            ActionButtonItems.Add(new ActionButtonItem()
            {
                Text = "행추가",
                Idx = 0,
                IsImportant = false,
                ClickAction = () => { OnAddAction(); },
                Name = "actAdd",

            });

            this.btnAction.Items = ActionButtonItems;

            ActionButtonItems.Add(new ActionButtonItem()
            {
                Text = "행삭제",
                Idx = 1,
                IsImportant = false,
                ClickAction = () => { OnDeleteAction(); },
                Name = "actDelete",
            });

            this.btnAction.Items = ActionButtonItems;

            ActionButtonItems.Add(new ActionButtonItem()
            {
                Text = "수정",
                Idx = 2,
                IsImportant = false,
                ClickAction = () => { OnUpdateAction(); },
                Name = "actUpdate",
            });
            this.btnAction.Items = ActionButtonItems;


            ActionButtonItems.Add(new ActionButtonItem()
            {
                Text = "저장",
                Idx = 3,
                IsImportant = false,
                ClickAction = () => { OnSaveAction(); },
                Name = "actSave",
            });
            this.btnAction.Items = ActionButtonItems;

        }

        #endregion

        // 환자번호 조회로 데이터 받아오는거
        public override void OnChangePatientInfo(string patno, long visitSn, PatientVO patInfo)
        {
            string patNm = base.MainPatient.patNm;
            string ageCnte = base.MainPatient.ageCnte;
            string aboBlty = base.MainPatient.aboBlty;
            this.patNm.Text = patNm;
            this.ageCnte.Text = ageCnte;
            this.aboBlty.Text = aboBlty;
        }

        #region ====== 의약품 검색 ======
        private async void MdctMediNmSearch()
        {
            PreData pdata = new PreData();
            pdata["mdctMediNm"] = txtmdctMediNm.Text.ToString();

            AmcData amcData = new AmcData
            {
                preDatas = new PreDatas
                {
                    {"IPD", pdata}
                }
            };

            AmcData ad = await CommService.CallServiceAsync("SANMU4001SR", amcData, this, LoadingType.Search);
            DataTable dt = ad.recordSets["ORS"].ToDataTable();

            if (dt.Rows.Count == 0)
            {
                AMessageBox.ShowInstant(this, "조회 데이터 없음");
            }

            gridmdctMediNm.DataSource = dt;

            GridColumn valdYnColumn = gridView2.Columns["valdYn"];
            if(valdYnColumn != null)
            {
                gridView2.ActiveFilterString = string.Format("[{0}] = 'Y'", valdYnColumn.FieldName);
            }
        }
        #endregion

        #region ====== 엔터키 글자만 입력 ======
        private void mdctMediNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                MdctMediNmSearch();
            }
            else if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                AMessageBox.ShowInstant(this, "글자만 입력합시다");
            }
            else
            {
                int maxLength = 6;
                if (txtmdctMediNm.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    AMessageBox.ShowInstant(this, "최대" + maxLength + "자만 입력 가능");
                }
            }
        }
        #endregion

        private void aTextEdit1_Click(object sender, EventArgs e)
        {
            Form1 newform1 = new Form1();
            DocumentService.ShowDialogPopup(newform1, Point.Empty);
            
        }

        private void btnMdctMediNm_Click(object sender, EventArgs e)
        {
            MdctMediNmSearch();
        }


        private void OnAddAction()
        {

            //if (gridmdctMediNm.DataSource as DataTable == null || (gridmdctMediNm.DataSource as DataTable).Columns.Count == 0)
            //{
            //    DataTable dt = new DataTable();
            //    foreach (GridColumn col in gridView2.Columns)
            //    {
            //        var name = col.FieldName.ToStringDefault();
            //        dt.Columns.Add(col.FieldName, col.ColumnType);
            //    }
            //    gridmdctMediNm.DataSource = dt;
            //}

            gridView2.AddNewRow();
        }


        private async void OnUpdateAction()
        {

            int rowHandle = gridView2.FocusedRowHandle; // 현재 포커스된 행의 핸들
            if (!IsChecked(rowHandle, gridView2))
                return;
          

            // 수정사항 조회
            BindingContext[(this.gridmdctMediNm.DataSource as DataTable)].EndCurrentEdit();
            DataTable dt = (this.gridmdctMediNm.DataSource as DataTable).GetChanges();

            if (dt == null)
            {
                AMessageBox.ShowInstant("변경된 내용이 없습니다.");
                return;
            }

            DataTable updateDt = gridmdctMediNm.DataSource as DataTable;
            DataTable chDt = updateDt.GetChanges();
            DataTable selectDt = updateDt.Clone();

            // 체크한거만 받아서 수정하기
            for (int i = 0; i < gridView2.GetSelectedRows().Length; i++)
            {
                DataRow dtRow = updateDt.NewRow();
                dtRow = updateDt.Rows[gridView2.GetSelectedRows()[i]];
                selectDt.ImportRow(dtRow);  // 데이터를 복사
            }

            preDatas["IPD"] = null;
            recordSets["IRS"] = dt.ToRecordSet(true);

            reqData.preDatas = preDatas;
            reqData.recordSets = recordSets;

            

            resData = await CommService.CallServiceAsync("SANMU4004SR", reqData, this, LoadingType.BlockSave, false);

            if (resData.IsFail)
            {
                AMessageBox.ShowInstant(this, "실패");
                return;
            }

            AMessageBox.ShowInstant(this, "수정 완료");
        }

        private async void OnDeleteAction()
        {
            int rowHandle = gridView2.FocusedRowHandle; // 현재 포커스된 행의 핸들
            if (!IsChecked(rowHandle, gridView2))
                return;
            BindingContext[(this.gridmdctMediNm.DataSource as DataTable)].EndCurrentEdit();
            DataTable dt = (this.gridmdctMediNm.DataSource as DataTable).GetChanges();

            //if (gridView2.RowCount == 0)
            //{
            //    AMessageBox.ShowInstant("삭제 내역이 없습니다.");
            //    return;
            //}

            DataTable deleteDt = gridmdctMediNm.DataSource as DataTable;
            DataTable selectDt = deleteDt.Clone();

            for (int i = 0; i < gridView2.GetSelectedRows().Length; i++)
            {
                DataRow dtRow = deleteDt.NewRow();
                dtRow = deleteDt.Rows[gridView2.GetSelectedRows()[i]];
                selectDt.ImportRow(dtRow);  // 데이터를 복사
            }

            GridColumn valdYn = gridView2.Columns["valdYn"]; // "valdYn"은 유효 여부 컬럼의 필드 이름입니다.
            
            if (valdYn != null)
            {
                for (int i = 0; i < gridView2.GetSelectedRows().Length; i++)
                {
                    DataRow row = gridView2.GetDataRow(gridView2.GetSelectedRows()[i]);
                    row[valdYn.FieldName] = "N";
                }
            }

            gridView2.UpdateCurrentRow();

            preDatas["IPD"] = null;
            recordSets["IRS"] = dt.ToRecordSet(true);

            reqData.preDatas = preDatas;
            reqData.recordSets = recordSets;

            resData = await CommService.CallServiceAsync("SANMU4003SR", reqData, this, LoadingType.BlockSave, false);
            resData = await CommService.CallServiceAsync("SANMU4004SR", reqData, this, LoadingType.BlockSave, false);

            if (resData.IsFail)
            {
                AMessageBox.ShowInstant(this, "실패");
                return;
            }
            AMessageBox.ShowInstant(this, "삭제 완료");
        }

        private async void OnSaveAction()
        {

            if (!saveActionCheck())
                return;
            int rowHandle = gridView2.FocusedRowHandle; // 현재 포커스된 행의 핸들
            if (!IsChecked(rowHandle, gridView2))
                return;
            if(rowHandle == 0)
            {
                AMessageBox.ShowInstant("저장할꺼 선택");
                return;
            }
            AMessageBox.Show(this, "저장", "저장하시겠습니까?", async (result) =>
            {
                if (result.ResultStatus == DialogResult.Yes)
                {
                    try
                    {
                        DataTable dtSave = gridmdctMediNm.DataSource as DataTable;
                        dtSave = dtSave.GetChanges();

                        AmcData amcData = new AmcData
                        {
                            recordSets = new RecordSets { { "IPD", dtSave.ToRecordSet(true) } }
                        };

                        AmcData amcMainData = await CommService.CallServiceAsync("SANMU4002SR", amcData, null, LoadingType.BlockSave, false);

                        AMessageBox.ShowInstant(this, amcMainData.header.message);

                        //MdctMediNmSearch();
                    }
                    catch (Exception ex)
                    {
                        ExceptionMessageCA.Show(this, ex);
                    }
                }
            }, AMessageType.OK, MessageBoxButtons.YesNo);
        }

        private bool saveActionCheck()
        {
            DataTable dtSave = gridmdctMediNm.DataSource as DataTable;
            dtSave = dtSave.GetChanges();

            if (dtSave == null || dtSave.Rows.Count == 0)
            {
                AMessageBox.ShowInstant("저장할 내역이 없습니다.");
                return false;
            }

            return true;
        }

        //바인딩되는 데이터 타입과 맞는 ValueChecked , ValueUnchecked값을 설정하면 된다.
        //private bool IsChecked()
        //{
        //    GridView gridView = gridView2; // 해당하는 GridView 인스턴스로 설정해야 합니다.
        //    GridColumn chkColumn = gridView.Columns["chk"]; // "chk"는 체크박스 컬럼의 필드 이름입니다.

        //    if (chkColumn == null)
        //    {
        //        //int rowIndex = gridView.FocusedRowHandle;
        //        //bool isChecked = (bool)gridView.GetRowCellValue(rowIndex, chkColumn);

        //        AMessageBox.ShowInstant("체크해주세요");
        //        return false;
        //    }

        //    return true;
        //}

        //private bool IsChecked(int rowHandle, GridView gridView)
        //{
        //    if (rowHandle >= 0)
        //    {
        //        bool isSelected = gridView.IsRowSelected(rowHandle);
        //        return isSelected;
        //    }

        //    return false;

        //}

        private bool IsChecked(int rowHandle, GridView gridView)
        {
            if (rowHandle >= 0)
            {
                bool isSelected = gridView.IsRowSelected(rowHandle);
                if (!isSelected)
                {
                    AMessageBox.ShowInstant("체크하세요");
                    return false;
                }
            }

            return true;

        }

        //private void ischek()
        //{
        //    GridView gridView = gridView2;
        //    GridColumn chkColumn = gridView.Columns["chk"];

        //    if (chkColumn != null)
        //    {
        //        chkColumn.OptionsColumn.AllowFocus = false;
        //    }
        //}
    }
}
