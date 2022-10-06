using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanHelp.EntityFramework.Models
{
    public class Technician
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int IssuesResolved { get; set; }

    }
}
