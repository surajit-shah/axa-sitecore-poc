namespace Mirabeau.Feature.Identity.Repositories
{
    using System;
    using Sitecore.Data.Items;
    using Mirabeau.Foundation.Extensions.Extensions;
    using Sitecore.Diagnostics;
    using Sitecore;

    public static class IdentityRepository
    {
        public static Item GetLogo(Item item)
        {
            if (item == null)
                return null;
            return item.GetAncestorOrSelfOfTemplate(Templates.Logo.ID) ?? Context.Site.GetContextItem(Templates.Logo.ID);
        }
    }
}
