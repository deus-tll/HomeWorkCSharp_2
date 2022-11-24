namespace Money
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("5 p", 0);
			System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("10 p", 1);
			System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("20 p", 2);
			System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("50 p", 3);
			System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("1 f", 4);
			System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("2 f", 5);
			System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("5 f", 6);
			System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("10 f", 7);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.listView1 = new System.Windows.Forms.ListView();
			this.imgL_Source = new System.Windows.Forms.ImageList(this.components);
			this.listView2 = new System.Windows.Forms.ListView();
			this.btn_Reset = new System.Windows.Forms.Button();
			this.lbl_Amount = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			listViewItem9.StateImageIndex = 0;
			listViewItem10.StateImageIndex = 0;
			listViewItem11.StateImageIndex = 0;
			listViewItem12.StateImageIndex = 0;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
			this.listView1.LargeImageList = this.imgL_Source;
			this.listView1.Location = new System.Drawing.Point(12, 125);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(231, 457);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
			// 
			// imgL_Source
			// 
			this.imgL_Source.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL_Source.ImageStream")));
			this.imgL_Source.TransparentColor = System.Drawing.Color.Transparent;
			this.imgL_Source.Images.SetKeyName(0, "5p.jpg");
			this.imgL_Source.Images.SetKeyName(1, "10p.jpg");
			this.imgL_Source.Images.SetKeyName(2, "20p.jpg");
			this.imgL_Source.Images.SetKeyName(3, "50p.jpg");
			this.imgL_Source.Images.SetKeyName(4, "1f.jpg");
			this.imgL_Source.Images.SetKeyName(5, "2f.jpg");
			this.imgL_Source.Images.SetKeyName(6, "5f.jpg");
			this.imgL_Source.Images.SetKeyName(7, "10f.jpg");
			// 
			// listView2
			// 
			this.listView2.AllowDrop = true;
			this.listView2.HideSelection = false;
			this.listView2.LargeImageList = this.imgL_Source;
			this.listView2.Location = new System.Drawing.Point(324, 125);
			this.listView2.MultiSelect = false;
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(534, 457);
			this.listView2.TabIndex = 1;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView2_DragDrop);
			this.listView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView2_DragEnter);
			// 
			// btn_Reset
			// 
			this.btn_Reset.Location = new System.Drawing.Point(783, 59);
			this.btn_Reset.Name = "btn_Reset";
			this.btn_Reset.Size = new System.Drawing.Size(75, 39);
			this.btn_Reset.TabIndex = 2;
			this.btn_Reset.Text = "Reset";
			this.btn_Reset.UseVisualStyleBackColor = true;
			this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
			// 
			// lbl_Amount
			// 
			this.lbl_Amount.AutoSize = true;
			this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_Amount.Location = new System.Drawing.Point(319, 63);
			this.lbl_Amount.Name = "lbl_Amount";
			this.lbl_Amount.Size = new System.Drawing.Size(65, 25);
			this.lbl_Amount.TabIndex = 3;
			this.lbl_Amount.Text = "0f 0p";
			this.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 594);
			this.Controls.Add(this.lbl_Amount);
			this.Controls.Add(this.btn_Reset);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.MaximumSize = new System.Drawing.Size(886, 633);
			this.MinimumSize = new System.Drawing.Size(886, 633);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ImageList imgL_Source;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.Button btn_Reset;
		private System.Windows.Forms.Label lbl_Amount;
	}
}

