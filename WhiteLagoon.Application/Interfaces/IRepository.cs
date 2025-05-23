﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool Tracked = false);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool Tracked = false);
        void Add(T entity);
        void Remove(T entity);
        bool Any(Expression<Func<T, bool>> filter);

    }
}