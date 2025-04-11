using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAppointmentSystem.Entites.Abstarct;

namespace HospitalAppointmentSystem.Entites.Concrete
{
     public class Doctor : BaseEntity
    {
        public required string DoctorName { get; set; }
        public required string DoctorSurname { get; set; }   
        public required string Branch { get; set; }  

        IList<Room> rooms { get; set; } = new List<Room>();
        IList<Appointment> DoctorAppointment { get; set; } = new List<Appointment>();
    }
}