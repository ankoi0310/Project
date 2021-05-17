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
    public class StudentController : Controller
    {
        private readonly Context _context;

        public StudentController()
        {
            _context = _context == null ? new Context() : _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: Student
        public async Task<IActionResult> List()
        {
            return View(await _context.Students.ToListAsync());
        }

        // GET: Student/AddOrEdit
        // GET: Student/AddOrEdit/5
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(string id = "0")
        {
            if (id.Equals("0"))
            {
                return base.View(new Student() { ID = id });
            }
            else
            {
                var student = await _context.Students.FindAsync(id);
                if (student == null)
                {
                    return NotFound();
                }
                return View(student);
            }
        }

        // POST: Student/AddOrEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(string id, [Bind("ID,Name,Date_Of_Birth,Gender,Password,ID_Class_Room,ID_Position")] Student student)
        {
            if (ModelState.IsValid)
            {
                if (id.Equals("0"))
                {
                    student.ID = Tools.GetNextStudentID();
                    student.ID_Position = 1;
                    student.Password = student.Date_Of_Birth.ToString("ddMMyyyy");
                    _context.Add(student);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(student);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!StudentExists(student.ID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Students.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewString(this, "AddOrEdit", student) });
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var Student = await _context.Students.FindAsync(id);
            _context.Students.Remove(Student);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Students.ToList()) });
        }

        private bool StudentExists(string id)
        {
            return _context.Students.Any(e => e.ID == id);
        }
    }
}
