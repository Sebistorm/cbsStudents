using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cbsStudents.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CbsStudents.Data
{
    public class CbsStudentsContext : IdentityDbContext
    {
        public CbsStudentsContext(DbContextOptions<CbsStudentsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.UsersSeed(builder);
            this.SeedPosts(builder);
            this.SeedComments(builder);
            this.SeedEvents(builder);
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<cbsStudents.Models.Entities.Comment> Comment { get; set; }


        private void UsersSeed(ModelBuilder builder)
        {
            var user1 = new IdentityUser
            {
                Id = "1",
                Email = "chrk@kea.dk",
                EmailConfirmed = true,
                UserName = "chrk@kea.dk",
            };

            var user2 = new IdentityUser
            {
                Id = "2",
                Email = "test@kea.dk",
                EmailConfirmed = true,
                UserName = "test@kea.dk",
            };

            PasswordHasher<IdentityUser> passHash = new PasswordHasher<IdentityUser>();
            user1.PasswordHash = passHash.HashPassword(user1, "aA123456!");
            user2.PasswordHash = passHash.HashPassword(user2, "aA123456!");

            builder.Entity<IdentityUser>().HasData(
                user1, user2
            );
        }
        private void SeedPosts(ModelBuilder builder)
        {
            builder.Entity<Post>().HasData(
                new Post() { Id = 1, Created = DateTime.Now, Text = "This is post 1", Title = "Post no 1", Status = PostStatus.DRAFT },
                new Post() { Id = 2, Created = DateTime.Now, Text = "This is post 2", Title = "Post no 2", Status = PostStatus.DRAFT },
                new Post() { Id = 3, Created = DateTime.Now, Text = "This is post 3", Title = "Post no 3", Status = PostStatus.DRAFT }
            );
        }

        private void SeedComments(ModelBuilder builder)
        {
            builder.Entity<Comment>().HasData(
                new Comment() { CommentId = 1, Text = "Hello", TimeStamp = DateTime.Now, PostId = 1, UserId = "1" },
                new Comment() { CommentId = 2, Text = "Hello again", TimeStamp = DateTime.Now, PostId = 1, UserId = "2" },
                new Comment() { CommentId = 3, Text = "Hi", TimeStamp = DateTime.Now, PostId = 2, UserId = "1" },
                new Comment() { CommentId = 4, Text = "Bye", TimeStamp = DateTime.Now, PostId = 3, UserId = "1" }
            );
        }

        private void SeedEvents(ModelBuilder builder)
        {
            builder.Entity<Event>().HasData(
                new Event() { Id = 1, Title = "Pokemon Safari", Description = "Welcome to the Pokemon Safari", StartDate = DateTime.Now, StartTime = "15:30", EndDate = DateTime.Now, EndTime = "20:30"},
                new Event() { Id = 2, Title = "Champions League", Description = "Welcome to the Champions League Finale", StartDate = DateTime.Now, StartTime = "12:30", EndDate = DateTime.Now, EndTime = "18:30"},
                new Event() { Id = 3, Title = "GoKart", Description = "Welcome to GoKart. Ready Set GO!", StartDate = DateTime.Now, StartTime = "14:30", EndDate = DateTime.Now, EndTime = "19:30" }
            );
        }
    }
}