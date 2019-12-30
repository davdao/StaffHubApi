using StaffHubApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Models.Relationship
{
    public class ActivitiesRelationship : EntityWithId
    {
        public int ActivityId { get; set; }

        public int MemberId { get; set; }

        public int? ShiftId { get; set; }

        public int CategoryId { get; set; }

        public Activity Activity { get; set; }

        public Member Member { get; set; }

        public Shift Shift { get; set; }

        public Category Category { get; set; }
    }
}
