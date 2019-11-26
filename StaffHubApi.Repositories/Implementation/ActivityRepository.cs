using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StaffHubApi.Repositories.Implementation
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(StaffHubContext context) : base(context) { }


    }
}
