﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using Mirabeau.Feature.Search.Models;

namespace Mirabeau.Feature.Search.Configuration.Search.Models
{
  public class SitecoreItem : SearchResultItem
  {
    public string Title { get; set; }

    [IndexField("__smallcreateddate")]
    public DateTime PublishDate { get; set; }

    [IndexField("has_presentation")]
    public bool HasPresentation { get; set; }

    [IndexField(BuiltinFields.Semantics)]
    public string Tags { get; set; }

    [IndexField("show_in_search_results")]
    public bool ShowInSearchResults { get; set; }

    [IndexField("articlegroupname")]
    public bool ArticleGroupName { get; set; }

   [IndexField("articlecategories")]
   public IEnumerable<string> ArticleCategories { get; set; }


    }
}