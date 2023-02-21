using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.config
{
    internal class ServerConfig
    {
        [JsonProperty("port")]
        public int Port;
    }
}
