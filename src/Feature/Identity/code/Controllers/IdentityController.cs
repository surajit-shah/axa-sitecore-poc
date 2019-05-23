namespace Mirabeau.Feature.Forms.Controllers
{
    using System;
    using System.Web.Mvc;

    public class IdentityController : Sitecore.Mvc.Controllers.SitecoreController
    {
        //private readonly IIdentityRepository IdentityRepository;

        //public IdentityController() : this(new IdentityRepository())
        //{
        //}

        //public IdentityController(IIdentityRepository IdentityRepository)
        //{
        //    this.IdentityRepository = IdentityRepository;
        //}

        public ActionResult Identity()
        {
            /* 
              TODO: Use the repository to retrieve model data 
              which can be passed into the view.
            */

            //var model = IdentityRepository. ;
            //
            //return this.View(model);

            throw new NotImplementedException();
        }
        public ActionResult Logo()
        {
            return View();
        }
    }
}
