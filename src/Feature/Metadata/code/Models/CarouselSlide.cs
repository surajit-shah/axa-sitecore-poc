﻿using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Resources.Media;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mirabeau.Feature.Carousel.Models
{
    public class CarouselSlide : CustomItem
    {
        public CarouselSlide(Item item)
          : base(item) { }

        public string Title
        {
            get { return InnerItem["CarouselTitle"]; }
        }

        public string Image
        {
            //get
            //{
            //    return new HtmlString(FieldRenderer.Render(InnerItem, "CarouselImage"));
            //}
            get
            {
                return GetImageUrl();
            }
        }
        private string GetImageUrl()
        {
            var currentItem = Sitecore.Context.Item;
            var imageUrl = string.Empty;

            Sitecore.Data.Fields.ImageField imageField = InnerItem.Fields["CarouselImage"];
            if (imageField?.MediaItem != null)
            {
                var image = new MediaItem(imageField.MediaItem);
                imageUrl = StringUtil.EnsurePrefix('/', MediaManager.GetMediaUrl(image));
            }
            return imageUrl;
        }

        public string Url
        {
            get
            {
                Item linkItem = Sitecore.Context.Database.GetItem(InnerItem["CarouselLinkItem"]);
                if (linkItem != null)
                    return LinkManager.GetItemUrl(linkItem);
                return "";
            }
        }
    }
}