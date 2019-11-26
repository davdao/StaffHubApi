using System.Collections.Generic;
using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Services
{
    class MemberService : ICommonService<Member>
    {
        private readonly ICommonRepository<Member> _memberRepository;

        public MemberService(ICommonRepository<Member> memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public bool Delete(Member item)
        {
            return _memberRepository.Delete(item) > 0;
        }

        public IEnumerable<Member> Get()
        {
            return _memberRepository.All;
        }

        public Member Post(Member item)
        {
            _memberRepository.Insert(item);
            _memberRepository.Save();

            return item;
        }

        public Member Update(Member item)
        {
            _memberRepository.Update(item);
            _memberRepository.Save();

            return item;
        }
    }
}
