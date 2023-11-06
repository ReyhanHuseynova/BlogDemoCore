using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.Controllers
{
    public class Message2Controller : Controller
    {
        Message2Manager mm= new Message2Manager(new EFMessage2Repository());
        public IActionResult InBox()
        {
            int id = 2;
            var values= mm.GetInboxListByWriter(id);
            return View(values);
        }

        public IActionResult Message2Detail(int id)
        {
            var values= mm.TGetById(id);
            return View(values);
        }
    }
}
