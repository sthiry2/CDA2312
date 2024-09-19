using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTestUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //abonnement de la methode ucIdentification1_AuthentificationFailed sur l'evenement AuthentificationFailed
            this.ucIdentification1.AuthentificationFailed += new System.EventHandler(this.ucIdentification1_AuthentificationFailed);
        }


        //methode qui respecte le delagate EventHandler
        private void ucIdentification1_AuthentificationFailed(object sender, EventArgs e)
        {

        }
    }
}
