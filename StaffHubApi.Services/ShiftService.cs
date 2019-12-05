using System.Collections.Generic;
using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;
using System.Linq;

namespace StaffHubApi.Services
{
    public class ShiftService : ICommonService<Shift>
    {
        private readonly ICommonRepository<Shift> _shiftRepository;
        private readonly IActivitiesRelationshipRepository _activitiesRelationshipRepository;

        public ShiftService(ICommonRepository<Shift> shiftRepository,
                            IActivitiesRelationshipRepository activitiesRelationshipRepository)
        {
            _shiftRepository = shiftRepository;
            _activitiesRelationshipRepository = activitiesRelationshipRepository;
        }

        public bool Delete(Shift item)
        {
            var activitiesToDelete = _activitiesRelationshipRepository.All.Where(i => i.ShiftId == item.Id).FirstOrDefault();
            _activitiesRelationshipRepository.Delete(activitiesToDelete);
                
            return _shiftRepository.Delete(item) > 0;
        }

        public IEnumerable<Shift> Get()
        {
            return _shiftRepository.All;
        }

        public Shift GetById(int itemID)
        {
            throw new System.NotImplementedException();
        }

        public Shift Post(Shift item)
        {
            _shiftRepository.Insert(item);
            _shiftRepository.Save();

            return item;
        }

        public Shift Update(Shift item)
        {
            _shiftRepository.Update(item);
            _shiftRepository.Save();

            return item;
        }
    }
}
