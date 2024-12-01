using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;

namespace Server.Services
{
    public class BlogPostService
    {
        public BlogPostService(AmiensusDb context)
        {
            _context = context;
        }

        private AmiensusDb _context { get; set; }

        public async Task<BlogPost> GetBlogPostById(int Id)
        {
            var blogPost = await _context.BlogPosts.FindAsync(Id);
            return blogPost;
        }

        public async Task<List<BlogPost>> GetAllBlogPosts()
        {
            var blogPosts = await _context.BlogPosts.ToListAsync();
            return blogPosts;
        }

        public async Task AddBlogPost(BlogPost blogPost)
        {
            _context.BlogPosts.Add(blogPost);
            _context.SaveChanges();
        }

        public async Task DeleteBlogPost(int id)
        {
            var blogPost = await _context.BlogPosts.FindAsync(id);
            _context.BlogPosts.Remove(blogPost);
            _context.SaveChanges();
        }

        public async Task UpdateBlogPost(BlogPost blogPost)
        {
            _context.BlogPosts.Update(blogPost);
            _context.SaveChanges();
        }
        
        public async Task<List<BlogPost>> LastFourBlogPosts()
        {
            var blogPosts = await _context.BlogPosts.OrderByDescending(b => b.PublishDate).Take(4).ToListAsync();
            return blogPosts;
        }
    }
}
