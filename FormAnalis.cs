using System;
using System.Windows.Forms;

namespace АВПЗ
{
    public partial class FormAnalis : Form
    {
        internal RiskManagement rs;

        public FormAnalis(RiskManagement _rs)
        {
            rs = _rs;
            InitializeComponent();
            CreateTable();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
        private void CreateTable()
        {
            for (int i = 0; i < rs.eventTechnical.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventTechnical[i].ToString(), rs.analisIdentifyRisk[0][i,0].ToString(), rs.analisIdentifyRisk[0][i, 1].ToString(), rs.analisIdentifyRisk[0][i, 2].ToString(), rs.analisIdentifyRisk[0][i, 3].ToString(), rs.analisIdentifyRisk[0][i, 4].ToString(), rs.analisIdentifyRisk[0][i, 5].ToString(), rs.analisIdentifyRisk[0][i, 6].ToString(), rs.analisIdentifyRisk[0][i, 7].ToString(), rs.analisIdentifyRisk[0][i, 8].ToString(), rs.analisIdentifyRisk[0][i, 9].ToString());
            }
            for (int i = 0; i < rs.eventValueRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventValueRisks[i].ToString(), rs.analisIdentifyRisk[1][i, 0].ToString(), rs.analisIdentifyRisk[1][i, 1].ToString(), rs.analisIdentifyRisk[1][i, 2].ToString(), rs.analisIdentifyRisk[1][i, 3].ToString(), rs.analisIdentifyRisk[1][i, 4].ToString(), rs.analisIdentifyRisk[1][i, 5].ToString(), rs.analisIdentifyRisk[1][i, 6].ToString(), rs.analisIdentifyRisk[1][i, 7].ToString(), rs.analisIdentifyRisk[1][i, 8].ToString(), rs.analisIdentifyRisk[1][i, 9].ToString());
            }
            for (int i = 0; i < rs.eventPlanRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventPlanRisks[i].ToString(), rs.analisIdentifyRisk[2][i, 0].ToString(), rs.analisIdentifyRisk[2][i, 1].ToString(), rs.analisIdentifyRisk[2][i, 2].ToString(), rs.analisIdentifyRisk[2][i, 3].ToString(), rs.analisIdentifyRisk[2][i, 4].ToString(), rs.analisIdentifyRisk[2][i, 5].ToString(), rs.analisIdentifyRisk[2][i, 6].ToString(), rs.analisIdentifyRisk[2][i, 7].ToString(), rs.analisIdentifyRisk[2][i, 8].ToString(), rs.analisIdentifyRisk[2][i, 9].ToString());
            }
            for (int i = 0; i < rs.eventProcesRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventProcesRisks[i].ToString(), rs.analisIdentifyRisk[3][i, 0].ToString(), rs.analisIdentifyRisk[3][i, 1].ToString(), rs.analisIdentifyRisk[3][i, 2].ToString(), rs.analisIdentifyRisk[3][i, 3].ToString(), rs.analisIdentifyRisk[3][i, 4].ToString(), rs.analisIdentifyRisk[3][i, 5].ToString(), rs.analisIdentifyRisk[3][i, 6].ToString(), rs.analisIdentifyRisk[3][i, 7].ToString(), rs.analisIdentifyRisk[3][i, 8].ToString(), rs.analisIdentifyRisk[3][i, 9].ToString());
            }
            dataGridViewSources.Rows[0].ReadOnly = true;
            dataGridViewSources.Rows[12].ReadOnly = true;
            dataGridViewSources.Rows[22].ReadOnly = true;
            dataGridViewSources.Rows[34].ReadOnly = true;
            //dataGridViewSources.Rows.Add("", "", rs.percentRisk[0].ToString());
            // ShowResult();
        }

        private void джерелаПоявиРизиківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getform = new ControlForms();
            getform.ActivateFormSources(rs);
        }
        private void потенційніРизиковіПодіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getform = new ControlForms();
            getform.ActivateFormPotentionalRiskEvents(rs);
        }

        private void FormAnalis_Activated(object sender, EventArgs e)
        {
            rs.FormAnalisProcess = Handle;
        }

        private void dataGridViewSources_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double numb;
            if (e.ColumnIndex > 0 && e.ColumnIndex < 10 && dataGridViewSources.RowCount > 1)
            {
                if (double.TryParse(dataGridViewSources[e.ColumnIndex, e.RowIndex].Value.ToString(), out numb) && numb >= 0 && numb <= 1)
                {
                    if (e.RowIndex < 12)
                    {
                        rs.analisIdentifyRisk[0][e.RowIndex, e.ColumnIndex - 1] = numb;
                        dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = numb.ToString();
                    }
                    else if (e.RowIndex < 22)
                    {
                        rs.analisIdentifyRisk[1][e.RowIndex - 12, e.ColumnIndex - 1] = numb;
                        dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = numb.ToString();
                    }
                    else if (e.RowIndex < 34)
                    {
                        rs.analisIdentifyRisk[2][e.RowIndex - 22, e.ColumnIndex - 1] = numb;
                        dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = numb.ToString();
                    }
                    else if (e.RowIndex < 51)
                    {
                        rs.analisIdentifyRisk[3][e.RowIndex - 34, e.ColumnIndex - 1] = numb;
                        dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = numb.ToString();
                    }
                } else
                {
                    dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = "0";
                }
                rs.CountPotentialRiskEvents();
                //ShowResult();
            }
        }
    }
}
