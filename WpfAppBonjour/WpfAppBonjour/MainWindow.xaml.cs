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
using ClassLibraryPersonne;

namespace WpfAppBonjour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //TextBox t = (TextBox)this.grid.Children[3];
            //t.TextChanged += T_TextChanged;


            this.DataContext = new Personne("LeFantome", "Casper",10,"booh");
        }


        private void textBoxMdp_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.textBoxMdp.Text != ((Personne)this.DataContext).Mdp)
            {
                return;
            }

            Application.Current.MainWindow = new WindowBienvenue((Personne)this.DataContext);
            Application.Current.MainWindow.Show();
            this.Close();
        }

    }
}
