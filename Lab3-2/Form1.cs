using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab3_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Receive(Socket clientSocket)
		{
			while (clientSocket.Connected)
			{
				string text = "";
				do
				{
					byte[] buffer = new byte[1];
					clientSocket.Receive(buffer);
					text += Encoding.UTF8.GetString(buffer);
				} while (text[text.Length - 1] != '\n');

				if (listView1.InvokeRequired)
				{
					listView1.Invoke((MethodInvoker)delegate
					{
						listView1.Items.Add(text);
					});
				}
			}
		}

		private void StartServer()
		{
			Socket listener = new Socket(
				AddressFamily.InterNetwork,
				SocketType.Stream,
				ProtocolType.Tcp
			);
			IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
			listener.Bind(iPEndPoint);
			listener.Listen(5);

			while (true)
			{
				Socket clientSocket = listener.Accept();
				Thread thread = new Thread(() => Receive(clientSocket));
				thread.Start();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			Thread thread = new Thread(StartServer);
			thread.Start();
		}
	}
}
