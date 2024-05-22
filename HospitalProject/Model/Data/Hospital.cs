using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject.Model
{
    public class Hospital
    {
        private int id;
        private string name;
        private string address;
        private string phoneNumber;
        private string state;

        public Hospital(string name,string address,string phoneNumber,string state)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.State= state;

        }
        public Hospital()
        {

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
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Въведете име за болницата!");
                }
                else
                {
                    this.name = value;
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
               if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Въведете адрес на болницата!");
                }
                else
                {
                    this.address = value;
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
                for(int i=0;i<value.Length; i++)
                {
                    if (value[i] >= 'a' && value[i]<='z')
                    {
                        correctNum = false;
                        break;
                    }
                }
                if(String.IsNullOrWhiteSpace(value)||!correctNum)
                {
                    throw new ArgumentException("Въведете валиден телефонен номер за болницата");
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Въведете име на град за болницата!");
                }
                else
                {
                    this.state = value;
                }
            }
        }
    }
}
