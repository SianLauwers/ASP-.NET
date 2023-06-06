using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreContext _context;

        public StoreController(StoreContext context)
        {
            _context = context;
        }

        public IActionResult ListGenres()
        {
            var genres = _context.Genres.OrderBy(g => g.Name);
            return View(genres);
        }

        public IActionResult ListAlbums(int? id)
        {
            var albums = _context.Albums.Where(a => a.GenreID == id).OrderBy(a => a.Title);
            ViewBag.Name = _context.Genres.Where(a => a.GenreID == id).SingleOrDefault().Name;
            return View(albums);
        }

        public IActionResult Details(int id)
        {
            var albums = _context.Albums.Include(a => a.Genre).Include(a => a.Artist).SingleOrDefault(a => a.AlbumID == id);


            return View(albums);
        }
    }
}
