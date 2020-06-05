using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Folder: ICanComment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<File> Files { get; set; }
        public List<Folder> Folders { get; set; }
        public List<Comment> Comments { get; set; }
    }
}