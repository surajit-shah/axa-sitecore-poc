﻿using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Links;
using System.Collections.Generic;
using System.Linq;

namespace Mirabeau.Feature.Navigation.Models
{
    public class SimpleItem : CustomItem
    {
        public SimpleItem(Item item) : base(item)
        {
            Assert.IsNotNull(item, "item");
        }

        public string MetaTitle
        {
            get { return InnerItem[FieldId.MetaTitle]; }
        }

        public string MetaDescription
        {
            get { return InnerItem[FieldId.MetaDescription]; }
        }

        public string MetaKeywords
        {
            get { return InnerItem[FieldId.MetaKeywords]; }
        }

        public string Body
        {
            get { return InnerItem[FieldId.Body]; }
        }

        public string Title
        {
            get { return InnerItem[FieldId.Title]; }
        }
        //public string ItemIcon
        //{
        //  get { return InnerItem[FieldId.Icon]; }
        //}

        public string Url
        {
            get { return LinkManager.GetItemUrl(InnerItem); }
        }

        public bool isSearchResultAvailable
        {
            get;
            set; 
        }
        //public string Mediaurl
        //{


        //}

        //public string SearchDescription
        //{
        //    get { return EBPOC.Web.Helpers.SiteHelper.GetPageDescripton(Item); }
        //}

        public Item Item
        {
            get { return InnerItem; }
        }

        //public IEnumerable<SimpleItem> ChildrenInCurrentLanguage
        //{
        //    get
        //    {
        //        return InnerItem.Children.Select(x => new SimpleItem(x)).Where(x => SiteConfiguration.DoesItemExistInCurrentLanguage(x.Item));
        //    }
        //}

        public IEnumerable<SimpleItem> Children
        {
            get
            {
                return InnerItem.Children.Select(x => new SimpleItem(x));
            }
        }

        public static class FieldId
        {
            public static readonly ID MetaTitle = new ID("{53E0DAED-D572-4A80-9A29-6BD14E37FC6F}");
            public static readonly ID MetaDescription = new ID("{E9A71581-8AD6-4038-AE75-A659CB472838}");
            public static readonly ID MetaKeywords = new ID("{51137A28-1D85-4300-AE72-058708960A5D}");
            public static readonly ID Title = new ID("{2F95898F-AC4A-4506-B44B-8B0CC052BD72}");
            public static readonly ID Body = new ID("{D9667C70-676E-48EC-BDF2-0BACBAD53083}");
            //public static readonly ID Icon = new ID("{2B60D8C1-81DB-45A7-B1CB-654CDDA96AE3}");
        }
    }
}