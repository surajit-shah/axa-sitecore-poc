namespace AXA.Project.EmployeeBenefits.Controllers
{
  using System;
  using System.Web.Mvc;
  using Sitecore.Data;
  using Repositories;

  public class EmployeeBenefitsController : Sitecore.Mvc.Controllers.SitecoreController
  {
    private readonly IEmployeeBenefitsRepository EmployeeBenefitsRepository;

    public EmployeeBenefitsController() : this(new EmployeeBenefitsRepository())
    {
    }

    public EmployeeBenefitsController(IEmployeeBenefitsRepository EmployeeBenefitsRepository)
    {
      this.EmployeeBenefitsRepository = EmployeeBenefitsRepository;
    }

    public ActionResult EmployeeBenefits()
    {
        /* 
          TODO: Use the repository to retrieve model data 
          which can be passed into the view.
        */

       //var model = EmployeeBenefitsRepository. ;
       //
       //return this.View(model);
       
       throw new NotImplementedException();
    }
  }
}
