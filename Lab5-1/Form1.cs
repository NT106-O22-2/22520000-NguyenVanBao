using MailKit.Net.Smtp;
using MimeKit;

namespace Lab5_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Connect("smtp.gmail.com", 465, true);
			try
			{
				smtpClient.Authenticate(tbTaiKhoan.Text, tbMatKhau.Text);

				MimeMessage message = new MimeMessage();
				message.From.Add(new MailboxAddress("", tbTaiKhoan.Text));
				message.To.Add(new MailboxAddress("", tbTo.Text));
				message.Subject = tbSubject.Text;
				message.Body = new TextPart("plain")
				{
					Text = rtbBody.Text
				};

				smtpClient.Send(message);
				MessageBox.Show("Da gui email");

			} catch (Exception ex)
			{
				MessageBox.Show("Sai tai hoan hoac mat khau");
			}
		}
	}
}
