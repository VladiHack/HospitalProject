namespace HospitalProject.View
{
    partial class DepartmentWindow
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
            this.btnActionDepartment = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.txtDepartment_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnActionDepartment
            // 
            this.btnActionDepartment.Location = new System.Drawing.Point(302, 300);
            this.btnActionDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnActionDepartment.Name = "btnActionDepartment";
            this.btnActionDepartment.Size = new System.Drawing.Size(167, 67);
            this.btnActionDepartment.TabIndex = 19;
            this.btnActionDepartment.Text = "Action";
            this.btnActionDepartment.UseVisualStyleBackColor = true;
            this.btnActionDepartment.Click += new System.EventHandler(this.btnActionDepartment_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(186, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Department name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hospital id";
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.Location = new System.Drawing.Point(370, 162);
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.Size = new System.Drawing.Size(244, 22);
            this.txtHospitalID.TabIndex = 22;
            // 
            // txtDepartment_Name
            // 
            this.txtDepartment_Name.Location = new System.Drawing.Point(370, 78);
            this.txtDepartment_Name.Name = "txtDepartment_Name";
            this.txtDepartment_Name.Size = new System.Drawing.Size(244, 22);
            this.txtDepartment_Name.TabIndex = 25;
            // 
            // DepartmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDepartment_Name);
            this.Controls.Add(this.txtHospitalID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActionDepartment);
            this.Controls.Add(this.label12);
            this.Name = "DepartmentWindow";
            this.Text = "DepartmentWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActionDepartment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.TextBox txtDepartment_Name;
    }
}