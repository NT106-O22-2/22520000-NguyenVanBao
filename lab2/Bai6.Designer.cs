namespace lab2
{
	partial class Bai6
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
			components = new System.ComponentModel.Container();
			dataGridView1 = new DataGridView();
			monAnBindingSource = new BindingSource(components);
			iDMADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			tenMonAnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			hinhAnhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			iDNDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			nguoiDungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)monAnBindingSource).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDMADataGridViewTextBoxColumn, tenMonAnDataGridViewTextBoxColumn, hinhAnhDataGridViewTextBoxColumn, iDNDDataGridViewTextBoxColumn, nguoiDungDataGridViewTextBoxColumn });
			dataGridView1.DataSource = monAnBindingSource;
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(548, 150);
			dataGridView1.TabIndex = 0;
			// 
			// monAnBindingSource
			// 
			monAnBindingSource.DataSource = typeof(MonAn);
			// 
			// iDMADataGridViewTextBoxColumn
			// 
			iDMADataGridViewTextBoxColumn.DataPropertyName = "IDMA";
			iDMADataGridViewTextBoxColumn.HeaderText = "IDMA";
			iDMADataGridViewTextBoxColumn.Name = "iDMADataGridViewTextBoxColumn";
			// 
			// tenMonAnDataGridViewTextBoxColumn
			// 
			tenMonAnDataGridViewTextBoxColumn.DataPropertyName = "TenMonAn";
			tenMonAnDataGridViewTextBoxColumn.HeaderText = "TenMonAn";
			tenMonAnDataGridViewTextBoxColumn.Name = "tenMonAnDataGridViewTextBoxColumn";
			// 
			// hinhAnhDataGridViewTextBoxColumn
			// 
			hinhAnhDataGridViewTextBoxColumn.DataPropertyName = "HinhAnh";
			hinhAnhDataGridViewTextBoxColumn.HeaderText = "HinhAnh";
			hinhAnhDataGridViewTextBoxColumn.Name = "hinhAnhDataGridViewTextBoxColumn";
			// 
			// iDNDDataGridViewTextBoxColumn
			// 
			iDNDDataGridViewTextBoxColumn.DataPropertyName = "IDND";
			iDNDDataGridViewTextBoxColumn.HeaderText = "IDND";
			iDNDDataGridViewTextBoxColumn.Name = "iDNDDataGridViewTextBoxColumn";
			// 
			// nguoiDungDataGridViewTextBoxColumn
			// 
			nguoiDungDataGridViewTextBoxColumn.DataPropertyName = "NguoiDung";
			nguoiDungDataGridViewTextBoxColumn.HeaderText = "NguoiDung";
			nguoiDungDataGridViewTextBoxColumn.Name = "nguoiDungDataGridViewTextBoxColumn";
			nguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Bai6
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridView1);
			Name = "Bai6";
			Text = "Bai6";
			Load += Bai6_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)monAnBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn iDMADataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn tenMonAnDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hinhAnhDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn iDNDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nguoiDungDataGridViewTextBoxColumn;
		private BindingSource monAnBindingSource;
	}
}