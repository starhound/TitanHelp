using Microsoft.AspNetCore.Mvc;
using System.Net;
using TitanHelp.Data.Models;
using TitanHelp.Services;

namespace TitanHelp.WebApp.Controllers
{
    public class TicketController : Controller
    {
        private TicketService _ticketService { get; set; }

        public TicketController(TicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get(int ticketId)
        {

            return Ok(ticketId);
        }

        [HttpPost]
        public IActionResult Post(Ticket newTicket) 
        {
            bool success = _ticketService.CreateNewTicket(newTicket);
            return Ok(HttpStatusCode.Created);
        }
    }
}
