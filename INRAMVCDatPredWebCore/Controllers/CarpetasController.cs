using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using INRAMVCDatPredWebCore.Data;
using INRAMVCDatPredWebCore.Models;
using Microsoft.AspNetCore.Identity;

namespace INRAMVCDatPredWebCore.Controllers
{
    public class CarpetasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly ApplicationDbContext _context;

        public CarpetasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Carpetass
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Carpetas.Include(us => us.ApplicationUser).Include(ub => ub.Ubicaciones).ToListAsync());
        //}

        // GET: Carpetass
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NombreSortParm"] = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewData["DescripcionSortParm"] = sortOrder == "descripcion_asc" ? "descripcion_desc" : "descripcion";
            ViewData["CurrentFilter"] = searchString;

            var carpetas = from c in _context.Carpetas select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                //carpetas = carpetas.Where(c => c.AgrupacionSocial.Equals(searchString) || c.IDCarpetas.Equals(searchString));
                var carpetasAux = carpetas.Where(c => c.IDCarpeta.Equals(searchString));
                if (!carpetasAux.Any())
                {
                    return RedirectToAction("Create");                    
                }     
                else
                {
                    return View(await carpetasAux.AsNoTracking().Include(us => us.ApplicationUser).Include(d => d.Departamento).Include(p => p.Provincia).Include(m => m.Municipio).Include(ub => ub.Ubicacion).ToListAsync());
                }
            }
            return View(await carpetas.AsNoTracking().Include(us => us.ApplicationUser).Include(d => d.Departamento).Include(p => p.Provincia).Include(m => m.Municipio).Include(ub => ub.Ubicacion).ToListAsync());

        }

        // GET: Carpetass/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carpeta = await _context.Carpetas
                .FirstOrDefaultAsync(m => m.CarpetaId == id);
            if (carpeta == null)
            {
                return NotFound();
            }

            return View(carpeta);
        }

        // GET: Carpetass/Create
        public IActionResult Create()
        {
            //ViewData["UsersId"] = new SelectList((from us in _context.Users.ToList()
            //                                      select new
            //                                      {
            //                                          ID_Usuario = us.Id,
            //                                          NombreCompleto = us.Nombres + " " + us.Apellidos
            //                                      }), "ID_Usuario", "NombreCompleto", null);
            ViewData["UsersId"] = new SelectList(_context.Users, "Id", "FullName", null);
            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "DepartamentoId", "Nombre");
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "UbicacionId", "Nombre");
            return View();
        }

        // POST: Carpetass/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarpetaId,IDCarpeta,AgrupacionSocial,Cuerpos,Fojas,Poligono,Id,DepartamentoId,ProvinciaId,MunicipioId,UbicacionId")] Carpeta carpeta)
        {
            var CarpetasAux = _context.Carpetas.Where(ca => ca.IDCarpeta == carpeta.IDCarpeta).FirstOrDefault();
            if (CarpetasAux == null)
            {
                if (ModelState.IsValid)
                {
                    carpeta.FechaRegistro = DateTime.Now;
                    _context.Add(carpeta);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //TempData["mensage"] = "El ID Carpetas" + CarpetasAux.IDCarpetas + " ya se encuentra tegistrado";
                    //this.AddMessageFixed(, "Un mensaje de prueba");
                    return RedirectToAction("Create");
                }
            }
            else
            {
                TempData["mensage"] = "El ID Carpetas" + CarpetasAux.IDCarpeta + " ya se encuentra tegistrado";
                //this.AddMessageFixed(, "Un mensaje de prueba");
                return RedirectToAction("Create");
            }            
            //return View(carpeta);
        }

        // GET: Carpetass/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {        
            if (id == null)
            {
                return NotFound();
            }

            var carpeta = await _context.Carpetas.FindAsync(id);

            ViewData["DepartamentoId"] = new SelectList(_context.Departamentos, "DepartamentoId", "Nombre");
            
            var fullNames = await _context.Users.ToListAsync();// Select(u => new { UserID = u.Id, FullName = u.Nombres + " " + u.Apellidos }).ToList();

            //var fullNames = await _context.Users.ToListAsync();

            //["Id"] = new SelectList(await _context.Users.ToListAsync(), "Id", "FullName");
            //ViewData["Id"] = new SelectList(_context.Users, "Id", "FullName");
            ViewData["Id"] = new SelectList(await _context.Users.ToListAsync().ConfigureAwait(false), "Id", "FullName");
            //ViewData["Id"] = _context.Users.Select(u => u.FullName).ToList();


            ViewData["ProvinciaId"] = new SelectList(_context.Provincias, "ProvinciaId", "Nombre");
            ViewData["MunicipioId"] = new SelectList(_context.Municipios, "MunicipioId", "Nombre");
            ViewData["UbicacionId"] = new SelectList(_context.Ubicaciones, "UbicacionId", "Nombre");

            //ViewData["Id"] = new SelectList(_context.Users, "Id", "FullName", resolucion.Id);
            //ViewData["UsersId"] = new SelectList(_context.Users.ToList(), "Id", "FullName", carpeta.Id);
            //ViewData["UsersId"] = new SelectList(_context.Users.ToList(), "Id", "FullName");
            

            if (carpeta == null)
            {
                return NotFound();
            }
            
            return View(carpeta);            
        }

        // POST: Carpetass/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarpetaId,IDCarpeta,AgrupacionSocial,Cuerpos,Fojas,Poligono,Id,DepartamentoId,ProvinciaId,MunicipioId,UbicacionId")] Carpeta carpeta)
        {
            if (id != carpeta.CarpetaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carpeta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarpetasExists(carpeta.CarpetaId))
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
            return View(carpeta);
        }

        // GET: Carpetass/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carpeta = await _context.Carpetas
                .FirstOrDefaultAsync(m => m.CarpetaId == id);
            if (carpeta == null)
            {
                return NotFound();
            }

            return View(carpeta);
        }

        // POST: Carpetass/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carpeta = await _context.Carpetas.FindAsync(id);
            _context.Carpetas.Remove(carpeta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarpetasExists(int id)
        {
            return _context.Carpetas.Any(e => e.CarpetaId == id);
        }

        //Obtener todos las provincias de un Departamentos
        public JsonResult getProvinciabyid(int id)
        {
            List<Provincia> list = new List<Provincia>();
            list = _context.Provincias.Where(De => De.Departamento.DepartamentoId == id).ToList();
            list.Insert(0, new Provincia { ProvinciaId = 0, Nombre = "Por favor Seleccione la Provincias" });
            return Json(new SelectList(list, "ProvinciaId", "Nombre"));
        }

        //Obtener todos los municipios de una Provincias
        public JsonResult getMunicipiobyid(int id)
        {
            List<Municipio> list = new List<Municipio>();
            list = _context.Municipios.Where(Pro => Pro.Provincia.ProvinciaId == id).ToList();
            list.Insert(0, new Municipio { MunicipioId = 0, Nombre = "Por favor Seleccione el Municipios" });
            return Json(new SelectList(list, "MunicipioId", "Nombre"));
        }
    }
}
