using System.Web;
using System.Web.Optimization;

namespace WebConsultaSGTD
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Public/css").Include(
                       //<!-- Bootstrap 3.3.7 -->
                      "~/Public/components/bootstrap/dist/css/bootstrap.min.css",
                     //< !--Font Awesome-- >
                     //"~/Public/components/font-awesome/css/font-awesome.min.css",
                      //< !--Ionicons-- >
                      //"~/Public/components/Ionicons/css/ionicons.min.css",

                      //<!-- Toastr Css -->
                      "~/Public/components/toastr/toastr.css",

                      //< !--Theme style-- >
                      "~/Public/dist/css/AdminLTE.min.css",
                      //< !--AdminLTE Skins.Choose a skin from the css/ skins-- >
                      "~/Public/dist/css/skins/_all-skins.min.css"));
            
            bundles.Add(new ScriptBundle("~/Public/js").Include(
                        //<!-- jQuery 3 -->
                        "~/Public/components/jquery/dist/jquery.min.js",
                        //<!-- Bootstrap 3.3.7 -->
                        "~/Public/components/bootstrap/dist/js/bootstrap.min.js",
                        //<!-- SlimScroll -->
                        "~/Public/components/jquery-slimscroll/jquery.slimscroll.min.js",
                        //<!-- FastClick -->
                        "~/Public/components/fastclick/lib/fastclick.js",
                         //<!--ToasTr JS-->
                         "~/Public/components/toastr/toastr.js",

                         
                        //<!-- AdminLTE App -->
                        "~/Public/dist/js/adminlte.min.js",
                        //<!-- AdminLTE for demo purposes -->
                        "~/Public/dist/js/demo.js",

                        //Personalizados
                        "~/Public/dist/js/Message.js",
                        "~/Public/dist/js/Time.js"
                        ));

            //bundles.FileSetOrderList.Clear();
            //BundleTable.EnableOptimizations = false;
        }
    }
}
