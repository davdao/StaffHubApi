using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;
using System.Collections.Generic;

namespace StaffHubApi.Repositories.Contract
{
    public interface IActivityRepository : ICommonRepository<Activity>
    {
        public IEnumerable<ActivitiesRelationship> GetActivity(int itemId);
    }
}
