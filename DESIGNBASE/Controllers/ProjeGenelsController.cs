using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DESIGNBASE.Contexts;
using DESIGNBASE.Entities;

namespace DESIGNBASE.Controllers
{
    public class ProjeGenelsController : Controller
    {
        private readonly DesignBaseContext _context;

        public ProjeGenelsController(DesignBaseContext context)
        {
            _context = context;
        }

        // GET: ProjeGenels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjeGenel.ToListAsync());
        }

        // GET: ProjeGenels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projeGenel = await _context.ProjeGenel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (projeGenel == null)
            {
                return NotFound();
            }

            return View(projeGenel);
        }

        // GET: ProjeGenels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjeGenels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TASARIM_BELGESI_NO,TRAFO_TANIM_KODU,PN,PROJE_ADI,FREKANS,SOGUTMA_SEKLI,SOGUTMA_SEKLI1,SOGUTMA_SEKLI2,SOGUTMA_SEKLI3,SARGI_SAYISI,BAGLANTI_GRUBU,IMALAT_NORMU,DENGELEME_SARGISI,TETA_MUH,SARGI_SIC,YAG_SIC,CALISMA_YERI_SIC,CALISMA_YERI_YUK,MAX_KD_SURESI,SARIM_GERILIMI,TOPLAM_BAKIR_AGIRLIGI,SARGI_OLCULERI,ACIKALAMALAR,PROJE_NO,SIPARIS_NO,TASARIM_NO")] ProjeGenel projeGenel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projeGenel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projeGenel);
        }

        // GET: ProjeGenels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projeGenel = await _context.ProjeGenel.FindAsync(id);
            if (projeGenel == null)
            {
                return NotFound();
            }
            return View(projeGenel);
        }

        // POST: ProjeGenels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TASARIM_BELGESI_NO,TRAFO_TANIM_KODU,PN,PROJE_ADI,FREKANS,SOGUTMA_SEKLI,SOGUTMA_SEKLI1,SOGUTMA_SEKLI2,SOGUTMA_SEKLI3,SARGI_SAYISI,BAGLANTI_GRUBU,IMALAT_NORMU,DENGELEME_SARGISI,TETA_MUH,SARGI_SIC,YAG_SIC,CALISMA_YERI_SIC,CALISMA_YERI_YUK,MAX_KD_SURESI,SARIM_GERILIMI,TOPLAM_BAKIR_AGIRLIGI,SARGI_OLCULERI,ACIKALAMALAR,PROJE_NO,SIPARIS_NO,TASARIM_NO")] ProjeGenel projeGenel)
        {
            if (id != projeGenel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projeGenel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjeGenelExists(projeGenel.ID))
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
            return View(projeGenel);
        }

        // GET: ProjeGenels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projeGenel = await _context.ProjeGenel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (projeGenel == null)
            {
                return NotFound();
            }

            return View(projeGenel);
        }

        // POST: ProjeGenels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projeGenel = await _context.ProjeGenel.FindAsync(id);
            _context.ProjeGenel.Remove(projeGenel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjeGenelExists(int id)
        {
            return _context.ProjeGenel.Any(e => e.ID == id);
        }
    }
}
