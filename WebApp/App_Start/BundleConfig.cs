using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterBundlesCss(bundles);
            RegisterBundlesJavaScript(bundles);
        }

        private static void RegisterBundlesCss(BundleCollection bundles)
        {
            RegisterBundleCssLayout(bundles);
        }
        private static void RegisterBundleCssLayout(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/CSS/styles").Include(
                "~/Content/CSS/reset.css",
                "~/Content/CSS/bullets.css",
                "~/Content/CSS/icons.css",
                "~/Content/CSS/structure.css",
                "~/Content/CSS/loginBar.css",
                "~/Content/CSS/header.css",
                "~/Content/CSS/cart.css",
                "~/Content/CSS/search.css",
                "~/Content/CSS/mainMenu.css",
                "~/Content/CSS/mainContent.css",
                "~/Content/CSS/categoriesNavigation.css",
                "~/Content/CSS/breadcrumb.css",
                "~/Content/CSS/facebox.css",
                "~/Content/CSS/productsList.css",
                "~/Content/CSS/footer.css",
                "~/Content/CSS/siteMap.css",
                "~/Content/CSS/socialNetworks.css",
                "~/Content/CSS/titles.css",
                "~/Content/CSS/orderDone.css",
                "~/Content/CSS/forms.css",
                "~/Content/CSS/faq.css",
                "~/Content/CSS/snippets.css",
                "~/Content/CSS/tables.css",
                "~/Content/CSS/buttons.css",
                "~/Content/CSS/modal.css",
                "~/Content/CSS/modalFeedback.css",
                "~/Content/CSS/clearFix.css",
                "~/Content/CSS/updateIE.css",
                "~/Content/CSS/loading.css",
                "~/Content/CSS/carousel.css",
                "~/Content/CSS/jquery.rating.css"
            ));
        }

        private static void RegisterBundlesJavaScript(BundleCollection bundles)
        {
            RegisterBundleJsJQuery(bundles);
            RegisterBundleJsShared(bundles);
            RegisterBundleJsRegisterUser(bundles);
            RegisterBundleJsEditUser(bundles);
            RegisterBundleJsForgotPassword(bundles);
            RegisterBundleJsFeedback(bundles);
            RegisterBundleJsContactUs(bundles);
            RegisterBundleJsFrequentlyAsked(bundles);
            RegisterBundleJsProduct(bundles);
            RegisterBundleJsBasket(bundles);
        }
        private static void RegisterBundleJsJQuery(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/JQuery/jquery").Include(
                "~/Scripts/JQuery/jquery-1.9.1.min.js",
                "~/Scripts/JQuery/accounting.min.js",
                "~/Scripts/JQuery/jquery.maskedinput-1.3.1.min.js",
                "~/Scripts/JQuery/jquery.lightbox-0.5.min.js",
                "~/Scripts/JQuery/jquery.validate.min.js",
                "~/Scripts/JQuery/plugins.min.js",
                "~/Scripts/JQuery/modernizr.js",
                "~/Scripts/JQuery/jquery.cookie.js",
                "~/Scripts/JQuery/jquery.anoslide.js"
            ));
        }

        private static void RegisterBundleJsShared(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Views/Shared/shared").Include(
                "~/Scripts/Views/Shared/ajax.js",
                "~/Scripts/JQuery/jquery.anoslide.js",
                "~/Scripts/Views/Shared/carousel.js",
                "~/Scripts/Views/Shared/validateFields.js",
                "~/Scripts/Views/Shared/login.js",
                "~/Scripts/Views/Shared/modal.js",
                "~/Scripts/Views/Shared/forgotPassword.js",
                "~/Scripts/Views/Shared/cart.js",
                "~/Scripts/Views/Home/index.js",
                "~/Scripts/Views/Shared/analytics.js"
                ));
        }

        private static void RegisterBundleJsProduct(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Product/product").Include(
                "~/Scripts/JQuery/jquery.jscroll.js",
             //   "~/Scripts/JQuery/jquery.rating.js",
                "~/Scripts/Views/Product/products.js"
            ));
        }


        private static void RegisterBundleJsBasket(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Basket/basket").Include(
                "~/Scripts/JQuery/jquery.priceformat-2.0.min.js",
                "~/Scripts/Views/Shared/mask.js",
                "~/Scripts/Views/Basket/index.js"
                ));
        }


        private static void RegisterBundleJsContactUs(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/ContactUs/contactUs").Include(
                "~/Scripts/Views/ContactUs/index.js"
            ));
        }

        private static void RegisterBundleJsFeedback(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Feedback/feedback").Include(
                "~/Scripts/Views/Home/modalFeedback.js"
            ));
        }

        private static void RegisterBundleJsFrequentlyAsked(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/FrequentlyAsked/frequentlyAsked").Include(
                "~/Scripts/Views/FrequentlyAsked/Index.js"
            ));
        }

        private static void RegisterBundleJsRegisterUser(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/RegisterUser/registerUser").Include(
                "~/Scripts/Views/Account/user.js",
                "~/Scripts/Views/Account/register.js"
            ));
        }

        private static void RegisterBundleJsEditUser(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/EditUser/editUser").Include(
                "~/Scripts/Views/Account/user.js",
                "~/Scripts/Views/Account/registerEdit.js",
                "~/Scripts/Views/Account/editPassword.js"
            ));
        }
        //private static void RegisterBundleJsEditUser(BundleCollection bundles)
        //{
        //    bundles.Add(new ScriptBundle("~/Scripts/EditUser/editPassword").Include(
        //        "~/Scripts/Views/Account/editPassword.js"
        //        ));
        //}

        private static void RegisterBundleJsForgotPassword(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/ForgotPassword/forgotPassword").Include(
                "~/Scripts/Views/Account/forgotPassword.js"
            ));
        }

    }
}