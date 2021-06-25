using SharpSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SharpSPA
{
    public class Router
    {

        static public void Navigate(string path, object passValues = null)
        {
            var findedRoute = SpaApplication.routes.FirstOrDefault(route => route.Path.ToLower() == path.ToLower());

            Type page = null;
            if (findedRoute != null) { page = findedRoute.Page;  }
            if (findedRoute == null) new Exception($"{path} not found");

            var frame = SpaApplication.routerOutlet.FindName("RouterOutletFrame") as Frame;

            frame.Content = (Page)Activator.CreateInstance(page, passValues, findedRoute.Data);
        }

        static public Type SPAPage<DynamicPage>() where DynamicPage: Page, new()
        {
            return new DynamicPage().GetType();
        }


    }
}
