using Newtonsoft.Json;
using System.Collections.Generic;

namespace StaffHubApi.Models.Return
{
    public class ResultBase<T>
    {
        [JsonProperty("data")]
        public IEnumerable<T> Data { get; set; }

        [JsonProperty("item")]
        public T Item { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; } = true;

        [JsonProperty("error")]
        public Error Error { get; set; } = new Error();
    }
}
