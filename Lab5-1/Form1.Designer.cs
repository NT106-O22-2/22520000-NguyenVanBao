namespace Lab5_1
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
			label1 = new Label();
			tbTaiKhoan = new TextBox();
			label2 = new Label();
			tbMatKhau = new TextBox();
			label3 = new Label();
			tbTo = new TextBox();
			label4 = new Label();
			tbSubject = new TextBox();
			label5 = new Label();
			rtbBody = new RichTextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(57, 15);
			label1.TabIndex = 0;
			label1.Text = "Tài khoản";
			// 
			// tbTaiKhoan
			// 
			tbTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbTaiKhoan.Location = new Point(93, 6);
			tbTaiKhoan.Name = "tbTaiKhoan";
			tbTaiKhoan.Size = new Size(277, 23);
			tbTaiKhoan.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 38);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 0;
			label2.Text = "Mật khẩu";
			// 
			// tbMatKhau
			// 
			tbMatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbMatKhau.Location = new Point(93, 35);
			tbMatKhau.Name = "tbMatKhau";
			tbMatKhau.PasswordChar = '*';
			tbMatKhau.Size = new Size(277, 23);
			tbMatKhau.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 67);
			label3.Name = "label3";
			label3.Size = new Size(19, 15);
			label3.TabIndex = 0;
			label3.Text = "To";
			// 
			// tbTo
			// 
			tbTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbTo.Location = new Point(93, 64);
			tbTo.Name = "tbTo";
			tbTo.Size = new Size(277, 23);
			tbTo.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 96);
			label4.Name = "label4";
			label4.Size = new Size(46, 15);
			label4.TabIndex = 0;
			label4.Text = "Subject";
			// 
			// tbSubject
			// 
			tbSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbSubject.Location = new Point(93, 93);
			tbSubject.Name = "tbSubject";
			tbSubject.Size = new Size(277, 23);
			tbSubject.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 125);
			label5.Name = "label5";
			label5.Size = new Size(34, 15);
			label5.TabIndex = 0;
			label5.Text = "Body";
			// 
			// rtbBody
			// 
			rtbBody.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			rtbBody.Location = new Point(93, 122);
			rtbBody.Name = "rtbBody";
			rtbBody.Size = new Size(277, 96);
			rtbBody.TabIndex = 2;
			rtbBody.Text = "";
			// 
			// button1
			// 
			button1.Location = new Point(295, 224);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "Send";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(382, 257);
			Controls.Add(button1);
			Controls.Add(rtbBody);
			Controls.Add(label5);
			Controls.Add(tbSubject);
			Controls.Add(label4);
			Controls.Add(tbTo);
			Controls.Add(label3);
			Controls.Add(tbMatKhau);
			Controls.Add(label2);
			Controls.Add(tbTaiKhoan);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox tbTaiKhoan;
		private Label label2;
		private TextBox tbMatKhau;
		private Label label3;
		private TextBox tbTo;
		private Label label4;
		private TextBox tbSubject;
		private Label label5;
		private RichTextBox rtbBody;
		private Button button1;
	}
}
