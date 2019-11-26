using System.Collections.Generic;
using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Services
{
    public class ClientService : ICommonService<Client>
    {
        private readonly ICommonRepository<Client> _clientRepository;

        public ClientService(ICommonRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public bool Delete(Client item)
        {
            return _clientRepository.Delete(item) > 0;
        }

        public IEnumerable<Client> Get()
        {
            return _clientRepository.All;
        }

        public Client Post(Client item)
        {
            _clientRepository.Insert(item);
            _clientRepository.Save();

            return item;
        }

        public Client Update(Client item)
        {
            _clientRepository.Update(item);
            _clientRepository.Save();

            return item;
        }
    }
}
