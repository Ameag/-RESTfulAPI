using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.repository.postgres.queris
{
    public interface IQueriesAccount
    {
        public string Create();
        public string Get();
        public string GetInfo();
    }
}
