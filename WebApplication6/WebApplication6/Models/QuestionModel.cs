using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class QuestionModel
    {
        private List<Question> questions;

        public QuestionModel()
        {
            questions = new List<Question>
            {
                new Question
                {
                    Id = 1 ,
                    Content = "Question 1",
                    Answers = new List<Answer>
                    {
                        new Answer{Id = 1, Content = "Ans 1.1", Correct = false},
                        new Answer{Id = 2, Content = "Ans 1.2", Correct = true},
                        new Answer{Id = 3, Content = "Ans 1.3", Correct = false},
                        new Answer{Id = 4, Content = "Ans 1.4", Correct = false},
                    }
                },

                new Question
                {
                    Id = 2 ,
                    Content = "Question 2",
                    Answers = new List<Answer>
                    {
                        new Answer{Id = 5, Content = "Ans 2.1", Correct = true},
                        new Answer{Id = 6, Content = "Ans 2.2", Correct = false},
                        new Answer{Id = 7, Content = "Ans 2.3", Correct = false},
                        new Answer{Id = 8, Content = "Ans 2.4", Correct = false},
                    }
                },

                new Question
                {
                    Id = 3 ,
                    Content = "Question 3",
                    Answers = new List<Answer>
                    {
                        new Answer{Id = 9, Content = "Ans 3.1", Correct = true},
                        new Answer{Id = 10, Content = "Ans 3.2", Correct = false},
                        new Answer{Id = 11, Content = "Ans 3.3", Correct = false},
                        new Answer{Id = 12, Content = "Ans 3.4", Correct = false},
                    }
                }
            };
        }

        public List<Question> findAll()
        {
            return questions;
        }
    }
}
