using Microsoft.AspNetCore.Http;

namespace DemoCore.Models
{
    public class AddProfileImages
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public bool WriterStatus { get; set; }
        public string WriterEmail { get; set; }
        public string WriterPassword { get; set; }
        
    }
}
