using System.Web;
using System.Web.Optimization;

namespace TravellinDollarWebAPI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/lib/startbootstrap-landing-page/vendor/bootstrap/js/bootstrap.bundle.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/lib/startbootstrap-landing-page/css/landing-page.css",
                      "~/lib/startbootstrap-landing-page/vendor/bootstrap/css/bootstrap.css",
                      "~/lib/startbootstrap-landing-page/vendor/fontawesome-free/css/all.css",
                      "~/lib/startbootstrap-landing-page/vendor/simple-line-icons/css/simple-line-icons.css"));

        }
    }
}
