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
    public class CompetitionController : Controller
    {
        private readonly Context _context;

        public CompetitionController()
        {
            _context = _context == null ? new Context() : _context;
        }

        // GET: Competition
        public async Task<IActionResult> Index()
        {
            return View(await _context.Competitions.ToListAsync());
        }

        // GET: Competition/AddOrEdit
        // GET: Competition/AddOrEdit/5
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return base.View(new Models.Competition());
            }
            else
            {
                var competition = await _context.Competitions.FindAsync(id);
                if (competition == null)
                {
                    return NotFound();
                }
                return View(competition);
            }
        }

        // POST: Competition/AddOrEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("ID,Topic,Short_Content,Content,Date_Start,Date_End,Status")] Models.Competition competition)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    _context.Add(competition);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(competition);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CompetitionExists(competition.ID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Competitions.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewString(this, "AddOrEdit", competition) });
        }

        // POST: Competition/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var competition = await _context.Competitions.FindAsync(id);
            _context.Competitions.Remove(competition);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Competitions.ToList()) });
        }

        private bool CompetitionExists(int id)
        {
            return _context.Competitions.Any(e => e.ID == id);
        }
    }
}
