using Newtonsoft.Json;
using StaffHubApi.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffHubApi.Models.Miscellaneous
{
    public class Color : ModelWithId
    {
        [JsonProperty("name")]
        public string ColorName { get; set; }

        [JsonProperty("colorcode")]
        public string ColorHexaCode { get; set; }
    }
}
