using HtmlAgilityPack;

namespace Lab4_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string url = textBox1.Text;
			webView21.Source = new Uri(url);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			HtmlWeb web = new HtmlWeb();
			var htmlDoc = web.Load(textBox1.Text);

			var imgs = htmlDoc.DocumentNode.SelectNodes("//img");
			foreach (var img in imgs)
			{
				var imgURL = img.GetAttributeValue("src", "");
				MessageBox.Show(imgURL);
			}
		}
	}
}
