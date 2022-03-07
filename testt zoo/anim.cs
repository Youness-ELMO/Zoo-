using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testt_zoo
{
    public class Anim
    {
         int num;
         string nom;
         string race;
         int age;
         int poids;
         static int nb=0;

        public Anim()
        {
            this.nom = "Inconnu";
            this.race = "Inconnu";
            nb++;
        }

        public Anim(int num, string nom, string race, int age, int poids)
        {
            this.num = num;
            this.nom = nom;
            this.race = race;
            this.age = age;
            this.poids = poids;
            nb++;
        }

        public Anim(Anim A)
        {
            this.num = A.num;
            this.nom = A.nom;
            this.race = A.race;
            this.age = A.age;
            this.poids = A.poids;
            nb++;
        }


        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Race
        {
            get { return race; }
            set { race = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        
        public string affichage()
        {
            return "le num est: " + num + "\ble nom est: " + nom + "\bla race est: " + race +  "\b l'age est: " + age +  "\ble poids est: " + poids +  "\ble nombre est: " + nb;
        }

        public bool equals(Anim A)
        {
            if ((this.age == A.Age)&& (this.poids == A.poids))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void incrementeage()
        {
            age++;
        }

        public void incrementepoids(int p)
        {
            poids = poids + p;
        }


    }
}
