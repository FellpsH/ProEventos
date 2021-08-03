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
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> evento = new Evento[] {
            new Evento(){            
                EventoId = 1,
                Tema = "Angular e .NET 5",
                Local = "Belo Horizonte",
                Lote = "Primeiro Lote",
                QtdPessoa = 150,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento(){     
                EventoId = 2,
                Tema = "O dia cinza, o ceu ta nublado!",
                Local = "New Texas",
                Lote = "Segundo Lote",
                QtdPessoa = 300,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                ImagemURL = "foto1.png"
            },
            new Evento(){     
                EventoId = 3,
                Tema = "O dia cinza, o ceu ta nublado!",
                Local = "New Texas",
                Lote = "Segundo Lote",
                QtdPessoa = 300,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                ImagemURL = "foto1.png"
            }
        };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Retorna Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Retorna Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Retorna Delete com id = {id}";
        }
    }
}
