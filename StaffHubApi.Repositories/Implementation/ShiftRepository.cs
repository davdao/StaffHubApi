using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Repositories.Implementation
{
    class ShiftRepository : BaseRepository<Shift>, ICommonRepository<Shift>
    {
        public ShiftRepository(StaffHubContext context) : base(context) { }
    }
}
