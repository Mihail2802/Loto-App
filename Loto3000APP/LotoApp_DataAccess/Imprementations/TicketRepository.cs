using Loto3000App_Domain.Models;
using LotoApp_DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LotoApp_DataAccess.Imprementations
{
    public class TicketRepository : IRepository<Ticket>
    {
        private readonly TicketsDbContext _ticketsDbContext;

        public TicketRepository(TicketsDbContext ticketetsDbContext)
        {
            _ticketsDbContext = ticketetsDbContext;
        }

        public async Task<Ticket> CreateAsync(Ticket entity)
        {
            await _ticketsDbContext.Tickets.AddAsync(entity);
            await _ticketsDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteByIdAsync(int id)
        {
            try
            {
                var entity = await _ticketsDbContext.Tickets.FirstOrDefaultAsync(x => x.Id == id);
                _ticketsDbContext.Tickets.Remove(entity ?? throw new NullReferenceException($"Ticket does not exist with id {id}."));
                await _ticketsDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<List<Ticket>> GetAllAsync()
        {
            return await _ticketsDbContext.Tickets.ToListAsync();
        }

        public async Task<Ticket> GetbyIdAsync(int id)
        {
            return await _ticketsDbContext.Tickets.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Ticket> UpdateAsync(Ticket entity)
        {
            _ticketsDbContext.Tickets.Update(entity);
            await _ticketsDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
