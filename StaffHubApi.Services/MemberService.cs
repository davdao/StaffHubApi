using System.Collections.Generic;
using System.Linq;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Relationship;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Services
{
    public class MemberService : IMemberService
    {
        private readonly ICommonRepository<Member> _memberRepository;
        private readonly ICommonRepository<Shift> _shiftRepository;
        private readonly IActivitiesRelationshipRepository _activitiesRelationshipRepository;

        public MemberService(ICommonRepository<Member> memberRepository,
                            ICommonRepository<Shift> shiftRepository,
                            IActivitiesRelationshipRepository activitiesRelationshipRepository)
        {
            _memberRepository = memberRepository;    
            _shiftRepository = shiftRepository;
            _activitiesRelationshipRepository = activitiesRelationshipRepository;
        }

        public bool AddEventByMemberEmail(Shift itemToUpdate, string memberEmail, int activityId)
        {
            bool succeeded = false;
            Member memberToLink = _memberRepository.All.Where(u => u.Email == memberEmail).FirstOrDefault();
            if (memberToLink != null)
            {
                Shift addedShift = _shiftRepository.Insert(itemToUpdate);
                _shiftRepository.Save();

                _activitiesRelationshipRepository.Insert(new ActivitiesRelationship() { ActivityId = activityId, MemberId = memberToLink.Id, ShiftId = addedShift.Id });
                _activitiesRelationshipRepository.Save();

                succeeded = true;
            }
            else
            {
                throw new System.Exception("User '" + memberEmail + "' not found");
            }
            return succeeded;
        }

        public bool Delete(Member item)
        {
            return _memberRepository.Delete(item) > 0;
        }

        public IEnumerable<Member> Get()
        {
            return _memberRepository.All;
        }

        public Member GetById(int itemID)
        {
            throw new System.NotImplementedException();
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
