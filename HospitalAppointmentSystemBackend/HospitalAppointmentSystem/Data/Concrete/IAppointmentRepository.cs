using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAppointmentSystem.Data.Abstarct;
using HospitalAppointmentSystem.Entites.Concrete;

namespace HospitalAppointmentSystem.Data.Concrete
{
    public interface IAppointmentRepository : IRepositoryBase<Appointment>
    {
        
    }
}