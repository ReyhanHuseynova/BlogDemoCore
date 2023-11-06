using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DemoCore.ViewComponents.Writer
{
   
    public class WriterAboutDashboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
           
            var writerId= c.Writers.Where(x=>x.WriterEmail==usermail).Select(y=>y.WriterID).FirstOrDefault();    
            var values = wm.GetWriterById(writerId);
            return View(values);
        }
    }
}
