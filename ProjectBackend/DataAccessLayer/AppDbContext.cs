using Microsoft.EntityFrameworkCore;
using ProjectBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Welcome> Welcomes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherDetail> TeacherDetails { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogDetails { get; set; }
        public DbSet<BlogsCategory> BlogsCategories { get; set; }
        public DbSet<BlogsPost> BlogsPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<CoursesCategory> CoursesCategories { get; set; }
        public DbSet<CoursesPost> CoursesPosts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<EventsCategory> EventsCategories { get; set; }
        public DbSet<EventsPost> EventsPosts { get; set; }
        public DbSet<EventsSpiker> EventsSpikers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Spiker> Spikers { get; set; }
        public DbSet<TeachersSkill> TeacherSkills { get; set; }
        public DbSet<NoticeVideo> NoticeVideos { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
    }
    
}
