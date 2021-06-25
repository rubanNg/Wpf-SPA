using SharpSPA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfSPAProject.Pages;
using SharpSPA;

namespace WpfSPAProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SpaApplication.Initialize(new SharpSPA.Models.SpaOptions()
            {
                Routes = new List<SharpSPA.Models.Route>()
                {
                    new SharpSPA.Models.Route() { Page = Router.SPAPage<Home>(), Path = "/" },
                    new SharpSPA.Models.Route() {
                        Page = Router.SPAPage<About>(),
                        Path = "about", 
                        Data = new Dictionary<string, object>()
                        {
                            { "keyStrings", new { key = new List<string>(){ "string1", "string2" } } },
                        }
                    }
                },
                RouterOutletName = "RouterOulet"
            }); ; ;
        }

        private void RedirectHome(object sender, RoutedEventArgs e)
        {
            Router.Navigate("/", new { title = "Home Title" });
        }

        private void RedirectAbout(object sender, RoutedEventArgs e)
        {
            Router.Navigate("about", new { title = "About Title", lableValue = "About lable text" });
        }
    }
}
