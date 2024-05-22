using HospitalProject.Controller;
using HospitalProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject.View
{
    public partial class DoctorWindow : Form
    {
        public string action;
        private int id;
        public DoctorWindow()
        {
            InitializeComponent();
        }

        public DoctorWindow(Doctor doctor)
        {
            InitializeComponent();
            txtDoctor_First_Name.Text = doctor.FirstName;
            txt_Doctor_Department_ID.Text = doctor.DepartmentId.ToString();
            txt_Doctor_Last_Name.Text = doctor.LastName;
            txt_Doctor_Phone_Number.Text = doctor.PhoneNumber;
            id = doctor.Id;
        }
     

        private void btnActionDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtDoctor_First_Name.Text; string lastName = txt_Doctor_Last_Name.Text; int departmentId = int.Parse(txt_Doctor_Department_ID.Text);
                string phoneNum = txt_Doctor_Phone_Number.Text;
                Doctor doctor = new Doctor(firstName, lastName, phoneNum, departmentId);
                if (action == "Register")
                {
                    DoctorController.AddDoctor(doctor);
                    txtDoctor_First_Name.Text = "";
                    txt_Doctor_Department_ID.Text = "";
                    txt_Doctor_Phone_Number.Text = "";
                    txt_Doctor_Last_Name.Text = "";
                    MessageBox.Show("Успешно добавен лекар.");
                    this.Close();
                }
                else if (action == "Update")
                {
                    doctor.Id = id;
                    DoctorController.UpdateDoctor(doctor);
                    txtDoctor_First_Name.Text = "";
                    txt_Doctor_Department_ID.Text = "";
                    txt_Doctor_Phone_Number.Text = "";
                    txt_Doctor_Last_Name.Text = "";
                    MessageBox.Show("Успешно обновена информация за лекар.");
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
