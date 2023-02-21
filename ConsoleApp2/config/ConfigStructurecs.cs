using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.config
{
    internal class ConfigStructurecs
    {
        [JsonProperty("server")]
        public ServerConfig Server;

        [JsonProperty("database")]
        public DataBaseConfig Database;
    }
}
