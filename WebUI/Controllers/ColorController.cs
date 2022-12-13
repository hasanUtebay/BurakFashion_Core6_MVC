using Business.Abstract;
using Business.Constants;
using Entities.Dtos.Color;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ColorController : Controller
    {
        private readonly IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AddColorDto dto)
        {
            if (ModelState.IsValid)
            {
                var result = _colorService.Create(dto);
                if (result.Success)
                {
                    return RedirectToAction("getall", "Color");
                }
                else
                {
                    ViewData["Error"] = result.Message;
                    return View(dto);
                }
            }
            return View(dto);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dto = _colorService.GetAll().Data;
            return View(dto);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var color = _colorService.GetById(id);
            UpdateColorDto dto = new UpdateColorDto()
            {
                Name = color.Data.Name,
                HexCode = color.Data.HexCode,
                ID = color.Data.ID
            };
            return View(dto);
        }

        [HttpPost]
        public IActionResult Update(UpdateColorDto dto)
        {
            if (ModelState.IsValid)
            {
               var result= _colorService.Update(dto);
                if (result.Success)
                {
                    return RedirectToAction("getall", "color");
                }
                else
                {
                    ViewData["Error"]= result.Message;
                    return View(dto);
                }
            }
            return View(dto);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _colorService.Delete(id);
            return RedirectToAction("getall", "Color");
        }


    }
}
