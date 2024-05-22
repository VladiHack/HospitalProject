using HospitalProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Model
{
    public class Appointment
    {
        private int patientId;
        private int doctorId;
        public DateTime Date;

        public Appointment(int patientId,int doctorId,DateTime date) 
        {
            this.PatientId = patientId;
            this.DoctorId = doctorId;
            this.Date = date;
        }
        public Appointment()
        {

        }

        public int PatientId
        {
            get { return patientId; }
            set
            {
                if (PatientController.CheckIfPatientExists(value)==false) throw new ArgumentException("Такъв пациент не съществува!");
                else this.patientId = value;
            }
        }

        public int DoctorId
        {
            get
            {
                return doctorId;
            }
            set
            {
                if (DoctorController.CheckIfDoctorExistsById(value)==false) throw new ArgumentException("Такъв доктор не съществува!");
                else this.doctorId= value;
            }
        }
    }
}
