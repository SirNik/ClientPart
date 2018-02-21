using RiskManagementLibrary;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace АВПЗ
{
    public partial class FormAnalis : Form
    {
        internal RiskManagementLib rs;

        public bool[] TableFull = new bool[]{ false, false,false};

        public int tempValue { get; private set; }

        public FormAnalis(RiskManagementLib _rs)
        {
            rs = _rs;
            InitializeComponent();
            CreateTable();
            CreateTableRating();
            CreateTablePossibility();
            CreateTableExperts();
        }

        private void CreateTableExperts()
        {
            dataGridViewExperts.Rows.Add(rs.eventTechnical[0].ToString(), rs.analisIdentifyRisk[0][0, 0].ToString(), rs.analisIdentifyRisk[0][0, 1].ToString(), rs.analisIdentifyRisk[0][0, 2].ToString(), rs.analisIdentifyRisk[0][0, 3].ToString(), rs.analisIdentifyRisk[0][0, 4].ToString(), rs.analisIdentifyRisk[0][0, 5].ToString(), rs.analisIdentifyRisk[0][0, 6].ToString(), rs.analisIdentifyRisk[0][0, 7].ToString(), rs.analisIdentifyRisk[0][0, 8].ToString(), rs.analisIdentifyRisk[0][0, 9].ToString());
            dataGridViewExperts.Rows.Add(rs.eventValueRisks[0].ToString(), rs.analisIdentifyRisk[1][0, 0].ToString(), rs.analisIdentifyRisk[1][0, 1].ToString(), rs.analisIdentifyRisk[1][0, 2].ToString(), rs.analisIdentifyRisk[1][0, 3].ToString(), rs.analisIdentifyRisk[1][0, 4].ToString(), rs.analisIdentifyRisk[1][0, 5].ToString(), rs.analisIdentifyRisk[1][0, 6].ToString(), rs.analisIdentifyRisk[1][0, 7].ToString(), rs.analisIdentifyRisk[1][0, 8].ToString(), rs.analisIdentifyRisk[1][0, 9].ToString());
            dataGridViewExperts.Rows.Add(rs.eventPlanRisks[0].ToString(), rs.analisIdentifyRisk[2][0, 0].ToString(), rs.analisIdentifyRisk[2][0, 1].ToString(), rs.analisIdentifyRisk[2][0, 2].ToString(), rs.analisIdentifyRisk[2][0, 3].ToString(), rs.analisIdentifyRisk[2][0, 4].ToString(), rs.analisIdentifyRisk[2][0, 5].ToString(), rs.analisIdentifyRisk[2][0, 6].ToString(), rs.analisIdentifyRisk[2][0, 7].ToString(), rs.analisIdentifyRisk[2][0, 8].ToString(), rs.analisIdentifyRisk[2][0, 9].ToString());
            dataGridViewExperts.Rows.Add(rs.eventProcesRisks[0].ToString(), rs.analisIdentifyRisk[3][0, 0].ToString(), rs.analisIdentifyRisk[3][0, 1].ToString(), rs.analisIdentifyRisk[3][0, 2].ToString(), rs.analisIdentifyRisk[3][0, 3].ToString(), rs.analisIdentifyRisk[3][0, 4].ToString(), rs.analisIdentifyRisk[3][0, 5].ToString(), rs.analisIdentifyRisk[3][0, 6].ToString(), rs.analisIdentifyRisk[3][0, 7].ToString(), rs.analisIdentifyRisk[3][0, 8].ToString(), rs.analisIdentifyRisk[3][0, 9].ToString());
            for (int i = 0; i < dataGridViewExperts.Columns.Count; i++)
            {
                dataGridViewExperts.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void CreateTablePossibility()
        {
            var add = 0;
            var value = "";
            for (int k = 0; k < 4; k++)
            {
                if (k == 1) add = 12; add = (k == 2) ? 22 : add; add = (k == 3) ? 34 : add;
                for (int i = 1 + add; i < rs.eventIdentifyRisk[k].Length + add; i++)
                {
                    if (rs.analisRiskWithValidity[k][i - add, 10] < 0.1) value = "Дуже низька";
                    else if (rs.analisRiskWithValidity[k][i - add, 10] < 0.25) value = "Низька";
                    else if(rs.analisRiskWithValidity[k][i - add, 10] < 0.5) value = "Середня";
                    else if(rs.analisRiskWithValidity[k][i - add, 10] < 0.75) value = "Висока";
                    else if(rs.analisRiskWithValidity[k][i - add, 10] < 1) value = "Дуже висока";
                    dataGridRating[13,i].Value = value;
                }
            }

            for (int i = 0; i < dataGridRating.Columns.Count; i++)
            {
                dataGridRating.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(ConnectServer.SendToServer(rs))
            {
                MessageBox.Show("Зміни збережено!");
            }
        }
        private void CreateTable()
        {
            rs.CountAnalisIdentifyRisk();
            for (int i = 0; i < rs.eventTechnical.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventTechnical[i].ToString(), rs.eventIdentifyRisk[0][i].ToString(), rs.analisIdentifyRisk[0][i,0].ToString("0.00"), rs.analisIdentifyRisk[0][i, 1].ToString("0.00"), rs.analisIdentifyRisk[0][i, 2].ToString("0.00"), rs.analisIdentifyRisk[0][i, 3].ToString("0.00"), rs.analisIdentifyRisk[0][i, 4].ToString("0.00"), rs.analisIdentifyRisk[0][i, 5].ToString("0.00"), rs.analisIdentifyRisk[0][i, 6].ToString("0.00"), rs.analisIdentifyRisk[0][i, 7].ToString("0.00"), rs.analisIdentifyRisk[0][i, 8].ToString("0.00"), rs.analisIdentifyRisk[0][i, 9].ToString("0.00"));
            }
            for (int i = 0; i < rs.eventValueRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventValueRisks[i].ToString(), rs.eventIdentifyRisk[1][i].ToString(), rs.analisIdentifyRisk[1][i, 0].ToString("0.00"), rs.analisIdentifyRisk[1][i, 1].ToString("0.00"), rs.analisIdentifyRisk[1][i, 2].ToString("0.00"), rs.analisIdentifyRisk[1][i, 3].ToString("0.00"), rs.analisIdentifyRisk[1][i, 4].ToString("0.00"), rs.analisIdentifyRisk[1][i, 5].ToString("0.00"), rs.analisIdentifyRisk[1][i, 6].ToString("0.00"), rs.analisIdentifyRisk[1][i, 7].ToString("0.00"), rs.analisIdentifyRisk[1][i, 8].ToString("0.00"), rs.analisIdentifyRisk[1][i, 9].ToString("0.00"));
            }
            for (int i = 0; i < rs.eventPlanRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventPlanRisks[i].ToString(), rs.eventIdentifyRisk[2][i].ToString(), rs.analisIdentifyRisk[2][i, 0].ToString("0.00"), rs.analisIdentifyRisk[2][i, 1].ToString("0.00"), rs.analisIdentifyRisk[2][i, 2].ToString("0.00"), rs.analisIdentifyRisk[2][i, 3].ToString("0.00"), rs.analisIdentifyRisk[2][i, 4].ToString("0.00"), rs.analisIdentifyRisk[2][i, 5].ToString("0.00"), rs.analisIdentifyRisk[2][i, 6].ToString("0.00"), rs.analisIdentifyRisk[2][i, 7].ToString("0.00"), rs.analisIdentifyRisk[2][i, 8].ToString("0.00"), rs.analisIdentifyRisk[2][i, 9].ToString("0.00"));
            }
            for (int i = 0; i < rs.eventProcesRisks.Length; i++)
            {
                dataGridViewSources.Rows.Add(rs.eventProcesRisks[i].ToString(), rs.eventIdentifyRisk[3][i].ToString(), rs.analisIdentifyRisk[3][i, 0].ToString("0.00"), rs.analisIdentifyRisk[3][i, 1].ToString("0.00"), rs.analisIdentifyRisk[3][i, 2].ToString("0.00"), rs.analisIdentifyRisk[3][i, 3].ToString("0.00"), rs.analisIdentifyRisk[3][i, 4].ToString("0.00"), rs.analisIdentifyRisk[3][i, 5].ToString("0.00"), rs.analisIdentifyRisk[3][i, 6].ToString("0.00"), rs.analisIdentifyRisk[3][i, 7].ToString("0.00"), rs.analisIdentifyRisk[3][i, 8].ToString("0.00"), rs.analisIdentifyRisk[3][i, 9].ToString("0.00"));
            }
            dataGridViewSources.Rows[0].ReadOnly = true;
            dataGridViewSources.Rows[12].ReadOnly = true;
            dataGridViewSources.Rows[22].ReadOnly = true;
            dataGridViewSources.Rows[34].ReadOnly = true;
            for (int i = 0; i < dataGridViewSources.Columns.Count; i++)
            {
                dataGridViewSources.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }         
            //dataGridViewSources.Rows.Add("", "", rs.percentRisk[0].ToString("0.00"));
            ShowResult();
        }
        private void ShowResult()
        {
            string specifier = "P";
            var add = 0;
            var font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            CultureInfo culture = CultureInfo.InvariantCulture;

            for (int i = 2; i <= 11; i++)
            {
                dataGridViewSources[i, 0].Value = rs.analisIdentifyRisk[0][0, i-2].ToString();
                dataGridViewSources[i, 0].Style.Font = font;
            }
            for (int i = 2; i <= 11; i++)
            {
                dataGridViewSources[i, 12].Style.Font = font;
                dataGridViewSources[i, 12].Value = rs.analisIdentifyRisk[1][0, i - 2].ToString();
            }
            for (int i = 2; i <= 11; i++)
            {
                dataGridViewSources[i, 22].Style.Font = font;
                dataGridViewSources[i, 22].Value = rs.analisIdentifyRisk[2][0, i - 2].ToString();
            }
            for (int i = 2; i <= 11; i++)
            {
                dataGridViewSources[i, 34].Style.Font = font;
                dataGridViewSources[i, 34].Value = rs.analisIdentifyRisk[3][0, i - 2].ToString();
            }

            //dataGridViewSources[1, 51].Value = (rs.eventIdentifyRisk[0][0] + rs.eventIdentifyRisk[1][0] + rs.eventIdentifyRisk[2][0] + rs.eventIdentifyRisk[3][0]).ToString();

            for (int i = 0; i < rs.eventTechnical.Length; i++)
            {
                dataGridViewSources[12, i].Value = rs.analisIdentifyRisk[0][i, 10].ToString("0.000");
                dataGridViewSources[12, i].Style.Font = font;
            }
            for (int i = 0; i < rs.eventValueRisks.Length; i++)
            {
                dataGridViewSources[12, i + 12].Value = rs.analisIdentifyRisk[1][i, 10].ToString("0.000");
                dataGridViewSources[12, i + 12].Style.Font = font;
            }
            for (int i = 0; i < rs.eventPlanRisks.Length; i++)
            {
                dataGridViewSources[12, i + 22].Style.Font = font;
                dataGridViewSources[12, i + 22].Value = rs.analisIdentifyRisk[2][i, 10].ToString("0.000");
            }
            for (int i = 0; i < rs.eventProcesRisks.Length; i++)
            {
                dataGridViewSources[12, i + 34].Style.Font = font;
                dataGridViewSources[12, i + 34].Value = rs.analisIdentifyRisk[3][i, 10].ToString("0.000");
            }
            dataGridViewSources[12, 0].Value = rs.analisIdentifyRisk[0][0, 10].ToString("00");
            dataGridViewSources[12, 12].Value = rs.analisIdentifyRisk[1][0, 10].ToString("00");
            dataGridViewSources[12, 22].Value = rs.analisIdentifyRisk[2][0, 10].ToString("00");
            dataGridViewSources[12, 34].Value = rs.analisIdentifyRisk[3][0, 10].ToString("00");
            for (int k = 0; k < 4; k++)
            {
                if (k == 1) add = 12; add = (k == 2) ? 22 : add; add = (k == 2) ? 34 : add;
                for (int i = 0 + add; i < rs.eventIdentifyRisk[k].Length + add; i++)
                {
                    dataGridViewSources[1, i].Value = rs.eventIdentifyRisk[k][i - add].ToString();
                }
            }
            //dataGridViewSources[2, 51].Value = rs.eventPercentRisk[0].ToString(specifier, culture);


            dataGridViewSources[0, 0].Style.Font = font;
            dataGridViewSources[0, 12].Style.Font = font;
            dataGridViewSources[0, 22].Style.Font = font;
            dataGridViewSources[0, 34].Style.Font = font;
            //dataGridViewSources[0, 51].Style.Font = font;
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
            rs.CountAnalisIdentifyRisk();
            ShowResult();
            rs.FormAnalisProcess = Handle;
        }

        private void dataGridViewSources_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!TableFull[0]) return;
            double numb;
            if (e.ColumnIndex > 1 && e.ColumnIndex < 12 && dataGridViewSources.RowCount > 1)
            {
                if (double.TryParse(dataGridViewSources[e.ColumnIndex, e.RowIndex].Value.ToString(), out numb) && numb >= 0 && numb <= 1)
                {
                    if (e.RowIndex < 12)
                    {
                        rs.analisIdentifyRisk[0][e.RowIndex, e.ColumnIndex - 2] = numb;
                        dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = numb.ToString("0.00");
                    }
                    else if (e.RowIndex < 22)
                    {
                        rs.analisIdentifyRisk[1][e.RowIndex - 12, e.ColumnIndex - 2] = numb;
                        dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = numb.ToString("0.00");
                    }
                    else if (e.RowIndex < 34)
                    {
                        rs.analisIdentifyRisk[2][e.RowIndex - 22, e.ColumnIndex - 2] = numb;
                        dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = numb.ToString("0.00");
                    }
                    else if (e.RowIndex < 51)
                    {
                        rs.analisIdentifyRisk[3][e.RowIndex - 34, e.ColumnIndex - 2] = numb;
                        dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = numb.ToString("0.00");
                    }
                } else
                {
                    dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = "0";
                }
                rs.CountAnalisIdentifyRisk();
                rs.CountAnalisRiskWithValidity();
                ShowResult();
                ShowResultRating();
            }
        }

        private void CreateTableRating()
        {
            rs.CountAnalisRiskWithValidity();
            for (int i = 0; i < rs.eventTechnical.Length; i++)
            {
                dataGridRating.Rows.Add(rs.eventTechnical[i].ToString(), rs.eventIdentifyRisk[0][i].ToString(), rs.analisRiskWithValidity[0][i, 0].ToString("0.00"), rs.analisRiskWithValidity[0][i, 1].ToString("0.00"), rs.analisRiskWithValidity[0][i, 2].ToString("0.00"), rs.analisRiskWithValidity[0][i, 3].ToString("0.00"), rs.analisRiskWithValidity[0][i, 4].ToString("0.00"), rs.analisRiskWithValidity[0][i, 5].ToString("0.00"), rs.analisRiskWithValidity[0][i, 6].ToString("0.00"), rs.analisRiskWithValidity[0][i, 7].ToString("0.00"), rs.analisRiskWithValidity[0][i, 8].ToString("0.00"), rs.analisRiskWithValidity[0][i, 9].ToString("0.00"));
            }
            for (int i = 0; i < rs.eventValueRisks.Length; i++)
            {
                dataGridRating.Rows.Add(rs.eventValueRisks[i].ToString(), rs.eventIdentifyRisk[1][i].ToString(), rs.analisRiskWithValidity[1][i, 0].ToString("0.00"), rs.analisRiskWithValidity[1][i, 1].ToString("0.00"), rs.analisRiskWithValidity[1][i, 2].ToString("0.00"), rs.analisRiskWithValidity[1][i, 3].ToString("0.00"), rs.analisRiskWithValidity[1][i, 4].ToString("0.00"), rs.analisRiskWithValidity[1][i, 5].ToString("0.00"), rs.analisRiskWithValidity[1][i, 6].ToString("0.00"), rs.analisRiskWithValidity[1][i, 7].ToString("0.00"), rs.analisRiskWithValidity[1][i, 8].ToString("0.00"), rs.analisRiskWithValidity[1][i, 9].ToString("0.00"));
            }
            for (int i = 0; i < rs.eventPlanRisks.Length; i++)
            {
                dataGridRating.Rows.Add(rs.eventPlanRisks[i].ToString(), rs.eventIdentifyRisk[2][i].ToString(), rs.analisRiskWithValidity[2][i, 0].ToString("0.00"), rs.analisRiskWithValidity[2][i, 1].ToString("0.00"), rs.analisRiskWithValidity[2][i, 2].ToString("0.00"), rs.analisRiskWithValidity[2][i, 3].ToString("0.00"), rs.analisRiskWithValidity[2][i, 4].ToString("0.00"), rs.analisRiskWithValidity[2][i, 5].ToString("0.00"), rs.analisRiskWithValidity[2][i, 6].ToString("0.00"), rs.analisRiskWithValidity[2][i, 7].ToString("0.00"), rs.analisRiskWithValidity[2][i, 8].ToString("0.00"), rs.analisRiskWithValidity[2][i, 9].ToString("0.00"));
            }
            for (int i = 0; i < rs.eventProcesRisks.Length; i++)
            {
                dataGridRating.Rows.Add(rs.eventProcesRisks[i].ToString(), rs.eventIdentifyRisk[3][i].ToString(), rs.analisRiskWithValidity[3][i, 0].ToString("0.00"), rs.analisRiskWithValidity[3][i, 1].ToString("0.00"), rs.analisRiskWithValidity[3][i, 2].ToString("0.00"), rs.analisRiskWithValidity[3][i, 3].ToString("0.00"), rs.analisRiskWithValidity[3][i, 4].ToString("0.00"), rs.analisRiskWithValidity[3][i, 5].ToString("0.00"), rs.analisRiskWithValidity[3][i, 6].ToString("0.00"), rs.analisRiskWithValidity[3][i, 7].ToString("0.00"), rs.analisRiskWithValidity[3][i, 8].ToString("0.00"), rs.analisRiskWithValidity[3][i, 9].ToString("0.00"));
            }
            dataGridRating.Rows[0].ReadOnly = true;
            dataGridRating.Rows[12].ReadOnly = true;
            dataGridRating.Rows[22].ReadOnly = true;
            dataGridRating.Rows[34].ReadOnly = true;

            for (int i = 0; i < dataGridRating.Columns.Count; i++)
            {
                dataGridRating.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //dataGridRating.Rows.Add("", "", rs.percentRisk[0].ToString("0.00"));            
            ShowResultRating();
        }

        private void ShowResultRating()
        {
            var add = 0;
            var font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            CultureInfo culture = CultureInfo.InvariantCulture;

            for (int j = 0; j < 17; j++)
            {
                for (int i = 2; i <= 11 && j < rs.analisRiskWithValidity[0].Length / 11; i++)
                {
                    dataGridRating[i, 0 + j].Value = rs.analisRiskWithValidity[0][j, i - 2].ToString("0.00");
                    dataGridRating[i, 0].Style.Font = font;
                }
                for (int i = 2; i <= 11 && j < rs.analisRiskWithValidity[1].Length / 11; i++)
                {
                    dataGridRating[i, 12].Style.Font = font;
                    dataGridRating[i, 12 + j].Value = rs.analisRiskWithValidity[1][j, i - 2].ToString("0.00");
                }
                for (int i = 2; i <= 11 && j < rs.analisRiskWithValidity[2].Length / 11; i++)
                {
                    dataGridRating[i, 22].Style.Font = font;
                    dataGridRating[i, 22 + j].Value = rs.analisRiskWithValidity[2][j, i - 2].ToString("0.00");
                }
                for (int i = 2; i <= 11 && j < rs.analisRiskWithValidity[3].Length / 11; i++)
                {
                    dataGridRating[i, 34].Style.Font = font;
                    dataGridRating[i, 34 + j].Value = rs.analisRiskWithValidity[3][j, i - 2].ToString("0.00");
                }
            }

            //dataGridRating[1, 51].Value = (rs.eventIdentifyRisk[0][0] + rs.eventIdentifyRisk[1][0] + rs.eventIdentifyRisk[2][0] + rs.eventIdentifyRisk[3][0]).ToString("0.00");

            for (int i = 0; i < rs.eventTechnical.Length; i++)
            {
                dataGridRating[12, i].Value = rs.analisRiskWithValidity[0][i, 10].ToString("0.000");
                dataGridRating[12, i].Style.Font = font;
            }
            for (int i = 0; i < rs.eventValueRisks.Length; i++)
            {
                dataGridRating[12, i + 12].Value = rs.analisRiskWithValidity[1][i, 10].ToString("0.000");
                dataGridRating[12, i + 12].Style.Font = font;
            }
            for (int i = 0; i < rs.eventPlanRisks.Length; i++)
            {
                dataGridRating[12, i + 22].Style.Font = font;
                dataGridRating[12, i + 22].Value = rs.analisRiskWithValidity[2][i, 10].ToString("0.000");
            }
            for (int i = 0; i < rs.eventProcesRisks.Length; i++)
            {
                dataGridRating[12, i + 34].Style.Font = font;
                dataGridRating[12, i + 34].Value = rs.analisRiskWithValidity[3][i, 10].ToString("0.000");
            }
            for (int k = 0; k < 4; k++)
            {
                if (k == 1) add = 12; add = (k == 2) ? 22 : add; add = (k == 2) ? 34 : add;
                for (int i = 0 + add; i < rs.eventIdentifyRisk[k].Length; i++)
                {
                    dataGridRating[1, i].Value = rs.eventIdentifyRisk[k][i].ToString();
                }
            }
            //dataGridRating[2, 51].Value = rs.eventPercentRisk[0].ToString(specifier, culture);


            dataGridRating[0, 0].Style.Font = font;
            dataGridRating[0, 12].Style.Font = font;
            dataGridRating[0, 22].Style.Font = font;
            dataGridRating[0, 34].Style.Font = font;
            //dataGridRating[0, 51].Style.Font = font;
        }

        private void dataGridViewSources_Click(object sender, EventArgs e)
        {
            TableFull[0] = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!TableFull[1]) return;
            int numb;
            int k = 0;
            if (e.ColumnIndex > 0 && dataGridViewSources.RowCount > 1)
            {
                if (int.TryParse(dataGridViewExperts[e.ColumnIndex, e.RowIndex].Value.ToString(), out numb) && numb >= 0 && numb <= 10)
                {
                    switch(e.RowIndex)
                    {
                       case 0: k = 0; break;
                       case 1: k = 12; break;
                       case 2: k = 22; break;
                       case 3: k = 34; break;
                    }
                    rs.analisIdentifyRisk[e.RowIndex][0, e.ColumnIndex - 1] = numb;
                    rs.CountAnalisIdentifyRisk();
                    rs.CountAnalisRiskWithValidity();
                    //rs.analisRiskWithValidity[e.RowIndex][0, e.ColumnIndex - 1] = numb;
                    //dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = numb.ToString();
                    dataGridRating[e.ColumnIndex + 1, k].Value = rs.analisRiskWithValidity[e.RowIndex][0, e.ColumnIndex - 1].ToString("0.00");
                    dataGridViewSources[e.ColumnIndex + 1, k].Value = numb.ToString();
                    ShowResult();
                    ShowResultRating();
                }
                else
                {
                    dataGridViewSources[e.ColumnIndex, e.RowIndex].Value = tempValue.ToString();
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 1) return;
            TableFull[1] = true;
            tempValue = Convert.ToInt32(dataGridViewExperts[e.ColumnIndex, e.RowIndex].Value);
        }

        private void FormAnalis_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10 && rs.number != 0; i++)
            {
                if (rs.number == i) continue;
                dataGridRating.Columns[i + 1].ReadOnly = true;
            }
            for (int i = 0; i < 10 && rs.number != 0; i++)
            {
                dataGridViewExperts.Columns[i].ReadOnly = true;
            }
            for (int i = 0; i < 10 && rs.number != 0; i++)
            {
                if (rs.number == i) continue;
                dataGridViewSources.Columns[i + 1].ReadOnly = true;
            }
        }


//------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
