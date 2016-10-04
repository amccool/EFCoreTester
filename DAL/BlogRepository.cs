using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlogRepository : IBlogRepository
    {
        public void AddBlog(Uri url)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetBlogPosts()
        {
            throw new NotImplementedException();
        }
    }
}
