using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SlippingCards.HelperClasses;
using SlippingCards.Models;
using SlippingCards.ViewModel;

namespace SlippingCards.Controllers
{
    public class CardsetController : Controller
    {
        public IActionResult Create(CardLoaderViewModel cardsetData)
        {
            try
            {
                var cardset = CardsetLoaderHelper.LoadCardset(cardsetData.CardSetText);
                return View(cardset);
            }
            catch (Exception ex)
            {
                return View("HowToUseIt");
            }
        }

        public IActionResult CreateTemplate()
        {
            TextReader cardsetTemplate = 
                new StreamReader(
                    Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        "SlippingCards_template.txt"));
            var cardset = CardsetLoaderHelper.LoadCardset(cardsetTemplate.ReadToEnd());
            return View("Create", cardset);
        }
    }
}
