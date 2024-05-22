using HospitalProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Controller
{
    public static class AppointmentController
    {
        public static DataTable ReturnAllAppointments()
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select Patient_ID as [Patient ID],Doctor_ID as [Doctor ID],Date from Appointment\r\n", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnAppointmentByPatientId(int patientId)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Patient_ID as [Patient ID],Doctor_ID as [Doctor ID],Date from Appointment\r\n where Patient_ID like '%{patientId}%'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnAppointmentByDoctorId(int doctorId)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Patient_ID as [Patient ID],Doctor_ID as [Doctor ID],Date from Appointment\r\n where Doctor_ID like '%{doctorId}%'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static void DeleteAppointmentByHospitalId(int hospitalId)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"\r\ndelete from Appointment where Appointment.Doctor_ID in (\r\nselect Appointment.Doctor_ID from Appointment\r\ninner join Doctor on Appointment.Doctor_ID=Doctor.Doctor_ID\r\ninner join Department on Department.Department_ID=Doctor.Department_ID\r\ninner join Hospital on Hospital.Hospital_ID=Department.Hospital_ID\r\nwhere Hospital.Hospital_ID={hospitalId})", connection);
            command.ExecuteNonQuery();
        }
        public static void DeleteAppointmentByDoctorId(int doctorId)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"\r\ndelete from Appointment where Appointment.Doctor_ID = {doctorId}", connection);
            command.ExecuteNonQuery();
        }
        public static void DeleteAppointmentByDepartmentID(int departmentId)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"\r\ndelete from Appointment where Appointment.Doctor_ID in (\r\nselect Appointment.Doctor_ID from Appointment\r\ninner join Doctor on Appointment.Doctor_ID=Doctor.Doctor_ID\r\ninner join Department on Department.Department_ID=Doctor.Department_ID\r\nwhere Department.Department_ID={departmentId})", connection);
            command.ExecuteNonQuery();
        }
        public static void AddAppointment(Appointment appointment)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            string query = $"INSERT INTO Appointment (Patient_ID,Doctor_ID,Date) VALUES (@patientId,@doctorId,@date)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@patientId",appointment.PatientId);
                command.Parameters.AddWithValue("@doctorId", appointment.DoctorId);
                command.Parameters.AddWithValue("@date",DateTime.Parse(appointment.Date.ToString("yyyy MMMM dd")));
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateAppointment(Appointment appointment,Appointment prevAppointment)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            string query = $"Update Appointment SET Patient_ID=@patientId,Doctor_ID=@doctorId,Date=@date where Patient_ID={prevAppointment.PatientId} AND Doctor_ID={prevAppointment.DoctorId} ";
            SqlCommand command = new SqlCommand(query, connection);
            using (command)
            {
                command.Parameters.AddWithValue("@patientId",appointment.PatientId);
                command.Parameters.AddWithValue(@"doctorId", appointment.DoctorId);
                command.Parameters.AddWithValue("@date", DateTime.Parse(appointment.Date.ToString("yyyy MMMM dd")));
                command.ExecuteNonQuery();
            }

        }
        public static void DeleteAppointment(Appointment appointment)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"Delete from Appointment where Patient_ID={appointment.PatientId} AND Doctor_ID={appointment.DoctorId}", connection);
            command.ExecuteNonQuery();
        }
        public static void DeleteAppointmentByPatientId(int patientId)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"Delete from Appointment where Patient_ID={patientId}", connection);
            command.ExecuteNonQuery();
        }
    }
}
