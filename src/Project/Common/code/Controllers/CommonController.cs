namespace AXA.Project.Common.Controllers
{
  using System;
  using System.Web.Mvc;
  using Sitecore.Data;
  using Repositories;

  public class CommonController : Sitecore.Mvc.Controllers.SitecoreController
  {
    private readonly ICommonRepository CommonRepository;

    public CommonController() : this(new CommonRepository())
    {
    }

    public CommonController(ICommonRepository CommonRepository)
    {
      this.CommonRepository = CommonRepository;
    }

    public ActionResult Common()
    {
        /* 
          TODO: Use the repository to retrieve model data 
          which can be passed into the view.
        */

       //var model = CommonRepository. ;
       //
       //return this.View(model);
       
       throw new NotImplementedException();
    }
  }
}
