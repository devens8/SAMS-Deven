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
    public class ExtendedAvesBellScheduleModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExtendedAvesBellScheduleModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExtendedAvesBellScheduleModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.extendedAvesModels.ToListAsync());
        }

        // GET: ExtendedAvesBellScheduleModels/Details/5
        public async Task<IActionResult> Details(TimeSpan? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extendedAvesBellScheduleModel = await _context.extendedAvesModels
                .FirstOrDefaultAsync(m => m.StartTime == id);
            if (extendedAvesBellScheduleModel == null)
            {
                return NotFound();
            }

            return View(extendedAvesBellScheduleModel);
        }

        // GET: ExtendedAvesBellScheduleModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExtendedAvesBellScheduleModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BellName,StartTime,EndTime,Duration")] ExtendedAvesBellScheduleModel extendedAvesBellScheduleModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(extendedAvesBellScheduleModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(extendedAvesBellScheduleModel);
        }

        // GET: ExtendedAvesBellScheduleModels/Edit/5
        public async Task<IActionResult> Edit(TimeSpan? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extendedAvesBellScheduleModel = await _context.extendedAvesModels.FindAsync(id);
            if (extendedAvesBellScheduleModel == null)
            {
                return NotFound();
            }
            return View(extendedAvesBellScheduleModel);
        }

        // POST: ExtendedAvesBellScheduleModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TimeSpan id, [Bind("BellName,StartTime,EndTime,Duration")] ExtendedAvesBellScheduleModel extendedAvesBellScheduleModel)
        {
            if (id != extendedAvesBellScheduleModel.StartTime)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(extendedAvesBellScheduleModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExtendedAvesBellScheduleModelExists(extendedAvesBellScheduleModel.StartTime))
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
            return View(extendedAvesBellScheduleModel);
        }

        // GET: ExtendedAvesBellScheduleModels/Delete/5
        public async Task<IActionResult> Delete(TimeSpan? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extendedAvesBellScheduleModel = await _context.extendedAvesModels
                .FirstOrDefaultAsync(m => m.StartTime == id);
            if (extendedAvesBellScheduleModel == null)
            {
                return NotFound();
            }

            return View(extendedAvesBellScheduleModel);
        }

        // POST: ExtendedAvesBellScheduleModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(TimeSpan id)
        {
            var extendedAvesBellScheduleModel = await _context.extendedAvesModels.FindAsync(id);
            if (extendedAvesBellScheduleModel != null)
            {
                _context.extendedAvesModels.Remove(extendedAvesBellScheduleModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExtendedAvesBellScheduleModelExists(TimeSpan id)
        {
            return _context.extendedAvesModels.Any(e => e.StartTime == id);
        }
    }
}
