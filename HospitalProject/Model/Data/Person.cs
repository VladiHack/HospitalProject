using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Model
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        public Person( string firstName, string lastName,string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentException("Името е твърде късо!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Въведете фамилия!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                bool correctNum = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] >= 'a' && value[i] <= 'z')
                    {
                        correctNum = false;
                        break;
                    }
                }
                if (String.IsNullOrWhiteSpace(value) || !correctNum)
                {
                    throw new ArgumentException("Въведете валиден телефонен номер!");
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }
    }
    
}
