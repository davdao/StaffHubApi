using Newtonsoft.Json;
using StaffHubApi.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Models.Activities
{
    public class Member : ModelWithId
    {
        [JsonProperty("name")]
        public string MemberName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("pictureurl")]
        public string PictureUrl { get; set; }

        [JsonProperty("shifts")]
        public Shift[] Shifts { get; set; }
    }
}
