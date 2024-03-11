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
	public partial class Bai9 : Form
	{
		public Bai9()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string monAn = textBox1.Text;
			listView1.Items.Add(new ListViewItem(monAn));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var danhSachMonAn = listView1.Items;
		}
	}
}
