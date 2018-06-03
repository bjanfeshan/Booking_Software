namespace bookingsByBita1._0
{
    partial class addEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAppt = new System.Windows.Forms.Button();
            this.btnSched = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Records";
            // 
            // btnAppt
            // 
            this.btnAppt.BackColor = System.Drawing.Color.Transparent;
            this.btnAppt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppt.ForeColor = System.Drawing.Color.Transparent;
            this.btnAppt.Image = ((System.Drawing.Image)(resources.GetObject("btnAppt.Image")));
            this.btnAppt.Location = new System.Drawing.Point(147, 188);
            this.btnAppt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAppt.Name = "btnAppt";
            this.btnAppt.Size = new System.Drawing.Size(233, 171);
            this.btnAppt.TabIndex = 1;
            this.btnAppt.Text = "New &Customer";
            this.btnAppt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAppt.UseVisualStyleBackColor = false;
            this.btnAppt.Click += new System.EventHandler(this.btnAppt_Click);
            // 
            // btnSched
            // 
            this.btnSched.BackColor = System.Drawing.Color.Transparent;
            this.btnSched.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSched.ForeColor = System.Drawing.Color.Transparent;
            this.btnSched.Image = ((System.Drawing.Image)(resources.GetObject("btnSched.Image")));
            this.btnSched.Location = new System.Drawing.Point(575, 188);
            this.btnSched.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSched.Name = "btnSched";
            this.btnSched.Size = new System.Drawing.Size(233, 171);
            this.btnSched.TabIndex = 2;
            this.btnSched.Text = "New &Employee";
            this.btnSched.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSched.UseVisualStyleBackColor = false;
            this.btnSched.Click += new System.EventHandler(this.btnSched_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(373, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 155);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Back";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(981, 647);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSched);
            this.Controls.Add(this.btnAppt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppt;
        private System.Windows.Forms.Button btnSched;
        private System.Windows.Forms.Button button1;
    }
}