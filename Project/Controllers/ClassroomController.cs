using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Controllers
{
    public class ClassroomController : Controller
    {
        private readonly Context _context;

        public ClassroomController()
        {
            _context = _context == null ? new Context() : _context;
        }

        // GET: Classroom
        public async Task<IActionResult> Index()
        {
            return View(await _context.Classrooms.ToListAsync());
        }

        // GET: Classroom/AddOrEdit
        // GET: Classroom/AddOrEdit/5
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return base.View(new Models.Classroom());
            }
            else
            {
                var classroom = await _context.Classrooms.FindAsync(id);
                if (classroom == null)
                {
                    return NotFound();
                }
                return View(classroom);
            }
        }

        // POST: Classroom/AddOrEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("ID,Name,Admission_Date")] Classroom classroom)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    _context.Add(classroom);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(classroom);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!StaffExists(classroom.ID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Classrooms.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewString(this, "AddOrEdit", classroom) });
        }

        // POST: Classroom/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classroom = await _context.Classrooms.FindAsync(id);
            _context.Classrooms.Remove(classroom);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Classrooms.ToList()) });
        }

        private bool StaffExists(int id)
        {
            return _context.Classrooms.Any(e => e.ID == id);
        }
    }
}
