using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NissanPractice.Models;

namespace NissanPractice.Controllers
{
    public class ItemsPurchasedsController : Controller
    {
        private readonly NissanPracticeContext _context;

        public ItemsPurchasedsController(NissanPracticeContext context)
        {
            _context = context;
        }

        // GET: ItemsPurchaseds
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemsPurchased.ToListAsync());
        }

        // GET: ItemsPurchaseds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsPurchased = await _context.ItemsPurchased
                .SingleOrDefaultAsync(m => m.Id == id);
            if (itemsPurchased == null)
            {
                return NotFound();
            }

            return View(itemsPurchased);
        }

        // GET: ItemsPurchaseds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemsPurchaseds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Item1,Item2,Item3,Item4,Item5,Item6,Item7,Item8,Item9,Item10,Item11,Item12,Item13,Item14,Item15,Item16,Item17,Item18,Item19,Item20")] ItemsPurchased itemsPurchased)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemsPurchased);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemsPurchased);
        }

        // GET: ItemsPurchaseds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsPurchased = await _context.ItemsPurchased.SingleOrDefaultAsync(m => m.Id == id);
            if (itemsPurchased == null)
            {
                return NotFound();
            }
            return View(itemsPurchased);
        }

        // POST: ItemsPurchaseds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Item1,Item2,Item3,Item4,Item5,Item6,Item7,Item8,Item9,Item10,Item11,Item12,Item13,Item14,Item15,Item16,Item17,Item18,Item19,Item20")] ItemsPurchased itemsPurchased)
        {
            if (id != itemsPurchased.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemsPurchased);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemsPurchasedExists(itemsPurchased.Id))
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
            return View(itemsPurchased);
        }

        // GET: ItemsPurchaseds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsPurchased = await _context.ItemsPurchased
                .SingleOrDefaultAsync(m => m.Id == id);
            if (itemsPurchased == null)
            {
                return NotFound();
            }

            return View(itemsPurchased);
        }

        // POST: ItemsPurchaseds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemsPurchased = await _context.ItemsPurchased.SingleOrDefaultAsync(m => m.Id == id);
            _context.ItemsPurchased.Remove(itemsPurchased);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemsPurchasedExists(int id)
        {
            return _context.ItemsPurchased.Any(e => e.Id == id);
        }
    }
}
