using StaffHubApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Models.Relationship
{
    public class ActivityMemberRelationship : EntityWithId
    {
        public int ActivityId { get; set; }

        public int MemberId { get; set; }

        public Activity Activity { get; set; }

        public Member Member { get; set; }
    }
}
