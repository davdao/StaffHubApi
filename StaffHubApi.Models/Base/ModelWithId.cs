using Newtonsoft.Json;
using System;

namespace StaffHubApi.Models.Base
{
    public class ModelWithId
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
