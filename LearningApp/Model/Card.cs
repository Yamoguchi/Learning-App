using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Model
{
    class Card
    {
        public string Question {  get; private set; }
        public string Answer { get; private set; }
        
        public Card(string question, string answer)
        {
            this.Question = question;
            this.Answer = answer;
        }

        public void setQuestion(string question)
        {
            this.Question=question;
        }

        public void setAnswer(string answer)
        {
            this.Answer = answer;
        }
    }
}
