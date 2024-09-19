using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FControlLesMiens
{
    public partial class UCIdentification : UserControl
    {
        string messageDErreur;
        //declaration de l'evenement
        public event EventHandler Authentificated;
        public event EventHandler AuthentificationFailed;


        public UCIdentification()
        {
            InitializeComponent();
        }

       /* [Browsable(true)]
        [DefaultValue("Identifiant ou Mot de passe incorrect.")]*/
        public string MessageDErreur { get => messageDErreur; set => messageDErreur = value; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.textBoxId.Text == this.textBoxMDP.Text)
            {
                this.errorProviderId.Clear();
                //declenchement de l'evenement
                if (Authentificated != null)
                {
                    Authentificated(this, new EventArgs());
                }


            }
            else
            {
                this.errorProviderId.SetError(this, messageDErreur);
                //declenchement de l'evenement
                AuthentificationFailed?.Invoke(this, EventArgs.Empty);

            }
        }
    }
}
