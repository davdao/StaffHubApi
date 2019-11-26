
using StaffHubApi.Models.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace StaffHubApi.Repositories.Contract
{
    public interface IActivityRepository 
    {
        IQueryable<Activity> All { get; }

        Activity Find(params object[] keyValues);

        int Delete(Activity kvp);

        Activity Insert(Activity kvp);

        Activity Update(Activity kvp);
        int Save();
    }
}   
