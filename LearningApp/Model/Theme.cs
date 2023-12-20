using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace LearningApp.Model
{
    class Theme
    {
        private List<Card> _cards;
        public string ThemeName { get; private set; }

        public Theme(string themeName)
        {
            this.ThemeName = themeName;
        }

        public void AddNewCard(string question, string answer)
        {
            Card card = new Card(question, answer);
            _cards.Add(card);
        }

        public void RemoveCard(string question, string answer)
        {
            var card = _cards.FirstOrDefault(x => x.Question == question && x.Answer == answer);
            if (card != null)
            {
                _cards.Remove(card);
            }
        }

        public int HowManyCards()
        {
            return _cards.Count;
        }
    }
}
