namespace Mirabeau.Feature.Navigation.Controllers
{
    using System;
    using System.Web.Mvc;
    using Sitecore.Data;
    using Repositories;

    public class NavigationController : Sitecore.Mvc.Controllers.SitecoreController
    {
        private readonly INavigationRepository NavigationRepository;

        public NavigationController() : this(new NavigationRepository())
        {
        }

        public NavigationController(INavigationRepository NavigationRepository)
        {
            this.NavigationRepository = NavigationRepository;
        }

        public ActionResult Navigation()
        {
            /* 
              TODO: Use the repository to retrieve model data 
              which can be passed into the view.
            */

            //var model = NavigationRepository. ;
            //
            //return this.View(model);

            throw new NotImplementedException();
        }

        public ActionResult LanguageSwitcher()
        {
            return View();
        }
    }
}
