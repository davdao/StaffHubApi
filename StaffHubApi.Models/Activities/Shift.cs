using Newtonsoft.Json;
using StaffHubApi.Models.Base;
using StaffHubApi.Models.Miscellaneous;

namespace StaffHubApi.Models.Activities
{
    public class Shift : ModelWithId
    {
        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("startdate")]
        public string StartDate { get; set; }

        [JsonProperty("enddate")]
        public string EndDate { get; set; }

        [JsonProperty("client")]
        public Client Client { get; set; }

        [JsonProperty("color")]
        public Color Color { get; set; }
    }
}
