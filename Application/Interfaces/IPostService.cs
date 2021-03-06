using Application.Dto;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostDto> GetAllPosts();
        PostDto GetPostById(int id);

        PostDto AddNewPost(CreatePostDto newPost);

        void UpdatePost(UpdatePostDto updatePost);

        void DeletePost(int id);

    }
}
