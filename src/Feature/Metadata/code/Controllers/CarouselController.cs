using Mirabeau.Feature.Carousel.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirabeau.Feature.Carousel.Controllers
{
    public class CarouselController : Controller
    {
        public ActionResult SCCarousel()
        {
            List<CarouselSlide> slides = new List<CarouselSlide>();
            MultilistField multilistField = Sitecore.Context.Item.Fields["PageCarouselSlides"];
            if (multilistField != null)
            {
                Item[] carouselItems = multilistField.GetItems();
                foreach (Item item in carouselItems)
                {
                    slides.Add(new CarouselSlide(item));
                }
            }
            return PartialView(slides);
        }

    }
}