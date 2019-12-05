using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Repositories.Implementation
{
    public class ClientRepository : BaseRepository<Client>, ICommonRepository<Client>
    {
        public ClientRepository(StaffHubContext context) : base(context) { }
    }
}
