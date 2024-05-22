using HospitalProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Controller
{
    public static class DoctorController
    {
        public static void AddDoctor(Doctor doctor)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            string query = $"INSERT INTO Doctor (Doctor_First_Name, Doctor_Last_Name,Department_ID,Doctor_Phone_Number) VALUES (@first_name,@last_name,@department_id,@doctor_phone_number)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@first_name", doctor.FirstName);
                command.Parameters.AddWithValue("@last_name", doctor.LastName);
                command.Parameters.AddWithValue("@department_id", doctor.DepartmentId);
                command.Parameters.AddWithValue("@doctor_phone_number", doctor.PhoneNumber);

                command.ExecuteNonQuery();

            }
        }
        public static bool DoctorExists(Doctor doctor)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            string query = $"Select * from Doctor where Doctor_First_Name='{doctor.FirstName}' AND Doctor_Last_Name='{doctor.LastName}' AND Department_ID={doctor.DepartmentId} AND Doctor_Phone_Number='{doctor.PhoneNumber}' ";
            SqlCommand command = new SqlCommand(query, connection);
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
        public static DataTable ReturnAllDoctors()
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select Doctor_ID as [ID],Doctor_First_Name as [First name],Doctor_Last_Name as [Last name],Department_ID as [Department ID],Doctor_Phone_Number as [Phone number] from Doctor", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();

            return dt;
        }
        public static DataTable ReturnDoctorById(int id)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Doctor_ID as [ID],Doctor_First_Name as [First name],Doctor_Last_Name as [Last name],Department_ID as [Department ID],Doctor_Phone_Number as [Phone number] from Doctor where Doctor_ID like '%{id}%' ", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnDoctorByFirstName(string name)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Doctor_ID as [ID],Doctor_First_Name as [First name],Doctor_Last_Name as [Last name],Department_ID as [Department ID],Doctor_Phone_Number as [Phone number] from Doctor where Doctor_First_Name like '%{name}%' ", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnDoctorByFullName(string firstName,string lastName)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Doctor_ID as [ID],Doctor_First_Name as [First name],Doctor_Last_Name as [Last name],Department_ID as [Department ID],Doctor_Phone_Number as [Phone number] from Doctor where Doctor_First_Name like '%{firstName}%' AND Doctor_Last_Name like '%{lastName}%' ", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static void DeleteDoctorByHospitalId(int hospitalId)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"delete from Doctor where Doctor.Doctor_ID in (\r\nselect Doctor_ID from Doctor\r\ninner join Department on Department.Department_ID=Doctor.Department_ID\r\ninner join Hospital on Hospital.Hospital_ID=Department.Hospital_ID\r\nwhere Hospital.Hospital_ID={hospitalId})", connection);
            command.ExecuteNonQuery();
            //Delete all appointments, featuring this doctor
        }
        public static void UpdateDoctor(Doctor doctor)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"update Doctor\r\nset Doctor_First_Name='{doctor.FirstName}',Doctor_Last_Name='{doctor.LastName}',Department_ID={doctor.DepartmentId},Doctor_Phone_Number='{doctor.PhoneNumber}' where Doctor_ID={doctor.Id}", connection);
            command.ExecuteNonQuery();
        }
        public static void DeleteDoctor(int id)
        {
            //Delete all appointments featuring this doctor
            AppointmentController.DeleteAppointmentByDoctorId(id);
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"Delete from Doctor where Doctor.Doctor_ID={id}",connection);
            command.ExecuteNonQuery();
 
        }
        public static void DeleteDoctorByDepartmentId(int id) 
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"Delete from Doctor where Doctor.Department_ID={id}", connection);
            command.ExecuteNonQuery();
        }
        public static bool CheckIfDoctorExistsById(int id)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select * from Doctor where Doctor_ID={id}", connection);
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

    }
}
