using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Controllers
{
    public class CompetitionController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CompetitionController(IWebHostEnvironment webHostEnvironment)
        {
            _context = _context == null ? new Context() : _context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Competitions.ToListAsync());
        }

        public async Task<IActionResult> Detail(int id)
        {
            var competition = await _context.Competitions.FindAsync(id);
            if (competition == null)
            {
                return NotFound();
            }
            return View(competition);
        }

        // GET: Competition
        public async Task<IActionResult> List()
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
                return View(new Competition());
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
        public async Task<IActionResult> AddOrEdit(int id, [Bind("ID,Topic,Description,Content,Date_Start,Date_End,ImageFile,Status")] Competition competition)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    
                        string wwwRootPath = _webHostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(competition.ImageFile.FileName);
                        string extension = Path.GetExtension(competition.ImageFile.FileName);
                        competition.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwRootPath + "/images", fileName);
                        using (var fs = new FileStream(path, FileMode.Create))
                        {
                            await competition.ImageFile.CopyToAsync(fs);
                        }

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