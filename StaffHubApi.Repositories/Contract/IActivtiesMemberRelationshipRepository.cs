using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;
using System.Collections.Generic;

namespace StaffHubApi.Repositories.Contract
{
    public interface IActivtiesMemberRelationshipRepository : ICommonRepository<ActivityMemberRelationship>
    {
        public IEnumerable<ActivityMemberRelationship> GetMembersByActivityId(int itemId);
    }
}
