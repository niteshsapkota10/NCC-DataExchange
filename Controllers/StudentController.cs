using Microsoft.AspNetCore.Mvc;
using StudentsEmployees.Models;
using System.Data.SqlClient;

namespace StudentsEmployees.Controllers
{
    public class StudentController : Controller
    {

        //private IConfiguration Configuration;

        //public StudentController(IConfiguration _configuration)
        //{
        //    Configuration = _configuration;
        //}

        public List<Student> GetFromDataSource()
        {
            //List<Student> StudentsList = new List<Student>();

            //string connectionString = this.Configuration.GetConnectionString("DefaultConnection");
            //string queryString = "Select * From StudentDetails";

            //using(SqlConnection connection=new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    connection.Open();
            //    using(SqlDataReader reader=command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            Student Student1 = new Student();
            //            Student1.ID=int.Parse(reader[0].ToString());
            //            Student1.Name=reader[1].ToString();
            //            Student1.Gender=reader[2].ToString();
            //            Student1.Branch = reader[3].ToString();
            //            StudentsList.Add(Student1);
            //        }
            //    }
            //}

            return studentList;
        }



        public List<Student> studentList = new List<Student>() {
                new Student() { ID = 1, Name = "Nitesh", Age = 21,Branch = "CSIT", Gender = "Male"},
                new Student() { ID = 2, Name = "Prabhat", Age = 22,Branch = "CSIT", Gender = "Male" },
                new Student() { ID = 3, Name = "Prakash", Age = 20,Branch = "CSIT", Gender = "Male" }
            };

        // GET: StudentController
        public ActionResult Index()
        {
            //ViewBag.students = studentList;
            return View();
        }

        public ActionResult StudentList()
        {
            TempData["students"]=studentList;
            //ViewData["students"] = studentList;
            //ViewBag.students = studentList;

            return View();
            //return View();
        }

        public ActionResult Student()
        {
            Student student = studentList[0];
            ViewBag.Student = student;
            return View();
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Create(IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: StudentController/Edit/5
        //    public ActionResult Edit(int id)
        //    {
        //        return View();
        //    }

        //    // POST: StudentController/Edit/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: StudentController/Delete/5
        //    public ActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: StudentController/Delete/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Delete(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
        //}
    }
}
