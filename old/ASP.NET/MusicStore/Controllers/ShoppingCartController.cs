using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly StoreContext _context;

        public ShoppingCartController(StoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cartItems = _context.CartItems.Include(c => c.Album).ToList();
            return View(cartItems);
        }

        public IActionResult AddToCart(int id)
        {
            var album = _context.Albums.SingleOrDefault(a => a.AlbumID == id);
            ShoppingCart shoppingCart = new ShoppingCart(HttpContext, _context);
            shoppingCart.AddToCart(album);
            return RedirectToAction("Index");
        }
        public ActionResult RemoveFromCart(int id)
        {
            var cart = new ShoppingCart(HttpContext, _context);

            cart.RemoveFromCart(id);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        public ActionResult RemoveOne(int id)
        {
            var cart = new ShoppingCart(HttpContext, _context);
            var cartItem = _context.CartItems.Single(i => i.CartItemID == id);

            cart.RemoveFromCart(id);


            return RedirectToAction("Index");
        }
        public ActionResult AddOne(int id)
        {
            var cart = new ShoppingCart(HttpContext, _context);
            var cartItem = _context.Albums.Single(i => i.AlbumID == id);
            cart.AddToCart(cartItem);

            return RedirectToAction("Index");
        }
    }
}
