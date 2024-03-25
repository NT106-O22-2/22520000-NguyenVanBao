namespace Lab1
{
	partial class Bai9
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai9));
			textBox1 = new TextBox();
			button1 = new Button();
			listView1 = new ListView();
			button2 = new Button();
			textBox2 = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Location = new Point(12, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(163, 16);
			textBox1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(396, 41);
			button1.Name = "button1";
			button1.Size = new Size(108, 23);
			button1.TabIndex = 1;
			button1.Text = "Them Mon An";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// listView1
			// 
			listView1.BackgroundImageTiled = true;
			listView1.Location = new Point(510, 12);
			listView1.Name = "listView1";
			listView1.Size = new Size(149, 133);
			listView1.TabIndex = 2;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.List;
			// 
			// button2
			// 
			button2.Location = new Point(341, 151);
			button2.Name = "button2";
			button2.Size = new Size(320, 23);
			button2.TabIndex = 3;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox2
			// 
			textBox2.BorderStyle = BorderStyle.None;
			textBox2.Location = new Point(129, 34);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 16);
			textBox2.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.White;
			label1.Location = new Point(48, 143);
			label1.Name = "label1";
			label1.Size = new Size(30, 15);
			label1.TabIndex = 5;
			label1.Text = "Tính";
			label1.Click += label1_Click;
			// 
			// Bai9
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(681, 269);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(button2);
			Controls.Add(listView1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "Bai9";
			Text = "Bai9";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private ListView listView1;
		private Button button2;
		private TextBox textBox2;
		private Label label1;
	}
}