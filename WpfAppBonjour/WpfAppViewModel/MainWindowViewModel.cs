using ClassLibraryPersonne;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WpfAppViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Personne personne;

        public MainWindowViewModel(Personne personne)
        {
            this.personne = personne;
        }


        public string Nom
        {
            get => personne.Nom;
            set
            {
                personne.Nom = value;
                //this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(MainWindowViewModel.Nom));
            }
        }

        public string Prenom
        {
            get => personne.Prenom;
            set
            {
                personne.Prenom = value;
                //this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(MainWindowViewModel.Prenom));
            }
        }

        public int Age
        {
            get => personne.Age;
            set
            {
                personne.Age = value;
                //this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(MainWindowViewModel.Age));
            }
        }

        public string Mdp
        {
            get => personne.Mdp;
            set
            {
                personne.Mdp = value;
                //this.OnPropertyChanged();
                this.OnPropertyChanged(nameof(MainWindowViewModel.Mdp));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        /*
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        */
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
