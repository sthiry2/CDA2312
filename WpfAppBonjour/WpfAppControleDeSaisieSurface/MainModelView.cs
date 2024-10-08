using ClassLibraryPersonne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLibraryBoiteOutil;

namespace WpfAppControleDeSaisieSurface
{
    public class MainModelView : BaseModelView
    {
            private Personne personne;

            public MainModelView(Personne personne)
            {
                this.personne = personne;
            }


            public string Nom
            {
                get => personne.Nom;
                set
                {
                    personne.Nom = value;
                    //ValidateName(value);
                    this.OnPropertyChanged();

                }
            }

            public string Prenom
            {
                get => personne.Prenom;
                set
                {
                    personne.Prenom = value;
                    this.OnPropertyChanged();
                }
            }

            public int Age
            {
                get => personne.Age;
                set
                {
                    personne.Age = value;
                    this.OnPropertyChanged();
                }
            }

            public DateTime DateDeNaissance
            {
                set
                {
                    personne.Age = GetDatePassed(value)[1];
                    this.OnPropertyChanged();
                }
            }


            //private void ValidateName(string texte)
            //{
            //    ClearErrors(nameof(Nom));
            //    if (string.IsNullOrWhiteSpace(texte))
            //        AddError(nameof(Nom), "Le Nom ne peut être vide");
            //    if (!string.IsNullOrEmpty(texte) && (texte[0] != char.ToUpper(texte[0])))
            //        AddError(nameof(Nom), "La premier lettre du Nom doit etre une majuscule");
            //}

            internal static int[] GetDatePassed(DateTime pDate)
            {
                DateTime Date = pDate;
                TimeSpan Tampon = new TimeSpan(1, 0, 0, 0);
                int Day = 0, Month = 0, Year = 0, DataMonth = 0;

                while (Date.Date != DateTime.Now.Date)
                {
                    Date += Tampon;
                    DataMonth = Date.Month - 1;
                    if (DataMonth == 0) DataMonth = 12;
                    Day++;

                    if (Day >= 28 && DataMonth == 2)
                    {
                        if (Date.Year % 4 != 0 || (Date.Year % 100 == 0 && Date.Year % 400 != 0))
                        {
                            Day = 0; Month++;
                        }
                        if (Day == 29)
                        {
                            Day = 0; Month++;
                        }
                    }
                    else if (Day == 30 && (DataMonth == 4 || DataMonth == 6 || DataMonth == 9 || DataMonth == 11))
                    {
                        Day = 0; Month++;
                    }
                    else if (Day == 31)
                    {
                        Day = 0; Month++;
                    }

                    if (Month == 12)
                    {
                        Month = 0; Year++;
                    }
                }
                if (Day == 30 && (DataMonth == 4 || DataMonth == 6 || DataMonth == 9 || DataMonth == 11))
                {
                    Day = 0; Month++;
                }

                return new int[] { Day, Month, Year };
            }
        }
}
