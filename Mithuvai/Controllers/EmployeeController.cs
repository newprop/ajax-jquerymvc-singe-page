using Mithuvai.Models;
using System.Linq;
using System.Web.Mvc;

namespace Mithuvai.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllEmployees()
        {
            var employees = db.Employees.ToList();
            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return Json(employee);
            }
            return Json(null);
        }

        [HttpPost]
        public JsonResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(employee);
            }
            return Json(null);
        }
        public JsonResult GetEmployeeById(int id)
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                var employee = db.Employees.FirstOrDefault(e => e.Id == id);
                return Json(employee, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public JsonResult Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
                return Json(employee);
            }
            return Json(null);
        }
    }
}
