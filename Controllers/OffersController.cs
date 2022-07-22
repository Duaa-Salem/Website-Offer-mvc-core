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
using Microsoft.AspNetCore.Identity;

namespace duaaOffer.Controllers
{
    public class OffersController : Controller
    {
        private readonly TestContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<AspNetUsers> _user;
        public OffersController(TestContext context, IWebHostEnvironment _hostEnvironment, UserManager<AspNetUsers> user)
        {
            _context = context;
            this._hostEnvironment = _hostEnvironment;
            _user = user;
        }

        // GET: Offers
        public async Task<IActionResult> Index()
        {
            var testContext = _context.Offer.Include(o => o.Category).Include(o => o.User);
            return View(await testContext.ToListAsync());
        }
        public IActionResult viewAlloffer()
        {
            return View(_context.Offer.ToList());
        }
        // GET: Offers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = await _context.Offer
                .Include(o => o.Category)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offer == null)
            {
                return NotFound();
            }

            return View(offer);
        }

        // GET: Offers/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Categoryname");
            ViewData["Userid"] = new SelectList(_context.Login, "Id", "Email");
            return View();
        }

        // POST: Offers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Image,City,Communication,Color,Startdate,Enddate,Text,Regular,Sale,Company,CategoryId,Userid,ImageFile")] Offer offer)
        {
            string id = _user.GetUserId(HttpContext.User);
            offer.Userid = Int32.Parse(id);
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" + offer.ImageFile.FileName;
                    string extension = Path.GetExtension(offer.ImageFile.FileName);
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))

                    {
                        await offer.ImageFile.CopyToAsync(fileStream);
                    }
                    offer.Image = fileName ;
                    _context.Add(offer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("UserId","Home");
                }
            }

            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Categoryname", offer.CategoryId);
            ViewData["Userid"] = new SelectList(_context.Login, "Id", "Email", offer.Userid);
            return View(offer);
        }

        // GET: Offers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = await _context.Offer.FindAsync(id);
            if (offer == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Categoryname", offer.CategoryId);
            ViewData["Userid"] = new SelectList(_context.Login, "Id", "Email", offer.Userid);
            return View(offer);
        }

        // POST: Offers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Image,City,Communication,Color,Startdate,Enddate,Text,Regular,Sale,Company,CategoryId,Userid,ImageFile")] Offer offer)
        {
            if (id != offer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (offer.ImageFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Guid.NewGuid().ToString() + "_" + offer.ImageFile.FileName;
                        string extension = Path.GetExtension(offer.ImageFile.FileName);
                        string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await offer.ImageFile.CopyToAsync(fileStream);
                        }
                        offer.Image = fileName;
                    }
                    _context.Update(offer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfferExists((int)offer.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Categoryname", offer.CategoryId);
            ViewData["Userid"] = new SelectList(_context.Login, "Id", "Email", offer.Userid);
            return View(offer);
        }

        // GET: Offers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = await _context.Offer
                .Include(o => o.Category)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offer == null)
            {
                return NotFound();
            }

            return View(offer);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offer = await _context.Offer.FindAsync(id);
            _context.Offer.Remove(offer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfferExists(int id)
        {
            return _context.Offer.Any(e => e.Id == id);
        }
        
    }
}
