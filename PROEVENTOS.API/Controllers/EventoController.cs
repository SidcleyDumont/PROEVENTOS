using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROEVENTOS.API.Models;

namespace PROEVENTOS.API.Controllers
{

[ApiController]
[Route("api/controller")]
public class EventoController : ControllerBase
   {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular 11 e .Net 5",
                    Local = "Mamanguape",
                    Lote = "1º Lote",
                    QtdPessoas = 400,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "jpg",
                    Nome = "Sidcley"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular 11",
                    Local = "João Pessoa",
                    Lote = "2º Lote",
                    QtdPessoas = 40,
                    DataEvento = DateTime.Now.AddDays(10).ToString("dd/MM/yyyy"),
                    ImagemURL = "jpg",
                    Nome = "Sidcley Joao"
                }
            };
        public EventoController()
        { 
        }
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento=>evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }
        
    }
};