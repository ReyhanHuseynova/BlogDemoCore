using DemoCore.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DemoCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriter = JsonConvert.SerializeObject(writers);
            return Json(jsonWriter);
        }
        public IActionResult WriterById(int writerId)
        {
            var findId=writers.FirstOrDefault(x=>x.Id==writerId);
            var writerJson = JsonConvert.SerializeObject(findId);
            return Json(writerJson);
        }
        [HttpPost]
        public IActionResult WriterAdd(WriterClass w)
        {
            writers.Add(w);
            var writerJson= JsonConvert.SerializeObject(w);
            return Json(writerJson);
        }
       
        public IActionResult Delete(int id)
        {
            var writer=writers.FirstOrDefault(x=>x.Id==id);
            writers.Remove(writer);
            return Json(writer);
        }

        public List<WriterClass> writers= new List<WriterClass>
        {
            new WriterClass
            {
                Id= 1,
                Name="Ayse"
            },
            new WriterClass { 
                Id= 2,
                Name="Seda"
            },
            new WriterClass
            {
                Id= 3,
                Name="Sema"
            }
        };
    }
}
