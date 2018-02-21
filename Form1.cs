using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АВПЗ
{
    public partial class Form1 : Form
    {
        FormSources FormS;
        Thread thread1;
        internal string nameOfTable;
        RiskManagement rs;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void джерелаПоявиРизиківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormS == null)
            {
                FormS = new FormSources(rs);
                thread1 = new Thread(new ParameterizedThreadStart(FormInThread));
                thread1.Start(FormS);
            }
            else if(FormS.IsDisposed)
            {
                FormS = new FormSources(rs);
                thread1 = new Thread(new ParameterizedThreadStart(FormInThread));
                thread1.Start(FormS);
            }     
        }

        private void FormInThread(object newFormInThread)
        {
            //formS = new FormSources(nameOfTable);
            Application.Run(newFormInThread as Form);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
