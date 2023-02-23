using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notissimus_Test.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Notissimus_Test.Context;

namespace Notissimus_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext dbContext;
        private yml_catalog catalog;
        private yml_catalogShopOffer offer;
        
        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            dbContext = context;
            dbContext.SavedChanges += DbContext_SavedChanges;
            catalog = LoadDataFromXML();
            offer = catalog.shop.offers.Where(o => o.id == 12344).FirstOrDefault();
            Task.Run(async () => await SaveOffer(offer)).Wait();
        }   

        public IActionResult Index()
        {
            ViewBag.Category = catalog.shop.categories.ToList();
            return View(offer);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private yml_catalog LoadDataFromXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(yml_catalog));

            using (FileStream fs = new FileStream("test.xml", FileMode.OpenOrCreate))
            {
                return xmlSerializer.Deserialize(fs) as yml_catalog;
            }
        }

        private async Task SaveOffer(yml_catalogShopOffer offer)
        {
            var result = await dbContext.Offer.FirstOrDefaultAsync(o => o.ID == offer.id);
            if (result == null)
            {
                SavedOfferModel saveModel = new SavedOfferModel()
                {
                    ID = offer.id,
                    BID = offer.bid,
                    CBID = offer.cbid,
                    Avalible = offer.available,
                    Type = offer.type
                };
                int index = 0;
                foreach (var item in offer.ItemsElementName)
                {
                    saveModel.GetType().GetProperty(item.ToString()).SetValue(saveModel, offer.Items[index]);
                    index++;
                }
                await dbContext.Offer.AddAsync(saveModel);
                await dbContext.SaveChangesAsync();
            }
        }

        private void DbContext_SavedChanges(object sender, SavedChangesEventArgs e)
        {
            _logger.LogInformation("Offer added to SQL Server");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
