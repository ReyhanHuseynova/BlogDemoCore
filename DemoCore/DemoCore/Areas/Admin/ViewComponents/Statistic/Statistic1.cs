using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace DemoCore.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Blogs.Count();
            ViewBag.v2 = c.Contact.Count();
            ViewBag.v3 = c.Comments.Count();
       
            return View();
        }
    }
}
