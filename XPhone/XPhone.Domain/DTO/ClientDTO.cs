﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPhone.Domain.Entities.DTO
{
    public class ClientDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Fine { get; set; }
        public double FineAmount { get; set; }

        public string Phone {  get; set; }

       public virtual ICollection<Rent> Rents { get; set; }
    }
}
