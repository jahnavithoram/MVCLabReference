using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class tempController : Controller
    {
        private readonly DataLayer.AppContext _context;

        public tempController(DataLayer.AppContext context)
        {
            _context = context;
        }

        // GET: temp
        public async Task<IActionResult> Index()
        {
            return View(await _context.LqStudentModel.ToListAsync());
        }

        // GET: temp/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lqStudentModel = await _context.LqStudentModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lqStudentModel == null)
            {
                return NotFound();
            }

            return View(lqStudentModel);
        }

        // GET: temp/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: temp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,RollNo,Class,Sec,EnglishM,MathsM,ScienceM,ID")] LqStudentModel lqStudentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lqStudentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lqStudentModel);
        }

        // GET: temp/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lqStudentModel = await _context.LqStudentModel.FindAsync(id);
            if (lqStudentModel == null)
            {
                return NotFound();
            }
            return View(lqStudentModel);
        }

        // POST: temp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Name,RollNo,Class,Sec,EnglishM,MathsM,ScienceM,ID")] LqStudentModel lqStudentModel)
        {
            if (id != lqStudentModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lqStudentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LqStudentModelExists(lqStudentModel.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lqStudentModel);
        }

        // GET: temp/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lqStudentModel = await _context.LqStudentModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lqStudentModel == null)
            {
                return NotFound();
            }

            return View(lqStudentModel);
        }

        // POST: temp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lqStudentModel = await _context.LqStudentModel.FindAsync(id);
            _context.LqStudentModel.Remove(lqStudentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LqStudentModelExists(string id)
        {
            return _context.LqStudentModel.Any(e => e.ID == id);
        }
    }
}
