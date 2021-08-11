using Gimli.Data.Entities.Enums;
using Gimli.Data.Repository;
using Gimli.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Gimli.Controllers
{
    public class ClothController : Controller
    {
        private readonly IClothRepository _clothRepository;

        public ClothController(IClothRepository clothRepository)
        {
            _clothRepository = clothRepository;
        }

        public IActionResult Index()
        {
            var clothes = _clothRepository.GetAll().ToList();

            var clothesViewModelList = clothes.Select(cloth => new ClothViewModel
            { 
                Id = cloth.Id,
                Name = cloth.Name,
                Type = Enum.GetName(typeof(ClothType), cloth.Type)
            }).ToList();

            return View(clothesViewModelList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
