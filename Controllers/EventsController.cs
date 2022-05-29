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
        public IActionResult Index(string SearchString)
        {
            if (SearchString == null)
            {
                SearchString = "";
            }

            var events = from e in _context.Events select e;

            events = events.Where(x => x.Title.Contains(SearchString));

            var vm = new EventIndexVm
            {
                Events = events.ToList(),
                SearchString = SearchString
            };

            return View(vm);
        }

        // Get Create
        public IActionResult Create()
        {
            return View();
        }

        // Post Create
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

        // Get Edit 

        public IActionResult Edit (int id)
        {
            Event e = _context.Events.First(x => x.Id == id);

            return View(e);
        }

        // Post Edit
        [HttpPost]
        public IActionResult Edit([Bind("Id", "Title", "StartDate", "EndDate", "StartTime", "EndTime", "Description")] Event oneEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Update(oneEvent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // Get Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oneEvent = await _context.Events.FirstOrDefaultAsync(x => x.Id == id);
            if (oneEvent == null)
            {
                return NotFound();
            }

            return View(oneEvent);
        }

        // Post Delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oneEvent = await _context.Events.FindAsync(id);
            _context.Events.Remove(oneEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
