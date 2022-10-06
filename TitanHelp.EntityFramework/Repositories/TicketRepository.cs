using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanHelp.Data.Models;
using TitanHelp.EntityFramework.Data;

namespace TitanHelp.EntityFramework.Repositories
{
    public class TicketRepository
    {
        public TicketContext _dbContext { get; set; }
        public TicketRepository(TicketContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool WriteNewTicketCommand(Ticket newTicket)
        {
            _dbContext.Add(newTicket);
            return _dbContext.SaveChanges() > 0;
        }

        public Ticket? QueryTicketById(int ticketId)
        {
            var ticket = _dbContext.Tickets.FirstOrDefault(x => x.TicketID == ticketId);
            return ticket;
        }

        public IEnumerable<Ticket> QueryAllTickets()
        {
            return _dbContext.Tickets.OrderByDescending(x => x.TicketID);
        }
    }
}
