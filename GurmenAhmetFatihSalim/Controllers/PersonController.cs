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

        public async Task<IActionResult> Index()
        {
            List<Person> people = await _unitOfWork.PersonRepository.GetAll();
            return View(people);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.PersonRepository.Add(person);
                await _unitOfWork.Save();
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Person? person = await _unitOfWork.PersonRepository.GetFirstOrDefault(person => person.ID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.PersonRepository.Update(person);
                await _unitOfWork.Save();
            }
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Person? person = await _unitOfWork.PersonRepository.GetFirstOrDefault(person => person.ID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePOST(int? id)
        {
            Person? person = await _unitOfWork.PersonRepository.GetFirstOrDefault(person => person.ID == id);
            if (person == null)
            {
                return NotFound();
            }
            await _unitOfWork.PersonRepository.Remove(person);
            await _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
