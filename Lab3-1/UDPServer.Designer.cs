namespace Lab3_1
{
	partial class UDPServer
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
			listView1 = new ListView();
			SuspendLayout();
			// 
			// listView1
			// 
			listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listView1.Location = new Point(12, 12);
			listView1.Name = "listView1";
			listView1.Size = new Size(305, 268);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.List;
			// 
			// UDPServer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(329, 292);
			Controls.Add(listView1);
			Name = "UDPServer";
			Text = "UDPServer";
			Load += UDPServer_Load;
			ResumeLayout(false);
		}

		#endregion

		private ListView listView1;
	}
}