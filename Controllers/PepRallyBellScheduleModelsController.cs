using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SAMS_Deven.Data;
using SAMS_Deven.Models;

namespace SAMS_Deven.Controllers
{
    public class PepRallyBellScheduleModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PepRallyBellScheduleModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PepRallyBellScheduleModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.pepRallyBellScheduleModels.ToListAsync());
        }

        // GET: PepRallyBellScheduleModels/Details/5
        public async Task<IActionResult> Details(TimeSpan? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pepRallyBellScheduleModel = await _context.pepRallyBellScheduleModels
                .FirstOrDefaultAsync(m => m.StartTime == id);
            if (pepRallyBellScheduleModel == null)
            {
                return NotFound();
            }

            return View(pepRallyBellScheduleModel);
        }

        // GET: PepRallyBellScheduleModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PepRallyBellScheduleModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BellName,StartTime,EndTime,Duration")] PepRallyBellScheduleModel pepRallyBellScheduleModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pepRallyBellScheduleModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pepRallyBellScheduleModel);
        }

        // GET: PepRallyBellScheduleModels/Edit/5
        public async Task<IActionResult> Edit(TimeSpan? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pepRallyBellScheduleModel = await _context.pepRallyBellScheduleModels.FindAsync(id);
            if (pepRallyBellScheduleModel == null)
            {
                return NotFound();
            }
            return View(pepRallyBellScheduleModel);
        }

        // POST: PepRallyBellScheduleModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TimeSpan id, [Bind("BellName,StartTime,EndTime,Duration")] PepRallyBellScheduleModel pepRallyBellScheduleModel)
        {
            if (id != pepRallyBellScheduleModel.StartTime)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pepRallyBellScheduleModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PepRallyBellScheduleModelExists(pepRallyBellScheduleModel.StartTime))
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
            return View(pepRallyBellScheduleModel);
        }

        // GET: PepRallyBellScheduleModels/Delete/5
        public async Task<IActionResult> Delete(TimeSpan? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pepRallyBellScheduleModel = await _context.pepRallyBellScheduleModels
                .FirstOrDefaultAsync(m => m.StartTime == id);
            if (pepRallyBellScheduleModel == null)
            {
                return NotFound();
            }

            return View(pepRallyBellScheduleModel);
        }

        // POST: PepRallyBellScheduleModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(TimeSpan id)
        {
            var pepRallyBellScheduleModel = await _context.pepRallyBellScheduleModels.FindAsync(id);
            if (pepRallyBellScheduleModel != null)
            {
                _context.pepRallyBellScheduleModels.Remove(pepRallyBellScheduleModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PepRallyBellScheduleModelExists(TimeSpan id)
        {
            return _context.pepRallyBellScheduleModels.Any(e => e.StartTime == id);
        }
    }
}
