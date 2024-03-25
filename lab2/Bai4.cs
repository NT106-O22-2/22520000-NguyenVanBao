using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
	public partial class Bai4 : Form
	{
		public Bai4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string hoTen = tbHoTen.Text;
			string sdt = tbSDT.Text;
			string mon1 = tbMon1.Text;
			string mon2 = tbMon2.Text;
			string mon3 = tbMon3.Text;

			richTextBox1.Text += string.Format("{0},{1},{2},{3},{4}", hoTen, sdt, mon1, mon2, mon3) + Environment.NewLine;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text|*.txt";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.Write(richTextBox1.Text);
				streamWriter.Close();
				fileStream.Close();
			}
		}
	}
}
