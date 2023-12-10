using Loto3000App_Domain.Models;
using LotoApp_DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LotoApp_DataAccess.Imprementations
{
    public class UserRepository : IRepository<User>
    {
        private readonly TicketsDbContext _ticketsDbContext;

        public UserRepository(TicketsDbContext ticketetsDbContext)
        {
            _ticketsDbContext = ticketetsDbContext;
        }

        public async Task<User> CreateAsync(User entity)
        {
            await _ticketsDbContext.Users.AddAsync(entity);
            await _ticketsDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteByIdAsync(int id)
        {
            try
            {
                var entity = await _ticketsDbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
                _ticketsDbContext.Users.Remove(entity ?? throw new NullReferenceException($"User does not exist with id {id}."));
                await _ticketsDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _ticketsDbContext.Users.ToListAsync();
        }

        public async Task<User> GetbyIdAsync(int id)
        {
            return await _ticketsDbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> UpdateAsync(User entity)
        {
            _ticketsDbContext.Users.Update(entity);
            await _ticketsDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
