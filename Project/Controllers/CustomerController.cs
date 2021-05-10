using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class CustomerController : Controller
    {
        private readonly Context _context;

        public CustomerController()
        {
            _context = _context == null ? new Context() : _context;
        }

        // GET: Customer
        public async Task<IActionResult> List()
        {
            return View(await _context.Customers.ToListAsync());
        }

        // GET: Customer/AddOrEdit
        // GET: Customer/AddOrEdit/5
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return base.View(new Models.Customer());
            }
            else
            {
                var Customer = await _context.Customers.FindAsync(id);
                if (Customer == null)
                {
                    return NotFound();
                }
                return View(Customer);
            }
        }

        // POST: Customer/AddOrEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("ID,Name,Date_Of_Birth,Gender,Phone")] Customer Customer)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    _context.Add(Customer);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(Customer);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CustomerExists(Customer.ID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Customers.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewString(this, "AddOrEdit", Customer) });
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(Customer);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewString(this, "_ViewAll", _context.Customers.ToList()) });
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.ID == id);
        }
    }
}
