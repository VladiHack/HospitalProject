using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Model
{
    public class Patient:Person
    {
        private int id;
        private string address;

        public Patient(string firstName,string lastName,string address,string phoneNumber):base(firstName, lastName,phoneNumber)
        {
            this.FirstName=firstName;
            this.LastName=lastName;
            this.Address=address;
            this.PhoneNumber=phoneNumber;
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

      
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Въведете адрес на пациента!");
                }
                else
                {
                    this.address = value;
                }
            }
        }
    }
}
