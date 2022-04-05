using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCVraboteni.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCVraboteni.Controllers
{
    public class VraboteniController : Controller
    {
        private readonly ConnectionStringClass _context;

        public VraboteniController(ConnectionStringClass context)
        {
            _context = context;
        }

               
        public async Task<IActionResult> Index(string searchString)
        {            
            var vraboteni = from v in _context.VraboteniTable
                            select v;
            if (!string.IsNullOrEmpty(searchString))
            {
                vraboteni = vraboteni.Where(s => s.Ime!.Contains(searchString));
            }
            return View(await vraboteni.ToListAsync());
        }

      

        [HttpPost]
        public IActionResult Details(int vrabotenID)
        {
            
            return PartialView("_VraboteniPartialView", _context.VraboteniTable.Find(vrabotenID));
        }

      
    }
}






