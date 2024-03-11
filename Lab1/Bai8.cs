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
	public partial class Bai8 : Form
	{
		public Bai8()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string input = textBox1.Text;
			lbHoTen.Text = input.Split(',')[0];
			lbDiem.Text = "";
			for (int i = 1; i < input.Split(',').Length; i++)
			{
				lbDiem.Text += string.Format("Mon {0}: {1}     ", i, input.Split(',')[i]);
			}
		}
	}
}
