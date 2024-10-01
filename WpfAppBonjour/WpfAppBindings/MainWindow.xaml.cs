using ClassLibraryPersonne;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfAppBindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Personne("LeFantome", "Casper", 10, "booh");
        }

        private void ButtonAge_Click(object sender, RoutedEventArgs e)
        {
            ((Personne)this.DataContext).Age++;
            Debug.WriteLine($"Age : {((Personne)this.DataContext).Age}");
        }
    }
}
