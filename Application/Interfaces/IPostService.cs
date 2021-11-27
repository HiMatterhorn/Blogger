using Application.DTO;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostDto> GetAllPosts();
        PostDto GetPostById(int id);

    }
}
