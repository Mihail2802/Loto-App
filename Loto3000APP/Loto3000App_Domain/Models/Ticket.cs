namespace Loto3000App_Domain.Models
{
    public class Ticket : BaseEntity
    {
        public int Numbers { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
