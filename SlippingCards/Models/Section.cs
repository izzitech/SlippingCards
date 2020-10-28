using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlippingCards.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Card> Cards { get; set; }
    }
}
