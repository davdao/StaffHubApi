using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StaffHubApi.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }

        public bool Delete(Activity item)
        {
            return _activityRepository.Delete(item) > 0;
        }

        public IEnumerable<Activity> Get()
        {
            return _activityRepository.All;
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
