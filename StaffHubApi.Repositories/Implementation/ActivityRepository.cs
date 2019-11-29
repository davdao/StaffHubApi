using System.Collections.Generic;
using System.Linq;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Repositories.Implementation
{
    public class ActivityRepository : BaseRepository<Activity>, ICommonRepository<Activity>
    {
        public ActivityRepository(StaffHubContext context) : base(context) {
        }
    }
}
