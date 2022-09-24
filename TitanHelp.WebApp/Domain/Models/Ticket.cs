using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TitanHelp.WebApp.Domain.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        [Required]
        public int TechnicianID { get; set; }
        public int CustID { get; set; }
        public DateOnly CreatedDate { get; set; }
        public DateOnly CompletedDate { get; set; }
        public string? IssueDescription { get; set; }
        public bool IsActive { get; set; }

        public Technician Technician { get; set; }
        public Customer Customer { get; set; }
    }
}
