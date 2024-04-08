using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1
{
	public partial class UDPServer : Form
	{
		public UDPServer()
		{
			InitializeComponent();
			Form1 form1 = new Form1();
			form1.Show();
		}

		private void Receive()
		{
			UdpClient udpClient = new UdpClient(8888);
			while (true)
			{
				IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
				Byte[] receiveBytes = udpClient.Receive(ref iPEndPoint);

				string msg = iPEndPoint.Address.ToString() + ":" + Encoding.UTF8.GetString(receiveBytes);

				if (listView1.InvokeRequired)
				{
					listView1.Invoke((MethodInvoker)delegate
					{
						listView1.Items.Add(msg);
					});
				}
			}
		}

		private void UDPServer_Load(object sender, EventArgs e)
		{
			Thread thread = new Thread(Receive);
			thread.Start();
		}
	}
}
