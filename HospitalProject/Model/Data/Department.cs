using HospitalProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Model
{
    public class Department
    {


        private int id;
        private int hospitalId;
        private string name;

        public Department( int hospitalId, string name)
        {
            HospitalId = hospitalId;
            Name = name;
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
        public int HospitalId
        {
            get
            {
                return this.hospitalId;
            }
            set
            {
                //CHECK IF THERE IS A HOSPITAL WITH SUCH ID
                if(HospitalController.ContainsId(value))
                {
                  this.hospitalId = value;
                }
                else
                {
                    throw new ArgumentException("Няма болница с такъв номер!");
                }
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
                    throw new ArgumentException("Въведете име на отдел!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
