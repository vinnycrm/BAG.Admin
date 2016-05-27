using System.Web;
using System.Web.Optimization;

namespace Admin
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/moment.min.js",
                        "~/Scripts/daterangepicker.js",
                        "~/Scripts/chart.min.js",
                        "~/Scripts/jquery.sparkline.min.js",
                        "~/Scripts/custom.js",
                        "~/Scripts/curvedLines.js",
                        "~/Scripts/date.js",
                        "~/Scripts/jquery-1.js",
                        "~/Scripts/jquery.flot.js",
                        "~/Scripts/jquery.flot.orderBars.js",
                        "~/Scripts/jquery.flot.pie.js",
                        "~/Scripts/jquery.flot.resize.js",
                        "~/Scripts/jquery.flot.spline.js",
                        "~/Scripts/jquery.flot.stack.js",
                        "~/Scripts/jquery.flot.time.min.js",
                        "~/Scripts/pace.min.js",
                        "~/Scripts/vinay.js",
                       "~/Scripts/icheck.min.js",
                       "~/Scripts/jquery-ui.js",
                       "~/Scripts/jquery-1.10.2.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/madancustom.css", 
                      "~/Content/animate.min.css",
                      "~/Content/jquery-jvectormap-2.0.3.css",
                      "~/Content/green.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/floatexamples.css",
                      "~/Content/custom.css"));
            // This is user to bundle the files as single file while releasing the product
            //BundleTable.EnableOptimizations = true;
        }
    }
}
