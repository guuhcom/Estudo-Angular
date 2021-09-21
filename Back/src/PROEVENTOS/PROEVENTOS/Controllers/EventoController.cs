using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proEventos.Context;
using proEventos.Models;
using proEventos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IEventos _evento;

        public EventoController(AppDbContext context,IEventos evento)
        {
            _context = context;
            _evento = evento;
        }


        [HttpGet]
        public IList<Evento> Get()
        {
            return (this._context.Eventos.ToList());

        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _evento.GetEventoByID(id);

        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Get";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return string.Format("Exemplo de Put com id = {0}", id);
        }

        [HttpDelete("{id}")]
        public string Del(int id)
        {
            return $"Exemplo de delete id = {id}";
        }

    }
}
