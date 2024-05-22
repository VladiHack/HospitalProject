namespace HospitalProject.View
{
    partial class StaffWindow
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
            this.txtStaff_Department_ID = new System.Windows.Forms.ComboBox();
            this.txtStaff_First_Name = new System.Windows.Forms.ComboBox();
            this.txtStaff_Last_Name = new System.Windows.Forms.ComboBox();
            this.txtStaff_Address = new System.Windows.Forms.ComboBox();
            this.txtStaff_Phone_Number = new System.Windows.Forms.ComboBox();
            this.btnActionStaff = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStaff_Department_ID
            // 
            this.txtStaff_Department_ID.FormattingEnabled = true;
            this.txtStaff_Department_ID.Location = new System.Drawing.Point(415, 47);
            this.txtStaff_Department_ID.Name = "txtStaff_Department_ID";
            this.txtStaff_Department_ID.Size = new System.Drawing.Size(200, 24);
            this.txtStaff_Department_ID.TabIndex = 41;
            // 
            // txtStaff_First_Name
            // 
            this.txtStaff_First_Name.FormattingEnabled = true;
            this.txtStaff_First_Name.Location = new System.Drawing.Point(415, 99);
            this.txtStaff_First_Name.Name = "txtStaff_First_Name";
            this.txtStaff_First_Name.Size = new System.Drawing.Size(200, 24);
            this.txtStaff_First_Name.TabIndex = 40;
            // 
            // txtStaff_Last_Name
            // 
            this.txtStaff_Last_Name.FormattingEnabled = true;
            this.txtStaff_Last_Name.Location = new System.Drawing.Point(415, 157);
            this.txtStaff_Last_Name.Name = "txtStaff_Last_Name";
            this.txtStaff_Last_Name.Size = new System.Drawing.Size(200, 24);
            this.txtStaff_Last_Name.TabIndex = 39;
            // 
            // txtStaff_Address
            // 
            this.txtStaff_Address.FormattingEnabled = true;
            this.txtStaff_Address.Location = new System.Drawing.Point(415, 218);
            this.txtStaff_Address.Name = "txtStaff_Address";
            this.txtStaff_Address.Size = new System.Drawing.Size(200, 24);
            this.txtStaff_Address.TabIndex = 38;
            // 
            // txtStaff_Phone_Number
            // 
            this.txtStaff_Phone_Number.FormattingEnabled = true;
            this.txtStaff_Phone_Number.Location = new System.Drawing.Point(415, 270);
            this.txtStaff_Phone_Number.Name = "txtStaff_Phone_Number";
            this.txtStaff_Phone_Number.Size = new System.Drawing.Size(200, 24);
            this.txtStaff_Phone_Number.TabIndex = 37;
            // 
            // btnActionStaff
            // 
            this.btnActionStaff.Location = new System.Drawing.Point(311, 353);
            this.btnActionStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnActionStaff.Name = "btnActionStaff";
            this.btnActionStaff.Size = new System.Drawing.Size(125, 50);
            this.btnActionStaff.TabIndex = 36;
            this.btnActionStaff.Text = "Action";
            this.btnActionStaff.UseVisualStyleBackColor = true;
            this.btnActionStaff.Click += new System.EventHandler(this.btnActionStaff_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(185, 269);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "Phone Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(185, 221);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(185, 165);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "Last Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(185, 107);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "First Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(185, 55);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "Department ID";
            // 
            // StaffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStaff_Department_ID);
            this.Controls.Add(this.txtStaff_First_Name);
            this.Controls.Add(this.txtStaff_Last_Name);
            this.Controls.Add(this.txtStaff_Address);
            this.Controls.Add(this.txtStaff_Phone_Number);
            this.Controls.Add(this.btnActionStaff);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Name = "StaffWindow";
            this.Text = "StaffWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtStaff_Department_ID;
        private System.Windows.Forms.ComboBox txtStaff_First_Name;
        private System.Windows.Forms.ComboBox txtStaff_Last_Name;
        private System.Windows.Forms.ComboBox txtStaff_Address;
        private System.Windows.Forms.ComboBox txtStaff_Phone_Number;
        private System.Windows.Forms.Button btnActionStaff;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}