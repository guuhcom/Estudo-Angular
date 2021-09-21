using proEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proEventos.Services
{
    public interface IEventos
    {
        IEnumerable<Evento> Eventos { get; }

        Evento GetEventoByID(int id);
    }
}
