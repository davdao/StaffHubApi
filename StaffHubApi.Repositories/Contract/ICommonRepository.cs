using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaffHubApi.Repositories.Contract
{
    public interface ICommonRepository<T>
    {
        IQueryable<T> All { get; }

        int Delete(T item);

        T Insert(T item);

        T Update(T item);

        int Save();
    }
}
