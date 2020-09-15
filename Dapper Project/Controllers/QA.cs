using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dapper_Project.Controllers
{
    public class QA : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReadQuestions()
        {
            List<Questions> QS = Questions.Read();
            return View(QS);
        }

        public IActionResult AskQuestion()
        {
            


            return View();
        }

        public IActionResult AddQuestion(string username, string title, string detail, string category, string tags)
        {
            Questions.Create(username, title, detail, category, tags);

            return RedirectToAction("ReadQuestions", "QA");
            //return Content($"{tags}");
        }

        /*
         //Prints comments in comments thread. 
            Same user should be able to add multiple answers to the same question
         
        public IActionResult ReadAnswers(long id)
        {
            List<Answers> answers = Answers.Read();
            return View(answers);

        }
        */
    }
}
