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

		class Student
		{
			public string HoTen { get; set; }
			public string? MSSV { get; set; }
			public string Phone { get; set; }
			public float Mon1 { get; set; }
			public float Mon2 { get; set; }
			public float Mon3 { get; set; }
			public string ToString()
			{
				return string.Format("{0},{1},{2},{3},{4},{5}", HoTen, MSSV, Phone, Mon1, Mon2, Mon3);
			}
		}

		List<Student> students = new List<Student>();

		private void button1_Click(object sender, EventArgs e)
		{
			string hoTen = tbHoTen.Text;
			string sdt = tbSDT.Text;
			string mon1 = tbMon1.Text;
			string mon2 = tbMon2.Text;
			string mon3 = tbMon3.Text;
			Student student = new Student
			{
				HoTen = hoTen,
				Phone = sdt,
				Mon1 = float.Parse(mon1),
				Mon2 = float.Parse(mon2),
				Mon3 = float.Parse(mon3),
			};

			richTextBox1.Text += student.ToString();

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
