using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Repositories.Implementation
{
    public class CategoryRepository : BaseRepository<Category>, ICommonRepository<Category>
    {
        public CategoryRepository(StaffHubContext context) : base(context) { }
    }
}
