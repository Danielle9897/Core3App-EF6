using System.Collections.Generic;

namespace Core3App_EF6.Model
{
    public class Category
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ISet<Post> Posts { get; set; }
    }
}