using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SlippingCards.ViewModel
{
    public class CardLoaderViewModel
    {
        [DisplayName("Cardset data")]
        [DataType(DataType.MultilineText)]
        public string CardSetText { get; set; }
    }
}
