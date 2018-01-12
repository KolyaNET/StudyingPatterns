using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;
using DotVVM.Framework.Routing;

namespace WebApplication
{
    public sealed class DotvvmStartup : IDotvvmStartup
    {
        // For more information about this class, visit https://dotvvm.com/docs/tutorials/basics-project-structure
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            ConfigureRoutes(config);
            ConfigureControls();
            ConfigureResources(config);
        }

        private static void ConfigureRoutes(DotvvmConfiguration config)
        {
            config.RouteTable.Add("Default", "", "Views/Pages/Default.dothtml");
	        config.RouteTable.Add("Singleton", "Singleton", "Views/Pages/Singleton.dothtml");
			config.RouteTable.AutoDiscoverRoutes(new DefaultRouteStrategy(config));    
        }

        private static void ConfigureControls()
        {
            // register code-only controls and markup controls
        }

        private static void ConfigureResources(DotvvmConfiguration config)
        {
            // register custom resources and adjust paths to the built-in resources
            config.Resources.Register("bootstrap-css", new StylesheetResource
            {
                Location = new UrlResourceLocation("~/lib/bootstrap/dist/css/bootstrap.min.css")
            });

            config.Resources.Register("bootstrap-theme", new StylesheetResource
            {
                Location = new UrlResourceLocation("~/lib/bootstrap/dist/css/bootstrap-theme.min.css"),
                Dependencies = new[] { "bootstrap-css" }
            });

	        config.Resources.Register("navbar-css", new StylesheetResource
	        {
		        Location = new UrlResourceLocation("~/site/navbar.css"),
		        Dependencies = new[] { "bootstrap-css" }
	        });

			config.Resources.Register("bootstrap", new ScriptResource
            {
                Location = new UrlResourceLocation("~/lib/bootstrap/dist/js/bootstrap.min.js"),
                Dependencies = new[] { "bootstrap-css", "navbar-css", "jquery" }
            });

            config.Resources.Register("jquery", new ScriptResource
            {
                Location = new UrlResourceLocation("~/lib/jquery/dist/jquery.min.js")
            });
        }
    }
}
