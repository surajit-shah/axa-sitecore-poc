using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mirabeau.Foundation.Extensions.Repositories
{
    public static class Helper
    {
        public static Item ProductItems(string scpath)
        {
            string productPath = scpath;
            return Sitecore.Context.Database.GetItem(productPath);
        }
    }
}