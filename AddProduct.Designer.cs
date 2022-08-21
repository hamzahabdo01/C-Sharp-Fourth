namespace C_Sharp_Fourth
{
    partial class AddProduct
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
            this.Olabel = new System.Windows.Forms.Label();
            this.Inlabel = new System.Windows.Forms.Label();
            this.Plbl = new System.Windows.Forms.Label();
            this.Numlbl = new System.Windows.Forms.Label();
            this.Clbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_date = new System.Windows.Forms.Label();
            this.txt_ObjectName = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_inventory = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Sinventbut = new System.Windows.Forms.Button();
            this.Snamebut = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Item = new System.Windows.Forms.CheckedListBox();
            this.PaymentgroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.productCard1 = new C_Sharp_Fourth.ProductCard();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PaymentgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Olabel
            // 
            this.Olabel.AutoSize = true;
            this.Olabel.Location = new System.Drawing.Point(45, 70);
            this.Olabel.Name = "Olabel";
            this.Olabel.Size = new System.Drawing.Size(93, 17);
            this.Olabel.TabIndex = 0;
            this.Olabel.Text = "Object Name:";
            // 
            // Inlabel
            // 
            this.Inlabel.AutoSize = true;
            this.Inlabel.Location = new System.Drawing.Point(267, 70);
            this.Inlabel.Name = "Inlabel";
            this.Inlabel.Size = new System.Drawing.Size(127, 17);
            this.Inlabel.TabIndex = 1;
            this.Inlabel.Text = "Inventory Number:";
            // 
            // Plbl
            // 
            this.Plbl.AutoSize = true;
            this.Plbl.Location = new System.Drawing.Point(45, 117);
            this.Plbl.Name = "Plbl";
            this.Plbl.Size = new System.Drawing.Size(42, 17);
            this.Plbl.TabIndex = 2;
            this.Plbl.Text = "Price:";
            // 
            // Numlbl
            // 
            this.Numlbl.AutoSize = true;
            this.Numlbl.Location = new System.Drawing.Point(546, 67);
            this.Numlbl.Name = "Numlbl";
            this.Numlbl.Size = new System.Drawing.Size(62, 17);
            this.Numlbl.TabIndex = 3;
            this.Numlbl.Text = "Number:";
            // 
            // Clbl
            // 
            this.Clbl.AutoSize = true;
            this.Clbl.Location = new System.Drawing.Point(260, 117);
            this.Clbl.Name = "Clbl";
            this.Clbl.Size = new System.Drawing.Size(51, 17);
            this.Clbl.TabIndex = 4;
            this.Clbl.Text = "Count:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 24);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txt_date
            // 
            this.txt_date.AutoSize = true;
            this.txt_date.Location = new System.Drawing.Point(466, 117);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(42, 17);
            this.txt_date.TabIndex = 6;
            this.txt_date.Text = "Date:";
            // 
            // txt_ObjectName
            // 
            this.txt_ObjectName.Location = new System.Drawing.Point(144, 63);
            this.txt_ObjectName.Name = "txt_ObjectName";
            this.txt_ObjectName.Size = new System.Drawing.Size(100, 24);
            this.txt_ObjectName.TabIndex = 7;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(320, 110);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(100, 24);
            this.txt_count.TabIndex = 8;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(119, 110);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 24);
            this.txt_price.TabIndex = 9;
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(624, 61);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 24);
            this.txt_number.TabIndex = 10;
            // 
            // txt_inventory
            // 
            this.txt_inventory.Location = new System.Drawing.Point(402, 63);
            this.txt_inventory.Name = "txt_inventory";
            this.txt_inventory.Size = new System.Drawing.Size(100, 24);
            this.txt_inventory.TabIndex = 11;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(274, 157);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(185, 24);
            this.txt_search.TabIndex = 12;
            // 
            // Sinventbut
            // 
            this.Sinventbut.Location = new System.Drawing.Point(469, 157);
            this.Sinventbut.Name = "Sinventbut";
            this.Sinventbut.Size = new System.Drawing.Size(172, 23);
            this.Sinventbut.TabIndex = 13;
            this.Sinventbut.Text = "Search by Inventory";
            this.Sinventbut.UseVisualStyleBackColor = true;
            this.Sinventbut.Click += new System.EventHandler(this.Sinventbut_Click);
            // 
            // Snamebut
            // 
            this.Snamebut.Location = new System.Drawing.Point(647, 157);
            this.Snamebut.Name = "Snamebut";
            this.Snamebut.Size = new System.Drawing.Size(172, 23);
            this.Snamebut.TabIndex = 14;
            this.Snamebut.Text = "Search by Object Name";
            this.Snamebut.UseVisualStyleBackColor = true;
            this.Snamebut.Click += new System.EventHandler(this.Snamebut_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(757, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Available";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(48, 157);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 16;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(158, 157);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 17;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(771, 179);
            this.dataGridView1.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Item
            // 
            this.Item.FormattingEnabled = true;
            this.Item.Items.AddRange(new object[] {
            "Product Availability",
            "Delivery",
            "Expired or not"});
            this.Item.Location = new System.Drawing.Point(48, 410);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(180, 80);
            this.Item.TabIndex = 19;
            // 
            // PaymentgroupBox
            // 
            this.PaymentgroupBox.Controls.Add(this.radioButton2);
            this.PaymentgroupBox.Controls.Add(this.radioButton1);
            this.PaymentgroupBox.Location = new System.Drawing.Point(270, 410);
            this.PaymentgroupBox.Name = "PaymentgroupBox";
            this.PaymentgroupBox.Size = new System.Drawing.Size(200, 80);
            this.PaymentgroupBox.TabIndex = 20;
            this.PaymentgroupBox.TabStop = false;
            this.PaymentgroupBox.Text = "Payment";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(101, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "E-Birr";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Paypal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.Location = new System.Drawing.Point(256, 25);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(103, 17);
            this.Welcomelbl.TabIndex = 21;
            this.Welcomelbl.Text = "Welcome back:";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(388, 25);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 16);
            this.user.TabIndex = 22;
            // 
            // productCard1
            // 
            this.productCard1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.productCard1.Desc = null;
            this.productCard1.Location = new System.Drawing.Point(506, 410);
            this.productCard1.Name = "productCard1";
            this.productCard1.Price = null;
            this.productCard1.Size = new System.Drawing.Size(288, 161);
            this.productCard1.TabIndex = 23;
            this.productCard1.Title = null;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 646);
            this.Controls.Add(this.productCard1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Welcomelbl);
            this.Controls.Add(this.PaymentgroupBox);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Snamebut);
            this.Controls.Add(this.Sinventbut);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_inventory);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_ObjectName);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Clbl);
            this.Controls.Add(this.Numlbl);
            this.Controls.Add(this.Plbl);
            this.Controls.Add(this.Inlabel);
            this.Controls.Add(this.Olabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.PaymentgroupBox.ResumeLayout(false);
            this.PaymentgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Olabel;
        private System.Windows.Forms.Label Inlabel;
        private System.Windows.Forms.Label Plbl;
        private System.Windows.Forms.Label Numlbl;
        private System.Windows.Forms.Label Clbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txt_date;
        private System.Windows.Forms.TextBox txt_ObjectName;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_inventory;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button Sinventbut;
        private System.Windows.Forms.Button Snamebut;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox Item;
        private System.Windows.Forms.GroupBox PaymentgroupBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label Welcomelbl;
        private ProductCard productCard1;
    }
}