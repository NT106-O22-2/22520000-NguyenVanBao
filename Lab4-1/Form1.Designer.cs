namespace Lab4_1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			button1 = new Button();
			richTextBox1 = new RichTextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(347, 23);
			textBox1.TabIndex = 0;
			textBox1.Text = "https://uit.edu.vn";
			// 
			// button1
			// 
			button1.Location = new Point(365, 12);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(12, 41);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(427, 397);
			richTextBox1.TabIndex = 2;
			richTextBox1.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(451, 450);
			Controls.Add(richTextBox1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private RichTextBox richTextBox1;
	}
}
