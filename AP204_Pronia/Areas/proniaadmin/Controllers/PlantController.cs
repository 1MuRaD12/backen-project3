using AP204_Pronia.DAL;
using AP204_Pronia.Existent;
using AP204_Pronia.Models;
using AP204_Pronia.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AP204_Pronia.Areas.proniaadmin.Controllers
{
    [Area("proniaadmin")]

    public class PlantController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment env;

        public PlantController(AppDbContext context, IWebHostEnvironment env)
        {
            this.context = context;
            this.env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Plant> plants = await context.Plants.Include(p => p.PlantImages).ToListAsync();
            return View(plants);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Sizes = await context.Sizes.ToArrayAsync();
            ViewBag.Colors = await context.Colors.ToArrayAsync();

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Plant plant)
        {
            ViewBag.Sizes = await context.Sizes.ToArrayAsync();
            ViewBag.Colors = await context.Colors.ToArrayAsync();
            if (!ModelState.IsValid) return View();
            if (plant.MainImage == null || plant.AnotherImage == null)
            {
                ModelState.AddModelError("", "Please choose mainImage or AnotherImage");
                return View();
            }
            if (!plant.MainImage.isExtent(1))
            {
                ModelState.AddModelError("MainImage", "Please choose mainImage max 1mb");
                return View();
            }
            foreach (var image in plant.AnotherImage)
            {
                if (!image.isExtent(1))
                {
                    ModelState.AddModelError("AnotherImage", "Please choose AnotherImage max 1mb");
                    return View();
                }
            }
            plant.PlantImages = new List<PlantImage>();
            PlantImage plantImage = new PlantImage
            {
                ImagePath = await plant.MainImage.FileCreate(env.WebRootPath, @"assets\images\website-images"),
                IsMain = true,
                Plants = plant
            };
            plant.PlantImages.Add(plantImage);
            foreach (var item in plant.AnotherImage)
            {
                PlantImage image = new PlantImage
                {
                    ImagePath = await plant.MainImage.FileCreate(env.WebRootPath, @"assets\images\website-images"),
                    IsMain = false,
                    Plants = plant
                };
                plant.PlantImages.Add(image);
            };
            await context.Plants.AddAsync(plant);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Sizes = await context.Sizes.ToArrayAsync();
            ViewBag.Colors = await context.Colors.ToArrayAsync();
            Plant plant = await context.Plants.Include(p => p.PlantImages).FirstOrDefaultAsync(p => p.Id == id);
            if (plant == null) return NotFound();
            return View(plant);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int id, Plant plant)
        {

            ViewBag.Sizes = await context.Sizes.ToArrayAsync();
            ViewBag.Colors = await context.Colors.ToArrayAsync();
            Plant exsist = await context.Plants.Include(p => p.PlantImages).FirstOrDefaultAsync(p => p.Id == id);
            if (exsist == null) return View();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Ditail(int id)
        {
            ViewBag.Sizes = await context.Sizes.ToArrayAsync();
            ViewBag.Colors = await context.Colors.ToArrayAsync();
            Plant plant = await context.Plants.FirstOrDefaultAsync(d => d.Id == id);
            if (plant == null) return NotFound();
            return View(plant);
        }
    }
}
