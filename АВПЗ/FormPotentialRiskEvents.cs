using RiskManagementLibrary;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace АВПЗ
{
    public partial class FormPotentialRiskEvents : Form
    {
        internal RiskManagementLib rs;

        public FormPotentialRiskEvents(RiskManagementLib _rs)
        {
            rs = _rs;
            InitializeComponent();

            rs.CountPotentialRiskEvents();
            CreateTable();

        }

        private void CreateTable()
        {
            for (int i = 0; i < rs.eventTechnical.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventTechnical[i].ToString(), rs.eventIdentifyRisk[0][i].ToString());
            }
            for (int i = 0; i < rs.eventValueRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventValueRisks[i].ToString(), rs.eventIdentifyRisk[1][i].ToString());
            }
            for (int i = 0; i < rs.eventPlanRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventPlanRisks[i].ToString(), rs.eventIdentifyRisk[2][i].ToString());
            }
            for (int i = 0; i < rs.eventProcesRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventProcesRisks[i].ToString(), rs.eventIdentifyRisk[3][i].ToString());
            }
            dataGridViewSources.Rows.Add("Результат", "", rs.eventPercentRisk[0].ToString());
            for (int i = 0; i < dataGridViewSources.Columns.Count; i++)
            {
                dataGridViewSources.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            ShowResult();
        }

        private void ShowResult()
        {
            string specifier = "P";
            CultureInfo culture = CultureInfo.InvariantCulture;

            dataGridViewSources[1, 0].Value = rs.eventIdentifyRisk[0][0].ToString();
            dataGridViewSources[1, 12].Value = rs.eventIdentifyRisk[1][0].ToString();
            dataGridViewSources[1, 22].Value = rs.eventIdentifyRisk[2][0].ToString();
            dataGridViewSources[1, 34].Value = rs.eventIdentifyRisk[3][0].ToString();
            dataGridViewSources[1, 51].Value = (rs.eventIdentifyRisk[0][0] + rs.eventIdentifyRisk[1][0] + rs.eventIdentifyRisk[2][0] + rs.eventIdentifyRisk[3][0]).ToString();

            dataGridViewSources[2, 0].Value = rs.eventPercentRisk[1].ToString(specifier, culture);
            dataGridViewSources[2, 12].Value = rs.eventPercentRisk[2].ToString(specifier, culture);
            dataGridViewSources[2, 22].Value = rs.eventPercentRisk[3].ToString(specifier, culture);
            dataGridViewSources[2, 34].Value = rs.eventPercentRisk[4].ToString(specifier, culture);
            dataGridViewSources[2, 51].Value = rs.eventPercentRisk[0].ToString(specifier, culture);

            var font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridViewSources[0, 0].Style.Font = font;
            dataGridViewSources[0, 12].Style.Font = font;
            dataGridViewSources[0, 22].Style.Font = font;
            dataGridViewSources[0, 34].Style.Font = font;
            dataGridViewSources[0, 51].Style.Font = font;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ConnectServer.SendToServer(rs))
            {
                MessageBox.Show("Зміни збережено!");
            }
        }

        //private void dataGridViewSources_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 1 && dataGridViewSources.RowCount > 1)
        //    {
        //        if (Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value) != 0 && e.RowIndex != 0 && e.RowIndex != 8 && e.RowIndex != 12 && e.RowIndex != 16 && e.RowIndex != 22)
        //            dataGridViewSources[1, e.RowIndex].Value = "1";
        //        if (e.RowIndex < 12)
        //        {
        //            rs.eventIdentifyRisk[0][e.RowIndex] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
        //        }
        //        else if (e.RowIndex < 22)
        //        {
        //            rs.eventIdentifyRisk[1][e.RowIndex - 12] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
        //        }
        //        else if (e.RowIndex < 34)
        //        {
        //            rs.eventIdentifyRisk[2][e.RowIndex - 22] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
        //        }
        //        else if (e.RowIndex < 51)
        //        {
        //            rs.eventIdentifyRisk[3][e.RowIndex - 34] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
        //        }

        //        rs.CountPotentialRiskEvents();
        //        ShowResult();
        //    }
        //}

        private void dataGridViewSources1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridViewSources.RowCount > 1)
            {
                if (Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value) != 0 && e.RowIndex != 0 && e.RowIndex != 12 && e.RowIndex != 22 && e.RowIndex != 34 && e.RowIndex != 51)
                    dataGridViewSources[1, e.RowIndex].Value = "1";
                if (e.RowIndex < 12)
                {
                    rs.eventIdentifyRisk[0][e.RowIndex] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
                }
                else if (e.RowIndex < 22)
                {
                    CheckCorrect(e.RowIndex);
                    rs.eventIdentifyRisk[1][e.RowIndex - 12] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);                    
                }
                else if (e.RowIndex < 34)
                {
                    CheckCorrect(e.RowIndex);
                    rs.eventIdentifyRisk[2][e.RowIndex - 22] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
                }
                else if (e.RowIndex < 51)
                {
                    CheckCorrect(e.RowIndex);
                    rs.eventIdentifyRisk[3][e.RowIndex - 34] = Convert.ToInt32(dataGridViewSources[1, e.RowIndex].Value);
                }

                rs.CountPotentialRiskEvents();
                ShowResult();
            }
        }

        private void CheckCorrect(int index)
        {
            if(index == 13 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index + 1].Value = "0";
                rs.eventIdentifyRisk[1][index - 11] = 0;
            }
            if (index == 14 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index - 1].Value = "0";
                rs.eventIdentifyRisk[1][index - 13] = 0;
            }

            if (index == 17 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index + 1].Value = "0";
                rs.eventIdentifyRisk[1][index - 11] = 0;
            }
            if (index == 18 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index - 1].Value = "0";
                rs.eventIdentifyRisk[1][index - 13] = 0;
            }

            if (index == 30 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index + 1].Value = "0";
                rs.eventIdentifyRisk[2][index - 21] = 0;
            }
            if (index == 31 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index - 1].Value = "0";
                rs.eventIdentifyRisk[2][index - 23] = 0;
            }

            if (index == 28 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index + 1].Value = "0";
                rs.eventIdentifyRisk[2][index - 21] = 0;
            }
            if (index == 29 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index - 1].Value = "0";
                rs.eventIdentifyRisk[2][index - 23] = 0;
            }

            if (index == 47 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index + 1].Value = "0";
                rs.eventIdentifyRisk[3][index - 33] = 0;
            }
            if (index == 48 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index - 1].Value = "0";
                rs.eventIdentifyRisk[3][index - 35] = 0;
            }
            if (index == 45 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index + 1].Value = "0";
                rs.eventIdentifyRisk[3][index - 33] = 0;
            }
            if (index == 46 && Convert.ToInt32(dataGridViewSources[1, index].Value) == 1)
            {
                dataGridViewSources[1, index - 1].Value = "0";
                rs.eventIdentifyRisk[3][index - 35] = 0;
            }
        }

        private void джерелаПоявиРизиківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getform = new ControlForms();
            getform.ActivateFormSources(rs);
        }

        private void аналізРизиківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getform = new ControlForms();
            getform.ActivateFormAnalis(rs);
        }

        private void FormPotentialRiskEvents_Activated(object sender, EventArgs e)
        {
            rs.FormPotentialRiskEventsProcess = Handle;
        }

        private void FormPotentialRiskEvents_Load(object sender, EventArgs e)
        {
            if(rs.number!=0)
               dataGridViewSources.Columns[1].ReadOnly = true;          
        }
    }
}
