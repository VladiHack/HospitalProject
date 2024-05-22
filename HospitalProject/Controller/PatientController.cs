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
    public static class PatientController
    {
        public static DataTable ReturnAllPatients()
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select Patient_ID as [ID],Patient_First_Name as [First name],Patient_Last_Name as [Last name], Patient_Address as [Address],Patient_Phone_Number as [Phone number] from Patient", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnPatientById(int id)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Patient_ID as [ID],Patient_First_Name as [First name],Patient_Last_Name as [Last name], Patient_Address as [Address],Patient_Phone_Number as [Phone number] from Patient where Patient_ID like '%{id}%'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnPatientByFirstName(string firstName)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Patient_ID as [ID],Patient_First_Name as [First name],Patient_Last_Name as [Last name], Patient_Address as [Address],Patient_Phone_Number as [Phone number] from Patient where Patient_First_Name like '%{firstName}%'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnPatientByFullName(string firstName,string lastName)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Patient_ID as [ID],Patient_First_Name as [First name],Patient_Last_Name as [Last name], Patient_Address as [Address],Patient_Phone_Number as [Phone number] from Patient where Patient_First_Name like '%{firstName}%' and Patient_Last_Name like '%{lastName}%'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static bool CheckIfPatientExists(int id)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select * from Patient where Patient_ID={id}", connection);
            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count != 1)
            {
                return false;
            }
            return true;
        }
        public static void AddPatient(Patient patient)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            string query = $"INSERT INTO Patient (Patient_First_Name,Patient_Last_Name,Patient_Address,Patient_Phone_Number) VALUES (@firstName,@lastName,@address,@phoneNumber)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@firstName", patient.FirstName);
                command.Parameters.AddWithValue("@lastName", patient.LastName);
                command.Parameters.AddWithValue("@address", patient.Address);
                command.Parameters.AddWithValue("@phoneNumber",patient.PhoneNumber);
                command.ExecuteNonQuery();
            }
        }
        public static void UpdatePatient(Patient patient)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"update Patient\r\nset Patient_First_Name='{patient.FirstName}',Patient_Last_Name='{patient.LastName}',Patient_Address='{patient.Address}',Patient_Phone_Number='{patient.PhoneNumber}' where Patient_ID={patient.Id}", connection);
            command.ExecuteNonQuery();
        }
        public static void DeletePatient(int id)
        {
            AppointmentController.DeleteAppointmentByPatientId(id);
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"Delete from Patient where Patient_ID={id}", connection);
            command.ExecuteNonQuery();
        }
    }
}
