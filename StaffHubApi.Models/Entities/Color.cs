using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Models.Entities
{
    public class Color : EntityWithId
    {
        public string Name { get; set; }

        public string ColorCode { get; set; }
    }
}
