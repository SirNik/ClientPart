using RiskManagementLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АВПЗ
{
    class ConnectServer
    {
        public static bool Server(RiskManagementLib rs)
        {
            string response = "";
            Byte[] SendBytes = Convertor.ObjectToByteArray(rs);//ObjectToByteArray(message);
            Byte[] RecvBytes = new byte[100000];
            int count;
            // визначення адреси сервера
            IPAddress address = Dns.Resolve("localhost").AddressList[0];
            // встановлення порту
            IPEndPoint EPhost = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12000);
            // формуваннняоб’єкту Socket
            Socket socket = new Socket(AddressFamily.InterNetwork,
                                           SocketType.Stream,
                                           ProtocolType.Tcp);
            // З’єднання з сервером
            try
            {
                socket.Connect(EPhost);
                // пересилання ти приймання даних 
                socket.Send(SendBytes,
                               SendBytes.Length,
                               SocketFlags.None);
                count = socket.Receive(RecvBytes);
                rs = (RiskManagementLib)Convertor.ByteArrayToObject(RecvBytes, count);
                if (rs.isCorrect == 0)
                    return false;
                MessageBox.Show("Ви експерт під номером " + rs.number);
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error - " + error);
                
            }
            return false;
        }

        internal static void ch(RiskManagementLib rs)
        {
            rs.isCorrect = 10;
        }

        public static bool SendToServer(RiskManagementLib rs)
        {
            string response = "";
            rs.isCorrect = 2;
            Byte[] SendBytes = Convertor.ObjectToByteArray(rs);//ObjectToByteArray(message);
            Byte[] RecvBytes = new byte[100000];
            int count;
            // визначення адреси сервера
            IPAddress address = Dns.Resolve("localhost").AddressList[0];
            // встановлення порту
            IPEndPoint EPhost = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12000);
            // формуваннняоб’єкту Socket
            Socket socket = new Socket(AddressFamily.InterNetwork,
                                           SocketType.Stream,
                                           ProtocolType.Tcp);
            // З’єднання з сервером
            try
            {
                socket.Connect(EPhost);
                // пересилання ти приймання даних 
                socket.Send(SendBytes,
                               SendBytes.Length,
                               SocketFlags.None);
                count = socket.Receive(RecvBytes);
                rs = (RiskManagementLib)Convertor.ByteArrayToObject(RecvBytes, count);
                if (rs.isCorrect == 0)
                    return false;
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error - " + error);

            }
            return false;
        }
        public static RiskManagementLib GetDataServer(RiskManagementLib rs)
        {
            RiskManagementLib temp = null;
            rs.isCorrect = 1;
            Byte[] SendBytes = Convertor.ObjectToByteArray(rs);//ObjectToByteArray(message);
            Byte[] RecvBytes = new byte[100000];
            int count;
            // визначення адреси сервера
            IPAddress address = Dns.Resolve("localhost").AddressList[0];
            // встановлення порту
            IPEndPoint EPhost = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12000);
            // формуваннняоб’єкту Socket
            Socket socket = new Socket(AddressFamily.InterNetwork,
                                           SocketType.Stream,
                                           ProtocolType.Tcp);
            // З’єднання з сервером
            try
            {
                socket.Connect(EPhost);
                // пересилання ти приймання даних 
                socket.Send(SendBytes,
                               SendBytes.Length,
                               SocketFlags.None);
                count = socket.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
                rs = (RiskManagementLib)Convertor.ByteArrayToObject(RecvBytes, count);

            }
            catch (Exception error)
            {
                MessageBox.Show("Error - " + error);

            }
            if (rs.isCorrect != 0)
                MessageBox.Show("Ви експерт під номером " + rs.number);
            return rs;
        }
    }
}
