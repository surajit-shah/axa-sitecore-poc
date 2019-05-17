namespace Mirabeau.Feature.Search.Controllers
{
  using System;
  using System.Web.Mvc;
  using Sitecore.Data;
  using Repositories;

  public class SearchController : Sitecore.Mvc.Controllers.SitecoreController
  {
    private readonly ISearchRepository SearchRepository;

    public SearchController() : this(new SearchRepository())
    {
    }

    public SearchController(ISearchRepository SearchRepository)
    {
      this.SearchRepository = SearchRepository;
    }

    public ActionResult Search()
    {
        /* 
          TODO: Use the repository to retrieve model data 
          which can be passed into the view.
        */

       //var model = SearchRepository. ;
       //
       //return this.View(model);
       
       throw new NotImplementedException();
    }
  }
}
