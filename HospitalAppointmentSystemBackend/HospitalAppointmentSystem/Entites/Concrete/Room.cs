using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAppointmentSystem.Entites.Abstarct;

namespace HospitalAppointmentSystem.Entites.Concrete
{
     public class Room : BaseEntity
    {
        public required string RoomNumber { get; set; }
    }
}