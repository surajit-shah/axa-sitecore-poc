namespace Mirabeau.Feature.Articles.Controllers
{
  using System;
  using System.Web.Mvc;
  using Sitecore.Data;
  using Repositories;

  public class ArticlesController : Sitecore.Mvc.Controllers.SitecoreController
  {
    private readonly IArticlesRepository ArticlesRepository;

    public ArticlesController() : this(new ArticlesRepository())
    {
    }

    public ArticlesController(IArticlesRepository ArticlesRepository)
    {
      this.ArticlesRepository = ArticlesRepository;
    }

    public ActionResult Articles()
    {
        /* 
          TODO: Use the repository to retrieve model data 
          which can be passed into the view.
        */

       //var model = ArticlesRepository. ;
       //
       //return this.View(model);
       
       throw new NotImplementedException();
    }
  }
}
