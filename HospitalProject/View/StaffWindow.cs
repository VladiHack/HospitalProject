using HospitalProject.Controller;
using HospitalProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject.View
{
    public partial class StaffWindow : Form
    {
        public string action = "";
        private int id;
        public StaffWindow()
        {
            InitializeComponent();
        }
        public StaffWindow(Staff staff)
        {
            InitializeComponent();
            this.id = staff.Id;
            txtStaff_Address.Text = staff.Address;
            txtStaff_Department_ID.Text = staff.DepartmentId.ToString();
            txtStaff_First_Name.Text = staff.FirstName; 
            txtStaff_Last_Name.Text= staff.LastName;
            txtStaff_Phone_Number.Text= staff.PhoneNumber;
        }

        private void btnActionStaff_Click(object sender, EventArgs e)
        {
            string firstName = txtStaff_First_Name.Text;string lastName=txtStaff_Last_Name.Text;string phoneNumber = txtStaff_Phone_Number.Text;
            int departmentId = int.Parse(txtStaff_Department_ID.Text); string address=txtStaff_Address.Text;
            try
            {
                Staff staff=new Staff(departmentId,firstName,lastName,address,phoneNumber);
                if (action == "Register")
                {
                    StaffController.AddStaff(staff);
                    MessageBox.Show("Успешно добавен служител.");
                    txtStaff_First_Name.Text = ""; txtStaff_Last_Name.Text = ""; txtStaff_Address.Text = ""; txtStaff_Department_ID.Text = "";txtStaff_Phone_Number.Text = "";
                    this.Close();
                }
                else if (action == "Update")
                {
                    staff.Id = id;
                    StaffController.UpdateStaff(staff);
                    MessageBox.Show("Успешно обновен служител.");
                    txtStaff_First_Name.Text = ""; txtStaff_Last_Name.Text = ""; txtStaff_Address.Text = ""; txtStaff_Department_ID.Text = ""; txtStaff_Phone_Number.Text = "";
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
