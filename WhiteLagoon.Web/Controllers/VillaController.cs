using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Application.Services.Interface;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;
        public VillaController(IVillaService villaService)
        {
            _villaService = villaService;
        }
        public IActionResult Index()
        {
            var villa = _villaService.GetAllVillas();
            return View(villa);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Villa obj)
        {
            if (ModelState.IsValid)
            {
                _villaService.AddVilla(obj);
                TempData["Success"] = "Villa added Succesfully";

                return RedirectToAction("Index");

            }
            TempData["Failed"] = "Failed";

            return View();

        }
        public IActionResult Update(int Id)
        {
            var villa = _villaService.GetVilla(Id); // Fetch the Villa by ID
            if (villa == null)
            {
                return NotFound();
            }

            return View(villa);
        }
        [HttpPost]
        public IActionResult Update(Villa obj)

        {
            if (ModelState.IsValid && obj.Id > 0)
            {
                _villaService.UpdateVilla(obj);
                TempData["Success"] = "Updated Succesfully";
                return RedirectToAction("Index");
            }
            TempData["Failed"] = "Update failed";
            return View();

        }
        public IActionResult Delete(int Id)
        {
            var villa = _villaService.GetVilla(Id);
            if (villa == null)
            {
                return NotFound();
            }
            return View(villa);
        }
        [HttpPost]
        public IActionResult Delete(Villa obj)
        {
            bool deleted = _villaService.DeleteVilla(obj.Id);
            if (deleted)
            {
                TempData["Success"] = "Villa Deleted Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Failed"] = "Villa Deletion Failed";

            }
            return View();
        }
    }
}
