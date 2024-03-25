namespace Lab1
{
	partial class Bai8
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
			textBox1 = new TextBox();
			button1 = new Button();
			label1 = new Label();
			lbHoTen = new Label();
			label3 = new Label();
			lbDiem = new Label();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(420, 23);
			textBox1.TabIndex = 0;
			textBox1.Text = "Nguyen Van A, 6, 7, 8, 6.5";
			// 
			// button1
			// 
			button1.Location = new Point(357, 41);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 68);
			label1.Name = "label1";
			label1.Size = new Size(46, 15);
			label1.TabIndex = 2;
			label1.Text = "Ho ten:";
			// 
			// lbHoTen
			// 
			lbHoTen.AutoSize = true;
			lbHoTen.Location = new Point(64, 68);
			lbHoTen.Name = "lbHoTen";
			lbHoTen.Size = new Size(38, 15);
			lbHoTen.TabIndex = 3;
			lbHoTen.Text = "label2";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 99);
			label3.Name = "label3";
			label3.Size = new Size(38, 15);
			label3.TabIndex = 4;
			label3.Text = "Diem:";
			// 
			// lbDiem
			// 
			lbDiem.AutoSize = true;
			lbDiem.Location = new Point(64, 99);
			lbDiem.Name = "lbDiem";
			lbDiem.Size = new Size(38, 15);
			lbDiem.TabIndex = 5;
			lbDiem.Text = "label4";
			// 
			// Bai8
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(444, 174);
			Controls.Add(lbDiem);
			Controls.Add(label3);
			Controls.Add(lbHoTen);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "Bai8";
			Text = "Bai8";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private Label label1;
		private Label lbHoTen;
		private Label label3;
		private Label lbDiem;
	}
}