using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Numerics;

namespace HomNayAnGi
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private JObject user = new JObject();
		private JToken danhSachMonAn;
		private string access_token = "Bearer ";
		public static readonly HttpClient httpClient = new HttpClient
		{
			BaseAddress = new Uri(@"https://nt106.uitiot.vn")
		};

		private class Pagination
		{
			public int current { get; set; }
			public int pageSize { get; set; }
		}
		private Pagination pagination = new Pagination
		{
			current = 1,
			pageSize = 50
		};

		private async void GetDishes(bool myDishes = false)
		{
			string uri = myDishes ? "api/v1/monan/my-dishes" : "api/v1/monan/all";
			Panel panel = myDishes ? panelMyDished : panelAllDishes;
			panel.Controls.Clear();

			httpClient.DefaultRequestHeaders.Clear();	
			httpClient.DefaultRequestHeaders.Add("Authorization", access_token);

			using HttpResponseMessage response = await httpClient.PostAsJsonAsync(
				uri,
				pagination
			);

			var res = await response.Content.ReadAsStringAsync();
			JObject keyValuePairs = JObject.Parse(res);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				MessageBox.Show(keyValuePairs["detail"].ToString());
			}
			else
			{
				JToken paginationRes = keyValuePairs["pagination"];
				int total = paginationRes.Value<int>("total");
				double totalPage = Math.Ceiling((float)total / (float)pagination.pageSize);
				comboBoxPage.Items.Clear();
				for (int i = 1; i <= totalPage; i++)
				{
					comboBoxPage.Items.Add(i);
				}
				/*DisplayMonAn(keyValuePairs["data"], panel);*/
			}
		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				//if (await CheckAuthorization())
				//{
					comboBoxPageSize.Text = pagination.pageSize.ToString();
					GetDishes();
				//}
			}
			catch
			{
				Login login = new Login();
				login.ShowDialog();
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			TabPage? selectedTabPage = tabControl?.SelectedTab;
			if (selectedTabPage != null)
			{
				if (selectedTabPage.Name == "tabPage2")
				{
					GetDishes(true);
				}
				if (selectedTabPage.Name == "tabPage1")
				{
					GetDishes();
				}
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			int page = comboBoxPage.SelectedItem == null ? 1 : int.Parse(comboBoxPage.SelectedItem.ToString());
			int pageSize = comboBoxPageSize.SelectedItem != null ? int.Parse(comboBoxPageSize.SelectedItem.ToString()) : 5;
			pagination.pageSize = pageSize;
			pagination.current = page;
			tabControl1_SelectedIndexChanged(sender, e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			/*ThemMonAn themMonAn = new ThemMonAn();
			themMonAn.FormClosed += tabControl1_SelectedIndexChanged;
			themMonAn.ShowDialog();*/
		}

		private void btnAnGi_Click(object sender, EventArgs e)
		{
			int soMonAn = danhSachMonAn.ToArray().Length;
			var rand = new Random();
			int monAnIndex = rand.Next(soMonAn);
			var monan = danhSachMonAn.ElementAt(monAnIndex);

			ShowMonAn showMonAn = new ShowMonAn(monan);
			showMonAn.ShowDialog();
		}

		private void toolStripStatusLabelLogout_Click(object sender, EventArgs e)
		{
			var confirm = MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirm == DialogResult.Yes)
			{
				if (File.Exists("access_token"))
				{
					File.Delete("access_token");
					access_token = "Bearer ";
					panelAllDishes.Controls.Clear();
					panelMyDished.Controls.Clear();
					//CheckAuthorization();
				}
			}
		}
	}
}
