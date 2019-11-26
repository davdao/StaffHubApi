using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StaffHubApi.Models.Entities
{
    public class Activity : EntityWithId
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public ICollection<Member> Members { get; set; } = new List<Member>();
    }
}
