using SharpSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SharpSPA
{
    public class SpaApplication
    {
        static public List<Route> routes = null;
        static Window window = null;
        static string routerOutletName = null;
        public static RouterOutlet routerOutlet;

        static public void Initialize(SpaOptions options)
        {
            var windows = Application.Current.Windows.Cast<Window>();


            if (windows.Count() > 1) window = windows.FirstOrDefault(win => win.Name == "SpaWindow");
            else window = windows.FirstOrDefault();

            if (window == null) 
            {
                new EntryPointNotFoundException("Applciation window not found! Please create window with specify name \"SpaWindow\"");
            }

            routes = options.Routes;
            routerOutletName = options.RouterOutletName;
            GetRouterOutlet();
        }


        private static void GetRouterOutlet() 
        {
            if (routerOutletName == null) 
            {
                new InvalidOperationException("Add \"Name\" attribute for you RouterOutlet control.");
            }
            routerOutlet = window.FindName(routerOutletName) as RouterOutlet;
        }
    }

}
