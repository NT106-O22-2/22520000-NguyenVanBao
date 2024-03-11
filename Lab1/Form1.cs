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
			string fullname = tbFullname.Text;
			// lab 1
			MessageBox.Show(string.Format("Chao mung ban {0}", fullname));
		}
	}
}
