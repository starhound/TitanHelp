using System.ComponentModel.DataAnnotations;

namespace TitanHelp.WebApp.Domain.Models
{
    public class Technician
    {
        public int TechnicianId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

    }
}
