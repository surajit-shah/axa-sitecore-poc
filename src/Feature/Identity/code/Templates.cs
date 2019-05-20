namespace Mirabeau.Feature.Identity
{
    using Sitecore.Data;

    public struct Templates
    {
        public struct Identity
        {
            // TODO: Provide Sitecore ID of template
            // public static readonly ID ID = new ID("");

            public struct Fields
            {
                // TODO: Declare variables for Identity template fields
            }
        }
        public struct Logo
        {
            public static readonly ID ID = new ID("{B8933C97-EFF6-4456-81C1-AD6AA0F67893}");

            public struct Fields
            {
                public static readonly ID MainLogo = new ID("{3E9DFC10-4FE7-40DC-9241-2B629A61BCFF}");
                public static readonly ID SecondaryLogo = new ID("{0DEF25CC-514F-4764-8381-2F5C693E874C}");
            }
        }
    }
}
