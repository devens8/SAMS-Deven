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
    public class TwoHrDelayBellScheduleModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TwoHrDelayBellScheduleModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TwoHrDelayBellScheduleModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.twoHrDelayBellScheduleModels.ToListAsync());
        }

        // GET: TwoHrDelayBellScheduleModels/Details/5
        public async Task<IActionResult> Details(TimeSpan? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var twoHrDelayBellScheduleModel = await _context.twoHrDelayBellScheduleModels
                .FirstOrDefaultAsync(m => m.StartTime == id);
            if (twoHrDelayBellScheduleModel == null)
            {
                return NotFound();
            }

            return View(twoHrDelayBellScheduleModel);
        }

        // GET: TwoHrDelayBellScheduleModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TwoHrDelayBellScheduleModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BellName,StartTime,EndTime,Duration")] TwoHrDelayBellScheduleModel twoHrDelayBellScheduleModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(twoHrDelayBellScheduleModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(twoHrDelayBellScheduleModel);
        }

        // GET: TwoHrDelayBellScheduleModels/Edit/5
        public async Task<IActionResult> Edit(TimeSpan? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var twoHrDelayBellScheduleModel = await _context.twoHrDelayBellScheduleModels.FindAsync(id);
            if (twoHrDelayBellScheduleModel == null)
            {
                return NotFound();
            }
            return View(twoHrDelayBellScheduleModel);
        }

        // POST: TwoHrDelayBellScheduleModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TimeSpan id, [Bind("BellName,StartTime,EndTime,Duration")] TwoHrDelayBellScheduleModel twoHrDelayBellScheduleModel)
        {
            if (id != twoHrDelayBellScheduleModel.StartTime)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(twoHrDelayBellScheduleModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TwoHrDelayBellScheduleModelExists(twoHrDelayBellScheduleModel.StartTime))
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
            return View(twoHrDelayBellScheduleModel);
        }

        // GET: TwoHrDelayBellScheduleModels/Delete/5
        public async Task<IActionResult> Delete(TimeSpan? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var twoHrDelayBellScheduleModel = await _context.twoHrDelayBellScheduleModels
                .FirstOrDefaultAsync(m => m.StartTime == id);
            if (twoHrDelayBellScheduleModel == null)
            {
                return NotFound();
            }

            return View(twoHrDelayBellScheduleModel);
        }

        // POST: TwoHrDelayBellScheduleModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(TimeSpan id)
        {
            var twoHrDelayBellScheduleModel = await _context.twoHrDelayBellScheduleModels.FindAsync(id);
            if (twoHrDelayBellScheduleModel != null)
            {
                _context.twoHrDelayBellScheduleModels.Remove(twoHrDelayBellScheduleModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TwoHrDelayBellScheduleModelExists(TimeSpan id)
        {
            return _context.twoHrDelayBellScheduleModels.Any(e => e.StartTime == id);
        }
    }
}
