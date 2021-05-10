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
    public class StaffController : Controller
    {
        private readonly Context _context;

        public StaffController()
        {
            _context = _context == null ? new Context() : _context;
        }

        // GET: Staff
        public async Task<IActionResult> List()
        {
            return View(await _context.Staffs.ToListAsync());
        }

        // GET: Staff/AddOrEdit
        // GET: Staff/AddOrEdit/5
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return base.View(new Models.Staff());
            }
            else
            {
                var staff = await _context.Staffs.FindAsync(id);
                if (staff == null)
                {
                    return NotFound();
                }
                return View(staff);
            }
        }

        // POST: Staff/AddOrEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("ID,Name,Date_Of_Birth,Gender,Start_Date,Password,ID_Position")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    staff.ID_Position = 2;
                    staff.Start_Date = DateTime.Now;
                    staff.Password = staff.Date_Of_Birth.ToString("ddMMyyyy");
                    _context.Add(staff);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(staff);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!StaffExists(staff.ID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Staffs.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewString(this, "AddOrEdit", staff) });
        }

        // POST: Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staff = await _context.Staffs.FindAsync(id);
            _context.Staffs.Remove(staff);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Staffs.ToList()) });
        }

        private bool StaffExists(int id)
        {
            return _context.Staffs.Any(e => e.ID == id);
        }
    }
}
