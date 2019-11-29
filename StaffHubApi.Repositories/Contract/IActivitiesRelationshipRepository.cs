using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;
using System.Collections.Generic;

namespace StaffHubApi.Repositories.Contract
{
    public interface IActivitiesRelationshipRepository : ICommonRepository<ActivitiesRelationship>
    {
        public IEnumerable<ActivitiesRelationship> GetActivityShiftsByActivityId(int itemId);
    }
}
