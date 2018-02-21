using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace АВПЗ
{
    public partial class FormSources : Form
    {
        internal string nameOfTable;
        internal RiskManagement rs;
        public FormSources(RiskManagement _rs)
        {
            rs = _rs;
            rs = new RiskManagement();
            InitializeComponent();

            rs.CountIdentyfyRisk();
            //nameOfTable = nameOfT;
            CreateTable();
        }

        private void CreateTable()
        {
            for (int i = 0; i < rs.technical.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.technical[i].ToString(), rs.IdentifyRisk[0][i].ToString());
            }
            for (int i = 0; i < rs.valueRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.valueRisks[i].ToString(), rs.IdentifyRisk[1][i].ToString());
            }
            for (int i = 0; i < rs.planRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.planRisks[i].ToString(), rs.IdentifyRisk[2][i].ToString());
            }
            for (int i = 0; i < rs.procesRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.procesRisks[i].ToString(), rs.IdentifyRisk[3][i].ToString());
            }
            dataGridViewSources.Rows.Add("Результат", "", rs.percentRisk[0].ToString());
            ShowResult();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSources_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewSources_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridViewSources.RowCount > 1)
            {
                if (Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value) != 0 && e.RowIndex!= 0 && e.RowIndex != 8 && e.RowIndex != 12 && e.RowIndex != 16 && e.RowIndex != 22)
                    dataGridViewSources[1, e.RowIndex].Value = "1";
                if (e.RowIndex < 8)
                {
                    rs.IdentifyRisk[0][e.RowIndex] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
                }
                else if (e.RowIndex < 12)
                {
                    rs.IdentifyRisk[1][e.RowIndex - 8] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
                }
                else if (e.RowIndex < 16)
                {
                    rs.IdentifyRisk[2][e.RowIndex - 12] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
                }
                else if (e.RowIndex < 22)
                {
                    rs.IdentifyRisk[3][e.RowIndex - 16] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
                }

                rs.CountIdentyfyRisk();
                ShowResult();
            }
        }

        private void ShowResult()
        {
            string specifier = "P";
            CultureInfo culture = CultureInfo.InvariantCulture;

            dataGridViewSources[1, 0].Value = rs.IdentifyRisk[0][0].ToString();
            dataGridViewSources[1, 8].Value = rs.IdentifyRisk[1][0].ToString();
            dataGridViewSources[1, 12].Value = rs.IdentifyRisk[2][0].ToString();
            dataGridViewSources[1, 16].Value = rs.IdentifyRisk[3][0].ToString();
            dataGridViewSources[1, 22].Value = (rs.IdentifyRisk[0][0] + rs.IdentifyRisk[1][0] + rs.IdentifyRisk[2][0] + rs.IdentifyRisk[3][0]).ToString();
          
            dataGridViewSources[2, 0].Value = rs.percentRisk[1].ToString(specifier, culture);
            dataGridViewSources[2, 8].Value = rs.percentRisk[2].ToString(specifier, culture);
            dataGridViewSources[2, 12].Value = rs.percentRisk[3].ToString(specifier, culture);
            dataGridViewSources[2, 16].Value = rs.percentRisk[4].ToString(specifier, culture);
            dataGridViewSources[2, 22].Value = rs.percentRisk[0].ToString(specifier, culture);

            var font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridViewSources[0, 0].Style.Font = font;
            dataGridViewSources[0, 8].Style.Font = font;
            dataGridViewSources[0, 12].Style.Font = font;
            dataGridViewSources[0, 16].Style.Font = font;
            dataGridViewSources[0, 22].Style.Font = font;
        }

        private void джерелаПоявиРизиківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getform = new ControlForms();
            getform.ActivateFormPotentionalRiskEvents(rs);
        }

        private void аналізРизиківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getform = new ControlForms();
            getform.ActivateFormAnalis(rs);
        }

        private void FormSources_Activated(object sender, EventArgs e)
        {
            rs.FormSourcesProcess = Handle;
        }
    }
}
