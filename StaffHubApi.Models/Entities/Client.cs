using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StaffHubApi.Models.Entities
{
    public class Category : EntityWithId
    {
        public string Name { get; set; }

        public string Color { get; set; }
    }
}
