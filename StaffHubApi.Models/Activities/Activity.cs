using Newtonsoft.Json;
using StaffHubApi.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Models.Activities
{
    public class Activity : ModelWithId
    {
        [JsonProperty("activityname")]
        public string ActivityName { get; set; }

        [JsonProperty("members")]
        public Member[] ActivityMembers { get; set; }
    }
}
