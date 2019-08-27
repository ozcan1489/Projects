using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnesComp.Models;
using OnesComp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnesComp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEquipmentRepository _equipmentRepository;

        public HomeController(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {


            var equipments = _equipmentRepository.GetAllEquipments().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Equipment Overview",
                Equipments = equipments.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var equipment = _equipmentRepository.GetEquipmentById(id);
            if (equipment == null)
                return NotFound();

            return View(equipment);
        }
    
    }
}
