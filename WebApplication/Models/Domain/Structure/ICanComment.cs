using System.Collections.Generic;

namespace WebApplication.Models
{
    public interface ICanComment
    {
        List<Comment> Comments { get; set; }
    }
}