using System;
using System.Web.Optimization;

namespace searchtactics.Web.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            var path = string.Empty;

            bundles.Add(new ScriptBundle("~/bundles/jquery", path + "/bundles/jquery?v=" + Guid.NewGuid()).Include(
                "~/Scripts/jquery/jquery-2.1.3.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular", path + "/bundles/angular?v=" + Guid.NewGuid()).Include(
                "~/Scripts/angular/angular.js",
                "~/Scripts/libs/ng-infinite-scroll.js",
                "~/Scripts/libs/lazy-image.js",
                "~/Scripts/libs/bindonce.js",
                "~/Scripts/libs/ui-unique.js",
                "~/Scripts/libs/angular-vs-repeat.js"));

            bundles.Add(new ScriptBundle("~/bundles/searchtactics", path + "/bundles/searchtactics?v=" + Guid.NewGuid()).Include(
                    "~/Scripts/app/st.*"));

            BundleTable.EnableOptimizations = true;
        }
    }
}