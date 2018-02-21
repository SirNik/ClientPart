using RiskManagementLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
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
        RiskManagementLib rs;
        public Form1()
        { 
            InitializeComponent();
            rs = new RiskManagementLib();
            ConnectServer.SendToServer(rs);
        }

    



        private void FormInThread(object newFormInThread)
        {
            //formS = new FormSources(nameOfTable);
            Application.Run(newFormInThread as Form);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ConnectServer
            if(Login.Text.Length < 4 || Login.Text.Length < 4)
            {
                MessageBox.Show("Логін та пароль мають складатися не менше ніж з 4 символів!");
                return;
            }
            rs.Login = Login.Text;
            rs.Parol = Parol.Text;
            rs = ConnectServer.GetDataServer(rs);
            //rs = new RiskManagementLib();
            rs.isCorrect = 1;
            if (rs.isCorrect == 0)
            {
                MessageBox.Show("Неправильний логін або пароль!");
                return;
            }
                

                if (FormS == null)
            {
                FormS = new FormSources(rs);
                thread1 = new Thread(new ParameterizedThreadStart(FormInThread));
                thread1.Start(FormS);
            }
            else if (FormS.IsDisposed)
            {
                FormS = new FormSources(rs);
                thread1 = new Thread(new ParameterizedThreadStart(FormInThread));
                thread1.Start(FormS);
            }
            Close();
        }
    }
}
