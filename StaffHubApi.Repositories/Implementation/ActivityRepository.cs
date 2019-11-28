using System.Collections.Generic;
using System.Linq;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Repositories.Implementation
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(StaffHubContext context) : base(context) {
        }

        public IEnumerable<ActivitiesRelationship> GetActivity(int _activityId)
        {
            var objectArray = (from am in _context.ActivitiesRelationship
                               join c in _context.Activity on am.ActivityId equals c.Id
                               join m in _context.Member on am.MemberId equals m.Id
                               where c.Id == _activityId
                               select new ActivitiesRelationship { Activity = new Activity() { Name = c.Name }, ActivityId = c.Id, MemberId = am.MemberId, Member = new Member() { Name = m.Name, Email = m.Email }});
            return objectArray;
        }
    }
}
