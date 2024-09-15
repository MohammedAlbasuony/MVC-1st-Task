using day_1.DAL.DB;
using Microsoft.AspNetCore.Mvc;

namespace day_1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDBContext dbContext = new ApplicationDBContext();
        public IActionResult Index()
        {
            var result = dbContext.Employees.ToList();

            return View(result);
        }
    }
}
