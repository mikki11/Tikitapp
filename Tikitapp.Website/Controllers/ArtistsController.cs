using Microsoft.AspNetCore.Mvc;
using Tikitapp.Website.Data;

namespace Tikitapp.Website.Controllers
{
    public class ArtistsController: Controller
    {
        private readonly ILogger<ArtistsController> logger;
        private readonly TikitappDbContext db;

        public ArtistsController(ILogger<ArtistsController> logger, TikitappDbContext db) {
            this.logger = logger;
            this.db = db;
        }

        public IActionResult Index() {
            var artist = db.Artists.ToList();
            return View(artist);
        }

        public IActionResult View(Guid id) {
            var artist = db.Artists.Find(id);
            return View(artist);
        }

    }
}
