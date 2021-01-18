using ChuckNorrisApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisApplication.Controllers
{
    public class RandomController : Controller
    {
        private IChuckNorrisRepository _chuckNorrisRepository;


        public RandomController(IChuckNorrisRepository chuckNorrisRepository)
        {
            _chuckNorrisRepository = chuckNorrisRepository;
        }

        public IActionResult Index()
        {
            var model = _chuckNorrisRepository.GetChuckNorris();
            
                
            return View(model);
        }
        [HttpPost]
        public IActionResult Save(ChuckNorris chuckNorris)
        {
            if (chuckNorris != null && _chuckNorrisRepository.CheckIfExists(chuckNorris))
            {
                _chuckNorrisRepository.Add(chuckNorris);
            }
           

            var model = _chuckNorrisRepository.GetAllChuckNorris();

            return View(model);
        }

        [HttpGet]
        public IActionResult Save()
        {
            var model = _chuckNorrisRepository.GetAllChuckNorris();

            return View(model);
        }


        [HttpGet]
        public IActionResult Delete(string id)
        {
            _chuckNorrisRepository.DeleteChuckNorris(id);

            return RedirectToAction("Save");
        }

        public IActionResult DeleteAll(ChuckNorris chuckNorris)
        {
            _chuckNorrisRepository.DeleteAllData(chuckNorris);
            return RedirectToAction("Save");
        }
    }
       
}
