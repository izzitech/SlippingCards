using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SlippingCards.HelperClasses;
using SlippingCards.Models;

namespace SlippingCards.Controllers
{
    public class CardsetController : Controller
    {
        public IActionResult Create()
        {
            TextReader cardsetTemplate = 
                new StreamReader(
                    Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        "SlippingCards_template.txt"));
            var cardset = CardsetLoaderHelper.LoadCardset(cardsetTemplate.ReadToEnd());
            return View(cardset);
        }
    }
}
