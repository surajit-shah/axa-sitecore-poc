namespace Mirabeau.Foundation.Indexing.Controllers
{
  using System;
  using System.Web.Mvc;
  using Sitecore.Data;
  using Repositories;

  public class IndexingController : Sitecore.Mvc.Controllers.SitecoreController
  {
    private readonly IIndexingRepository IndexingRepository;

    public IndexingController() : this(new IndexingRepository())
    {
    }

    public IndexingController(IIndexingRepository IndexingRepository)
    {
      this.IndexingRepository = IndexingRepository;
    }

    public ActionResult Indexing()
    {
        /* 
          TODO: Use the repository to retrieve model data 
          which can be passed into the view.
        */

       //var model = IndexingRepository. ;
       //
       //return this.View(model);
       
       throw new NotImplementedException();
    }
  }
}
