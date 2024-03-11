using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			form1.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Bai5 bai5 = new Bai5();
			bai5.ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Bai8 bai8 = new Bai8();
			bai8.ShowDialog();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Bai9 bai9 = new Bai9();
			bai9.ShowDialog();
		}
	}
}
