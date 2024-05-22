namespace HospitalProject.View
{
    partial class PatientWindow
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
            this.txtPatient_Phone_Number = new System.Windows.Forms.ComboBox();
            this.txtPatient_Address = new System.Windows.Forms.ComboBox();
            this.txtPatient_Last_Name = new System.Windows.Forms.ComboBox();
            this.txtPatient_First_Name = new System.Windows.Forms.ComboBox();
            this.btnActionPatient = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPatient_Phone_Number
            // 
            this.txtPatient_Phone_Number.FormattingEnabled = true;
            this.txtPatient_Phone_Number.Location = new System.Drawing.Point(341, 218);
            this.txtPatient_Phone_Number.Name = "txtPatient_Phone_Number";
            this.txtPatient_Phone_Number.Size = new System.Drawing.Size(289, 24);
            this.txtPatient_Phone_Number.TabIndex = 27;
            // 
            // txtPatient_Address
            // 
            this.txtPatient_Address.FormattingEnabled = true;
            this.txtPatient_Address.Location = new System.Drawing.Point(341, 174);
            this.txtPatient_Address.Name = "txtPatient_Address";
            this.txtPatient_Address.Size = new System.Drawing.Size(289, 24);
            this.txtPatient_Address.TabIndex = 26;
            // 
            // txtPatient_Last_Name
            // 
            this.txtPatient_Last_Name.FormattingEnabled = true;
            this.txtPatient_Last_Name.Location = new System.Drawing.Point(341, 126);
            this.txtPatient_Last_Name.Name = "txtPatient_Last_Name";
            this.txtPatient_Last_Name.Size = new System.Drawing.Size(289, 24);
            this.txtPatient_Last_Name.TabIndex = 25;
            // 
            // txtPatient_First_Name
            // 
            this.txtPatient_First_Name.FormattingEnabled = true;
            this.txtPatient_First_Name.Location = new System.Drawing.Point(341, 77);
            this.txtPatient_First_Name.Name = "txtPatient_First_Name";
            this.txtPatient_First_Name.Size = new System.Drawing.Size(289, 24);
            this.txtPatient_First_Name.TabIndex = 24;
            // 
            // btnActionPatient
            // 
            this.btnActionPatient.Location = new System.Drawing.Point(330, 356);
            this.btnActionPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnActionPatient.Name = "btnActionPatient";
            this.btnActionPatient.Size = new System.Drawing.Size(163, 61);
            this.btnActionPatient.TabIndex = 22;
            this.btnActionPatient.Text = "Action";
            this.btnActionPatient.UseVisualStyleBackColor = true;
            this.btnActionPatient.Click += new System.EventHandler(this.btnActionPatient_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(151, 221);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 16);
            this.label27.TabIndex = 21;
            this.label27.Text = "Phone Number";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(151, 174);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 16);
            this.label26.TabIndex = 20;
            this.label26.Text = "Address";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(151, 126);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 16);
            this.label25.TabIndex = 19;
            this.label25.Text = "Last Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(151, 74);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 16);
            this.label23.TabIndex = 17;
            this.label23.Text = "First Name";
            // 
            // PatientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPatient_Phone_Number);
            this.Controls.Add(this.txtPatient_Address);
            this.Controls.Add(this.txtPatient_Last_Name);
            this.Controls.Add(this.txtPatient_First_Name);
            this.Controls.Add(this.btnActionPatient);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Name = "PatientWindow";
            this.Text = "PatientWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtPatient_Phone_Number;
        private System.Windows.Forms.ComboBox txtPatient_Address;
        private System.Windows.Forms.ComboBox txtPatient_Last_Name;
        private System.Windows.Forms.ComboBox txtPatient_First_Name;
        private System.Windows.Forms.Button btnActionPatient;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
    }
}