using Newtonsoft.Json;
using System.Collections.Generic;

namespace StaffHubApi.Models.Return
{
    public class Error
    {
        [JsonProperty("message")]
        public string Message { get; set; } = string.Empty;

        [JsonProperty("stack")]
        public string Stack { get; set; } = string.Empty;

        [JsonProperty("parameters")]
        public List<string> Parameters { get; set; }
    }
}
