using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppKundeProdukt.Data;
using WebAppKundeProdukt.Models;

namespace WebAppKundeProdukt.Controllers
{
    public class WarenkorbpositionenController : Controller
    {
        private readonly WebAppKundeProduktContext _context;

        public WarenkorbpositionenController(WebAppKundeProduktContext context)
        {
            _context = context;
        }

        // GET: Warenkorbpositionen
        public async Task<IActionResult> Index()
        {
            var webAppKundeProduktContext = _context.Warenkorbposition.Include(w => w.Kunde).Include(w => w.Produkt);
            return View(await webAppKundeProduktContext.ToListAsync());
        }

        // GET: Warenkorbpositionen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warenkorbposition = await _context.Warenkorbposition
                .Include(w => w.Kunde)
                .Include(w => w.Produkt)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warenkorbposition == null)
            {
                return NotFound();
            }

            return View(warenkorbposition);
        }

        // GET: Warenkorbpositionen/Create
        public IActionResult Create()
        {
            ViewData["KundeId"] = new SelectList(_context.Kunde, "Id", "Nachname");
            ViewData["ProduktId"] = new SelectList(_context.Produkt, "Id", "Beschreibung");
            return View();
        }

        // POST: Warenkorbpositionen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KundeId,ProduktId,Menge")] Warenkorbposition warenkorbposition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(warenkorbposition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KundeId"] = new SelectList(_context.Kunde, "Id", "Nachname", warenkorbposition.KundeId);
            ViewData["ProduktId"] = new SelectList(_context.Produkt, "Id", "Beschreibung", warenkorbposition.ProduktId);
            return View(warenkorbposition);
        }

        // GET: Warenkorbpositionen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warenkorbposition = await _context.Warenkorbposition.FindAsync(id);
            if (warenkorbposition == null)
            {
                return NotFound();
            }
            ViewData["KundeId"] = new SelectList(_context.Kunde, "Id", "Nachname", warenkorbposition.KundeId);
            ViewData["ProduktId"] = new SelectList(_context.Produkt, "Id", "Beschreibung", warenkorbposition.ProduktId);
            return View(warenkorbposition);
        }

        // POST: Warenkorbpositionen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KundeId,ProduktId,Menge")] Warenkorbposition warenkorbposition)
        {
            if (id != warenkorbposition.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warenkorbposition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarenkorbpositionExists(warenkorbposition.Id))
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
            ViewData["KundeId"] = new SelectList(_context.Kunde, "Id", "Nachname", warenkorbposition.KundeId);
            ViewData["ProduktId"] = new SelectList(_context.Produkt, "Id", "Beschreibung", warenkorbposition.ProduktId);
            return View(warenkorbposition);
        }

        // GET: Warenkorbpositionen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warenkorbposition = await _context.Warenkorbposition
                .Include(w => w.Kunde)
                .Include(w => w.Produkt)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warenkorbposition == null)
            {
                return NotFound();
            }

            return View(warenkorbposition);
        }

        // POST: Warenkorbpositionen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var warenkorbposition = await _context.Warenkorbposition.FindAsync(id);
            if (warenkorbposition != null)
            {
                _context.Warenkorbposition.Remove(warenkorbposition);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarenkorbpositionExists(int id)
        {
            return _context.Warenkorbposition.Any(e => e.Id == id);
        }
    }
}
