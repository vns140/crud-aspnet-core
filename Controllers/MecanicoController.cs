using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using estudo.Models;
using Microsoft.EntityFrameworkCore;

namespace estudo.Controllers
{
    public class MecanicoController : Controller
    {
        private readonly Context _context;

        public MecanicoController(Context context)
        {
            _context = context;
        }

        // GET: Livros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mecanicos.ToListAsync());
        }

        // GET: Livros/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Mecanicos
                .SingleOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RazaoSocial,CNPJ,Responsavel,CPF,DDDTelefone,Telefone,DDDCelular,Celular,Endereco,Numero,CEP,Cidade,Estado,Latitude,Longitude")] Mecanico mecanico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mecanico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mecanico);
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Mecanicos.SingleOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro);
        }

        // POST: Livros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,RazaoSocial,CNPJ,Responsavel,CPF,DDDTelefone,Telefone,DDDCelular,Celular,Endereco,Numero,CEP,Cidade,Estado,Latitude,Longitude")] Mecanico mecanico)
        {
            if (id != mecanico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mecanico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(mecanico.Id))
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
            return View(mecanico);
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Mecanicos
                .SingleOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var livro = await _context.Mecanicos.SingleOrDefaultAsync(m => m.Id == id);
            _context.Mecanicos.Remove(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(Guid id)
        {
            return _context.Mecanicos.Any(e => e.Id == id);
        }
    }
}
