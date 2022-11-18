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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
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
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_EditProduct = new System.Windows.Forms.Button();
			this.btn_DelProduct = new System.Windows.Forms.Button();
			this.btn_AddProduct = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.моваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.українськаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Col_Fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_PriceFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
			// 
			// splitContainer1.Panel2
			// 
			resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.Indigo;
			this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.GridFuel);
			this.panel1.Name = "panel1";
			// 
			// GridFuel
			// 
			resources.ApplyResources(this.GridFuel, "GridFuel");
			this.GridFuel.AllowUserToAddRows = false;
			this.GridFuel.AllowUserToDeleteRows = false;
			this.GridFuel.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.GridFuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.GridFuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridFuel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Fuel,
            this.Col_PriceFuel});
			this.GridFuel.GridColor = System.Drawing.Color.Black;
			this.GridFuel.Name = "GridFuel";
			// 
			// tableLayoutPanel3
			// 
			resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
			this.tableLayoutPanel3.Controls.Add(this.btn_AddFuel, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btn_DelFuel, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.btn_EditFuel, 2, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			// 
			// btn_AddFuel
			// 
			resources.ApplyResources(this.btn_AddFuel, "btn_AddFuel");
			this.btn_AddFuel.Name = "btn_AddFuel";
			this.btn_AddFuel.UseVisualStyleBackColor = true;
			this.btn_AddFuel.Click += new System.EventHandler(this.btn_AddGoods_Click);
			// 
			// btn_DelFuel
			// 
			resources.ApplyResources(this.btn_DelFuel, "btn_DelFuel");
			this.btn_DelFuel.Name = "btn_DelFuel";
			this.btn_DelFuel.UseVisualStyleBackColor = true;
			this.btn_DelFuel.Click += new System.EventHandler(this.btn_DelGoods_Click);
			// 
			// btn_EditFuel
			// 
			resources.ApplyResources(this.btn_EditFuel, "btn_EditFuel");
			this.btn_EditFuel.Name = "btn_EditFuel";
			this.btn_EditFuel.UseVisualStyleBackColor = true;
			this.btn_EditFuel.Click += new System.EventHandler(this.btn_EditGoods_Click);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Indigo;
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// panel2
			// 
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Controls.Add(this.GridProduct);
			this.panel2.Name = "panel2";
			// 
			// GridProduct
			// 
			resources.ApplyResources(this.GridProduct, "GridProduct");
			this.GridProduct.AllowUserToAddRows = false;
			this.GridProduct.AllowUserToDeleteRows = false;
			this.GridProduct.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.GridProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Products,
            this.Col_PriceProduct});
			this.GridProduct.GridColor = System.Drawing.Color.Black;
			this.GridProduct.Name = "GridProduct";
			// 
			// tableLayoutPanel4
			// 
			resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
			this.tableLayoutPanel4.Controls.Add(this.btn_EditProduct, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.btn_DelProduct, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.btn_AddProduct, 0, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			// 
			// btn_EditProduct
			// 
			resources.ApplyResources(this.btn_EditProduct, "btn_EditProduct");
			this.btn_EditProduct.Name = "btn_EditProduct";
			this.btn_EditProduct.UseVisualStyleBackColor = true;
			this.btn_EditProduct.Click += new System.EventHandler(this.btn_EditGoods_Click);
			// 
			// btn_DelProduct
			// 
			resources.ApplyResources(this.btn_DelProduct, "btn_DelProduct");
			this.btn_DelProduct.Name = "btn_DelProduct";
			this.btn_DelProduct.UseVisualStyleBackColor = true;
			this.btn_DelProduct.Click += new System.EventHandler(this.btn_DelGoods_Click);
			// 
			// btn_AddProduct
			// 
			resources.ApplyResources(this.btn_AddProduct, "btn_AddProduct");
			this.btn_AddProduct.Name = "btn_AddProduct";
			this.btn_AddProduct.UseVisualStyleBackColor = true;
			this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddGoods_Click);
			// 
			// menuStrip1
			// 
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моваToolStripMenuItem});
			this.menuStrip1.Name = "menuStrip1";
			// 
			// моваToolStripMenuItem
			// 
			resources.ApplyResources(this.моваToolStripMenuItem, "моваToolStripMenuItem");
			this.моваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.українськаToolStripMenuItem});
			this.моваToolStripMenuItem.Name = "моваToolStripMenuItem";
			// 
			// englishToolStripMenuItem
			// 
			resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
			// 
			// українськаToolStripMenuItem
			// 
			resources.ApplyResources(this.українськаToolStripMenuItem, "українськаToolStripMenuItem");
			this.українськаToolStripMenuItem.Name = "українськаToolStripMenuItem";
			this.українськаToolStripMenuItem.Click += new System.EventHandler(this.українськаToolStripMenuItem_Click);
			// 
			// Col_Fuel
			// 
			this.Col_Fuel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Col_Fuel.DataPropertyName = "ProductName";
			resources.ApplyResources(this.Col_Fuel, "Col_Fuel");
			this.Col_Fuel.Name = "Col_Fuel";
			this.Col_Fuel.ReadOnly = true;
			// 
			// Col_PriceFuel
			// 
			this.Col_PriceFuel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Col_PriceFuel.DataPropertyName = "Price";
			resources.ApplyResources(this.Col_PriceFuel, "Col_PriceFuel");
			this.Col_PriceFuel.Name = "Col_PriceFuel";
			this.Col_PriceFuel.ReadOnly = true;
			// 
			// Col_Products
			// 
			this.Col_Products.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Col_Products.DataPropertyName = "ProductName";
			resources.ApplyResources(this.Col_Products, "Col_Products");
			this.Col_Products.Name = "Col_Products";
			this.Col_Products.ReadOnly = true;
			// 
			// Col_PriceProduct
			// 
			this.Col_PriceProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Col_PriceProduct.DataPropertyName = "Price";
			resources.ApplyResources(this.Col_PriceProduct, "Col_PriceProduct");
			this.Col_PriceProduct.Name = "Col_PriceProduct";
			this.Col_PriceProduct.ReadOnly = true;
			// 
			// AdminForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Name = "AdminForm";
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
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.Button btn_EditProduct;
		private System.Windows.Forms.Button btn_DelProduct;
		private System.Windows.Forms.Button btn_AddProduct;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem моваToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem українськаToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_Fuel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_PriceFuel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_Products;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_PriceProduct;
	}
}