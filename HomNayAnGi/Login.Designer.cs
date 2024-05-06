namespace HomNayAnGi
{
	partial class Login
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
			label1 = new Label();
			tbUsername = new TextBox();
			label2 = new Label();
			label3 = new Label();
			tbPassword = new TextBox();
			btnLogin = new Button();
			label4 = new Label();
			lbSignup = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 72);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(100, 64);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(138, 23);
			tbUsername.TabIndex = 1;
			tbUsername.KeyPress += Login_KeyPress;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
			label2.ForeColor = Color.IndianRed;
			label2.Location = new Point(47, 9);
			label2.Name = "label2";
			label2.Size = new Size(239, 37);
			label2.TabIndex = 0;
			label2.Text = "HÔM NAY ĂN GÌ?";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 101);
			label3.Name = "label3";
			label3.Size = new Size(57, 15);
			label3.TabIndex = 0;
			label3.Text = "Password";
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(100, 93);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(138, 23);
			tbPassword.TabIndex = 2;
			tbPassword.KeyPress += Login_KeyPress;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(244, 64);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(75, 53);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(100, 136);
			label4.Name = "label4";
			label4.Size = new Size(150, 15);
			label4.TabIndex = 0;
			label4.Text = "Don't have an account yet?";
			// 
			// lbSignup
			// 
			lbSignup.AutoSize = true;
			lbSignup.Cursor = Cursors.Hand;
			lbSignup.ForeColor = SystemColors.MenuHighlight;
			lbSignup.Location = new Point(248, 136);
			lbSignup.Name = "lbSignup";
			lbSignup.Size = new Size(47, 15);
			lbSignup.TabIndex = 0;
			lbSignup.Text = "Sign up";
			lbSignup.Click += lbSignup_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(334, 172);
			Controls.Add(btnLogin);
			Controls.Add(tbPassword);
			Controls.Add(tbUsername);
			Controls.Add(label4);
			Controls.Add(lbSignup);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Hôm nay ăn gì? Login";
			FormClosing += Login_FormClosing;
			KeyPress += Login_KeyPress;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox tbUsername;
		private Label label2;
		private Label label3;
		private TextBox tbPassword;
		private Button btnLogin;
		private Label label4;
		private Label lbSignup;
	}
}