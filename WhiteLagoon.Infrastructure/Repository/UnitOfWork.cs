﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Application.Interfaces;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IVillaRepository Villa { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
                Villa = new VillaRepository(_context);
        }
        public void save()
        {
            _context.SaveChanges();
        }
    }
}
