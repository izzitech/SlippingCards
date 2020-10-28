using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlippingCards.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public Card() { }

        public Card(string card)
        {
            Image = "🗃";
            Title = card.Split(':')[0].Trim();
            Text = card.Split(':')[1].Trim();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !obj.GetType().Equals(typeof(Card))) return false;
            Card cardToCompare = (Card)obj;

            bool titleEquals = Title.Equals(cardToCompare.Title);
            bool imageEquals = Image.Equals(cardToCompare.Image);
            bool textEquals = Text.Equals(cardToCompare.Text);
            bool areEqual = titleEquals && imageEquals && textEquals;

            return areEqual;
        }
    }
}
