using DevOpsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        List<PostViewModel> IPostRepository.GetPosts()
        {
            return new List<PostViewModel>()
            {
                new PostViewModel()
                {
                     Title = "Title1",
                     Author = "Author1",
                     Description = "Description1",
                     PostId = 1
                },
                new PostViewModel()
                {
                     Title = "Title2",
                     Author = "Author2",
                     Description = "Description2",
                     PostId = 2,
                }
            };
        }
    }
}
