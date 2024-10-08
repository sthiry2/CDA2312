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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppControleDeSaisiePersonne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainModelView(new Personne());
            ((MainModelView)this.DataContext).PropertyChanged += MainWindow_PropertyChanged;
           
        }

        private void MainWindow_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.buttonALaSuite.IsEnabled = !((MainModelView)this.DataContext).HasErrors;
        }
    }
}
