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

        [Route("Ticket")]
        [HttpGet]
        public IActionResult Ticket()
        {
            return View("Ticket");
        }

        [HttpGet]
        [Route("Ticket/getTicket")]
        public IActionResult Get(int ticketId)
        {

            return Ok(ticketId);
        }

        [HttpPost]
        [Route("Ticket/newTicket")]
        public IActionResult Post(Ticket newTicket) 
        {
            bool success = _ticketService.CreateNewTicket(newTicket);
            if(success)
            {
                return Ok(HttpStatusCode.Created);
            }
            else
            {
                return BadRequest(newTicket);
            }
        }
    }
}
