using Rest1.Properties;
using System.Resources;

namespace Rest1
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Category_2 = new System.Windows.Forms.Button();
            this.Category_3 = new System.Windows.Forms.Button();
            this.Category_4 = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Database = new System.Windows.Forms.Button();
            this.Delete_Selected = new System.Windows.Forms.Button();
            this.Category_5 = new System.Windows.Forms.Button();
            this.Category_6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Category_1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Chocolate;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(461, 565);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 356;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 48;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.ForestGreen;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.Submit.ForeColor = System.Drawing.Color.Snow;
            this.Submit.Location = new System.Drawing.Point(500, 601);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(160, 68);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(670, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 68);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Category_2
            // 
            this.Category_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Category_2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Category_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Category_2.BackgroundImage")));
            this.Category_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Category_2.FlatAppearance.BorderSize = 0;
            this.Category_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_2.ForeColor = System.Drawing.Color.Transparent;
            this.Category_2.Location = new System.Drawing.Point(583, 60);
            this.Category_2.Name = "Category_2";
            this.Category_2.Size = new System.Drawing.Size(77, 77);
            this.Category_2.TabIndex = 7;
            this.Category_2.Text = "ÇORBA";
            this.Category_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Category_2.UseVisualStyleBackColor = false;
            this.Category_2.Click += new System.EventHandler(this.Category_2_Click);
            // 
            // Category_3
            // 
            this.Category_3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Category_3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Category_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Category_3.BackgroundImage")));
            this.Category_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Category_3.FlatAppearance.BorderSize = 0;
            this.Category_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_3.ForeColor = System.Drawing.Color.Transparent;
            this.Category_3.Location = new System.Drawing.Point(749, 59);
            this.Category_3.Name = "Category_3";
            this.Category_3.Size = new System.Drawing.Size(77, 77);
            this.Category_3.TabIndex = 8;
            this.Category_3.Text = "TATLI";
            this.Category_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Category_3.UseVisualStyleBackColor = false;
            this.Category_3.Click += new System.EventHandler(this.Category_3_Click);
            // 
            // Category_4
            // 
            this.Category_4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Category_4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Category_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Category_4.BackgroundImage")));
            this.Category_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Category_4.FlatAppearance.BorderSize = 0;
            this.Category_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_4.ForeColor = System.Drawing.Color.Transparent;
            this.Category_4.Location = new System.Drawing.Point(832, 59);
            this.Category_4.Name = "Category_4";
            this.Category_4.Size = new System.Drawing.Size(77, 77);
            this.Category_4.TabIndex = 10;
            this.Category_4.Text = "İÇECEK";
            this.Category_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Category_4.UseVisualStyleBackColor = false;
            this.Category_4.Click += new System.EventHandler(this.Category_4_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.History.Cursor = System.Windows.Forms.Cursors.Default;
            this.History.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.History.FlatAppearance.BorderSize = 0;
            this.History.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.History.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.History.Location = new System.Drawing.Point(500, 12);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(243, 42);
            this.History.TabIndex = 13;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Database
            // 
            this.Database.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Database.FlatAppearance.BorderSize = 0;
            this.Database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Database.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.Database.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Database.Location = new System.Drawing.Point(749, 11);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(243, 42);
            this.Database.TabIndex = 14;
            this.Database.Text = "Database";
            this.Database.UseVisualStyleBackColor = false;
            this.Database.Click += new System.EventHandler(this.Database_Click);
            // 
            // Delete_Selected
            // 
            this.Delete_Selected.BackColor = System.Drawing.Color.IndianRed;
            this.Delete_Selected.FlatAppearance.BorderSize = 0;
            this.Delete_Selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Selected.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.Delete_Selected.ForeColor = System.Drawing.Color.Snow;
            this.Delete_Selected.Location = new System.Drawing.Point(836, 601);
            this.Delete_Selected.Name = "Delete_Selected";
            this.Delete_Selected.Size = new System.Drawing.Size(156, 68);
            this.Delete_Selected.TabIndex = 5;
            this.Delete_Selected.Text = "Delete Item";
            this.Delete_Selected.UseVisualStyleBackColor = false;
            this.Delete_Selected.Click += new System.EventHandler(this.button3_Click);
            // 
            // Category_5
            // 
            this.Category_5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Category_5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Category_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Category_5.BackgroundImage")));
            this.Category_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Category_5.FlatAppearance.BorderSize = 0;
            this.Category_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_5.ForeColor = System.Drawing.Color.Transparent;
            this.Category_5.Location = new System.Drawing.Point(666, 59);
            this.Category_5.Name = "Category_5";
            this.Category_5.Size = new System.Drawing.Size(77, 77);
            this.Category_5.TabIndex = 16;
            this.Category_5.Text = "KAHVALTI";
            this.Category_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Category_5.UseVisualStyleBackColor = false;
            this.Category_5.Click += new System.EventHandler(this.Category_5_Click);
            // 
            // Category_6
            // 
            this.Category_6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Category_6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Category_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Category_6.FlatAppearance.BorderSize = 0;
            this.Category_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_6.ForeColor = System.Drawing.Color.Transparent;
            this.Category_6.Location = new System.Drawing.Point(915, 59);
            this.Category_6.Name = "Category_6";
            this.Category_6.Size = new System.Drawing.Size(77, 77);
            this.Category_6.TabIndex = 17;
            this.Category_6.Text = "Close ALL";
            this.Category_6.UseVisualStyleBackColor = false;
            this.Category_6.Click += new System.EventHandler(this.Category_6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(395, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Yu Gothic Medium", 18F, System.Drawing.FontStyle.Bold);
            this.Total.ForeColor = System.Drawing.Color.Chocolate;
            this.Total.Location = new System.Drawing.Point(326, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(28, 31);
            this.Total.TabIndex = 20;
            this.Total.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.32446F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.67554F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Total, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 612);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 50);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(16, 0);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(500, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(492, 452);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // Category_1
            // 
            this.Category_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Category_1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Category_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Category_1.BackgroundImage")));
            this.Category_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Category_1.FlatAppearance.BorderSize = 0;
            this.Category_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_1.ForeColor = System.Drawing.Color.Transparent;
            this.Category_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Category_1.ImageKey = "(none)";
            this.Category_1.Location = new System.Drawing.Point(500, 60);
            this.Category_1.Name = "Category_1";
            this.Category_1.Size = new System.Drawing.Size(77, 77);
            this.Category_1.TabIndex = 6;
            this.Category_1.Text = "YEMEK";
            this.Category_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Category_1.UseVisualStyleBackColor = false;
            this.Category_1.Click += new System.EventHandler(this.Category_1_Click);
            // 
            // Orders
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Category_3);
            this.Controls.Add(this.Delete_Selected);
            this.Controls.Add(this.Category_5);
            this.Controls.Add(this.Category_6);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Category_4);
            this.Controls.Add(this.Category_2);
            this.Controls.Add(this.Category_1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Orders";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Orders_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Category_2;
        private System.Windows.Forms.Button Category_3;
        private System.Windows.Forms.Button Category_4;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Database;
        public System.Windows.Forms.Button Category_1;
        private System.Windows.Forms.Button Delete_Selected;
        private System.Windows.Forms.Button Category_5;
        private System.Windows.Forms.Button Category_6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

