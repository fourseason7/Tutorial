using System.Web;
using System.Web.Optimization;

namespace EddyHomePage
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/eddyhome/css").Include(
                  "~/assets/vendor/bootstrap/css/bootstrap.min.css",
                  "~/assets/vendor/fontawesome/css/font-awesome.min.css",
                  "~/assets/vendor/flaticons/flaticon.css",
                  "~/assets/vendor/hover/css/hover-min.css",
                  "~/assets/vendor/wow/animate.css",
                  "~/assets/vendor/mfp/css/magnific-popup.css",
                  "~/assets/custom/css/style.css"));

            bundles.Add(new ScriptBundle("~/eddyhome/js").Include(
                 "~/assets/vendor/jquery/js/jquery-2.2.0.min.js",
                 "~/assets/vendor/bootstrap/js/bootstrap.min.js",
                 "~/assets/vendor/imagesloaded/js/imagesloaded.pkgd.min.js",
                 "~/assets/vendor/isotope/js/isotope.pkgd.min.js",
                 "~/assets/vendor/mfp/js/jquery.magnific-popup.min.js",
                 "~/assets/vendor/circle-progress/circle-progress.js",
                 "~/assets/vendor/waypoints/waypoints.min.js",
                 "~/assets/vendor/anicounter/jquery.counterup.min.js",
                 "~/assets/vendor/wow/wow.min.js",
                 "~/assets/vendor/pjax/jquery.pjax.js",
                 "~/assets/custom/js/custom.js"));
        }
    }
}
