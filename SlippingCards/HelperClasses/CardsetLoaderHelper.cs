using SlippingCards.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SlippingCards.HelperClasses
{
    public class CardsetLoaderHelper
    {
        public static Cardset LoadCardset(string text)
        {
            string lastLine = "";
            string thisLine = "";
            var lines = new StringReader(text);

            var cardSet = new Cardset();

            while ((thisLine = lines.ReadLine()) != null)
            {
                if (thisLine.StartsWith("===="))
                {
                    cardSet.Name = lastLine;
                }
                if (thisLine.StartsWith("----"))
                {
                    var newSection = new Section()
                    {
                        Title = lastLine
                    };
                    cardSet.Sections.Add(newSection);
                }
                if (thisLine.Contains(':'))
                {
                    if (cardSet.Sections == null)
                    {
                        cardSet.Sections = new List<Section>();
                        cardSet.Sections.Add(new Section());
                    }

                    var newCard = new Card(thisLine);
                    cardSet.Sections.Last().Cards.Add(newCard);
                }

                lastLine = thisLine;
            }

            return cardSet;
        }
    }
}
