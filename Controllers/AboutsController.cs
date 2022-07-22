using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using duaaOffer.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace duaaOffer.Controllers
{
    public class AboutsController : Controller
    {
        private readonly TestContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public AboutsController(TestContext context, IWebHostEnvironment _hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = _hostEnvironment;
        }

        // GET: Abouts
        public async Task<IActionResult> Index()
        {
            return View(await _context.About.ToListAsync());
        }
        public async Task<IActionResult> AboutUs()
        {
            return View(await _context.About.ToListAsync());
        }
        // GET: Abouts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var about = await _context.About
                .FirstOrDefaultAsync(m => m.Id == id);
            if (about == null)
            {
                return NotFound();
            }

            return View(about);
        }

        // GET: Abouts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Abouts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Image,Text,ImageFile")] About about)
        {
            if (ModelState.IsValid)
            {
                if (about.ImageFile != null)

                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" + about.ImageFile.FileName;
                    string extension = Path.GetExtension(about.ImageFile.FileName);
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await about.ImageFile.CopyToAsync(fileStream);
                    }
                    about.Image = fileName;
                    _context.Add(about);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {

                }
            }
            return View(about);
        }

    

    // GET: Abouts/Edit/5
    public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var about = await _context.About.FindAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }

        // POST: Abouts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Image,Text,ImageFile")] About about)
        {
            if (id != about.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (about.ImageFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Guid.NewGuid().ToString() + "_" + about.ImageFile.FileName;
                        string extension = Path.GetExtension(about.ImageFile.FileName);
                        string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await about.ImageFile.CopyToAsync(fileStream);
                        }
                        about.Image = fileName;
                    }
                    _context.Update(about);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutExists((int)about.Id))
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
            return View(about);
        }

        // GET: Abouts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var about = await _context.About
                .FirstOrDefaultAsync(m => m.Id == id);
            if (about == null)
            {
                return NotFound();
            }

            return View(about);
        }

        // POST: Abouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var about = await _context.About.FindAsync(id);
            _context.About.Remove(about);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutExists(int id)
        {
            return _context.About.Any(e => e.Id == id);
        }
    }
}
