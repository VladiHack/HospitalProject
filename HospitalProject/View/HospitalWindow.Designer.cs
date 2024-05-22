namespace HospitalProject.View
{
    partial class HospitalWindow
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActionHospital = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtHospital_Phone_Number = new System.Windows.Forms.TextBox();
            this.txtHospital_Address = new System.Windows.Forms.TextBox();
            this.txtHospital_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(117, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phone Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(121, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "State";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(125, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(121, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActionHospital
            // 
            this.btnActionHospital.Location = new System.Drawing.Point(259, 369);
            this.btnActionHospital.Margin = new System.Windows.Forms.Padding(4);
            this.btnActionHospital.Name = "btnActionHospital";
            this.btnActionHospital.Size = new System.Drawing.Size(201, 39);
            this.btnActionHospital.TabIndex = 29;
            this.btnActionHospital.Text = "Action";
            this.btnActionHospital.UseVisualStyleBackColor = true;
            this.btnActionHospital.Click += new System.EventHandler(this.btnActionHospital_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(360, 298);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(211, 22);
            this.txtState.TabIndex = 30;
            // 
            // txtHospital_Phone_Number
            // 
            this.txtHospital_Phone_Number.Location = new System.Drawing.Point(362, 237);
            this.txtHospital_Phone_Number.Name = "txtHospital_Phone_Number";
            this.txtHospital_Phone_Number.Size = new System.Drawing.Size(209, 22);
            this.txtHospital_Phone_Number.TabIndex = 31;
            // 
            // txtHospital_Address
            // 
            this.txtHospital_Address.Location = new System.Drawing.Point(360, 174);
            this.txtHospital_Address.Name = "txtHospital_Address";
            this.txtHospital_Address.Size = new System.Drawing.Size(211, 22);
            this.txtHospital_Address.TabIndex = 32;
            // 
            // txtHospital_Name
            // 
            this.txtHospital_Name.Location = new System.Drawing.Point(362, 116);
            this.txtHospital_Name.Name = "txtHospital_Name";
            this.txtHospital_Name.Size = new System.Drawing.Size(209, 22);
            this.txtHospital_Name.TabIndex = 33;
            // 
            // HospitalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHospital_Name);
            this.Controls.Add(this.txtHospital_Address);
            this.Controls.Add(this.txtHospital_Phone_Number);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnActionHospital);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "HospitalWindow";
            this.Text = "HospitalWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActionHospital;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtHospital_Phone_Number;
        private System.Windows.Forms.TextBox txtHospital_Address;
        private System.Windows.Forms.TextBox txtHospital_Name;
    }
}