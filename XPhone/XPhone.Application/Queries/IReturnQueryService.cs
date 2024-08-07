﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPhone.Domain.Entities;
using XPhone.Domain.Entities.DTO;

namespace XPhone.Application.Queries
{
    public interface IReturnQueryService
    {
        Task<ReturnDTO> GetReturnAsync(Guid id);
        Task<IEnumerable<Return>> GetAllReturnAsync();
    }
}
