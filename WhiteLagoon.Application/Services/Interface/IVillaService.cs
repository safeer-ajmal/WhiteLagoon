using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Services.Interface
{
    public interface IVillaService
    {

        IEnumerable<Villa> GetAllVillas();
        Villa GetVilla(int id);
        void AddVilla(Villa villa);
        void UpdateVilla(Villa villa);
        bool DeleteVilla(int id);

    }
}
