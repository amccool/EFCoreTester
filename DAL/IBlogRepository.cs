using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IBlogRepository
    {
        void AddBlog(Uri url);

        IEnumerable<Post> GetBlogPosts();
    }
}
