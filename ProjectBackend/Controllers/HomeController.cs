using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.DataAccessLayer;
using ProjectBackend.ViewModels;
using System.Threading.Tasks;

namespace ProjectBackend.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    
        public async Task<IActionResult> Index()
        {
            var slider = await _dbContext.Sliders.SingleOrDefaultAsync();
            var welcome = await _dbContext.Welcomes.SingleOrDefaultAsync();
            var noticeVideo = await _dbContext.NoticeVideos.SingleOrDefaultAsync();
            var noticeBoards = await _dbContext.NoticeBoards.ToListAsync();
            var courses = await _dbContext.Courses.ToListAsync();
            var events = await _dbContext.Events.ToListAsync();
            var categories = await _dbContext.Categories.ToListAsync();
            var courseDetails = await _dbContext.CourseDetails.ToListAsync();
            var eventDetails = await _dbContext.EventDetails.ToListAsync();

            return View(new HomeViewModel
            {
                Slider=slider,
                Welcome=welcome,
                NoticeVideo =noticeVideo,
                NoticeBoards = noticeBoards,
                Courses=courses,
                Events = events,
                Categories = categories,
                CourseDetails = courseDetails,
                EventDetails = eventDetails

            });
        }
    }
}
