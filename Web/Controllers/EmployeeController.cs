using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using Web.Interfaces;
using Web.Models.ViewModels;

namespace Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRequestHelper _employee;
        private readonly IGenderRequestHelper _gender;
        private readonly IStatusRequestHelper _status;

        public EmployeeController(IEmployeeRequestHelper employee, IGenderRequestHelper gender, IStatusRequestHelper status)
        {
            _employee = employee;
            _gender = gender;
            _status = status;
        }

        public async Task<IActionResult> Index(string name)
        {
            var employees = await _employee.GetRequest(name);
            var gender = await _gender.GetRequest();
            ViewBag.Gender = gender.ToDictionary(x => x.Id, x => x.Name);

            var status = await _status.GetRequest();
            ViewBag.Status = status.ToDictionary(x => x.Id, x => x.Name);

            return View(employees);
        }


        public async Task<IActionResult> Create()
        {
            var gender = await _gender.GetRequest();
            ViewBag.Gender = new SelectList(gender, "Id", "Name");

            var status = await _status.GetRequest();
            ViewBag.Status = new SelectList(status, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                await _employee.PostRequest(employeeVM);

                TempData["Success"] = "Added Successfully!";

                return RedirectToAction("Index");
            }
            return View(employeeVM);
        }

        public async Task<IActionResult> Update(int id)
        {
            if (id == 0)
                return NotFound();

            var obj = await _employee.GetByIdRequest(id);

            if (obj == default)
                return NotFound();

            var gender = await _gender.GetRequest();
            ViewBag.Gender = new SelectList(gender, "Id", "Name");

            var status = await _status.GetRequest();
            ViewBag.Status = new SelectList(status, "Id", "Name");

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                await _employee.PutRequest(id, employeeVM);

                return RedirectToAction("Index");
            }
            return View(employeeVM);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return NotFound();

            var obj = await _employee.GetByIdRequest(id);

            if (obj == default)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _employee.DeleteRequest(id);

            return RedirectToAction("Index");
        }
    }
}
