using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffHubApi.Models
{
    public class MemberShift
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public int TotalHours { get; set; }
        public string PictureUrl { get; set; }

        public Shift[] Shifts { get; set; }

    }


    public class StaffGroup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public MemberShift[] TeamMembers { get; set; }

    }

    public class Shift
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
        public int StartYear { get; set; }
        public int StartMonth { get; set; }
        public int StartDay { get; set; }
        public string EndDate { get; set; }
        public int EndYear { get; set; }
        public int EndMonth { get; set; }
        public int EndDay { get; set; }
        public Client Client { get; set; }
        public string Color { get; set; }

        public int ClientId { get; set; }
        public int MemberShiftId { get; set; }
        public int StaffGroupId { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
    }


}
