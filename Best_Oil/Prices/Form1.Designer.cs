namespace Prices
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.GridFuel = new System.Windows.Forms.DataGridView();
			this.GridProduct = new System.Windows.Forms.DataGridView();
			this.Col_Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_PriceFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridFuel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.GridFuel);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(376, 469);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.GridProduct);
			this.panel2.Location = new System.Drawing.Point(394, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(376, 469);
			this.panel2.TabIndex = 1;
			// 
			// GridFuel
			// 
			this.GridFuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridFuel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Col_Fuel,
			this.Col_PriceFuel});
			this.GridFuel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridFuel.Location = new System.Drawing.Point(0, 0);
			this.GridFuel.Name = "GridFuel";
			this.GridFuel.Size = new System.Drawing.Size(376, 469);
			this.GridFuel.TabIndex = 0;
			// 
			// GridProduct
			// 
			this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Col_Products,
			this.Col_PriceProduct});
			this.GridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridProduct.Location = new System.Drawing.Point(0, 0);
			this.GridProduct.Name = "GridProduct";
			this.GridProduct.Size = new System.Drawing.Size(376, 469);
			this.GridProduct.TabIndex = 2;
			// 
			// Col_Products
			// 
			this.Col_Products.DataPropertyName = "ProductName";
			this.Col_Products.HeaderText = "Products";
			this.Col_Products.Name = "Col_Products";
			this.Col_Products.Width = 166;
			// 
			// Col_PriceProduct
			// 
			this.Col_PriceProduct.DataPropertyName = "Price";
			this.Col_PriceProduct.HeaderText = "Price";
			this.Col_PriceProduct.Name = "Col_PriceProduct";
			this.Col_PriceProduct.Width = 166;
			// 
			// Col_Fuel
			// 
			this.Col_Fuel.DataPropertyName = "FuelName";
			this.Col_Fuel.HeaderText = "Fuel";
			this.Col_Fuel.Name = "Col_Fuel";
			this.Col_Fuel.Width = 166;
			// 
			// Col_PriceFuel
			// 
			this.Col_PriceFuel.DataPropertyName = "Price";
			this.Col_PriceFuel.HeaderText = "Price";
			this.Col_PriceFuel.Name = "Col_PriceFuel";
			this.Col_PriceFuel.Width = 166;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 493);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridFuel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView GridFuel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView GridProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_Products;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_PriceProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_Fuel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_PriceFuel;
	}
}