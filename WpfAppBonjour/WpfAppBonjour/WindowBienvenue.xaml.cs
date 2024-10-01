using ClassLibraryPersonne;
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
using System.Windows.Shapes;

namespace WpfAppBonjour
{
    /// <summary>
    /// Logique d'interaction pour WindowBienvenue.xaml
    /// </summary>
    public partial class WindowBienvenue : Window
    {
        internal WindowBienvenue()
        {
            InitializeComponent();
        }

        public WindowBienvenue(Personne p):this()
        {
            this.DataContext = p;
        }
    }
}
