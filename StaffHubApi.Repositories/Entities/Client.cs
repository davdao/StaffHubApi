using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StaffHubApi.Repositories.Entities
{
    public class Client : EntityWithId
    {
        public string Name { get; set; }

        public Color Color { get; set; }
    }
}
