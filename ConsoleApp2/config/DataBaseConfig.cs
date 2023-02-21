using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.config
{
    internal class DataBaseConfig
    {
        [JsonProperty("host")]
        public string Host;
        [JsonProperty("username")]
        public string Username;
        [JsonProperty("password")]
        public string Password;
        [JsonProperty("database")]
        public string Database;
    }
}
