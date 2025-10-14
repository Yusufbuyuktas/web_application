using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using web_odev.Models;


namespace web_odev.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var students = Repository.Students;
        List<Student> signedStudents = new List<Student>();

        foreach (Student student in Repository.Students)
        {
            if (student.Signed)
            {
                signedStudents.Add(student);
            }

        }

        ViewBag.SignedStudents = signedStudents;
        return View();
    }

    public IActionResult AllStudents()
    {
        var students = Repository.Students;
        ViewBag.allstudents = students;
        return View();

    }

    [HttpGet]
    public IActionResult Sign()
    {
        return View();

    }

    [HttpPost]
    public IActionResult Sign(int studentID)
    {
        Student? student = Repository.Students.FirstOrDefault(s => s.StudentID == studentID);
        if (student != null)
        {
            student.Signed = true;
            student.SignedAt = DateTime.Now;

            return RedirectToAction("Index");
        }
        else
        {
            ViewBag.ErrorMessage = "Öğrenci numarası bulunamadı.";
            return View("Sign");   
        }
        

    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
