using System.Web.Optimization;

namespace TeamExplorer
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // CSS used for the site
            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                "~/Content/bootstrap/bootstrap.css",
                "~/Content/bootstrap/bootstrap-responsive.css",
                "~/Content/site.css"
                ));

            // CSS used for the Chrome application
            bundles.Add(new StyleBundle("~/bootstrap/application/css").Include(
                "~/Content/application.css"
                ));

            // Javascript for the site
            bundles.Add(new ScriptBundle("~/bootstrap/js").Include(
                "~/Scripts/jquery-2.0.3.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/teamexplorer-paste-image.js"
                ));              
        }
    }
}