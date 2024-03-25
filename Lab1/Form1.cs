namespace Lab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int soThuNhat = int.Parse(tbSoThuNhat.Text);
			int soThuHai = int.Parse(tbSoThuHai.Text);

			tbKetQua.Text = (soThuNhat + soThuHai).ToString();
		}
	}
}
