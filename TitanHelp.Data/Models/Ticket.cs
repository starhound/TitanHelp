using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanHelp.Data.Models
{
    public class Ticket
    {
        public int? TicketID { get; set; }
        [Required]
        public int? TechnicianID { get; set; }
        public int CustID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string? IssueDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
