namespace Mirabeau.Feature.Metadaa.Controllers
{
  using System;
  using System.Web.Mvc;
  using Sitecore.Data;
  using Repositories;

  public class MetadaaController : Sitecore.Mvc.Controllers.SitecoreController
  {
    private readonly IMetadaaRepository MetadaaRepository;

    public MetadaaController() : this(new MetadaaRepository())
    {
    }

    public MetadaaController(IMetadaaRepository MetadaaRepository)
    {
      this.MetadaaRepository = MetadaaRepository;
    }

    public ActionResult Metadaa()
    {
        /* 
          TODO: Use the repository to retrieve model data 
          which can be passed into the view.
        */

       //var model = MetadaaRepository. ;
       //
       //return this.View(model);
       
       throw new NotImplementedException();
    }
  }
}
