using cbsStudents.Models.Entities;
using CbsStudents.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace cbsStudents.Controllers
{
    public class EventsController : Controller
    {
        private CbsStudentsContext _context;

        public EventsController(CbsStudentsContext context)
        {
            this._context = context;
        }

        // Get Index & All Events
        public IActionResult Index()
        {
            var events = from e in _context.Events select e;

            var vm = new EventIndexVm
            {
                Events = events.ToList()
            };

            return View(vm);
        }

        // Get Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title", "StartDate", "EndDate", "StartTime", "EndTime", "Description")] Event oneEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(oneEvent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
            
        }


    }
}
