using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMIS3.UIFramework.DataModel;
using AMIS3.UIFramework.FxExtension;
using AMIS3.UIFramework.UI;

namespace AMIS3.ZZ.AN.MU004
{
    public partial class Form1 : PopupBase
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnOk(object sender, EventArgs e)
        {

        }

        private async void NursCommonDtlCdSearch()
        {
            string keyword = nursCommonDtlCd.Text.ToString().Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                AMessageBox.ShowInstant(this, "검색어를 입력해주세요");
                return;
            }

            PreData pdata = new PreData();
            pdata["nursCommonDtlCd"] = nursCommonDtlCd.Text.ToString();

            AmcData amcData = new AmcData
            {
                preDatas = new PreDatas
                {
                    {"IPD", pdata }
                }
            };

            AmcData ad = await CommService.CallServiceAsync("SANMU044SR", amcData, this, LoadingType.Search);
            DataTable dt = ad.recordSets["ORS"].ToDataTable();

            if (dt.Rows.Count == 0)
            {
                AMessageBox.ShowInstant(this, "조회 데이터 없음");
            }

            gridRsamStat.DataSource = dt;

        }

        private void nursCommonDtlCd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                NursCommonDtlCdSearch();
            }
            else if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                AMessageBox.ShowInstant(this, "글자만 입력");
            }
            else
            {
                int maxLength = 4;
                if (nursCommonDtlCd.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    AMessageBox.ShowInstant(this, "최대" + maxLength + "자만 입력 가능");
                }
            }
        }

        private void btnNursCommonDtlCdSearch_Click(object sender, EventArgs e)
        {
            NursCommonDtlCdSearch();
        }

    }
}
