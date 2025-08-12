//using System.Diagnostics;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using NewProject.Models;

//namespace NewProject.Controllers
//{
//    public class StudentController : Controller
//    {
//        private readonly StudentDbContext studentDb;

//        //private readonly ILogger<HomeController> _logger;

//        //public HomeController(ILogger<HomeController> logger)
//        //{
//        //    _logger = logger;
//        //}


//        public StudentController(StudentDbContext studentDb)
//        {
//            this.studentDb = studentDb;
//        }

//        public async Task<IActionResult> Index()
//        {
//            var stdData = await studentDb.Students.ToListAsync();
//            return View(stdData);
//        }

//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(Student std)
//        {
//            if (ModelState.IsValid)
//            {
//                await studentDb.Students.AddAsync(std);
//                await studentDb.SaveChangesAsync();
//                TempData["insert_success"] = "Inserted Successfully";
//                return RedirectToAction("Index", "Student");

//            }
//            return View(std);
//        }

//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null || studentDb.Students == null)
//            {
//                return NotFound();
//            }

//            var stdData = await studentDb.Students.FirstOrDefaultAsync(x => x.Id == id);
//            if (stdData == null)
//            {
//                return NotFound();
//            }

//            return View(stdData);
//        }

//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || studentDb.Students == null)
//            {
//                return NotFound();
//            }
//            var stdData = await studentDb.Students.FindAsync(id);
//            if (stdData == null)
//            {
//                return NotFound();
//            }
//            return View
//                (stdData);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int? id, Student std)
//        {
//            if (id != std.Id)
//            {
//                return NotFound();
//            }
//            if (ModelState.IsValid)
//            {
//                studentDb.Update(std);
//                await studentDb.SaveChangesAsync();
//                TempData["Updated_success"] = "Updated Successfully";
//                return RedirectToAction
//                    ("Index", "Student");

//            }
//            return View(std);
//        }

//        public async Task<IActionResult> Delete(int? id)
//        {

//            if (id == null || studentDb.Students == null)
//            {
//                return NotFound();
//            }
//            var stdData = await studentDb.Students.FirstOrDefaultAsync(x => x.Id == id);
//            if (stdData == null)
//            {
//                return NotFound();
//            }
//            return View(stdData);
//        }

//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int? id)
//        {
//            var stdData = await studentDb.Students.FindAsync(id);
//            if (stdData != null)
//            {
//                studentDb.Students.Remove(stdData);
//            }
//            await studentDb.SaveChangesAsync();
//            TempData["Deleted_success"] = "Deleted Successfully";
//            return RedirectToAction("Index", "Student");
//        }


//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}
