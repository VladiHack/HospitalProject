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
    public partial class AppointmentWindow : Form
    {
        public string action = "";
        private Appointment prevAppointment = new Appointment();
        public AppointmentWindow()
        {
            InitializeComponent();
        }
        public AppointmentWindow(Appointment appointment)
        {
            InitializeComponent();
            this.prevAppointment = appointment;
            txtDoctorID.Text = appointment.DoctorId.ToString();
            txtPatientID.Text= appointment.PatientId.ToString();
            AppointmentDate.Text= appointment.Date.ToString();
        }
        private void btnActionAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                int patientId = int.Parse(txtPatientID.Text); int doctorId = int.Parse(txtDoctorID.Text);
                DateTime date = DateTime.Parse(AppointmentDate.Text.ToString());
                Appointment appointment=new Appointment(patientId, doctorId,date);
                if (action == "Register")
                {
                    AppointmentController.AddAppointment(appointment);
                    txtDoctorID.Text = ""; txtPatientID.Text = "";
                    MessageBox.Show("Успешно добавен преглед!");
                    this.Close();
                }
                else if (action == "Update")
                {
                    AppointmentController.UpdateAppointment(appointment,prevAppointment);
                    txtDoctorID.Text = ""; txtPatientID.Text = "";
                    MessageBox.Show("Успешно Обновен преглед!");
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
