using System.Runtime.Serialization.Formatters.Binary;

namespace lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text file|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;
				FileInfo fileInfo = new FileInfo(filePath);
				string fileName = fileInfo.Name;
				long fileSize = fileInfo.Length;

				textBox1.Text = filePath;
				FileStream fileStream = new FileStream(filePath, FileMode.Open);
				StreamReader streamReader = new StreamReader(fileStream);
				richTextBox1.Text = streamReader.ReadToEnd();

				int lineCount = richTextBox1.Text.Trim().Split('\n').Length;
				MessageBox.Show(lineCount.ToString());

				streamReader.Close();
				fileStream.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string test = "Nguyen Van Bao";

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text file|*.txt";
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
