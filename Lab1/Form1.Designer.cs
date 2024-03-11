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
			tbFullname = new TextBox();
			button1 = new Button();
			label1 = new Label();
			SuspendLayout();
			// 
			// tbFullname
			// 
			tbFullname.Location = new Point(86, 15);
			tbFullname.Name = "tbFullname";
			tbFullname.Size = new Size(100, 23);
			tbFullname.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(111, 44);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Xac nhan";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 23);
			label1.Name = "label1";
			label1.Size = new Size(58, 15);
			label1.TabIndex = 2;
			label1.Text = "Ho va ten";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(200, 79);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(tbFullname);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbFullname;
		private Button button1;
		private Label label1;
	}
}
