namespace Lab4_5
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
			label1 = new Label();
			textBox2 = new TextBox();
			label2 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(98, 17);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(162, 23);
			textBox1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 20);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 1;
			label1.Text = "Username";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(98, 46);
			textBox2.Name = "textBox2";
			textBox2.PasswordChar = '@';
			textBox2.Size = new Size(162, 23);
			textBox2.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 49);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// button1
			// 
			button1.Location = new Point(266, 17);
			button1.Name = "button1";
			button1.Size = new Size(75, 52);
			button1.TabIndex = 2;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(356, 89);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private TextBox textBox2;
		private Label label2;
		private Button button1;
	}
}
