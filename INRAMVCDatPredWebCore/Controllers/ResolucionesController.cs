using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using INRAMVCDatPredWebCore.Data;
using INRAMVCDatPredWebCore.Models;

namespace INRAMVCDatPredWebCore.Controllers
{
    public class ResolucionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResolucionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Resoluciones
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Resoluciones.Include(r => r.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Resoluciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resolucion = await _context.Resoluciones
                .Include(r => r.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ResolcuionId == id);
            if (resolucion == null)
            {
                return NotFound();
            }

            return View(resolucion);
        }

        // GET: Resoluciones/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Resoluciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResolcuionId,IDCarpeta,AgrupacionSocial,Poligono,Expediente,ClaseResolucion,TipoResolucion,FechaRegistro,Id")] Resolucion resolucion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resolucion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", resolucion.Id);
            return View(resolucion);
        }

        // GET: Resoluciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resolucion = await _context.Resoluciones.FindAsync(id);
            if (resolucion == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", resolucion.Id);
            return View(resolucion);
        }

        // POST: Resoluciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResolcuionId,IDCarpeta,AgrupacionSocial,Poligono,Expediente,ClaseResolucion,TipoResolucion,FechaRegistro,Id")] Resolucion resolucion)
        {
            if (id != resolucion.ResolcuionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resolucion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResolucionExists(resolucion.ResolcuionId))
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
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", resolucion.Id);
            return View(resolucion);
        }

        // GET: Resoluciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resolucion = await _context.Resoluciones
                .Include(r => r.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ResolcuionId == id);
            if (resolucion == null)
            {
                return NotFound();
            }

            return View(resolucion);
        }

        // POST: Resoluciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resolucion = await _context.Resoluciones.FindAsync(id);
            _context.Resoluciones.Remove(resolucion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResolucionExists(int id)
        {
            return _context.Resoluciones.Any(e => e.ResolcuionId == id);
        }
    }
}
