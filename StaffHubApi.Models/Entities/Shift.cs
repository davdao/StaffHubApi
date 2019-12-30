using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StaffHubApi.Models.Entities
{
    public class Shift : EntityWithId
    {
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [NotMapped]
        public Category Category { get; set; }

        [NotMapped]
        public int startDay { get; set; }

        [NotMapped]
        public int StartMonth { get; set; }

        [NotMapped]
        public int StartYear { get; set; }

        [NotMapped]
        public int endDay { get; set; }

        [NotMapped]
        public int endMonth { get; set; }

        [NotMapped]
        public int endYear { get; set; }
    }
}
