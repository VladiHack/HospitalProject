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
    public partial class DepartmentWindow : Form
    {
        public string action = "";
        public int id = 0;
        public DepartmentWindow()
        {
            InitializeComponent();
        }
        public DepartmentWindow(Department department)
        {
            InitializeComponent();
            id=department.Id;
            txtDepartment_Name.Text = department.Name.ToString();
            txtHospitalID.Text = department.HospitalId.ToString();
        }
        private void btnActionDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                string departmentName = txtDepartment_Name.Text; int hospitalId = int.Parse(txtHospitalID.Text);
                Department department=new Department(hospitalId, departmentName);
                if (action == "Register")
                {
                    DepartmentController.AddDepartment(department);
                    txtDepartment_Name.Text = "";txtHospitalID.Text = "";
                    MessageBox.Show("Успешно добавен отдел!");
                    this.Close();
                }
                else if(action=="Update")
                {
                    department.Id = id;
                    DepartmentController.UpdateDepartment(department);
                    txtDepartment_Name.Text = ""; txtHospitalID.Text = "";
                    MessageBox.Show("Успешно Обновен отдел!");
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
                
            
        }
    }
}
