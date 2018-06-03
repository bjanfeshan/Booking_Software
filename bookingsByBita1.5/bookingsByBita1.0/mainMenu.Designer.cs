namespace bookingsByBita1._0
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAppt = new System.Windows.Forms.Button();
            this.btnSched = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewHairStylists = new System.Windows.Forms.DataGridView();
            this.hairStrylistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spShowTodayScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hairSalonDataSet = new bookingsByBita1._0.HairSalonDataSet();
            this.spShowTodayScheduleTableAdapter = new bookingsByBita1._0.HairSalonDataSetTableAdapters.spShowTodayScheduleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHairStylists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spShowTodayScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairSalonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Schedule :";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(391, 478);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 155);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAppt
            // 
            this.btnAppt.BackColor = System.Drawing.Color.Transparent;
            this.btnAppt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppt.ForeColor = System.Drawing.Color.Transparent;
            this.btnAppt.Image = ((System.Drawing.Image)(resources.GetObject("btnAppt.Image")));
            this.btnAppt.Location = new System.Drawing.Point(99, 294);
            this.btnAppt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppt.Name = "btnAppt";
            this.btnAppt.Size = new System.Drawing.Size(233, 171);
            this.btnAppt.TabIndex = 1;
            this.btnAppt.Text = "&Appointments";
            this.btnAppt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppt.UseVisualStyleBackColor = false;
            this.btnAppt.Click += new System.EventHandler(this.btnAppt_Click);
            // 
            // btnSched
            // 
            this.btnSched.BackColor = System.Drawing.Color.Transparent;
            this.btnSched.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSched.ForeColor = System.Drawing.Color.Transparent;
            this.btnSched.Image = ((System.Drawing.Image)(resources.GetObject("btnSched.Image")));
            this.btnSched.Location = new System.Drawing.Point(363, 294);
            this.btnSched.Margin = new System.Windows.Forms.Padding(4);
            this.btnSched.Name = "btnSched";
            this.btnSched.Size = new System.Drawing.Size(233, 171);
            this.btnSched.TabIndex = 2;
            this.btnSched.Text = "Check &Schedule";
            this.btnSched.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSched.UseVisualStyleBackColor = false;
            this.btnSched.Click += new System.EventHandler(this.btnSched_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(636, 294);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 171);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add / &Edit";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewHairStylists
            // 
            this.dataGridViewHairStylists.AutoGenerateColumns = false;
            this.dataGridViewHairStylists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHairStylists.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewHairStylists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hairStrylistDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridViewHairStylists.DataSource = this.spShowTodayScheduleBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHairStylists.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHairStylists.Location = new System.Drawing.Point(99, 78);
            this.dataGridViewHairStylists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHairStylists.Name = "dataGridViewHairStylists";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewHairStylists.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHairStylists.RowTemplate.Height = 24;
            this.dataGridViewHairStylists.Size = new System.Drawing.Size(770, 189);
            this.dataGridViewHairStylists.TabIndex = 23;
            // 
            // hairStrylistDataGridViewTextBoxColumn
            // 
            this.hairStrylistDataGridViewTextBoxColumn.DataPropertyName = "Hair Strylist";
            this.hairStrylistDataGridViewTextBoxColumn.HeaderText = "Hair Strylist";
            this.hairStrylistDataGridViewTextBoxColumn.Name = "hairStrylistDataGridViewTextBoxColumn";
            this.hairStrylistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // spShowTodayScheduleBindingSource
            // 
            this.spShowTodayScheduleBindingSource.DataMember = "spShowTodaySchedule";
            this.spShowTodayScheduleBindingSource.DataSource = this.hairSalonDataSet;
            // 
            // hairSalonDataSet
            // 
            this.hairSalonDataSet.DataSetName = "HairSalonDataSet";
            this.hairSalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spShowTodayScheduleTableAdapter
            // 
            this.spShowTodayScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(981, 647);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewHairStylists);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSched);
            this.Controls.Add(this.btnAppt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.mainMenu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHairStylists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spShowTodayScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hairSalonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAppt;
        private System.Windows.Forms.Button btnSched;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewHairStylists;
        private HairSalonDataSet hairSalonDataSet;
        private System.Windows.Forms.BindingSource spShowTodayScheduleBindingSource;
        private HairSalonDataSetTableAdapters.spShowTodayScheduleTableAdapter spShowTodayScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hairStrylistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
    }
}