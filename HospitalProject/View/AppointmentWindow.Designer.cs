namespace HospitalProject.View
{
    partial class AppointmentWindow
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
            this.label22 = new System.Windows.Forms.Label();
            this.AppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnActionAppointment = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(186, 216);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 16);
            this.label22.TabIndex = 12;
            this.label22.Text = "Date";
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.Location = new System.Drawing.Point(298, 208);
            this.AppointmentDate.Margin = new System.Windows.Forms.Padding(4);
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.Size = new System.Drawing.Size(265, 22);
            this.AppointmentDate.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(162, 151);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 16);
            this.label21.TabIndex = 10;
            this.label21.Text = "Doctor id";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(162, 73);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 16);
            this.label20.TabIndex = 9;
            this.label20.Text = "Patient id";
            // 
            // btnActionAppointment
            // 
            this.btnActionAppointment.Location = new System.Drawing.Point(308, 304);
            this.btnActionAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnActionAppointment.Name = "btnActionAppointment";
            this.btnActionAppointment.Size = new System.Drawing.Size(156, 55);
            this.btnActionAppointment.TabIndex = 15;
            this.btnActionAppointment.Text = "Action";
            this.btnActionAppointment.UseVisualStyleBackColor = true;
            this.btnActionAppointment.Click += new System.EventHandler(this.btnActionAppointment_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(306, 73);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(257, 22);
            this.txtPatientID.TabIndex = 16;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(308, 145);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(255, 22);
            this.txtDoctorID.TabIndex = 17;
            // 
            // AppointmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.btnActionAppointment);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.AppointmentDate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Name = "AppointmentWindow";
            this.Text = "AppointmentWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker AppointmentDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnActionAppointment;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtDoctorID;
    }
}