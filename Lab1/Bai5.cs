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
		class Phim
		{
			public required string Ten { get; set; }
			public int GiaVe { get; set; }
			public int[]? PhongChieu { get; set; }
		}

		public Bai5()
		{
			InitializeComponent();
			List<Phim> phims = new List<Phim>();
			phims.Add(new Phim() { Ten = "Đào, phở và piano", GiaVe = 45000, PhongChieu = [1,2] });
			phims.Add(new Phim() { Ten = "Mai", GiaVe = 100000, PhongChieu = [1,2,3] });
			phims.Add(new Phim() { Ten = "Gặp lại chị bầu", GiaVe = 70000, PhongChieu = [2] });
			phims.Add(new Phim() { Ten = "Tarot", GiaVe = 90000, PhongChieu = [1] });

			comboBox1.DataSource = phims;
			comboBox1.DisplayMember = "Ten";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Phim selectedPhim = comboBox1.SelectedItem as Phim;

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
