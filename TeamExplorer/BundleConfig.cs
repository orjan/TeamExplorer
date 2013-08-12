using System.Web.Optimization;
using Raven.Client.Linq;

namespace TeamExplorer
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bootstrap/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-responsive.css",
                "~/Content/custom.css"
                ));

            bundles.Add(new StyleBundle("~/bootstrap/application/css").Include(
                "~/Content/application.css"
                ));

            /*
            var bootstrapJs = new Bundle("~/bootstrap/js", new JsMinify());
            bootstrapJs.AddFile("~/Scripts/jquery-1.7.1.js");
            bootstrapJs.AddFile("~/Scripts/bootstrap-modal.js");
            bootstrapJs.AddFile("~/Scripts/jquery.validate.js");
            bootstrapJs.AddFile("~/Scripts/jquery.unobtrusive-ajax.js");
            bootstrapJs.AddFile("~/Scripts/jquery.validate.unobtrusive.js");
            //bootstrapJs.AddFile("~/js/prettify.js");
            */

        }
    }
}