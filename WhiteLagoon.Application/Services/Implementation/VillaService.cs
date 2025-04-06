using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Application.Interfaces;
using WhiteLagoon.Application.Services.Interface;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Services.Implementation
{
    public class VillaService : IVillaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public VillaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddVilla(Villa villa)
        {
            _unitOfWork.Villa.Add(villa);
            _unitOfWork.save();
        }

        public bool DeleteVilla(int id)
        {
            try
            {
                {
                    var villa = _unitOfWork.Villa.Get(u => u.Id == id);
                    _unitOfWork.Villa.Remove(villa);
                    _unitOfWork.save();
                }

                return true;
            }
            catch (Exception) { return false; }
        }

        public IEnumerable<Villa> GetAllVillas()
        {
            return _unitOfWork.Villa.GetAll();
        }

        public Villa GetVilla(int id)
        {
            return _unitOfWork.Villa.Get(u => u.Id == id);
        }

        public void UpdateVilla(Villa villa)
        {
            _unitOfWork.Villa.Update(villa);
            _unitOfWork.save();


        }
    }
}