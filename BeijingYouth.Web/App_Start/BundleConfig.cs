using System.Web;
using System.Web.Optimization;

namespace BeijingYouth.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //plugins/sparkline/jquery.sparkline.min.js
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                                  "~/Scripts/bootstrap.min.js",
                                  "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/LTEAll").Include(
                        "~/Content/plugins/jQueryUI/jquery-ui.min.js",
                        "~/Content/dist/js/raphael-min.js",
                        "~/Content/plugins/morris/morris.min.js",
                        "~/Content/plugins/sparkline/jquery.sparkline.min.js",
                        "~/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        "~/Content/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                        "~/Content/plugins/knob/jquery.knob.js",
                        "~/Content/dist/js/moment.min.js",
                        "~/Content/plugins/daterangepicker/daterangepicker.js",
                        "~/Content/plugins/datepicker/bootstrap-datepicker.js",
                        "~/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                        "~/Content/plugins/slimScroll/jquery.slimscroll.min.js",
                        "~/Content/plugins/fastclick/fastclick.min.js",
                        "~/Content/dist/js/app.min.js",
                        "~/Content/dist/js/pages/dashboard.js",
                        "~/Content/dist/js/demo.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/Css/ionicons.min.css",
                      "~/Content/Css/font-awesome.min.css",
                      "~/Content/dist/css/AdminLTE.min.css",
                      "~/Content/dist/css/skins/_all-skins.min.css",
                      "~/Content/plugins/iCheck/flat/blue.css",
                      "~/Content/plugins/morris/morris.css",
                      "~/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                      "~/Content/plugins/datepicker/datepicker3.css",
                      "~/Content/plugins/daterangepicker/daterangepicker-bs3.css",
                      "~/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                      "~/Content/site.css"));
            BundleTable.EnableOptimizations = false;

        }
    }
}
