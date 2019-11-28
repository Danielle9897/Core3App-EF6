using System;
using System.Linq;
using System.Windows.Forms;
using Core3App_EF6.Model;

namespace Core3App_EF6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EF6buttonAdd_Click(object sender, EventArgs e)
        {
            // todo : is this (tx) needed ??? scenarios in test suit don't use this but some do
            using var tx = new System.Transactions.TransactionScope(); 
            using var db = new Entities();
          
            var newBlog = new Blog()
            {
                Title = "from EF-6",
                CreatedAt = DateTime.Now,
                Subtitle = "SubFrom EF-6"
            };
            
            db.Blogs.Add(newBlog);
            db.SaveChanges();
            tx.Complete();
            
            var lastBlogId = newBlog.Id;
            Console.WriteLine($"Added Blog: Blog with id {lastBlogId} was added");
        }

        private void EF6buttonGetBlogsCount_Click(object sender, EventArgs e)
        {
            using var tx = new System.Transactions.TransactionScope();
            using var db = new Entities();
            
            var query = db.Blogs.Select(x => x).ToList();
            
            Console.WriteLine("Blogs count = " + query.Count);
            tx.Complete();
        }

        private void EF6QueryButton_Click(object sender, EventArgs e)
        {
            using var tx = new System.Transactions.TransactionScope();
            using var db = new Entities();
            
            var query = from blog in db.Blogs
                    where blog.Title.Contains("EF")
                    select new { blog.Title };

            var results = query.ToArray();
            foreach (var blog in results)
            {
                Console.WriteLine($"Blog: *** Blog Id={blog.Title}");
            }
            tx.Complete();
        }
    }
}