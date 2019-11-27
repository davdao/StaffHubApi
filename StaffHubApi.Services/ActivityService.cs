using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;
using System.Collections.Generic;
using System.Linq;

namespace StaffHubApi.Services
{
    public class ActivityService : ICommonService<Activity>
    {
        private readonly ICommonRepository<Activity> _activityRepository;
        private readonly ICommonRepository<Member> _memberRepository;
        private readonly ICommonRepository<Client> _clientRepository;
        private readonly ICommonRepository<Shift> _shiftRepository;

        public ActivityService(ICommonRepository<Activity> activityRepository,
                                ICommonRepository<Member> memberRepository,
                                ICommonRepository<Client> clientRepository,
                                ICommonRepository<Shift> shiftRepository)
        {
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
            List<Activity> activities = _activityRepository.All.ToList();
            return activities;
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
    }
}
