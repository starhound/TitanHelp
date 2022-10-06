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
            var ticket = _ticketService.QueryTicketById(ticketId);
            if(ticket is not null)
            {
                return Ok(ticket);
            }
            return BadRequest(ticketId);
        }

        [HttpGet]
        [Route("Ticket/getTickets")]
        public IActionResult GetTickets()
        {
            IEnumerable<Ticket> tickets = _ticketService.QueryTickets();
            return Ok(tickets);
        }

        [HttpDelete]
        [Route("Ticket/deleteTicket")]
        public IActionResult DeleteTicket(int ticketId)
        {
            if(_ticketService.DeleteTicket(ticketId))
            {
                return Ok(HttpStatusCode.Accepted);
            }
            return BadRequest(ticketId.ToString());
        }

        [HttpPost]
        [Route("Ticket/newTicket")]
        public IActionResult NewTicket([FromForm] Ticket newTicket) 
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
