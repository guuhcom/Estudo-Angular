using proEventos.Context;
using proEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proEventos.Services
{
    public class EventoStore : IEventos
    {
        private readonly AppDbContext _context;

        public EventoStore(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Evento> Eventos => _context.Eventos;

        public Evento GetEventoByID(int id) => _context.Eventos.FirstOrDefault(e => e.Id == id);
    }
}
