using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMetier
{
    public class Transaction
    {
        double montant;

        public double Montant 
        { get => montant;
          set { montant = value; 
                if (montant == 10)
                {
                    OnDixEuros();
                }
            } 
        }

        public delegate void Modele10EurosAtteint(Transaction sender);
        public event Modele10EurosAtteint DixEurosAtteint;

        public Transaction(double montant)
        {
            this.Montant = montant;
        }

        public void Add1Euros()
        {
            this.Montant += 1;

        }

        private void OnDixEuros()
        {
            if (DixEurosAtteint != null)
            {
                DixEurosAtteint(this);
            }
        }
    }
}
