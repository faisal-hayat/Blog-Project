using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
    public class BlogPost
    {
        public int Guid { get; set; }
        public string Heading { get; set; }
    }
}
