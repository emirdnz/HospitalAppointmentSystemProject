using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAppointmentSystem.Entites.Abstarct;

namespace HospitalAppointmentSystem.Entites.Concrete
{
     public class Patient : BaseEntity
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        List<Appointment> PatientAppointment { get; set; } = new List<Appointment>();

    }
}