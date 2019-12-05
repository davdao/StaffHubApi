using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;
using StaffHubApi.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StaffHubApi.Services
{
    public class ActivityService : ICommonService<Activity>
    {
        private readonly IActivitiesRelationshipRepository _activitiesRelationshipRepository;
        private readonly IActivtiesMemberRelationshipRepository _activtiesMemberRelationshipRepository;
        private readonly ICommonRepository<Activity> _activityRepository;
        private readonly ICommonRepository<Member> _memberRepository;
        private readonly ICommonRepository<Client> _clientRepository;
        private readonly ICommonRepository<Shift> _shiftRepository;

        public ActivityService(IActivitiesRelationshipRepository activitiesRelationshipRepository,
                                IActivtiesMemberRelationshipRepository activtiesMemberRelationshipRepository,
                                ICommonRepository<Activity> activityRepository,
                                ICommonRepository<Member> memberRepository,
                                ICommonRepository<Client> clientRepository,
                                ICommonRepository<Shift> shiftRepository)
        {
            _activitiesRelationshipRepository = activitiesRelationshipRepository;
            _activtiesMemberRelationshipRepository = activtiesMemberRelationshipRepository;
            _activityRepository = activityRepository;
            _memberRepository = memberRepository;
            _clientRepository = clientRepository;
            _shiftRepository = shiftRepository;
        }

        public bool Delete(Activity item)
        {
            return _activityRepository.Delete(item) > 0;
        }

        public IEnumerable<Activity> Get()
        {
            return _activityRepository.All;
        }

        private object Cast(object singleItem, object p)
        {
            throw new NotImplementedException();
        }

        public Activity Post(Activity item)
        {
            _activityRepository.Insert(item);
            _activityRepository.Save();

            return item;
        }

        public Activity Update(Activity item)
        {
            _activityRepository.Update(item);
            _activityRepository.Save();

            return item;
        }

        public Activity GetById(int activityId)
        {
            List<ActivityMemberRelationship> membersList = _activtiesMemberRelationshipRepository.GetMembersByActivityId(activityId).ToList();
            List<ActivitiesRelationship> shiftsList = _activitiesRelationshipRepository.GetActivityShiftsByActivityId(activityId).ToList();
            Activity activity = new Activity() { Id = 0 };

            membersList.ForEach((singleItem) =>
            {
                if (activity.Id != singleItem.ActivityId)
                {
                    activity = new Activity();
                    activity.Id = singleItem.ActivityId;
                    activity.Name = singleItem.Activity.Name;
                }

                List<Shift> filteredValues = shiftsList.Where(u => u.MemberId == singleItem.MemberId).Select(i => i.Shift).ToList();
                Member memberToAdd = new Member()
                {
                    Id = singleItem.MemberId,
                    Name = singleItem.Member.Name,
                    Email = singleItem.Member.Email
                };

                if (filteredValues.Count > 0)
                    memberToAdd.ShiftArray = filteredValues;
                activity.Members.Add(memberToAdd);
            });

            return activity;
        }
    }
}
