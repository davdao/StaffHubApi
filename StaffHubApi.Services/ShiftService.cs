using System.Collections.Generic;
using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Services
{
    public class ShiftService : ICommonService<Shift>
    {
        private readonly ICommonRepository<Shift> _shiftRepository;

        public ShiftService(ICommonRepository<Shift> shiftRepository)
        {
            _shiftRepository = shiftRepository;
        }

        public bool Delete(Shift item)
        {
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
