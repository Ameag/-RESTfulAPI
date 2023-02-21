using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_PlanetaApi.config
{
    public class Config
    {

        private  ConfigStructurecs? _structure;
        public Config()
        {
            _structure = null;
        }
        /// <summary>
        /// Загружвет конфигрурацию из файла представленного по пути filepath 
        /// </summary>
        /// <param name="filepath">Путь к файлу</param>
        public void Load(string filepath)
        {
            _structure = JsonConvert.DeserializeObject<ConfigStructurecs>(File.ReadAllText(filepath));
           
        }

        /// <summary>
        /// Генерирует строку для подключения к базе данных 
        /// </summary>
        /// <returns>Строка подключения</returns>
        public string GetDataBaseConnString()
        {
            if(_structure == null )
            {
                throw new NullReferenceException("config not load");
            }
            var database = _structure.Database;
            return string.Format("Host={0};Username={1};Password={2};Database={3}",
                database.Host,
                database.Username,
                database.Password,
                database.Database);
        }

        /// <summary>
        /// Возвращает порт сервера 
        /// </summary>
        /// <returns>Порт сервера</returns>
        public string GetPort() 
        {
            return "";
        }
    }
}
