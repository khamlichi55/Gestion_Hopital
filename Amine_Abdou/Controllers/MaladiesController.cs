using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Amine_Abdou.Data;
using Amine_Abdou.Models;
using Microsoft.AspNetCore.Authorization;

namespace Amine_Abdou.Controllers
{
    [Authorize]
    public class MaladiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaladiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Maladies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Maladies.ToListAsync());
        }
        public async Task<IActionResult> Search(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return View("Index", await _context.Maladies.ToListAsync());
            }

            var result = await _context.Maladies
                .Where(m => m.Nom.Contains(searchTerm) || m.Description.Contains(searchTerm))
                .ToListAsync();

            return View("Index", result);
        }

        // GET: Maladies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maladie = await _context.Maladies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (maladie == null)
            {
                return NotFound();
            }

            return View(maladie);
        }

        // GET: Maladies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Maladies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nom,Description")] Maladie maladie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maladie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maladie);
        }

        // GET: Maladies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maladie = await _context.Maladies.FindAsync(id);
            if (maladie == null)
            {
                return NotFound();
            }
            return View(maladie);
        }

        // POST: Maladies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nom,Description")] Maladie maladie)
        {
            if (id != maladie.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maladie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaladieExists(maladie.ID))
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
            return View(maladie);
        }

        // GET: Maladies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maladie = await _context.Maladies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (maladie == null)
            {
                return NotFound();
            }

            return View(maladie);
        }

        // POST: Maladies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maladie = await _context.Maladies.FindAsync(id);
            if (maladie != null)
            {
                _context.Maladies.Remove(maladie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaladieExists(int id)
        {
            return _context.Maladies.Any(e => e.ID == id);
        }
    }
}
