using System.Web;
using System.Web.Optimization;

namespace Dashboard
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/script/modernizr").Include("~/Assets/Scripts/modernizr-*"));
        }
    }
}