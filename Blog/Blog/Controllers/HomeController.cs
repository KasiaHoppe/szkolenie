using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ViewResult Index()
        {
            var wpisy = _context.Wpisy.ToList();

            return View(wpisy);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Details(int id)
        {
            var wpis = _context.Wpisy.SingleOrDefault(c => c.Id == id);

            if (wpis == null)
                return HttpNotFound();

            return View(wpis);
        }

        //private IEnumerable<Wpis> GetWpis()
        //{
        //    return new List<Wpis>
        //    {
        //        new Wpis { Id = 1, Tytul = "Tytuł1", Autor = "BlueDahlia", Tresc = "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam nisl sem, fringilla id metus accumsan, facilisis aliquam urna. In venenatis, lacus sed elementum efficitur, enim eros molestie nulla, quis tincidunt leo ante nec est. Etiam vel pharetra mauris. Vivamus enim orci, porttitor id eleifend et, consectetur vitae justo. Proin velit leo, ornare vitae turpis ac, blandit feugiat eros. Curabitur hendrerit quam vitae felis dapibus, in sodales sapien eleifend. Duis ac sapien quis nulla consectetur varius non fringilla diam. Duis in leo eget metus pellentesque venenatis eu eu ante. Ut varius eu mauris maximus suscipit. Nulla imperdiet lacus ut tortor interdum, at molestie est sollicitudin.", DataDodania = DateTime.Now },
        //        new Wpis { Id = 2, Tytul = "Tytuł2", Autor = "BlueDahlia", Tresc = "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam nisl sem, fringilla id metus accumsan, facilisis aliquam urna. In venenatis, lacus sed elementum efficitur, enim eros molestie nulla, quis tincidunt leo ante nec est. Etiam vel pharetra mauris. Vivamus enim orci, porttitor id eleifend et, consectetur vitae justo. Proin velit leo, ornare vitae turpis ac, blandit feugiat eros. Curabitur hendrerit quam vitae felis dapibus, in sodales sapien eleifend. Duis ac sapien quis nulla consectetur varius non fringilla diam. Duis in leo eget metus pellentesque venenatis eu eu ante. Ut varius eu mauris maximus suscipit. Nulla imperdiet lacus ut tortor interdum, at molestie est sollicitudin.", DataDodania = DateTime.Now }
        //    };
        //}
        public ActionResult Kategorie()
        {
            return View();
        }
    }
}