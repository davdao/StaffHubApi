using StaffHubApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Repositories.Contract
{
    public interface IMemberService : ICommonService<Member>
    {
        public bool AddEventByMemberEmail(Shift itemToUpdate, string memberEmail, int activityId);
    }
}
