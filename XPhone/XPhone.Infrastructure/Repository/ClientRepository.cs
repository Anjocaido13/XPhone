﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPhone.Domain.Entities;

namespace XPhone.Infrastructure.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly XPhoneDbContext _context;

        public ClientRepository(XPhoneDbContext context)
        {
            _context = context;
        }

        public async Task AddClientAsync(Client client)
        {
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckFineAsync(Guid id)
        {
            var client = await _context.Clients.FindAsync(id);
            return client != null && client.Fine;
        }

        public async Task DeleteClientByIdAsync(Guid id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetClientByIdAsync(Guid id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task<Client> GetFineAmount(Guid id)
        {
            return await GetClientByIdAsync(id);
        }

        public async Task UpdateClientAsync(Client client)
        {
            if(client != null)
            {
                _context.Clients.Update(client);
                await _context.SaveChangesAsync();
            }
            
        }
    }
}
