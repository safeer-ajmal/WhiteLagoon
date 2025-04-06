using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Application.Interfaces
{
    public interface IUnitOfWork 
    {
        public IVillaRepository Villa { get; }
        void save();
    }
}
