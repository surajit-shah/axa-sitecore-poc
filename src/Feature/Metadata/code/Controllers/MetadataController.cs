namespace Mirabeau.Feature.Metadata.Controllers
{
  using System;
  using System.Web.Mvc;
  using Sitecore.Data;
  using Repositories;

  public class MetadataController : Sitecore.Mvc.Controllers.SitecoreController
  {
    private readonly IMetadataRepository MetadataRepository;

    public MetadataController() : this(new MetadataRepository())
    {
    }

    public MetadataController(IMetadataRepository MetadataRepository)
    {
      this.MetadataRepository = MetadataRepository;
    }

    public ActionResult Metadata()
    {
        /* 
          TODO: Use the repository to retrieve model data 
          which can be passed into the view.
        */

       //var model = MetadataRepository. ;
       //
       //return this.View(model);
       
       throw new NotImplementedException();
    }
  }
}
