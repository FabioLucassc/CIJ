using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace DadosPC
{
    public partial class Principal : MetroFramework.Forms.MetroForm
    {



        public Principal()
        {
            InitializeComponent();
            getDados();
        }

        void getDadosSocket()
        {

            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();

                string maquina = Dns.GetHostName();

                labelIP.Text = localIP;
                labelHostName.Text = maquina;


            }


        }
        void getDados()
        {
            try
            {
                string enderecoIP = null;
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Console.WriteLine("IP Address = " + ip.ToString());
                        enderecoIP = ip.ToString();
                    }
                }

                string maquina = Dns.GetHostName();

                labelIP.Text = enderecoIP;
                labelHostName.Text = maquina;

            }
            catch
            {
                string maquina = Dns.GetHostName();

                labelIP.Text = "ERRO 404 - JVS";
                labelHostName.Text = maquina;

            }
        }


        private void Principal_Load(object sender, EventArgs e)
        {



        }

        private void buttonAtulizar_Click(object sender, EventArgs e)
        {
            getDados();

        }
    }
}
