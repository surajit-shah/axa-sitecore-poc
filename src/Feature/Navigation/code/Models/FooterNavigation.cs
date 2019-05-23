﻿using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mirabeau.Feature.Navigation.Models
{
    public class FooterNavigation: CustomItem
    {
        public FooterNavigation(Item item)
            : base(item) { }
        public string Title
        {
            get { return InnerItem["Meta Title"]; }
        }

        public string FooterText
        {
            get { return InnerItem["Footer Text"]; }

        }
    }
}