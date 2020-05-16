using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Route("quiz")]
    public class QuizController : Controller
    {

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            QuestionModel questionModel = new QuestionModel();
            ViewBag.questions = questionModel.findAll();
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(IFormCollection iformCollection)
        {
            int score = 0;
            var questionModel = new QuestionModel();
            foreach (var question in questionModel.findAll())
            {
                int ansIdCorrect = question.Answers.Where(a => a.Correct).SingleOrDefault().Id;
                int answerIdSubmit = int.Parse(iformCollection["question_" + question.Id].ToString());
                if (ansIdCorrect == answerIdSubmit)
                {
                    score++;
                }
            }
            ViewBag.score = score;
            return View("Result");
        }
    }
}