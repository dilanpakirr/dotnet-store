using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.ViewComponents
{
    public class Slide : ViewComponent
    {
        private readonly DataContext _context;

        public Slide(DataContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Slides.ToList());
        }
    }
}