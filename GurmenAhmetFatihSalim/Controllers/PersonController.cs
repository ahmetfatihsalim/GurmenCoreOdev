using Gurmen.DataAccess.Data;
using Gurmen.DataAccess.Repository.IRepository;
using Gurmen.Model;
using Microsoft.AspNetCore.Mvc;

namespace GurmenAhmetFatihSalim.Controllers
{
    public class PersonController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Person> people= _unitOfWork.PersonRepository.GetAll().ToList();
            return View(people);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.PersonRepository.Add(person);
                _unitOfWork.Save();
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Person? person = _unitOfWork.PersonRepository.GetFirstOrDefault(person => person.ID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.PersonRepository.Update(person);
                _unitOfWork.Save();
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Person? person = _unitOfWork.PersonRepository.GetFirstOrDefault(person => person.ID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Person? person = _unitOfWork.PersonRepository.GetFirstOrDefault(person => person.ID == id);
            if (person == null)
            {
                return NotFound();
            }
            _unitOfWork.PersonRepository.Remove(person);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
