using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Repositories.Contract
{
    public interface ICommonService<T>
    {
        IEnumerable<T> Get();

        T Post(T item);

        T Update(T item);

        bool Delete(T item);
    }
}
