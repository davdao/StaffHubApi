using System.Collections.Generic;
using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Services
{
    public class CategoryService : ICommonService<Category>
    {
        private readonly ICommonRepository<Category> _categoryRepository;

        public CategoryService(ICommonRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public bool Delete(Category item)
        {
            return _categoryRepository.Delete(item) > 0;
        }

        public IEnumerable<Category> Get()
        {
            return _categoryRepository.All;
        }

        public Category GetById(int itemID)
        {
            throw new System.NotImplementedException();
        }

        public Category Post(Category item)
        {
            _categoryRepository.Insert(item);
            _categoryRepository.Save();

            return item;
        }

        public Category Update(Category item)
        {
            _categoryRepository.Update(item);
            _categoryRepository.Save();

            return item;
        }
    }
}
