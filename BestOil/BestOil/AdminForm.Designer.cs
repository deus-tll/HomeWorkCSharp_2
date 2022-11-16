namespace BestOil
{
	partial class AdminForm
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.GridFuel = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_AddFuel = new System.Windows.Forms.Button();
			this.btn_DelFuel = new System.Windows.Forms.Button();
			this.btn_EditFuel = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.GridProduct = new System.Windows.Forms.DataGridView();
			this.Col_Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_EditProduct = new System.Windows.Forms.Button();
			this.btn_DelProduct = new System.Windows.Forms.Button();
			this.btn_AddProduct = new System.Windows.Forms.Button();
			this.Col_Fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_PriceFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridFuel)).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(782, 493);
			this.splitContainer1.SplitterDistance = 389;
			this.splitContainer1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.Indigo;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.95F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 493);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.GridFuel);
			this.panel1.Location = new System.Drawing.Point(3, 57);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(383, 433);
			this.panel1.TabIndex = 4;
			// 
			// GridFuel
			// 
			this.GridFuel.AllowUserToAddRows = false;
			this.GridFuel.AllowUserToDeleteRows = false;
			this.GridFuel.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.GridFuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.GridFuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridFuel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Fuel,
            this.Col_PriceFuel});
			this.GridFuel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridFuel.GridColor = System.Drawing.Color.Black;
			this.GridFuel.Location = new System.Drawing.Point(0, 0);
			this.GridFuel.Name = "GridFuel";
			this.GridFuel.Size = new System.Drawing.Size(383, 433);
			this.GridFuel.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel3.Controls.Add(this.btn_AddFuel, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btn_DelFuel, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.btn_EditFuel, 2, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(92, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(205, 48);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// btn_AddFuel
			// 
			this.btn_AddFuel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_AddFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_AddFuel.Location = new System.Drawing.Point(3, 3);
			this.btn_AddFuel.Name = "btn_AddFuel";
			this.btn_AddFuel.Size = new System.Drawing.Size(62, 42);
			this.btn_AddFuel.TabIndex = 0;
			this.btn_AddFuel.Text = "➕";
			this.btn_AddFuel.UseVisualStyleBackColor = true;
			this.btn_AddFuel.Click += new System.EventHandler(this.btn_AddGoods_Click);
			// 
			// btn_DelFuel
			// 
			this.btn_DelFuel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_DelFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.btn_DelFuel.Location = new System.Drawing.Point(71, 3);
			this.btn_DelFuel.Name = "btn_DelFuel";
			this.btn_DelFuel.Size = new System.Drawing.Size(62, 42);
			this.btn_DelFuel.TabIndex = 1;
			this.btn_DelFuel.Text = "🗑";
			this.btn_DelFuel.UseVisualStyleBackColor = true;
			this.btn_DelFuel.Click += new System.EventHandler(this.btn_DelGoods_Click);
			// 
			// btn_EditFuel
			// 
			this.btn_EditFuel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_EditFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.btn_EditFuel.Location = new System.Drawing.Point(139, 3);
			this.btn_EditFuel.Name = "btn_EditFuel";
			this.btn_EditFuel.Size = new System.Drawing.Size(63, 42);
			this.btn_EditFuel.TabIndex = 2;
			this.btn_EditFuel.Text = "✍";
			this.btn_EditFuel.UseVisualStyleBackColor = true;
			this.btn_EditFuel.Click += new System.EventHandler(this.btn_EditGoods_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Indigo;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05328F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.94672F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(389, 493);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.GridProduct);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 57);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(383, 433);
			this.panel2.TabIndex = 5;
			// 
			// GridProduct
			// 
			this.GridProduct.AllowUserToAddRows = false;
			this.GridProduct.AllowUserToDeleteRows = false;
			this.GridProduct.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.GridProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Products,
            this.Col_PriceProduct});
			this.GridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridProduct.GridColor = System.Drawing.Color.Black;
			this.GridProduct.Location = new System.Drawing.Point(0, 0);
			this.GridProduct.Name = "GridProduct";
			this.GridProduct.Size = new System.Drawing.Size(383, 433);
			this.GridProduct.TabIndex = 2;
			// 
			// Col_Products
			// 
			this.Col_Products.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Col_Products.DataPropertyName = "ProductName";
			this.Col_Products.HeaderText = "Products";
			this.Col_Products.Name = "Col_Products";
			this.Col_Products.ReadOnly = true;
			// 
			// Col_PriceProduct
			// 
			this.Col_PriceProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Col_PriceProduct.DataPropertyName = "Price";
			this.Col_PriceProduct.HeaderText = "Price";
			this.Col_PriceProduct.Name = "Col_PriceProduct";
			this.Col_PriceProduct.ReadOnly = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.Controls.Add(this.btn_EditProduct, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.btn_DelProduct, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.btn_AddProduct, 0, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(92, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(205, 48);
			this.tableLayoutPanel4.TabIndex = 6;
			// 
			// btn_EditProduct
			// 
			this.btn_EditProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_EditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.btn_EditProduct.Location = new System.Drawing.Point(139, 3);
			this.btn_EditProduct.Name = "btn_EditProduct";
			this.btn_EditProduct.Size = new System.Drawing.Size(63, 42);
			this.btn_EditProduct.TabIndex = 5;
			this.btn_EditProduct.Text = "✍";
			this.btn_EditProduct.UseVisualStyleBackColor = true;
			this.btn_EditProduct.Click += new System.EventHandler(this.btn_EditGoods_Click);
			// 
			// btn_DelProduct
			// 
			this.btn_DelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_DelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.btn_DelProduct.Location = new System.Drawing.Point(71, 3);
			this.btn_DelProduct.Name = "btn_DelProduct";
			this.btn_DelProduct.Size = new System.Drawing.Size(62, 42);
			this.btn_DelProduct.TabIndex = 4;
			this.btn_DelProduct.Text = "🗑";
			this.btn_DelProduct.UseVisualStyleBackColor = true;
			this.btn_DelProduct.Click += new System.EventHandler(this.btn_DelGoods_Click);
			// 
			// btn_AddProduct
			// 
			this.btn_AddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_AddProduct.Location = new System.Drawing.Point(3, 3);
			this.btn_AddProduct.Name = "btn_AddProduct";
			this.btn_AddProduct.Size = new System.Drawing.Size(62, 42);
			this.btn_AddProduct.TabIndex = 3;
			this.btn_AddProduct.Text = "➕";
			this.btn_AddProduct.UseVisualStyleBackColor = true;
			this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddGoods_Click);
			// 
			// Col_Fuel
			// 
			this.Col_Fuel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Col_Fuel.DataPropertyName = "ProductName";
			this.Col_Fuel.HeaderText = "Fuel";
			this.Col_Fuel.Name = "Col_Fuel";
			this.Col_Fuel.ReadOnly = true;
			// 
			// Col_PriceFuel
			// 
			this.Col_PriceFuel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Col_PriceFuel.DataPropertyName = "Price";
			this.Col_PriceFuel.HeaderText = "Price";
			this.Col_PriceFuel.Name = "Col_PriceFuel";
			this.Col_PriceFuel.ReadOnly = true;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 493);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(798, 532);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridFuel)).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView GridFuel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView GridProduct;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button btn_AddFuel;
		private System.Windows.Forms.Button btn_DelFuel;
		private System.Windows.Forms.Button btn_EditFuel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_Products;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_PriceProduct;
		private System.Windows.Forms.Button btn_EditProduct;
		private System.Windows.Forms.Button btn_DelProduct;
		private System.Windows.Forms.Button btn_AddProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_Fuel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_PriceFuel;
	}
}