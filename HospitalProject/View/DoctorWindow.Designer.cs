namespace HospitalProject.View
{
    partial class DoctorWindow
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
            this.btnActionDoctor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDoctor_First_Name = new System.Windows.Forms.TextBox();
            this.txt_Doctor_Last_Name = new System.Windows.Forms.MaskedTextBox();
            this.txt_Doctor_Phone_Number = new System.Windows.Forms.TextBox();
            this.txt_Doctor_Department_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnActionDoctor
            // 
            this.btnActionDoctor.Location = new System.Drawing.Point(300, 375);
            this.btnActionDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.btnActionDoctor.Name = "btnActionDoctor";
            this.btnActionDoctor.Size = new System.Drawing.Size(177, 39);
            this.btnActionDoctor.TabIndex = 32;
            this.btnActionDoctor.Text = "Action";
            this.btnActionDoctor.UseVisualStyleBackColor = true;
            this.btnActionDoctor.Click += new System.EventHandler(this.btnActionDoctor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Department_ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "First Name";
            // 
            // txtDoctor_First_Name
            // 
            this.txtDoctor_First_Name.Location = new System.Drawing.Point(396, 86);
            this.txtDoctor_First_Name.Name = "txtDoctor_First_Name";
            this.txtDoctor_First_Name.Size = new System.Drawing.Size(216, 22);
            this.txtDoctor_First_Name.TabIndex = 37;
            // 
            // txt_Doctor_Last_Name
            // 
            this.txt_Doctor_Last_Name.Location = new System.Drawing.Point(396, 130);
            this.txt_Doctor_Last_Name.Name = "txt_Doctor_Last_Name";
            this.txt_Doctor_Last_Name.Size = new System.Drawing.Size(216, 22);
            this.txt_Doctor_Last_Name.TabIndex = 38;
            // 
            // txt_Doctor_Phone_Number
            // 
            this.txt_Doctor_Phone_Number.Location = new System.Drawing.Point(396, 238);
            this.txt_Doctor_Phone_Number.Name = "txt_Doctor_Phone_Number";
            this.txt_Doctor_Phone_Number.Size = new System.Drawing.Size(216, 22);
            this.txt_Doctor_Phone_Number.TabIndex = 39;
            // 
            // txt_Doctor_Department_ID
            // 
            this.txt_Doctor_Department_ID.Location = new System.Drawing.Point(396, 189);
            this.txt_Doctor_Department_ID.Name = "txt_Doctor_Department_ID";
            this.txt_Doctor_Department_ID.Size = new System.Drawing.Size(216, 22);
            this.txt_Doctor_Department_ID.TabIndex = 40;
            // 
            // DoctorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Doctor_Department_ID);
            this.Controls.Add(this.txt_Doctor_Phone_Number);
            this.Controls.Add(this.txt_Doctor_Last_Name);
            this.Controls.Add(this.txtDoctor_First_Name);
            this.Controls.Add(this.btnActionDoctor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "DoctorWindow";
            this.Text = "DoctorWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActionDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDoctor_First_Name;
        private System.Windows.Forms.MaskedTextBox txt_Doctor_Last_Name;
        private System.Windows.Forms.TextBox txt_Doctor_Phone_Number;
        private System.Windows.Forms.TextBox txt_Doctor_Department_ID;
    }
}