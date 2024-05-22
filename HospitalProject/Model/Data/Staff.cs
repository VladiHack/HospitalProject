using HospitalProject.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Model
{
    public class Staff:Person
    {
        int id;
        int departmentId;
        string address;

        public Staff( int departmentId, string firstName, string lastName, string address, string phoneNumber):base(firstName, lastName,phoneNumber) 
        {
            DepartmentId = departmentId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public int DepartmentId
        {
            get
            {
                return this.departmentId;
            }
            set
            {
                if(!DepartmentController.CheckIfDepartmentExists(value))
                {
                    throw new ArgumentException("Такъв отдел не съществува!");
                }
                else
                {
                    this.departmentId = value;
                }
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Въведете адрес на служител");
                }
                else
                {
                    this.address = value;
                }
            }
        }


    }
}
