using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlfaSoftware.Data;
using AlfaSoftware.Models;

namespace AlfaSoftware.Controllers
{
    public class ClientePFModelsController : Controller
    {
        private readonly AlfaSoftwareContext _context;

        public ClientePFModelsController(AlfaSoftwareContext context)
        {
            _context = context;
        }

        // GET: ClientePFModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClientePFModels.ToListAsync());
        }

        // GET: ClientePFModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientePFModels = await _context.ClientePFModels
                .FirstOrDefaultAsync(m => m.clientepjId == id);
            if (clientePFModels == null)
            {
                return NotFound();
            }

            return View(clientePFModels);
        }

        // GET: ClientePFModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientePFModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Date,Cpf,Email,Profissao,clientepjId,Cnpj,NomeEmpresa")] ClientePFModels clientePFModels)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientePFModels);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientePFModels);
        }

        // GET: ClientePFModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientePFModels = await _context.ClientePFModels.FindAsync(id);
            if (clientePFModels == null)
            {
                return NotFound();
            }
            return View(clientePFModels);
        }

        // POST: ClientePFModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Date,Cpf,Email,Profissao,clientepjId,Cnpj,NomeEmpresa")] ClientePFModels clientePFModels)
        {
            if (id != clientePFModels.clientepjId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientePFModels);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientePFModelsExists(clientePFModels.clientepjId))
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
            return View(clientePFModels);
        }

        // GET: ClientePFModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientePFModels = await _context.ClientePFModels
                .FirstOrDefaultAsync(m => m.clientepjId == id);
            if (clientePFModels == null)
            {
                return NotFound();
            }

            return View(clientePFModels);
        }

        // POST: ClientePFModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientePFModels = await _context.ClientePFModels.FindAsync(id);
            _context.ClientePFModels.Remove(clientePFModels);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientePFModelsExists(int id)
        {
            return _context.ClientePFModels.Any(e => e.clientepjId == id);
        }
    }
}
