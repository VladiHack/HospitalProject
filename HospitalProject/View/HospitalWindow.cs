using HospitalProject.Controller;
using HospitalProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject.View
{
    public partial class HospitalWindow : Form
    {
        static string connectionString = @"Server = .\SQLEXPRESS; DATABASE = HospitalDB;Integrated Security = True";
        static SqlConnection connection = new SqlConnection(connectionString);
        public string hospitalName = "";
        public string action = "";
        int hospitalID = -1;

        public HospitalWindow()
        {
            InitializeComponent();
            action = "Register";
        }
        public HospitalWindow(Hospital hospital)
        {
            InitializeComponent();
            txtHospital_Name.Text= hospital.Name;
            txtHospital_Address.Text= hospital.Address;
            txtHospital_Phone_Number.Text= hospital.PhoneNumber;
            txtState.Text= hospital.State;
            action = "Update";
            hospitalID = hospital.Id;
        }
        private void btnActionHospital_Click(object sender, EventArgs e)
        {
            string hospitalName = txtHospital_Name.Text; string hospitalAddress = txtHospital_Address.Text; string hospitalPhoneNum = txtHospital_Phone_Number.Text;
            string hospitalState = txtState.Text;
            try
            {
                Hospital hospital = new Hospital(hospitalName, hospitalAddress, hospitalPhoneNum, hospitalState);
                if (action == "Register")
                {
                    HospitalController.AddHospital(hospital);
                    MessageBox.Show("Успешно добавена болница.");
                    txtHospital_Name.Text = ""; txtHospital_Address.Text = ""; txtHospital_Phone_Number.Text = ""; txtState.Text = "";
                    this.Close();
                }
                else if(action=="Update")
                {
                    hospital.Id = hospitalID;
                    HospitalController.UpdateHospital(hospital);
                    MessageBox.Show("Успешно обновена болница.");
                    txtHospital_Name.Text = ""; txtHospital_Address.Text = ""; txtHospital_Phone_Number.Text = ""; txtState.Text = "";
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
