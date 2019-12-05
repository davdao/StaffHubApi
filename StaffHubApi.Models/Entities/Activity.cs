using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffHubApi.Models.Entities
{
    public class Activity : EntityWithId
    {
        public string Name { get; set; }

        public Guid TenantId { get; set; }

        [NotMapped]
        public ICollection<Member> Members { get; set; } = new List<Member>();
    }
}
