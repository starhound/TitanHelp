
using TitanHelp.Data.Models;
using TitanHelp.EntityFramework.Data;
using TitanHelp.EntityFramework.Repositories;

namespace TitanHelp.Services
{
    public class TicketService
    {
        public TicketRepository repository { get; set; }
        public TicketService()
        {
            TicketRepository ticketRepository = new TicketRepository(new TicketContext());
            repository = ticketRepository;
        }

        public Ticket? QueryTicketById(int ticketId)
        {
            return repository.QueryTicketById(ticketId);
        }

        public bool CreateNewTicket(Ticket newTicket)
        {
            if(newTicket is null) 
                return false;
            if (newTicket.CustID is 0)
                return false;
            if (newTicket.TechnicianID is null)
                return false;
            var result = repository.WriteNewTicketCommand(newTicket);
            return result;
        }
    }
}