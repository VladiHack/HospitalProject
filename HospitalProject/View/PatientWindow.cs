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
    public partial class PatientWindow : Form
    {
        public string action = "";
        private int id;
        public PatientWindow()
        {
            InitializeComponent();
        }
        public PatientWindow(Patient patient)
        {
            InitializeComponent();
            id=patient.Id;
            txtPatient_Address.Text = patient.Address;
            txtPatient_First_Name.Text = patient.FirstName;
            txtPatient_Last_Name.Text = patient.LastName;   
            txtPatient_Phone_Number.Text = patient.PhoneNumber;
        }
        private void btnActionPatient_Click(object sender, EventArgs e)
        {
            string firstName=txtPatient_First_Name.Text;string lastName=txtPatient_Last_Name.Text;string address=txtPatient_Address.Text;
            string phoneNumber = txtPatient_Phone_Number.Text;
            try
            {
                Patient patient=new Patient(firstName, lastName, address, phoneNumber);
                if (action == "Register")
                {
                    PatientController.AddPatient(patient);
                    MessageBox.Show("Успешно добавен пациент.");
                    txtPatient_Address.Text = "";txtPatient_First_Name.Text = "";txtPatient_Last_Name.Text = "";txtPatient_Phone_Number.Text = "";
                    this.Close();
                }
                else if (action == "Update")
                {
                    patient.Id = id;
                    PatientController.UpdatePatient(patient);
                    MessageBox.Show("Успешно обновена информация за пациент.");
                    txtPatient_Address.Text = ""; txtPatient_First_Name.Text = ""; txtPatient_Last_Name.Text = ""; txtPatient_Phone_Number.Text = "";
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
