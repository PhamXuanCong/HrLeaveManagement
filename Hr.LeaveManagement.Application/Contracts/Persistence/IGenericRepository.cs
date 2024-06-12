using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Contracts.Persistence
{
    //where o day co nghiax laf T phari la 1 lop
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<bool> Exists(int id);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
