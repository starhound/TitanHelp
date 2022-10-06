using Microsoft.AspNetCore.Mvc;
using TitanHelp.Services;
using TitanHelp.WebApp.Models;

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
        public IActionResult Post(TicketModel newTicket) 
        {

            return Ok(newTicket);
        }
    }
}
