using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DemoCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WidgetController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            ViewBag.v1 = c.Blogs.Count();
            ViewBag.v2 = c.Contact.Count();
            ViewBag.v3 = c.Comments.Count();
            ViewBag.Name=c.Blogs.OrderByDescending(x=>x.BlogID).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();   
            return View();
        }
    }
}
