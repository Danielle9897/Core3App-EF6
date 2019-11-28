using System.Data.Entity;

namespace Core3App_EF6.Model
{
    public class Entities : DbContext
    {
        const string myConStr = "server=.\\sqlexpress;database=efprof;trusted_connection=True;";
        private readonly string connectionString;

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }

        public Entities() : base(myConStr)
        {
            this.connectionString = myConStr;
        }
    }
}