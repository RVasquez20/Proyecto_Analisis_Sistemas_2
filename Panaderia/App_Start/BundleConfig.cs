using System.Web;
using System.Web.Optimization;

namespace Panaderia
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios.  De esta manera estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            var Bootstrap5CDNSCRIPTS = "https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js";
            var Bootstrap5CDN = "https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css";
            bundles.Add(new ScriptBundle("~/bundles/bootstrap", Bootstrap5CDNSCRIPTS).Include(
                      "~/Scripts/bootstrap.js"));
            
            bundles.Add(new StyleBundle("~/Content/css", Bootstrap5CDN).Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
