using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
        }

        public IEnumerable<PostDto> GetAllPosts()
        {
            var posts = _postRepository.GetAll();
            return posts.Select(post => new PostDto
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content
            });
        }

        public PostDto GetPostById(int id)
            {
                var post = _postRepository.GetById(id);
                return new PostDto()
                {
                    Id = post.Id,
                    Title = post.Title,
                    Content = post.Content
                };
            }
        }
    }
