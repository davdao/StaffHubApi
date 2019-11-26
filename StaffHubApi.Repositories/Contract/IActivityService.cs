using StaffHubApi.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StaffHubApi.Repositories.Contract
{
    public interface IActivityService
    {
        IEnumerable<Activity> Get();

        Activity Post(Activity item);

        Activity Update(Activity item);

        bool Delete(Activity item);
    }
}
