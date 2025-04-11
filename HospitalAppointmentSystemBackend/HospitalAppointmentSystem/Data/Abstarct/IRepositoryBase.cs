using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAppointmentSystem.Entites.Abstarct;

namespace HospitalAppointmentSystem.Data.Abstarct
{
    public interface IRepositoryBase <T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity); 
        Task DeleteAsync(int id);

    }
    
        
    
}