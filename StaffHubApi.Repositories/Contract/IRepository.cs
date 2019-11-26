using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StaffHubApi.Repositories.Contract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
    }
}
