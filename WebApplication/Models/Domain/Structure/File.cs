using System.Collections.Generic;

namespace WebApplication.Models
{
    public class File : ICanComment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public List<Comment> Comments { get; set; }
    }
}