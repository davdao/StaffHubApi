using System.Collections.Generic;
using System.Linq;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Repositories.Implementation
{
    public class ActivitiesRelationshipRepository : BaseRepository<ActivitiesRelationship>, IActivitiesRelationshipRepository
    {
        public ActivitiesRelationshipRepository(StaffHubContext context) : base(context) { }

        public IEnumerable<ActivitiesRelationship> GetActivityShiftsByActivityId(int _activityId)
        {
            var objectArray = (from ar in _context.ActivitiesRelationship
                               join a in _context.Activity on ar.ActivityId equals a.Id
                               join m in _context.Member on ar.MemberId equals m.Id
                               join s in _context.Shift on ar.ShiftId equals s.Id
                               join c in _context.Client on s.Id equals c.Id
                               where ar.ActivityId == _activityId
                               select new ActivitiesRelationship { Activity = new Activity() 
                                                                    { 
                                                                        Name = a.Name
                                                                    },
                                                                    ActivityId = a.Id,
                                                                    MemberId = ar.MemberId,
                                                                    Member = new Member() 
                                                                    { 
                                                                        Name = m.Name,
                                                                        Email = m.Email
                                                                    },
                                                                    ShiftId = s.Id,
                                                                    Shift = new Shift()
                                                                    {
                                                                        Id = s.Id,
                                                                        Title = s.Title,
                                                                        StartDate = s.StartDate,
                                                                        EndDate = s.EndDate,
                                                                        Client = new Client()
                                                                        {
                                                                            Name = c.Name,
                                                                            Id = c.Id,
                                                                            Color = c.Color
                                                                        }
                                                                    }
                               });     
            return objectArray;
        }
    }
}
