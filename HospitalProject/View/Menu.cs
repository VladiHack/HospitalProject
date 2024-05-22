using HospitalProject.Controller;
using HospitalProject.Model;
using HospitalProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalProject
{
    public partial class Menu : Form
    {
        static int CurrentHospitalID = -1;
        static string UsedHospitalName = "";
        static string connectionString = @"Server = .\SQLEXPRESS; DATABASE = HospitalDB;Integrated Security = True";
        static SqlConnection connection = new SqlConnection(connectionString);
        static string action = "";
        private System.Windows.Forms.Button currentButton;
        private Random random;
        private int tempIndex;
        string usedTable = "Hospital";
        public Menu()
        {
            InitializeComponent();
            dataView.DataSource = HospitalController.ReturnAllHospitals();
            random = new Random();
        }
       private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex==index)
            {
                index=random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (System.Windows.Forms.Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (System.Windows.Forms.Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    dataView.ColumnHeadersDefaultCellStyle.BackColor = color;
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType()==typeof(System.Windows.Forms.Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        //Adding info to the hospital comboboxes
        
        //Adding info to the doctor comboboxes
    
        //Adding info to the Department comboboxes
        private void FillDepartmentParams()
        {
            connection.Open();
            string query = "";
            if (CurrentHospitalID == -1)
            {
                query = $"select * from Department order by Department_Name";
            }
            else
            {
                query = $"select * from Department where Hospital_ID={CurrentHospitalID} order by Department_Name";
            }
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            string name = "";
            while (reader.Read())
            {
                name = reader[2].ToString();
            }
            reader.Close();
            connection.Close();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (action == "Register")
            {

            }
        }

       

       


  

  

        private void btnHospital_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usedTable = "Hospital";
            txtSearch.Clear();
            lblSearch.Text = "Search hospital:";
            dataView.DataSource = HospitalController.ReturnAllHospitals();
        }



       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                this.WindowState=FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usedTable = "Doctor";
            lblSearch.Text = "Search doctor:";
            txtSearch.Clear();
            dataView.DataSource = DoctorController.ReturnAllDoctors();

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usedTable = "Department";
            txtSearch.Clear();
            lblSearch.Text = "Search department:";
            dataView.DataSource=DepartmentController.ReturnAllDepartments();


        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usedTable = "Staff";
            txtSearch.Clear();
            lblSearch.Text = "Search staff:";
            dataView.DataSource = StaffController.ReturnAllStaff();

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usedTable = "Appointment";
            txtSearch.Clear();
            lblSearch.Text = "Search appointment:";
            dataView.DataSource = AppointmentController.ReturnAllAppointments();

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            usedTable = "Patient";
            txtSearch.Clear();
            lblSearch.Text = "Search patient:";
            dataView.DataSource=PatientController.ReturnAllPatients();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(usedTable=="Hospital")
            {
                if(String.IsNullOrWhiteSpace(txtSearch.Text))
                {
                   dataView.DataSource=HospitalController.ReturnAllHospitals();
                }
                else
                {
                    bool isNum = true;
                    for(int i=0;i<txtSearch.Text.Length;i++)
                    {
                        if (txtSearch.Text[i] >= 'a' && txtSearch.Text[i] <= 'z' || (txtSearch.Text[i] >= 'A' && txtSearch.Text[i] <= 'Z')) 
                        {
                            isNum = false;break;
                        }
                    }
                    if(isNum)
                    {
                        dataView.DataSource = HospitalController.ReturnHospitalById(int.Parse(txtSearch.Text));
                    }
                    else
                    {
                        dataView.DataSource = HospitalController.ReturnHospitalByName(txtSearch.Text.Trim());
                    }
                }
            }
            else if(usedTable=="Doctor")
            {
                if (String.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    dataView.DataSource = DoctorController.ReturnAllDoctors();
                }
                else
                {
                    bool isNum = true;
                    for (int i = 0; i < txtSearch.Text.Length; i++)
                    {
                        if (txtSearch.Text[i] >= 'a' && txtSearch.Text[i] <= 'z' || (txtSearch.Text[i] >= 'A' && txtSearch.Text[i] <= 'Z'))
                        {
                            isNum = false; break;
                        }
                    }
                    if (isNum)
                    {
                        dataView.DataSource = DoctorController.ReturnDoctorById(int.Parse(txtSearch.Text));
                    }
                    else
                    {
                        string[] splitName = txtSearch.Text.Split().ToArray();
                        if (splitName.Length == 1)
                            dataView.DataSource = DoctorController.ReturnDoctorByFirstName(txtSearch.Text.Trim());
                        else dataView.DataSource = DoctorController.ReturnDoctorByFullName(splitName[0], splitName[1]);
                    }
                }
            }
            else if(usedTable=="Staff")
            {
                if (String.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    dataView.DataSource = StaffController.ReturnAllStaff();
                }
                else
                {
                    bool isNum = true;
                    for (int i = 0; i < txtSearch.Text.Length; i++)
                    {
                        if (txtSearch.Text[i] >= 'a' && txtSearch.Text[i] <= 'z' || (txtSearch.Text[i] >= 'A' && txtSearch.Text[i] <= 'Z'))
                        {
                            isNum = false; break;
                        }
                    }
                    if (isNum)
                    {
                        dataView.DataSource = StaffController.ReturnStaffById(int.Parse(txtSearch.Text));
                    }
                    else
                    {
                        string[] splitName = txtSearch.Text.Split().ToArray();
                        if (splitName.Length == 1)
                            dataView.DataSource = StaffController.ReturnStaffByFirstName(txtSearch.Text.Trim());
                        else dataView.DataSource = StaffController.ReturnStaffByFullName(splitName[0], splitName[1]);
                    }
                }
            }
            else if(usedTable=="Patient")
            {
                if (String.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    dataView.DataSource = PatientController.ReturnAllPatients();
                }
                else
                {
                    bool isNum = true;
                    for (int i = 0; i < txtSearch.Text.Length; i++)
                    {
                        if (txtSearch.Text[i] >= 'a' && txtSearch.Text[i] <= 'z' || (txtSearch.Text[i] >= 'A' && txtSearch.Text[i] <= 'Z'))
                        {
                            isNum = false; break;
                        }
                    }
                    if (isNum)
                    {
                        dataView.DataSource = PatientController.ReturnPatientById(int.Parse(txtSearch.Text));
                    }
                    else
                    {
                        string[] splitName = txtSearch.Text.Split().ToArray();
                        if (splitName.Length == 1)
                            dataView.DataSource = PatientController.ReturnPatientByFirstName(txtSearch.Text.Trim());
                        else dataView.DataSource = PatientController.ReturnPatientByFullName(splitName[0], splitName[1]);
                    }
                }
            }
            else if(usedTable=="Appointment")
            {
                bool isNum = true;
                for (int i = 0; i < txtSearch.Text.Length; i++)
                {
                    if (txtSearch.Text[i] >= 'a' && txtSearch.Text[i] <= 'z' || (txtSearch.Text[i] >= 'A' && txtSearch.Text[i] <= 'Z'))
                    {
                        isNum = false; break;
                    }
                }
                if(isNum&&!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    dataView.DataSource = AppointmentController.ReturnAppointmentByPatientId(int.Parse(txtSearch.Text));
                }
                else
                {
                    dataView.DataSource = AppointmentController.ReturnAllAppointments();
                }
            }
            else if(usedTable=="Department")
            {
                if (String.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    dataView.DataSource = DepartmentController.ReturnAllDepartments();
                }
                else
                {
                    bool isNum = true;
                    for (int i = 0; i < txtSearch.Text.Length; i++)
                    {
                        if (txtSearch.Text[i] >= 'a' && txtSearch.Text[i] <= 'z' || (txtSearch.Text[i] >= 'A' && txtSearch.Text[i] <= 'Z'))
                        {
                            isNum = false; break;
                        }
                    }
                    if (isNum)
                    {
                        dataView.DataSource = DepartmentController.ReturnDepartmentById(int.Parse(txtSearch.Text));
                    }
                    else
                    {
                        dataView.DataSource = DepartmentController.ReturnDepartmentByName(txtSearch.Text);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(usedTable=="Hospital")
            {
                HospitalWindow hw=new HospitalWindow();
                hw.action = "Register";
                this.Hide();
                hw.ShowDialog();
                this.Show();
                dataView.DataSource=HospitalController.ReturnAllHospitals();
            }
            else if(usedTable=="Doctor")
            {
                DoctorWindow docWindow=new DoctorWindow();
                docWindow.action = "Register";
                this.Hide();
                docWindow.ShowDialog();
                this.Show();
                dataView.DataSource = DoctorController.ReturnAllDoctors();
            }
            else if(usedTable== "Department")
            {
                DepartmentWindow departWindow=new DepartmentWindow();
                departWindow.action = "Register";
                this.Hide();
                departWindow.ShowDialog();
                this.Show();
                dataView.DataSource=DepartmentController.ReturnAllDepartments();
            }
            else if(usedTable== "Staff")
            {
                   StaffWindow staffWin=new StaffWindow();
                staffWin.action = "Register";
                this.Hide();
                staffWin.ShowDialog();
                this.Show();
                dataView.DataSource = StaffController.ReturnAllStaff();
            }
            else if(usedTable=="Appointment")
            {
                AppointmentWindow appointmentWindow=new AppointmentWindow();
                appointmentWindow.action = "Register";
                this.Hide();
                appointmentWindow.ShowDialog();
                this.Show();
                dataView.DataSource = AppointmentController.ReturnAllAppointments();
            }
            else if(usedTable=="Patient")
            {
                PatientWindow patWin=new PatientWindow();
                patWin.action = "Register";
                this.Hide(); patWin.ShowDialog();
                this.Show();
                dataView.DataSource=PatientController.ReturnAllPatients();
            }
        }
        private int GetIndexOfMarkedCellOrColumn()
        {
            int index = 0;
            if (dataView.SelectedRows.Count == 1)
            {
                index = dataView.SelectedRows[0].Index;
            }
            else if (dataView.SelectedRows.Count == 0)
            {
                index = dataView.CurrentCell.RowIndex;
            }
            return index;
        }
        private Hospital GetHospital(int indexMarkedRow)
        {
            int id = int.Parse(dataView.Rows[indexMarkedRow].Cells[0].Value.ToString());
            string name = dataView.Rows[indexMarkedRow].Cells[1].Value.ToString();
            string address = dataView.Rows[indexMarkedRow].Cells[2].Value.ToString();
            string phoneNum = dataView.Rows[indexMarkedRow].Cells[3].Value.ToString();
            string state = dataView.Rows[indexMarkedRow].Cells[4].Value.ToString();
            Hospital hospital = new Hospital(name, address, phoneNum, state);
            hospital.Id = id;
            return hospital;
        }
        private Doctor GetDoctor(int indexMarkedRow)
        {
            int id = int.Parse(dataView.Rows[indexMarkedRow].Cells[0].Value.ToString());
            string firstName = dataView.Rows[indexMarkedRow].Cells[1].Value.ToString();
            string lastName = dataView.Rows[indexMarkedRow].Cells[2].Value.ToString();
            int departmentId =int.Parse(dataView.Rows[indexMarkedRow].Cells[3].Value.ToString());
            string phoneNumber = dataView.Rows[indexMarkedRow].Cells[4].Value.ToString();
            Doctor doctor = new Doctor(firstName, lastName, phoneNumber, departmentId);
            doctor.Id=id;
            return doctor;
        }
        public Department GetDepartment(int indexMarkedRow)
        {
            int id = int.Parse(dataView.Rows[indexMarkedRow].Cells[0].Value.ToString());
            int hospital_id = int.Parse(dataView.Rows[indexMarkedRow].Cells[1].Value.ToString());
            string name = dataView.Rows[indexMarkedRow].Cells[2].Value.ToString();

            Department department=new Department(hospital_id, name);
            department.Id = id;
            return department;
        }
        public Staff GetStaff(int indexMarkedRow)
        {
            int id = int.Parse(dataView.Rows[indexMarkedRow].Cells[0].Value.ToString());
            int departmentId = int.Parse(dataView.Rows[indexMarkedRow].Cells[1].Value.ToString());
            string firstName = dataView.Rows[indexMarkedRow].Cells[2].Value.ToString();
            string lastName = dataView.Rows[indexMarkedRow].Cells[3].Value.ToString();
            string address = dataView.Rows[indexMarkedRow].Cells[4].Value.ToString();
            string phoneNumber = dataView.Rows[indexMarkedRow].Cells[5].Value.ToString();
            Staff staff=new Staff(departmentId, firstName, lastName, address, phoneNumber);
            staff.Id = id;
            return staff;   
        }
        public Appointment GetAppointment(int indexMarkedRow)
        {
            int patientId = int.Parse(dataView.Rows[indexMarkedRow].Cells[0].Value.ToString());
            int doctorId = int.Parse(dataView.Rows[indexMarkedRow].Cells[1].Value.ToString());
            DateTime date =DateTime.Parse( dataView.Rows[indexMarkedRow].Cells[2].Value.ToString());
            Appointment appointment=new Appointment(patientId,doctorId,date);
            return appointment;
        }
        public Patient GetPatient(int indexMarkedRow)
        {
            int patientId = int.Parse(dataView.Rows[indexMarkedRow].Cells[0].Value.ToString());
            string firstName = dataView.Rows[indexMarkedRow].Cells[1].Value.ToString();
            string lastName = dataView.Rows[indexMarkedRow].Cells[2].Value.ToString();
            string address = dataView.Rows[indexMarkedRow].Cells[3].Value.ToString();
            string phoneNumber = dataView.Rows[indexMarkedRow].Cells[4].Value.ToString();
          Patient patient=new Patient(firstName,lastName,address,phoneNumber);
            patient.Id= patientId;
            return patient;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (usedTable == "Hospital")
            {
                int index=GetIndexOfMarkedCellOrColumn();
                Hospital hospital = GetHospital(index);
                HospitalWindow hw = new HospitalWindow(hospital);
                hw.action = "Update";
                this.Hide();
                hw.ShowDialog();
                this.Show();
                dataView.DataSource = HospitalController.ReturnAllHospitals();
            }
            else if(usedTable=="Doctor")
            {
                int index= GetIndexOfMarkedCellOrColumn();
                Doctor doctor = GetDoctor(index);
                DoctorWindow docWin = new DoctorWindow(doctor);
                this.Hide();
                docWin.action = "Update";
                docWin.ShowDialog();
                this.Show();
                dataView.DataSource = DoctorController.ReturnAllDoctors();
            }
            else if(usedTable=="Department")
            {
                int index = GetIndexOfMarkedCellOrColumn();
                Department department = GetDepartment(index);
                DepartmentWindow depWin = new DepartmentWindow(department);
                this.Hide();
                depWin.action = "Update";
                depWin.ShowDialog();
                this.Show();
                dataView.DataSource = DepartmentController.ReturnAllDepartments();
            }
            else if(usedTable=="Staff")
            {
                int index=GetIndexOfMarkedCellOrColumn();
                Staff staff = GetStaff(index);
                StaffWindow staffWin=new StaffWindow(staff);
                this.Hide();
                staffWin.action = "Update";
                staffWin.ShowDialog();
                this.Show();
                dataView.DataSource = StaffController.ReturnAllStaff();
            }
            else if (usedTable == "Appointment")
            {
                int index = GetIndexOfMarkedCellOrColumn();
                Appointment appointment = GetAppointment(index);
                AppointmentWindow appWin = new AppointmentWindow(appointment);
                this.Hide();
                appWin.action = "Update";
                appWin.ShowDialog();
                this.Show();
                dataView.DataSource = AppointmentController.ReturnAllAppointments();
            }
            else if(usedTable=="Patient")
            {
                int index= GetIndexOfMarkedCellOrColumn();
                Patient patient = GetPatient(index);
                PatientWindow patWin = new PatientWindow(patient);
                this.Hide();
                patWin.action = "Update";
                patWin.ShowDialog();
                this.Show();
                dataView.DataSource = PatientController.ReturnAllPatients();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(usedTable=="Hospital")
            {
                int index= GetIndexOfMarkedCellOrColumn();
                Hospital hospital = GetHospital(index);
               DialogResult dialogRes=MessageBox.Show($"Are you sure you want to delete hospital {hospital.Name}?","Deleting Hospital",MessageBoxButtons.YesNo);
                if(dialogRes==DialogResult.Yes)
                {
                    HospitalController.DeleteHospital(hospital.Id);
                    dataView.DataSource = HospitalController.ReturnAllHospitals();
                    MessageBox.Show($"Успешно изтрихте болница :{hospital.Name}");
                }

            }
            else if(usedTable=="Doctor")
            {
                int index= GetIndexOfMarkedCellOrColumn();
                Doctor doctor=GetDoctor(index);
                DialogResult dialogRes = MessageBox.Show($"Are you sure you want to delete doctor {doctor.FirstName} {doctor.LastName}?", "Deleting Doctor", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    DoctorController.DeleteDoctor(doctor.Id);
                    MessageBox.Show($"Успешно изтрихте лекар :{doctor.FirstName} {doctor.LastName}");
                    dataView.DataSource=DoctorController.ReturnAllDoctors();
                }
            }
            else if(usedTable=="Department")
            {
                int index= GetIndexOfMarkedCellOrColumn();
                Department department = GetDepartment(index);
                DialogResult dialogRes = MessageBox.Show($"Are you sure you want to delete department {department.Name} with hospital id: {department.HospitalId}?", "Deleting Department", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    DepartmentController.DeleteDepartment(department.Id);
                    MessageBox.Show($"Успешно изтрихте отдел :{department.Name}");
                    dataView.DataSource = DepartmentController.ReturnAllDepartments();
                }
            }
            else if(usedTable=="Staff")
            {
                int index= GetIndexOfMarkedCellOrColumn();  
                Staff staff=GetStaff(index);
                DialogResult dialogRes = MessageBox.Show($"Are you sure you want to delete Staff {staff.FirstName} {staff.LastName}?", "Deleting Staff", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    StaffController.DeleteStaff(staff.Id);
                    MessageBox.Show($"Успешно изтрихте служител :{staff.FirstName} {staff.LastName}");
                    dataView.DataSource = StaffController.ReturnAllStaff();
                }
            }
            else if(usedTable=="Appointment")
            {
                int index= GetIndexOfMarkedCellOrColumn();
                Appointment appointment=GetAppointment(index);
                DialogResult dialogRes = MessageBox.Show($"Are you sure you want to delete Appointment with Doctor id: {appointment.DoctorId} And Patient id:{appointment.PatientId}?", "Deleting Appointment", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    AppointmentController.DeleteAppointment(appointment);
                    MessageBox.Show($"Успешно изтрихте прегледа");
                    dataView.DataSource = AppointmentController.ReturnAllAppointments();
                }
            }
            else if(usedTable=="Patient")
            {
                int index = GetIndexOfMarkedCellOrColumn();
                Patient patient=GetPatient(index);
                DialogResult dialogRes = MessageBox.Show($"Are you sure you want to delete Patient: {patient.FirstName} {patient.LastName}?", "Deleting Patient", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    PatientController.DeletePatient(patient.Id);
                    MessageBox.Show($"Успешно изтрихте пациент");
                    dataView.DataSource= PatientController.ReturnAllPatients();
                }
            }
        }
    }
    }

