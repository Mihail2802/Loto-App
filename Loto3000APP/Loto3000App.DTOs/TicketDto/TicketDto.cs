namespace Loto3000App.DTOs.TicketDto
{
    public class TicketDto
    {
        public int Numbers { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; }
    }
}
