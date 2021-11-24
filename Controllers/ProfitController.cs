using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shopping_mall.Data;
namespace shopping_mall.Controllers
{
    public class ProfitController : Controller
    {
        private readonly shopping_mallContext _context;
        public ProfitController(shopping_mallContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }
    }
}
