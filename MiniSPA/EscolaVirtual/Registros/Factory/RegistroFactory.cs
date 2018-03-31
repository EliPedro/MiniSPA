using MiniSPA.EscolaVirtual.Cursos;
using MiniSPA.EscolaVirtual.Estudantes;
using MiniSPA.EscolaVirtual.Registros.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace MiniSPA.EscolaVirtual.Registros.Factory
{
    public class RegistroFactory : IRegistroFactory
    {
        public Registro BuildRegistration()
        {
            var registration = new Registro
            {
                Cursos = ObterCursosSerializado(),
                Estudantes = ObterEstudantesSerializado(),
            };
            return registration;
        }

        public string ObterCursosSerializado()
        {
            var cursos = new[]
             {
                new Curso {Codigo = "1A", Nome = "Ensinando Angular", Instrutor = "Google"},
                new Curso {Codigo = "2B", Nome = "Ensinando AWS", Instrutor = "Amazon AWS"},
                new Curso {Codigo = "3C", Nome = "Ensinando .Net", Instrutor = "Microsoft"},
            };
            JsonSerializerSettings settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(cursos, Formatting.None, settings);
        }

        public string ObterEstudantesSerializado()
        {
            var estudantes = new[]
             {
                new Estudante {Codigo = "1", Nome = "Algum Nome", Email = "algumnome@email.com"},
                new Estudante {Codigo = "2", Nome = "Outro Nome", Email = "outronome@email.com"},
                new Estudante {Codigo = "3", Nome = "Mais Um Nome", Email = "maisumnome@email.com"},
            };
            JsonSerializerSettings settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(estudantes, Formatting.None, settings);
        }
    }
}