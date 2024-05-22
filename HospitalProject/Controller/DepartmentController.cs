using HospitalProject.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Controller
{
    public static class DepartmentController
    {
        public static DataTable ReturnAllDepartments()
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select Department_ID as [ID],Hospital_ID as [Hospital ID], Department_Name as [Department name] from Department", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnDepartmentById(int id)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Department_ID as [ID],Hospital_ID as [Hospital ID], Department_Name as [Department name] from Department where Department_ID like '%{id}%'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnDepartmentByName(string name)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Department_ID as [ID],Hospital_ID as [Hospital ID], Department_Name as [Department name] from Department where Department_Name like '%{name}%'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static void DeleteDepartmentsByHospitalID(int hospitalId)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"delete from Department where Department.Department_ID in (\r\nselect Department.Department_ID from Department\r\ninner join Hospital on Department.Hospital_ID=Hospital.Hospital_ID\r\nwhere Hospital.Hospital_ID={hospitalId})\r\n", connection);
            command.ExecuteNonQuery();
         


        }
        public static bool CheckIfDepartmentExists(int id)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select * from Department where Department.Department_ID={id}",connection);
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
        public static void AddDepartment(Department department)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            string query = $"INSERT INTO Department (Hospital_ID,Department_Name) VALUES (@hospitalId,@name)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@hospitalId",department.HospitalId);
                command.Parameters.AddWithValue("@name", department.Name);
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateDepartment(Department department)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"update Department\r\nset Hospital_ID={department.HospitalId},Department_Name='{department.Name}' where Department_ID={department.Id}", connection);
            command.ExecuteNonQuery();
        }
        public static void DeleteDepartment(int id)
        {
            StaffController.DeleteStaffByDepartmentID(id);
            AppointmentController.DeleteAppointmentByDepartmentID(id);
            DoctorController.DeleteDoctorByDepartmentId(id);
            SqlConnection connection=Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"Delete from Department where Department.Department_ID={id}", connection);
            command.ExecuteNonQuery();
        }
    }
}
