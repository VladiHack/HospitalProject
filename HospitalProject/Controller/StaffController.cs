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
    public class StaffController
    {
        public static DataTable ReturnAllStaff()
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select Staff_ID as [ID],Department_ID as [Department ID], Staff_First_Name as [First name],Staff_Last_Name as [Last name],Staff_Address as [Address],Staff_Phone_Number as [Phone number] from Staff Staff", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnStaffById(int id)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Staff_ID as [ID],Department_ID as [Department ID], Staff_First_Name as [First name],Staff_Last_Name as [Last name],Staff_Address as [Address],Staff_Phone_Number as [Phone number] from Staff where Staff_ID like '%{id}%' ", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnStaffByFirstName(string name)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Staff_ID as [ID],Department_ID as [Department ID], Staff_First_Name as [First name],Staff_Last_Name as [Last name],Staff_Address as [Address],Staff_Phone_Number as [Phone number] from Staff where Staff_First_Name like '%{name}%' ", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static DataTable ReturnStaffByFullName(string firstName,string lastName)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"select Staff_ID as [ID],Department_ID as [Department ID], Staff_First_Name as [First name],Staff_Last_Name as [Last name],Staff_Address as [Address],Staff_Phone_Number as [Phone number] from Staff where Staff_Last_Name like '%{lastName}%' and Staff_First_Name like '%{firstName}%'", connection);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            connection.Close();
            return dt;
        }
        public static void DeleteStaffByHospitalId(int hospitalId)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"delete from Staff where Staff.Staff_ID in (\r\nselect Staff.Staff_ID from Hospital\r\ninner join Department on Department.Hospital_ID = Hospital.Hospital_ID\r\ninner join Staff on Staff.Department_ID=Department.Department_ID\r\nwhere Hospital.Hospital_ID={hospitalId})", connection);
            command.ExecuteNonQuery();
        }
        public static void DeleteStaffByDepartmentID(int departmentID)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"delete from Staff where Staff.Department_ID={departmentID}", connection);
            command.ExecuteNonQuery();
        }
        public static void AddStaff(Staff staff)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            string query = $"INSERT INTO Staff (Department_ID,Staff_First_Name,Staff_Last_Name,Staff_Address,Staff_Phone_Number) VALUES (@departmentId,@firstName,@lastName,@address,@phoneNumber)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@departmentId",staff.DepartmentId);
                command.Parameters.AddWithValue("@firstName", staff.FirstName);
                command.Parameters.AddWithValue("@lastName", staff.LastName);
                command.Parameters.AddWithValue("@address", staff.Address);
                command.Parameters.AddWithValue("@phoneNumber", staff.PhoneNumber);
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateStaff(Staff staff)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"update Staff\r\nset Department_ID={staff.DepartmentId},Staff_First_Name='{staff.FirstName}',Staff_Last_Name='{staff.LastName}',Staff_Address='{staff.Address}',Staff_Phone_Number='{staff.PhoneNumber}' where Staff_ID={staff.Id}", connection);
            command.ExecuteNonQuery();
        }
        public static void DeleteStaff(int id)
        {
            SqlConnection connection=Database.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand($"Delete from Staff where Staff_ID={id}", connection);
            command.ExecuteNonQuery();
        }
    }
}
