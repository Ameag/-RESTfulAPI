using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using Npgsql;
using It_PlanetaApi.config;
using It_PlanetaApi.repository;
using repository.postgres;
using repository.It_PlanetaApi.Account;

const string CONFIG_FILE_PATH = "config/config.json";
//загрузка конфига
var config = new Config();
config.Load(CONFIG_FILE_PATH);


// соединение с базой и проверка
var database = new PostgresDatabase(config);


// создание слоя handler, service, repository

var repository = new Repository(database);

var account = repository.Account.Get("nekqga@gmail.com", "1234");
Console.WriteLine(account.Email);

// запустить сервер

// отключение сервера






























namespace It_PlanetaApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=1234;Database=2023-itPlaneta";
            var connection = new NpgsqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
            Console.WriteLine("Connection to database successful");
            

            var listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Start();
            Console.WriteLine("server listener");


            while (true)
            {
                Console.WriteLine("Waiting request...");
                var context = listener.GetContext();
                var request = context.Request;
                var response = context.Response;

                var requestParams = request.QueryString;
                var method = request.HttpMethod;
                var endPoint = request.RawUrl;

                if (endPoint == null)
                {
                    throw new Exception("End point is null");
                }

                if(endPoint=="/locations")
                {
                    if(method=="POST") 
                    {
                        string body;
                        using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                        {
                            body = reader.ReadToEnd();
                        }

                        CreateLocationInput? input = JsonConvert.DeserializeObject<CreateLocationInput>(body);
                        if(input==null)
                        {
                            throw new Exception("error DeserializeObject");
                        }

                        var output = new CreateLocationOunput();
                        output.latitude = input.latitude;
                        output.longitude = input.longitude;
                        var outputString = JsonConvert.SerializeObject(output);
                        var buffer = Encoding.UTF8.GetBytes(outputString);

                        response.StatusCode = (int)HttpStatusCode.Created;
                        using (var outputStream = response.OutputStream)
                        {
                            outputStream.Write(buffer, 0, buffer.Length);
                        }
                    }
                }

            }

        }
    }


    class CreateLocationInput
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    class CreateLocationOunput
    {
        public double id { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

}


