using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto3000App_Domain.Models
{
    public class User : BaseEntity
    {
        public string ?FirstName { get; set; }
        public string ?Lastname { get; set; }
        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
        public int Age { get; set; }

        public List<Ticket> Tickets = new List<Ticket>();
    }
}
