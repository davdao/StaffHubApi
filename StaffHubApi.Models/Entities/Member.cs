using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StaffHubApi.Models.Entities
{
    public class Member : EntityWithId
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PictureUrl { get; set; }

        public ICollection<Shift> ShiftArray { get; set; } = new List<Shift>();
    }
}
