using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_1
{
	public partial class Bai2 : Form
	{
		public Bai2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ImapClient imapClient = new ImapClient();
			imapClient.Connect("imap.gmail.com", 993, true);
			try
			{
				imapClient.Authenticate(tbTaiKhoan.Text, tbMatKhau.Text);

				var inbox = imapClient.Inbox;
				inbox.Open(FolderAccess.ReadOnly);

				for (int i = 0; i < 10; i++)
				{
					var message = inbox.GetMessage(i);


				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Sai tai khoan hoac mat khau");
			}
		}
	}
}
