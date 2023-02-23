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
using It_PlanetaApi.service;
using System.Reflection.Metadata;
using It_PlanetaApi.handler;
using It_PlanetaApi.server;

const string CONFIG_FILE_PATH = "config/config.json";
//загрузка конфига
var config = new Config();
config.Load(CONFIG_FILE_PATH);


// соединение с базой и проверка
var database = new PostgresDatabase(config);


// создание слоя handler, service, repository

var repository = new Repository(database);
var service = new Service(repository);
var handler = new Handler(service);

var router = handler.GetRouter();
var server = new Server(config,router);
server.Run();




