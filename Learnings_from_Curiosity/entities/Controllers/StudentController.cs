using entities.Data;
using entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace entities.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult DisplayStudents()
        {
            List<StudentModel> students = new List<StudentModel>();
            students = _dbContext.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult AddStudents()
        {
            StudentModel student = new StudentModel();
            return View(student);
        }

        [HttpPost]
        public IActionResult AddStudents(StudentModel studentModel)
        {
            _dbContext.Add(studentModel);
            _dbContext.SaveChanges();
            return RedirectToAction("DisplayStudents");
        }

        [HttpGet]
        public IActionResult EditStudents(int studentId)
        {
            StudentModel? student = _dbContext.Students.Find(studentId);
            if (student is not null)
            {
                return View(student);
            }
            else
                return RedirectToAction("DisplayStudents");
        }

        [HttpPost]
        public IActionResult EditStudents(StudentModel studentModel)
        {
            StudentModel? student = _dbContext.Students.Find(studentModel.StudentId);
            if (student is not null)
            {
                student.Name = studentModel.Name;
                student.Semester = studentModel.Semester;
                student.Marks = studentModel.Marks;
                _dbContext.SaveChanges();
                return RedirectToAction("DisplayStudents");
            }
            else
                return View();
        }

        public IActionResult DeleteStudents(int studentId)
        {
            StudentModel? student = _dbContext.Students.Find(studentId);
            if (student is not null)
            {
                _dbContext.Students.Remove(student);
                _dbContext.SaveChanges();
                return RedirectToAction("DisplayStudents");
            }
            else
                return RedirectToAction("DisplayStudents");
        }
    }
}
