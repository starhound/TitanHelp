
using TitanHelp.Data.Models;
using TitanHelp.EntityFramework.Data;
using TitanHelp.EntityFramework.Repositories;

namespace TitanHelp.Services
{
    public class TicketService
    {
        public TicketContext _context { get;set;} 
        public TicketRepository repository { get; set; }
        public TicketService()
        {
            TicketRepository ticketRepository = new TicketRepository(new TicketContext());
            repository = ticketRepository;
        }

        public bool CreateNewTicket(Ticket newTicket)
        {
            var result = repository.WriteNewTicketCommand(newTicket);
            return result;
        }
    }
}