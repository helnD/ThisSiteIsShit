using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Solution: ICanComment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Project> Projects { get; set; }
        public List<Comment> Comments { get; set; }
    }
}