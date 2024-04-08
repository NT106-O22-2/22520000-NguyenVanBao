using System.Net.Sockets;
using System.Text;

namespace Lab3_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UdpClient udpClient = new UdpClient();
			Byte[] data = Encoding.UTF8.GetBytes("Xin Chào");
			udpClient.Send(data, data.Length, textBox1.Text, 8888);
		}
	}
}
