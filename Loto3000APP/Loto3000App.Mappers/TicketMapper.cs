using Loto3000App.DTOs.TicketDto;
using Loto3000App_Domain.Models;

namespace Loto3000App.Mappers
{
    public static class TicketMapper
    {
        public static TicketDto MapToTicketDto(this Ticket ticket)
        {
            return new TicketDto()
            {
                Numbers = ticket.Numbers,
                UserId = ticket.UserId,

            };
        }
    }
}
