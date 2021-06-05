using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviseWinForm
{
    class Client
    {
            private string nom;
            private string prenom;
            private string adresse;
        static int cpt = 0;
            //private List<Compte> lesComptes;


            public Client(string n, string p, string a)
            {
                this.nom = n;
                this.prenom = p;
                this.adresse = a;
                //this.lesComptes = new List<Compte>();

            }
            public void afficher()
            {
                Console.WriteLine(this.ToString());
               /* foreach (Compte c in lesComptes)
                {
                    c.consulter();
                }*/

            }


            public override string ToString()
            {
                return " le nom est : " + this.nom + " " + this.prenom + " " + this.adresse;
            }

        public string enregistrer()
        {
            return "insert into Client values('" + +cpt++ + "','" + this.nom + "','" + this.prenom + "','" + this.adresse + "')";
        }

        /* public void affecter(Compte c)
         {
             this.lesComptes.Add(c);
         }*/
    }
    }

