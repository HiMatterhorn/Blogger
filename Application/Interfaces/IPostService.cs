using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IPostService
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);

    }
}
