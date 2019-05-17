namespace Mirabeau.Foundation.Extensions.Controllers
{
  using System;
  using System.Web.Mvc;
  using Sitecore.Data;
  using Repositories;

  public class ExtensionsController : Sitecore.Mvc.Controllers.SitecoreController
  {
    private readonly IExtensionsRepository ExtensionsRepository;

    public ExtensionsController() : this(new ExtensionsRepository())
    {
    }

    public ExtensionsController(IExtensionsRepository ExtensionsRepository)
    {
      this.ExtensionsRepository = ExtensionsRepository;
    }

    public ActionResult Extensions()
    {
        /* 
          TODO: Use the repository to retrieve model data 
          which can be passed into the view.
        */

       //var model = ExtensionsRepository. ;
       //
       //return this.View(model);
       
       throw new NotImplementedException();
    }
  }
}
