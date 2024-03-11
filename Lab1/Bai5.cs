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
	public partial class Bai5 : Form
	{

		public Bai5()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string phim = comboBox1.SelectedItem.ToString();

			List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
			foreach(CheckBox checkBox in checkBoxes)
			{
				if(checkBox.Checked)
				{
					MessageBox.Show(checkBox.Name);
				}
			}
		}
	}
}
