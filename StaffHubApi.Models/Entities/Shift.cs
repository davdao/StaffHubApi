using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Models.Entities
{
    public class Shift : EntityWithId
    {
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Client Client { get; set; }
    }
}
