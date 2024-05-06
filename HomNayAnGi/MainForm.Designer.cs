namespace HomNayAnGi
{
	partial class MainForm
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
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel = new ToolStripStatusLabel();
			toolStripStatusLabelLogout = new ToolStripStatusLabel();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStripProgressBar1 = new ToolStripProgressBar();
			tabControl = new TabControl();
			tabPage1 = new TabPage();
			panelAllDishes = new Panel();
			tabPage2 = new TabPage();
			panelMyDished = new Panel();
			label2 = new Label();
			comboBoxPage = new ComboBox();
			comboBoxPageSize = new ComboBox();
			label1 = new Label();
			label3 = new Label();
			button1 = new Button();
			btnAnGi = new Button();
			statusStrip1.SuspendLayout();
			tabControl.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripStatusLabelLogout, toolStripStatusLabel1, toolStripProgressBar1 });
			statusStrip1.Location = new Point(0, 734);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(534, 22);
			statusStrip1.TabIndex = 0;
			statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			toolStripStatusLabel.Name = "toolStripStatusLabel";
			toolStripStatusLabel.Size = new Size(43, 17);
			toolStripStatusLabel.Text = "            ";
			// 
			// toolStripStatusLabelLogout
			// 
			toolStripStatusLabelLogout.IsLink = true;
			toolStripStatusLabelLogout.LinkBehavior = LinkBehavior.HoverUnderline;
			toolStripStatusLabelLogout.Name = "toolStripStatusLabelLogout";
			toolStripStatusLabelLogout.Size = new Size(22, 17);
			toolStripStatusLabelLogout.Text = "     ";
			toolStripStatusLabelLogout.Click += toolStripStatusLabelLogout_Click;
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(10, 17);
			toolStripStatusLabel1.Text = "|";
			// 
			// toolStripProgressBar1
			// 
			toolStripProgressBar1.Name = "toolStripProgressBar1";
			toolStripProgressBar1.Size = new Size(100, 16);
			// 
			// tabControl
			// 
			tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tabControl.Controls.Add(tabPage1);
			tabControl.Controls.Add(tabPage2);
			tabControl.Location = new Point(12, 64);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(510, 638);
			tabControl.TabIndex = 1;
			tabControl.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(panelAllDishes);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(502, 610);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "All";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// panelAllDishes
			// 
			panelAllDishes.AutoScroll = true;
			panelAllDishes.Dock = DockStyle.Fill;
			panelAllDishes.Location = new Point(3, 3);
			panelAllDishes.Name = "panelAllDishes";
			panelAllDishes.Size = new Size(496, 604);
			panelAllDishes.TabIndex = 0;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(panelMyDished);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(502, 610);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Tôi đóng góp";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// panelMyDished
			// 
			panelMyDished.AutoScroll = true;
			panelMyDished.Dock = DockStyle.Fill;
			panelMyDished.Location = new Point(3, 3);
			panelMyDished.Name = "panelMyDished";
			panelMyDished.Size = new Size(496, 604);
			panelMyDished.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
			label2.ForeColor = Color.IndianRed;
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(239, 37);
			label2.TabIndex = 2;
			label2.Text = "HÔM NAY ĂN GÌ?";
			// 
			// comboBoxPage
			// 
			comboBoxPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			comboBoxPage.FormattingEnabled = true;
			comboBoxPage.Location = new Point(377, 708);
			comboBoxPage.Name = "comboBoxPage";
			comboBoxPage.Size = new Size(36, 23);
			comboBoxPage.TabIndex = 3;
			comboBoxPage.Text = "1";
			comboBoxPage.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
			// 
			// comboBoxPageSize
			// 
			comboBoxPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			comboBoxPageSize.FormattingEnabled = true;
			comboBoxPageSize.Items.AddRange(new object[] { "5", "10", "15", "20", "50" });
			comboBoxPageSize.Location = new Point(480, 708);
			comboBoxPageSize.Name = "comboBoxPageSize";
			comboBoxPageSize.Size = new Size(38, 23);
			comboBoxPageSize.TabIndex = 3;
			comboBoxPageSize.Text = "5";
			comboBoxPageSize.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(419, 711);
			label1.Name = "label1";
			label1.Size = new Size(55, 15);
			label1.TabIndex = 4;
			label1.Text = "Page size";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Location = new Point(338, 711);
			label3.Name = "label3";
			label3.Size = new Size(33, 15);
			label3.TabIndex = 5;
			label3.Text = "Page";
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.BackColor = Color.PapayaWhip;
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			button1.ForeColor = SystemColors.ActiveCaptionText;
			button1.Location = new Point(390, 33);
			button1.Name = "button1";
			button1.Size = new Size(132, 49);
			button1.TabIndex = 6;
			button1.Text = "Thêm món ăn";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// btnAnGi
			// 
			btnAnGi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAnGi.BackColor = Color.NavajoWhite;
			btnAnGi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnAnGi.ForeColor = SystemColors.ActiveCaptionText;
			btnAnGi.Location = new Point(252, 33);
			btnAnGi.Name = "btnAnGi";
			btnAnGi.Size = new Size(132, 49);
			btnAnGi.TabIndex = 6;
			btnAnGi.Text = "Ăn gì giờ?";
			btnAnGi.UseVisualStyleBackColor = false;
			btnAnGi.Click += btnAnGi_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(534, 756);
			Controls.Add(btnAnGi);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(comboBoxPageSize);
			Controls.Add(comboBoxPage);
			Controls.Add(label2);
			Controls.Add(tabControl);
			Controls.Add(statusStrip1);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Hôm nay ăn gì?";
			Load += MainForm_Load;
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			tabControl.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private StatusStrip statusStrip1;
		public ToolStripStatusLabel toolStripStatusLabel;
		private TabControl tabControl;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private Panel panelAllDishes;
		private Label label2;
		private ToolStripProgressBar toolStripProgressBar1;
		private Panel panelMyDished;
		private ToolStripStatusLabel toolStripStatusLabelLogout;
		private ComboBox comboBoxPage;
		private ComboBox comboBoxPageSize;
		private Label label1;
		private Label label3;
		private Button button1;
		private Button btnAnGi;
		private ToolStripStatusLabel toolStripStatusLabel1;
	}
}