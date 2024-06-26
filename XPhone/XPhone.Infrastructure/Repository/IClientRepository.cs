﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPhone.Domain.Entities;

namespace XPhone.Infrastructure.Repository
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task<Client> GetClientByIdAsync(Guid id);
        Task<Client> AddClientAsync(Client client);
        Task UpdateClientAsync(Client client);
        Task DeleteClientByIdAsync(Guid id);

        


    }
}
