using Newtonsoft.Json;
using StaffHubApi.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Models.Miscellaneous
{
    public class Client : ModelWithId
    {
        [JsonProperty("name")]
        public string ClientName { get; set; }

        [JsonProperty("name")]
        public Color ClientColor { get; set; }
    }
}
