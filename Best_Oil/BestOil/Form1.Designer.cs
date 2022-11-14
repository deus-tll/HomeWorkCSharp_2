namespace BestOil
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tlp_GroupGasStationAndMiniCafe = new System.Windows.Forms.TableLayoutPanel();
			this.gb_GasStation = new System.Windows.Forms.GroupBox();
			this.gb_MiniCafe = new System.Windows.Forms.GroupBox();
			this.gb_TotalAmount = new System.Windows.Forms.GroupBox();
			this.panel_GasStation = new System.Windows.Forms.Panel();
			this.panel_MiniCafe = new System.Windows.Forms.Panel();
			this.panel_TotalAmount = new System.Windows.Forms.Panel();
			this.gb_GasStationPay = new System.Windows.Forms.GroupBox();
			this.gb_MiniCafePay = new System.Windows.Forms.GroupBox();
			this.lbl_TotalAmount = new System.Windows.Forms.Label();
			this.btn_Count = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tlp_GroupTotalAmountForPayment = new System.Windows.Forms.TableLayoutPanel();
			this.gb_TotalIncome = new System.Windows.Forms.GroupBox();
			this.panel_TotalIncome = new System.Windows.Forms.Panel();
			this.lbl_TotalIncome = new System.Windows.Forms.Label();
			this.tlp_GroupTotalAmounts = new System.Windows.Forms.TableLayoutPanel();
			this.lbl_MiniCafeAmount = new System.Windows.Forms.Label();
			this.lbl_GasStationAmount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tlp_GroupGasStationAndMiniCafe.SuspendLayout();
			this.gb_GasStation.SuspendLayout();
			this.gb_MiniCafe.SuspendLayout();
			this.gb_TotalAmount.SuspendLayout();
			this.panel_TotalAmount.SuspendLayout();
			this.gb_GasStationPay.SuspendLayout();
			this.gb_MiniCafePay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tlp_GroupTotalAmountForPayment.SuspendLayout();
			this.gb_TotalIncome.SuspendLayout();
			this.panel_TotalIncome.SuspendLayout();
			this.tlp_GroupTotalAmounts.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Black;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tlp_GroupGasStationAndMiniCafe);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.splitContainer1.Panel2.Controls.Add(this.tlp_GroupTotalAmounts);
			this.splitContainer1.Size = new System.Drawing.Size(875, 604);
			this.splitContainer1.SplitterDistance = 462;
			this.splitContainer1.TabIndex = 0;
			// 
			// tlp_GroupGasStationAndMiniCafe
			// 
			this.tlp_GroupGasStationAndMiniCafe.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.tlp_GroupGasStationAndMiniCafe.ColumnCount = 2;
			this.tlp_GroupGasStationAndMiniCafe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_GroupGasStationAndMiniCafe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_GroupGasStationAndMiniCafe.Controls.Add(this.gb_GasStation, 0, 0);
			this.tlp_GroupGasStationAndMiniCafe.Controls.Add(this.gb_MiniCafe, 1, 0);
			this.tlp_GroupGasStationAndMiniCafe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_GroupGasStationAndMiniCafe.Location = new System.Drawing.Point(0, 0);
			this.tlp_GroupGasStationAndMiniCafe.Name = "tlp_GroupGasStationAndMiniCafe";
			this.tlp_GroupGasStationAndMiniCafe.RowCount = 1;
			this.tlp_GroupGasStationAndMiniCafe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_GroupGasStationAndMiniCafe.Size = new System.Drawing.Size(875, 462);
			this.tlp_GroupGasStationAndMiniCafe.TabIndex = 0;
			// 
			// gb_GasStation
			// 
			this.gb_GasStation.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.gb_GasStation.Controls.Add(this.gb_GasStationPay);
			this.gb_GasStation.Controls.Add(this.panel_GasStation);
			this.gb_GasStation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_GasStation.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Italic);
			this.gb_GasStation.Location = new System.Drawing.Point(3, 3);
			this.gb_GasStation.Name = "gb_GasStation";
			this.gb_GasStation.Size = new System.Drawing.Size(431, 456);
			this.gb_GasStation.TabIndex = 0;
			this.gb_GasStation.TabStop = false;
			this.gb_GasStation.Text = "Автозаправка";
			// 
			// gb_MiniCafe
			// 
			this.gb_MiniCafe.Controls.Add(this.gb_MiniCafePay);
			this.gb_MiniCafe.Controls.Add(this.panel_MiniCafe);
			this.gb_MiniCafe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_MiniCafe.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gb_MiniCafe.Location = new System.Drawing.Point(440, 3);
			this.gb_MiniCafe.Name = "gb_MiniCafe";
			this.gb_MiniCafe.Size = new System.Drawing.Size(432, 456);
			this.gb_MiniCafe.TabIndex = 1;
			this.gb_MiniCafe.TabStop = false;
			this.gb_MiniCafe.Text = "Міні-Кафе";
			// 
			// gb_TotalAmount
			// 
			this.gb_TotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_TotalAmount.Controls.Add(this.panel_TotalAmount);
			this.gb_TotalAmount.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Italic);
			this.gb_TotalAmount.Location = new System.Drawing.Point(3, 3);
			this.gb_TotalAmount.Name = "gb_TotalAmount";
			this.gb_TotalAmount.Size = new System.Drawing.Size(559, 132);
			this.gb_TotalAmount.TabIndex = 0;
			this.gb_TotalAmount.TabStop = false;
			this.gb_TotalAmount.Text = "Всього до сплати";
			// 
			// panel_GasStation
			// 
			this.panel_GasStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_GasStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panel_GasStation.Location = new System.Drawing.Point(6, 27);
			this.panel_GasStation.Name = "panel_GasStation";
			this.panel_GasStation.Size = new System.Drawing.Size(421, 323);
			this.panel_GasStation.TabIndex = 0;
			// 
			// panel_MiniCafe
			// 
			this.panel_MiniCafe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_MiniCafe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panel_MiniCafe.Location = new System.Drawing.Point(6, 27);
			this.panel_MiniCafe.Name = "panel_MiniCafe";
			this.panel_MiniCafe.Size = new System.Drawing.Size(422, 323);
			this.panel_MiniCafe.TabIndex = 1;
			// 
			// panel_TotalAmount
			// 
			this.panel_TotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_TotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panel_TotalAmount.Controls.Add(this.tlp_GroupTotalAmountForPayment);
			this.panel_TotalAmount.Location = new System.Drawing.Point(6, 27);
			this.panel_TotalAmount.Name = "panel_TotalAmount";
			this.panel_TotalAmount.Size = new System.Drawing.Size(545, 97);
			this.panel_TotalAmount.TabIndex = 0;
			// 
			// gb_GasStationPay
			// 
			this.gb_GasStationPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_GasStationPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.gb_GasStationPay.Controls.Add(this.lbl_GasStationAmount);
			this.gb_GasStationPay.Location = new System.Drawing.Point(6, 353);
			this.gb_GasStationPay.Name = "gb_GasStationPay";
			this.gb_GasStationPay.Size = new System.Drawing.Size(422, 100);
			this.gb_GasStationPay.TabIndex = 0;
			this.gb_GasStationPay.TabStop = false;
			this.gb_GasStationPay.Text = "До оплати";
			// 
			// gb_MiniCafePay
			// 
			this.gb_MiniCafePay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_MiniCafePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.gb_MiniCafePay.Controls.Add(this.lbl_MiniCafeAmount);
			this.gb_MiniCafePay.Location = new System.Drawing.Point(6, 353);
			this.gb_MiniCafePay.Name = "gb_MiniCafePay";
			this.gb_MiniCafePay.Size = new System.Drawing.Size(421, 100);
			this.gb_MiniCafePay.TabIndex = 1;
			this.gb_MiniCafePay.TabStop = false;
			this.gb_MiniCafePay.Text = "До оплати";
			// 
			// lbl_TotalAmount
			// 
			this.lbl_TotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbl_TotalAmount.AutoSize = true;
			this.lbl_TotalAmount.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Italic);
			this.lbl_TotalAmount.Location = new System.Drawing.Point(395, 29);
			this.lbl_TotalAmount.Name = "lbl_TotalAmount";
			this.lbl_TotalAmount.Size = new System.Drawing.Size(89, 38);
			this.lbl_TotalAmount.TabIndex = 0;
			this.lbl_TotalAmount.Text = "0.00";
			// 
			// btn_Count
			// 
			this.btn_Count.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_Count.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Count.Location = new System.Drawing.Point(128, 3);
			this.btn_Count.Name = "btn_Count";
			this.btn_Count.Size = new System.Drawing.Size(203, 91);
			this.btn_Count.TabIndex = 1;
			this.btn_Count.Text = "Прорахувати";
			this.btn_Count.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(119, 91);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// tlp_GroupTotalAmountForPayment
			// 
			this.tlp_GroupTotalAmountForPayment.ColumnCount = 3;
			this.tlp_GroupTotalAmountForPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66678F));
			this.tlp_GroupTotalAmountForPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77867F));
			this.tlp_GroupTotalAmountForPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77867F));
			this.tlp_GroupTotalAmountForPayment.Controls.Add(this.pictureBox1, 0, 0);
			this.tlp_GroupTotalAmountForPayment.Controls.Add(this.btn_Count, 1, 0);
			this.tlp_GroupTotalAmountForPayment.Controls.Add(this.lbl_TotalAmount, 2, 0);
			this.tlp_GroupTotalAmountForPayment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_GroupTotalAmountForPayment.Location = new System.Drawing.Point(0, 0);
			this.tlp_GroupTotalAmountForPayment.Name = "tlp_GroupTotalAmountForPayment";
			this.tlp_GroupTotalAmountForPayment.RowCount = 1;
			this.tlp_GroupTotalAmountForPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_GroupTotalAmountForPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp_GroupTotalAmountForPayment.Size = new System.Drawing.Size(545, 97);
			this.tlp_GroupTotalAmountForPayment.TabIndex = 0;
			// 
			// gb_TotalIncome
			// 
			this.gb_TotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_TotalIncome.Controls.Add(this.panel_TotalIncome);
			this.gb_TotalIncome.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Italic);
			this.gb_TotalIncome.Location = new System.Drawing.Point(568, 3);
			this.gb_TotalIncome.Name = "gb_TotalIncome";
			this.gb_TotalIncome.Size = new System.Drawing.Size(304, 132);
			this.gb_TotalIncome.TabIndex = 1;
			this.gb_TotalIncome.TabStop = false;
			this.gb_TotalIncome.Text = "Загальна сума виторгу за день";
			// 
			// panel_TotalIncome
			// 
			this.panel_TotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_TotalIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panel_TotalIncome.Controls.Add(this.lbl_TotalIncome);
			this.panel_TotalIncome.Location = new System.Drawing.Point(6, 27);
			this.panel_TotalIncome.Name = "panel_TotalIncome";
			this.panel_TotalIncome.Size = new System.Drawing.Size(288, 97);
			this.panel_TotalIncome.TabIndex = 0;
			// 
			// lbl_TotalIncome
			// 
			this.lbl_TotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_TotalIncome.AutoSize = true;
			this.lbl_TotalIncome.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Italic);
			this.lbl_TotalIncome.Location = new System.Drawing.Point(104, 31);
			this.lbl_TotalIncome.Name = "lbl_TotalIncome";
			this.lbl_TotalIncome.Size = new System.Drawing.Size(89, 38);
			this.lbl_TotalIncome.TabIndex = 1;
			this.lbl_TotalIncome.Text = "0.00";
			// 
			// tlp_GroupTotalAmounts
			// 
			this.tlp_GroupTotalAmounts.ColumnCount = 2;
			this.tlp_GroupTotalAmounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.60283F));
			this.tlp_GroupTotalAmounts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.39717F));
			this.tlp_GroupTotalAmounts.Controls.Add(this.gb_TotalAmount, 0, 0);
			this.tlp_GroupTotalAmounts.Controls.Add(this.gb_TotalIncome, 1, 0);
			this.tlp_GroupTotalAmounts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_GroupTotalAmounts.Location = new System.Drawing.Point(0, 0);
			this.tlp_GroupTotalAmounts.Name = "tlp_GroupTotalAmounts";
			this.tlp_GroupTotalAmounts.RowCount = 1;
			this.tlp_GroupTotalAmounts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_GroupTotalAmounts.Size = new System.Drawing.Size(875, 138);
			this.tlp_GroupTotalAmounts.TabIndex = 0;
			// 
			// lbl_MiniCafeAmount
			// 
			this.lbl_MiniCafeAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_MiniCafeAmount.AutoSize = true;
			this.lbl_MiniCafeAmount.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Italic);
			this.lbl_MiniCafeAmount.Location = new System.Drawing.Point(232, 24);
			this.lbl_MiniCafeAmount.Name = "lbl_MiniCafeAmount";
			this.lbl_MiniCafeAmount.Size = new System.Drawing.Size(89, 38);
			this.lbl_MiniCafeAmount.TabIndex = 2;
			this.lbl_MiniCafeAmount.Text = "0.00";
			// 
			// lbl_GasStationAmount
			// 
			this.lbl_GasStationAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_GasStationAmount.AutoSize = true;
			this.lbl_GasStationAmount.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_GasStationAmount.Location = new System.Drawing.Point(243, 24);
			this.lbl_GasStationAmount.Name = "lbl_GasStationAmount";
			this.lbl_GasStationAmount.Size = new System.Drawing.Size(89, 38);
			this.lbl_GasStationAmount.TabIndex = 3;
			this.lbl_GasStationAmount.Text = "0.00";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 604);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(891, 643);
			this.Name = "Form1";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tlp_GroupGasStationAndMiniCafe.ResumeLayout(false);
			this.gb_GasStation.ResumeLayout(false);
			this.gb_MiniCafe.ResumeLayout(false);
			this.gb_TotalAmount.ResumeLayout(false);
			this.panel_TotalAmount.ResumeLayout(false);
			this.gb_GasStationPay.ResumeLayout(false);
			this.gb_GasStationPay.PerformLayout();
			this.gb_MiniCafePay.ResumeLayout(false);
			this.gb_MiniCafePay.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tlp_GroupTotalAmountForPayment.ResumeLayout(false);
			this.tlp_GroupTotalAmountForPayment.PerformLayout();
			this.gb_TotalIncome.ResumeLayout(false);
			this.panel_TotalIncome.ResumeLayout(false);
			this.panel_TotalIncome.PerformLayout();
			this.tlp_GroupTotalAmounts.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tlp_GroupGasStationAndMiniCafe;
		private System.Windows.Forms.GroupBox gb_GasStation;
		private System.Windows.Forms.Panel panel_GasStation;
		private System.Windows.Forms.GroupBox gb_MiniCafe;
		private System.Windows.Forms.Panel panel_MiniCafe;
		private System.Windows.Forms.GroupBox gb_TotalAmount;
		private System.Windows.Forms.Panel panel_TotalAmount;
		private System.Windows.Forms.GroupBox gb_GasStationPay;
		private System.Windows.Forms.GroupBox gb_MiniCafePay;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_Count;
		private System.Windows.Forms.Label lbl_TotalAmount;
		private System.Windows.Forms.TableLayoutPanel tlp_GroupTotalAmountForPayment;
		private System.Windows.Forms.GroupBox gb_TotalIncome;
		private System.Windows.Forms.Panel panel_TotalIncome;
		private System.Windows.Forms.Label lbl_TotalIncome;
		private System.Windows.Forms.TableLayoutPanel tlp_GroupTotalAmounts;
		private System.Windows.Forms.Label lbl_GasStationAmount;
		private System.Windows.Forms.Label lbl_MiniCafeAmount;
	}
}

