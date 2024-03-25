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
			phims.Add(new Phim() { Ten = "Đào, phở và piano", GiaVe = 45000, PhongChieu = [1, 2] });
			phims.Add(new Phim() { Ten = "Mai", GiaVe = 100000, PhongChieu = [1, 2, 3] });
			phims.Add(new Phim() { Ten = "Gặp lại chị bầu", GiaVe = 70000, PhongChieu = [2] });
			phims.Add(new Phim() { Ten = "Tarot", GiaVe = 90000, PhongChieu = [1] });

			comboBox1.DataSource = phims;
			comboBox1.DisplayMember = "Ten";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Phim selectedPhim = comboBox1.SelectedItem as Phim;
			List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
			int tongTien = 0;
			int giaVe = selectedPhim.GiaVe;

			foreach (CheckBox checkBox in checkBoxes)
			{
				if (checkBox.Checked)
				{
					//MessageBox.Show(checkBox.Name);
					string hangGhe = checkBox.Name.Split('_')[0];
					int soGhe = int.Parse(checkBox.Name.Split("_")[1]);
					
					if (soGhe == 1 || soGhe == 5)
					{
						tongTien += giaVe / 2;
					} else
					{
						if (hangGhe.Equals("B"))
						{
							tongTien += giaVe * 2;
						} else
						{
							tongTien += giaVe;
						}
					}
				}
			}

			MessageBox.Show(string.Format("Tong so tien: {0}", tongTien));
		}

		private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			Phim selectedPhim = comboBox1.SelectedItem as Phim;
			comboBox2.DataSource = selectedPhim.PhongChieu;
			label5.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString();
		}

		private void Bai5_Load(object sender, EventArgs e)
		{
			Phim selectedPhim = comboBox1.SelectedItem as Phim;
			label5.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString();
		}
	}
}
