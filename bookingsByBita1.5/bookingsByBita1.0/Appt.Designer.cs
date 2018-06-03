namespace bookingsByBita1._0
{
    partial class Appt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSched = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.apptDate = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.spShowAllHairStylistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hairSalonDataSet = new bookingsByBita1._0.HairSalonDataSet();
            this.empName = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewHairStylists = new System.Windows.Forms.DataGridView();
            this.hairStrylistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersTableAdapter = new bookingsByBita1._0.HairSalonDataSetTableAdapters.CustomersTableAdapter();
            this.spShowAllHairStylistTableAdapter = new bookingsByBita1._0.HairSalonDataSetTableAdapters.spShowAllHairStylistTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spShowAllHairStylistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairSalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHairStylists)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bookings";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(530, 478);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 139);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Back";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSched
            // 
            this.btnSched.BackColor = System.Drawing.Color.Transparent;
            this.btnSched.FlatAppearance.BorderSize = 0;
            this.btnSched.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSched.ForeColor = System.Drawing.Color.Transparent;
            this.btnSched.Image = ((System.Drawing.Image)(resources.GetObject("btnSched.Image")));
            this.btnSched.Location = new System.Drawing.Point(188, 478);
            this.btnSched.Margin = new System.Windows.Forms.Padding(4);
            this.btnSched.Name = "btnSched";
            this.btnSched.Size = new System.Drawing.Size(196, 141);
            this.btnSched.TabIndex = 6;
            this.btnSched.Text = "Schedule";
            this.btnSched.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSched.UseVisualStyleBackColor = false;
            this.btnSched.Click += new System.EventHandler(this.btnSched_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Time :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(651, 246);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 30);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(254, 248);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(220, 30);
            this.dtpDate.TabIndex = 4;
            // 
            // apptDate
            // 
            this.apptDate.AutoSize = true;
            this.apptDate.BackColor = System.Drawing.Color.Transparent;
            this.apptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptDate.Location = new System.Drawing.Point(85, 249);
            this.apptDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apptDate.Name = "apptDate";
            this.apptDate.Size = new System.Drawing.Size(75, 29);
            this.apptDate.TabIndex = 29;
            this.apptDate.Text = "Date :";
            // 
            // txtEmpID
            // 
            this.txtEmpID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spShowAllHairStylistBindingSource, "Employee ID", true));
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(254, 184);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(220, 30);
            this.txtEmpID.TabIndex = 2;
            // 
            // spShowAllHairStylistBindingSource
            // 
            this.spShowAllHairStylistBindingSource.DataMember = "spShowAllHairStylist";
            this.spShowAllHairStylistBindingSource.DataSource = this.hairSalonDataSet;
            // 
            // hairSalonDataSet
            // 
            this.hairSalonDataSet.DataSetName = "HairSalonDataSet";
            this.hairSalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.BackColor = System.Drawing.Color.Transparent;
            this.empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(83, 185);
            this.empName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(163, 29);
            this.empName.TabIndex = 27;
            this.empName.Text = "Employee ID :";
            // 
            // txtCustID
            // 
            this.txtCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustID.Location = new System.Drawing.Point(675, 184);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(220, 30);
            this.txtCustID.TabIndex = 3;
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.BackColor = System.Drawing.Color.Transparent;
            this.custName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(506, 185);
            this.custName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(152, 29);
            this.custName.TabIndex = 25;
            this.custName.Text = "Customer ID:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(458, 87);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(200, 41);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AutoGenerateColumns = false;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.custFirstNameDataGridViewTextBoxColumn,
            this.custLastNameDataGridViewTextBoxColumn,
            this.custPhoneDataGridViewTextBoxColumn,
            this.custEmailDataGridViewTextBoxColumn});
            this.dataGridViewCustomers.DataSource = this.customerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomers.GridColor = System.Drawing.Color.Black;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(18, 343);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCustomers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(707, 128);
            this.dataGridViewCustomers.TabIndex = 34;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            // 
            // custFirstNameDataGridViewTextBoxColumn
            // 
            this.custFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustFirstName";
            this.custFirstNameDataGridViewTextBoxColumn.HeaderText = "CustFirstName";
            this.custFirstNameDataGridViewTextBoxColumn.Name = "custFirstNameDataGridViewTextBoxColumn";
            // 
            // custLastNameDataGridViewTextBoxColumn
            // 
            this.custLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustLastName";
            this.custLastNameDataGridViewTextBoxColumn.HeaderText = "CustLastName";
            this.custLastNameDataGridViewTextBoxColumn.Name = "custLastNameDataGridViewTextBoxColumn";
            // 
            // custPhoneDataGridViewTextBoxColumn
            // 
            this.custPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustPhone";
            this.custPhoneDataGridViewTextBoxColumn.HeaderText = "CustPhone";
            this.custPhoneDataGridViewTextBoxColumn.Name = "custPhoneDataGridViewTextBoxColumn";
            // 
            // custEmailDataGridViewTextBoxColumn
            // 
            this.custEmailDataGridViewTextBoxColumn.DataPropertyName = "CustEmail";
            this.custEmailDataGridViewTextBoxColumn.HeaderText = "CustEmail";
            this.custEmailDataGridViewTextBoxColumn.Name = "custEmailDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(bookingsByBita1._0.Customer);
            // 
            // dataGridViewHairStylists
            // 
            this.dataGridViewHairStylists.AutoGenerateColumns = false;
            this.dataGridViewHairStylists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHairStylists.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewHairStylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHairStylists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hairStrylistDataGridViewTextBoxColumn});
            this.dataGridViewHairStylists.DataSource = this.spShowAllHairStylistBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHairStylists.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHairStylists.Location = new System.Drawing.Point(731, 343);
            this.dataGridViewHairStylists.Name = "dataGridViewHairStylists";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewHairStylists.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHairStylists.RowTemplate.Height = 24;
            this.dataGridViewHairStylists.Size = new System.Drawing.Size(227, 128);
            this.dataGridViewHairStylists.TabIndex = 35;
            // 
            // hairStrylistDataGridViewTextBoxColumn
            // 
            this.hairStrylistDataGridViewTextBoxColumn.DataPropertyName = "Hair Strylist";
            this.hairStrylistDataGridViewTextBoxColumn.HeaderText = "Hair Strylist";
            this.hairStrylistDataGridViewTextBoxColumn.Name = "hairStrylistDataGridViewTextBoxColumn";
            this.hairStrylistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // spShowAllHairStylistTableAdapter
            // 
            this.spShowAllHairStylistTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-19, -19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "&Look Up :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Customer Info: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(777, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Stylist Info: ";
            // 
            // Appt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 647);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewHairStylists);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.apptDate);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.btnSched);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Appt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.Appt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spShowAllHairStylistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairSalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHairStylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSched;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label apptDate;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridView dataGridViewHairStylists;
        private HairSalonDataSet hairSalonDataSet;
        private HairSalonDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource spShowAllHairStylistBindingSource;
        private HairSalonDataSetTableAdapters.spShowAllHairStylistTableAdapter spShowAllHairStylistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hairStrylistDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailDataGridViewTextBoxColumn;
    }
}