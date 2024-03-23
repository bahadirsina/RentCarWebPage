using System.Web;
using System.Web.Optimization;

namespace Rento
{
    public class BundleConfig
    {
        // Paketleme hakkında daha fazla bilgi için lütfen https://go.microsoft.com/fwlink/?LinkId=301862 adresini ziyaret edin
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JS dosyalarını birleştirme
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/bootstrap.bundle.min.js",
                "~/Scripts/custom.js",
                "~/Scripts/jquery-3.0.0.min.js",
                "~/Scripts/jquery.mCustomScrollbar.concat.min.js",
                "~/Scripts/jquery.min.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/plugin.js",
                "~/Scripts/popper.min.js"
            ));

            // CSS dosyalarını birleştirme
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/animate.css",
                "~/Content/bootstrap.min.css",
                "~/Content/jquery-ui.css",
                "~/Content/jquery.mCustomScrollbar.concat.min.css",
                "~/Content/meanmenu.css",
                "~/Content/nice-select.css",
                "~/Content/normalize.css",
                "~/Content/owl.carousel.min.css",
                "~/Content/responsive.css",
                "~/Content/slick.css",
                "~/Content/style.css"
            ));
        }
    }
}
