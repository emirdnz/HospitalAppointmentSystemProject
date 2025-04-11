using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAppointmentSystem.Entites.Abstarct;

namespace HospitalAppointmentSystem.Entites.Concrete
{
    public class Appointment : BaseEntity
    {
        public required string AppointmentDate { get; set; }
        public required string AppointmentTime { get; set; }
        public required string AppointmentStatus { get; set; } // e.g., "Pending", "Confirmed", "Cancelled"
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int RoomId { get; set; }
        public required Patient Patient { get; set; }
        public required Doctor Doctor { get; set; }
        public required Room Room { get; set; }  
    }
}