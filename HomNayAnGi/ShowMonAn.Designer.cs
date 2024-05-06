namespace HomNayAnGi
{
	partial class ShowMonAn
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
			panel1 = new Panel();
			button1 = new Button();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(415, 109);
			panel1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(304, 115);
			button1.Name = "button1";
			button1.Size = new Size(99, 23);
			button1.TabIndex = 1;
			button1.Text = "Mời bạn bè...";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ShowMonAn
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(415, 150);
			Controls.Add(button1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "ShowMonAn";
			StartPosition = FormStartPosition.CenterScreen;
			ResumeLayout(false);
		}

		#endregion

		public Panel panel1;
		private Button button1;
	}
}