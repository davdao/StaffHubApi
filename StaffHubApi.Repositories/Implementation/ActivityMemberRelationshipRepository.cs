using System.Collections.Generic;
using System.Linq;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Repositories.Implementation
{
    public class ActivityMemberRelationshipRepository : BaseRepository<ActivityMemberRelationship>, IActivtiesMemberRelationshipRepository
    {
        public ActivityMemberRelationshipRepository(StaffHubContext context) : base(context) { }

        public IEnumerable<ActivityMemberRelationship> GetMembersByActivityId(int _activityId)
        {
            var objectArray = (from am in _context.ActivityMemberRelationship
                         join c in _context.Activity on am.ActivityId equals c.Id
                         join m in _context.Member on am.MemberId equals m.Id
                         where c.Id == _activityId
                         select new ActivityMemberRelationship
                         {
                             Activity = new Activity() { Name = c.Name },
                             ActivityId = c.Id,
                             MemberId = am.MemberId,
                             Member = new Member() { Name = m.Name, Email = m.Email }
                         });        
            return objectArray;
        }
    }
}
