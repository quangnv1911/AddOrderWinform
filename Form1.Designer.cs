namespace Lab_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbEmployees = new ComboBox();
            cbCustomers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dgvListProduct = new DataGridView();
            groupBox2 = new GroupBox();
            dgvOrderList = new DataGridView();
            label8 = new Label();
            dtpRequireDate = new DateTimePicker();
            btnAdd = new Button();
            label6 = new Label();
            tbTotalPrice = new TextBox();
            gbShip = new GroupBox();
            tbCountry = new TextBox();
            tbCity = new TextBox();
            tbAddress = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            gbShip.SuspendLayout();
            SuspendLayout();
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(93, 12);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(151, 28);
            cbEmployees.TabIndex = 0;
            cbEmployees.SelectedIndexChanged += cbEmployee_SelectedIndexChanged;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(642, 12);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(151, 28);
            cbCustomers.TabIndex = 1;
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Employee";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 20);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 15);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 4;
            label3.Text = "Require Date";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvListProduct);
            groupBox1.Location = new Point(0, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(793, 364);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Product";
            // 
            // dgvListProduct
            // 
            dgvListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProduct.Dock = DockStyle.Fill;
            dgvListProduct.Location = new Point(3, 23);
            dgvListProduct.Name = "dgvListProduct";
            dgvListProduct.RowHeadersWidth = 51;
            dgvListProduct.RowTemplate.Height = 29;
            dgvListProduct.Size = new Size(787, 338);
            dgvListProduct.TabIndex = 0;
            dgvListProduct.CellContentClick += DgvListProduct_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvOrderList);
            groupBox2.Location = new Point(816, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 406);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Detail";
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(0, 29);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new Size(447, 384);
            dgvOrderList.TabIndex = 3;
            dgvOrderList.CellContentClick += dgvOrderList_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(953, 442);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 9;
            label8.Text = "Total";
            // 
            // dtpRequireDate
            // 
            dtpRequireDate.Format = DateTimePickerFormat.Short;
            dtpRequireDate.Location = new Point(380, 12);
            dtpRequireDate.Name = "dtpRequireDate";
            dtpRequireDate.Size = new Size(148, 27);
            dtpRequireDate.TabIndex = 11;
            dtpRequireDate.ValueChanged += dtpRequireDate_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(992, 484);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(910, 431);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 17;
            // 
            // tbTotalPrice
            // 
            tbTotalPrice.Location = new Point(1037, 439);
            tbTotalPrice.Name = "tbTotalPrice";
            tbTotalPrice.Size = new Size(125, 27);
            tbTotalPrice.TabIndex = 4;
            tbTotalPrice.TextChanged += tbTotalPrice_TextChanged;
            // 
            // gbShip
            // 
            gbShip.Controls.Add(tbCountry);
            gbShip.Controls.Add(tbCity);
            gbShip.Controls.Add(tbAddress);
            gbShip.Controls.Add(label7);
            gbShip.Controls.Add(label5);
            gbShip.Controls.Add(label4);
            gbShip.Location = new Point(12, 46);
            gbShip.Name = "gbShip";
            gbShip.Size = new Size(778, 79);
            gbShip.TabIndex = 18;
            gbShip.TabStop = false;
            gbShip.Text = "Ship";
            gbShip.Enter += groupBox3_Enter;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(647, 38);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(125, 27);
            tbCountry.TabIndex = 6;
            tbCountry.TextChanged += tbCountry_TextChanged;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(424, 38);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(125, 27);
            tbCity.TabIndex = 5;
            tbCity.TextChanged += tbCity_TextChanged;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(81, 41);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(267, 27);
            tbAddress.TabIndex = 4;
            tbAddress.TextChanged += tbAddress_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(575, 45);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 3;
            label7.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 44);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 2;
            label5.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 41);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 1;
            label4.Text = "Address";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 534);
            Controls.Add(gbShip);
            Controls.Add(tbTotalPrice);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(btnAdd);
            Controls.Add(dtpRequireDate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbCustomers);
            Controls.Add(cbEmployees);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListProduct).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            gbShip.ResumeLayout(false);
            gbShip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private ComboBox cbEmployees;
        private ComboBox cbCustomers;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private DateTimePicker dtpRequireDate;
        private DataGridView dgvListProduct;
        private DataGridView dgvOrderList;
        private Button btnAdd;
        private Label label6;
        private TextBox tbTotalPrice;
        private GroupBox gbShip;
        private TextBox tbAddress;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox tbCountry;
        private TextBox tbCity;
    }
}