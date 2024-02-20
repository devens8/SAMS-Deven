using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SAMS.Data;
using SAMS.Models;

namespace SAMS.Controllers
{
    public class TeacherInfoModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherInfoModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TeacherInfoModels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.teacherInfoModels.Include(t => t.Room);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TeacherInfoModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherInfoModel = await _context.teacherInfoModels
                .Include(t => t.Room)
                .FirstOrDefaultAsync(m => m.TeacherID == id);
            if (teacherInfoModel == null)
            {
                return NotFound();
            }

            return View(teacherInfoModel);
        }

        // GET: TeacherInfoModels/Create
        public IActionResult Create()
        {
            ViewData["RoomAssigned"] = new SelectList(_context.roomLocationInfoModels, "RoomId", "RoomId");
            return View();
        }

        // POST: TeacherInfoModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherID,TeacherFirstNameMod,TeacherMiddleNameMod,TeacherLastNameMod,TeacherPreferredNameMod,TeacherEmailMod,TeacherPhoneMod,Teaches5Days,RoomAssigned")] TeacherInfoModel teacherInfoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacherInfoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomAssigned"] = new SelectList(_context.roomLocationInfoModels, "RoomId", "RoomId", teacherInfoModel.RoomAssigned);
            return View(teacherInfoModel);
        }

        // GET: TeacherInfoModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherInfoModel = await _context.teacherInfoModels.FindAsync(id);
            if (teacherInfoModel == null)
            {
                return NotFound();
            }
            ViewData["RoomAssigned"] = new SelectList(_context.roomLocationInfoModels, "RoomId", "RoomId", teacherInfoModel.RoomAssigned);
            return View(teacherInfoModel);
        }

        // POST: TeacherInfoModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TeacherID,TeacherFirstNameMod,TeacherMiddleNameMod,TeacherLastNameMod,TeacherPreferredNameMod,TeacherEmailMod,TeacherPhoneMod,Teaches5Days,RoomAssigned")] TeacherInfoModel teacherInfoModel)
        {
            if (id != teacherInfoModel.TeacherID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacherInfoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherInfoModelExists(teacherInfoModel.TeacherID))
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
            ViewData["RoomAssigned"] = new SelectList(_context.roomLocationInfoModels, "RoomId", "RoomId", teacherInfoModel.RoomAssigned);
            return View(teacherInfoModel);
        }

        // GET: TeacherInfoModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherInfoModel = await _context.teacherInfoModels
                .Include(t => t.Room)
                .FirstOrDefaultAsync(m => m.TeacherID == id);
            if (teacherInfoModel == null)
            {
                return NotFound();
            }

            return View(teacherInfoModel);
        }

        // POST: TeacherInfoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var teacherInfoModel = await _context.teacherInfoModels.FindAsync(id);
            if (teacherInfoModel != null)
            {
                _context.teacherInfoModels.Remove(teacherInfoModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherInfoModelExists(string id)
        {
            return _context.teacherInfoModels.Any(e => e.TeacherID == id);
        }
    }
}
