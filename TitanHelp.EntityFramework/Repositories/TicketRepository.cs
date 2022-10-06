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
    internal class TicketRepository
    {
        public TicketContext _dbContext { get; set; }
        public TicketRepository(TicketContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool WriteNewTicketCommand(Ticket newTicket)
        {
            _dbContext.Add(newTicket);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
