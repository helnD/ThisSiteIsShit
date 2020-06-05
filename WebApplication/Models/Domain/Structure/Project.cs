using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Project: ICanComment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Comment> Comments { get; set; }
    }
}