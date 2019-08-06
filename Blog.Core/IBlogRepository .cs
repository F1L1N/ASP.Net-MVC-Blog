using Blog.Core.Objects;
using System.Collections.Generic;

namespace Blog.Core
{
    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNo, int pageSize);
        int TotalPosts();
    }
}