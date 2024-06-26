﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPhone.Infrastructure.Repository
{
    public interface IStockRepository
    {
        Task<IEnumerable<Stock>> GetAllStocksAsync();
        Task<Stock> GetStockById(Guid id);

        Task UpdateStockAsync(Stock stock);

        Task DeleteStockAsync(Guid id);

        Task<SmartPhone> AddsmartPhone(Guid id, SmartPhone smartPhone);

        Task<Stock> CreateStock(Stock stock);
        Task<int> GetStockCountAsync(Guid id);
    }
}
