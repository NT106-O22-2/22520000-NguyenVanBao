namespace Lab5_1
{
	partial class Bai2
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
			tbMatKhau = new TextBox();
			label2 = new Label();
			tbTaiKhoan = new TextBox();
			label1 = new Label();
			button1 = new Button();
			listView1 = new ListView();
			SuspendLayout();
			// 
			// tbMatKhau
			// 
			tbMatKhau.Location = new Point(93, 35);
			tbMatKhau.Name = "tbMatKhau";
			tbMatKhau.PasswordChar = '*';
			tbMatKhau.Size = new Size(236, 23);
			tbMatKhau.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 38);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 7;
			label2.Text = "Mật khẩu";
			// 
			// tbTaiKhoan
			// 
			tbTaiKhoan.Location = new Point(93, 6);
			tbTaiKhoan.Name = "tbTaiKhoan";
			tbTaiKhoan.Size = new Size(236, 23);
			tbTaiKhoan.TabIndex = 12;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(57, 15);
			label1.TabIndex = 8;
			label1.Text = "Tài khoản";
			// 
			// button1
			// 
			button1.Location = new Point(335, 6);
			button1.Name = "button1";
			button1.Size = new Size(75, 52);
			button1.TabIndex = 13;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// listView1
			// 
			listView1.Location = new Point(12, 64);
			listView1.Name = "listView1";
			listView1.Size = new Size(398, 233);
			listView1.TabIndex = 14;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// Bai2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(421, 309);
			Controls.Add(listView1);
			Controls.Add(button1);
			Controls.Add(tbMatKhau);
			Controls.Add(label2);
			Controls.Add(tbTaiKhoan);
			Controls.Add(label1);
			Name = "Bai2";
			Text = "Bai2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbMatKhau;
		private Label label2;
		private TextBox tbTaiKhoan;
		private Label label1;
		private Button button1;
		private ListView listView1;
	}
}