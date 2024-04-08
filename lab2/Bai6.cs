using Microsoft.EntityFrameworkCore;
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
	public partial class Bai6 : Form
	{
		private AnGiContext? anGiContext;
		public Bai6()
		{
			InitializeComponent();
		}

		private void Bai6_Load(object sender, EventArgs e)
		{
			anGiContext = new AnGiContext();
			anGiContext.Database.EnsureCreated();

			anGiContext.MonAns.Load();

			dataGridView1.DataSource = anGiContext.MonAns.Local.ToBindingList();
		}
	}
}
