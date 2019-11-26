using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Repositories.Implementation
{
    class MemberRepository : BaseRepository<Member>, ICommonRepository<Member>
    {
        public MemberRepository(StaffHubContext context) : base(context) { }
    }
}
