using System.Web;
using System.Web.Optimization;

namespace MSS.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Boss Theme Files/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/queryLoader").Include(
                        "~/Boss Theme Files/js/queryloader2.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bossScripts").Include(
                      "~/Scripts//Boss Theme Files/js/jquery.hoverIntent.min.js",
                      "~/Boss Theme Files/js/jquery.nicescroll.min.js",
                      "~/Boss Theme Files/js/waypoints.min.js",
                      "~/Boss Theme Files/js/waypoints-sticky.min.js",
                      "~/Boss Theme Files/js/jquery.debouncedresize.js",
                      "~/Boss Theme Files/js/retina.min.js",
                      "~/Boss Theme Files/js/jquery.themepunch.tools.min.js",
                      "~/Boss Theme Files/js/jquery.themepunch.revolution.min.js",
                      "~/Boss Theme Files/js/owl.carousel.min.js",
                      "~/Boss Theme Files/js/isotope.pkgd.min.js",
                      "~/Boss Theme Files/js/skrollr.min.js",
                      "~/Boss Theme Files/js/jquery.magnific-popup.min.js",
                      "~/Boss Theme Files/js/jquery.countTo.js",
                      "~/Boss Theme Files/js/jquery.validate.min.js",
                      "~/Boss Theme Files/js/contact.js",
                      "~/Boss Theme Files/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Boss Theme Files/css/animate.css",
                      "~/Boss Theme Files/css/bootstrap.min.css",
                      "~/Boss Theme Files/css/magnific-popup.css",
                      "~/Boss Theme Files/css/style.css",
                      "~/Boss Theme Files/css/revslider/revslider-index33.css",
                      "~/Boss Theme Files/css/colors/darkblue.css",
                      "~/Content/font-awesome.min.css"));
        }
    }
}
