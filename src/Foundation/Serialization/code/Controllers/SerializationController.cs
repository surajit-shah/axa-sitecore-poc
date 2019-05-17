namespace Mirabeau.Foundation.Serialization.Controllers
{
  using System;
  using System.Web.Mvc;
  using Sitecore.Data;
  using Repositories;

  public class SerializationController : Sitecore.Mvc.Controllers.SitecoreController
  {
    private readonly ISerializationRepository SerializationRepository;

    public SerializationController() : this(new SerializationRepository())
    {
    }

    public SerializationController(ISerializationRepository SerializationRepository)
    {
      this.SerializationRepository = SerializationRepository;
    }

    public ActionResult Serialization()
    {
        /* 
          TODO: Use the repository to retrieve model data 
          which can be passed into the view.
        */

       //var model = SerializationRepository. ;
       //
       //return this.View(model);
       
       throw new NotImplementedException();
    }
  }
}
