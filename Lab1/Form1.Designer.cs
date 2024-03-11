namespace Lab1
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
			tbSoThuNhat = new TextBox();
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			tbSoThuHai = new TextBox();
			label3 = new Label();
			tbKetQua = new TextBox();
			label4 = new Label();
			SuspendLayout();
			// 
			// tbSoThuNhat
			// 
			tbSoThuNhat.Location = new Point(86, 47);
			tbSoThuNhat.Name = "tbSoThuNhat";
			tbSoThuNhat.Size = new Size(100, 23);
			tbSoThuNhat.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(111, 105);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Tinh";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 50);
			label1.Name = "label1";
			label1.Size = new Size(68, 15);
			label1.TabIndex = 2;
			label1.Text = "So thu nhat";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(159, 15);
			label2.TabIndex = 2;
			label2.Text = "TINH TONG HAI SO NGUYEN";
			// 
			// tbSoThuHai
			// 
			tbSoThuHai.Location = new Point(86, 76);
			tbSoThuHai.Name = "tbSoThuHai";
			tbSoThuHai.Size = new Size(100, 23);
			tbSoThuHai.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 79);
			label3.Name = "label3";
			label3.Size = new Size(60, 15);
			label3.TabIndex = 2;
			label3.Text = "So thu hai";
			// 
			// tbKetQua
			// 
			tbKetQua.Location = new Point(86, 134);
			tbKetQua.Name = "tbKetQua";
			tbKetQua.ReadOnly = true;
			tbKetQua.Size = new Size(100, 23);
			tbKetQua.TabIndex = 0;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 137);
			label4.Name = "label4";
			label4.Size = new Size(47, 15);
			label4.TabIndex = 2;
			label4.Text = "Ket qua";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(203, 173);
			Controls.Add(label2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(tbKetQua);
			Controls.Add(tbSoThuHai);
			Controls.Add(tbSoThuNhat);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbSoThuNhat;
		private Button button1;
		private Label label1;
		private Label label2;
		private TextBox tbSoThuHai;
		private Label label3;
		private TextBox tbKetQua;
		private Label label4;
	}
}
