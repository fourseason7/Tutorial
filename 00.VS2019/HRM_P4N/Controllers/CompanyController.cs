using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HRM_P4N.Models;

namespace HRM_P4N.Controllers
{
    public class CompanyController : Controller
    {
        private readonly P4N_HRM_DEVContext _context;

        public CompanyController(P4N_HRM_DEVContext context)
        {
            _context = context;
        }

        // GET: Company
        public async Task<IActionResult> Index()
        {
            var p4N_HRM_DEVContext = _context.Companies.Include(c => c.CompanyType).Include(c => c.PayPeriodType);
            return View(await p4N_HRM_DEVContext.ToListAsync());
        }

        // GET: Company/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .Include(c => c.CompanyType)
                .Include(c => c.PayPeriodType)
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: Company/Create
        public IActionResult Create()
        {
            ViewData["CompanyTypeId"] = new SelectList(_context.RefCompanyTypes, "CompanyTypeId", "Code");
            ViewData["PayPeriodTypeId"] = new SelectList(_context.RefPayPeriodTypes, "PayPeriodTypeId", "Code");
            return View();
        }

        // POST: Company/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,Name,Code,CompanyTypeId,PayPeriodTypeId,RegisterDate,TerminateDate,ActiveFlag,HostName,Created,CreatedBy,Modified,ModifiedBy")] Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyTypeId"] = new SelectList(_context.RefCompanyTypes, "CompanyTypeId", "Code", company.CompanyTypeId);
            ViewData["PayPeriodTypeId"] = new SelectList(_context.RefPayPeriodTypes, "PayPeriodTypeId", "Code", company.PayPeriodTypeId);
            return View(company);
        }

        // GET: Company/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            ViewData["CompanyTypeId"] = new SelectList(_context.RefCompanyTypes, "CompanyTypeId", "Code", company.CompanyTypeId);
            ViewData["PayPeriodTypeId"] = new SelectList(_context.RefPayPeriodTypes, "PayPeriodTypeId", "Code", company.PayPeriodTypeId);
            return View(company);
        }

        // POST: Company/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyId,Name,Code,CompanyTypeId,PayPeriodTypeId,RegisterDate,TerminateDate,ActiveFlag,HostName,Created,CreatedBy,Modified,ModifiedBy")] Company company)
        {
            if (id != company.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.CompanyId))
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
            ViewData["CompanyTypeId"] = new SelectList(_context.RefCompanyTypes, "CompanyTypeId", "Code", company.CompanyTypeId);
            ViewData["PayPeriodTypeId"] = new SelectList(_context.RefPayPeriodTypes, "PayPeriodTypeId", "Code", company.PayPeriodTypeId);
            return View(company);
        }

        // GET: Company/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .Include(c => c.CompanyType)
                .Include(c => c.PayPeriodType)
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var company = await _context.Companies.FindAsync(id);
            var company = await _context.Companies.Include("CompanyPaySeqs").Where(p => p.CompanyId == id).FirstOrDefaultAsync();
            var companyPaySeqs = company.CompanyPaySeqs.ToList();

            foreach (var companyPaySeq in companyPaySeqs)
            {
                _context.CompanyPaySeqs.Remove(companyPaySeq);
            }

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.CompanyId == id);
        }
    }
}
