namespace ClassLibraryPersonne
{
    public class Personne
    {
        private string nom;
        private string prenom;
        private string mdp;
        private int age;

        public Personne(string nom, string prenom, int age,string mdp)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.mdp = mdp;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }
        public string Mdp { get => mdp; set => mdp = value; }
    }
}