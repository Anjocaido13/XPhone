﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPhone.Domain.Entities;
using XPhone.Infrastructure;

namespace XPhone.Infra.Repository
{
    public class RentRepository : IRentRepository
    {
        private readonly XPhoneDbContext _context;

        public RentRepository(XPhoneDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Rent>> GetAllRentAsync()
        {
            return await _context.Rents.ToListAsync();
        }

        public async Task<Rent> GetRentByIdAsync(int id)
        {
            return await _context.Rents.FindAsync(id);
        }

        public async Task UpdateRentAsync(Rent rent)
        {
            
           
                _context.Rents.Update(rent);
                await _context.SaveChangesAsync();
           
            
        }

        public async Task DeleteRentAsync(Guid id)
        {
            var rent = await _context.Rents.FindAsync(id);
            if (rent != null)
            {
                _context.Rents.Remove(rent);
                await _context.SaveChangesAsync();
            }

        }
    }
}