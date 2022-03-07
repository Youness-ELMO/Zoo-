using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace testt_zoo
{
    class zoo1
    {
        int tmax;
        static int tefectif=0;

         public static ArrayList an = new ArrayList();


        public zoo1(int cmax) { }


        public static void ajouter(Anim a)
        {

            an.Add(a);
            tefectif++;//tefectif=tefectif+1
        }

        public static void supp(string n)//declare un boucle qui peux teste sur tout les animaux
        {
            foreach(Anim a in an)
            {
                if (n == a.Nom)
                {
                    an.Remove(a);
                }
                break;
            }
            tefectif = an.Count;
        }

        public static void ChercherAnimal(string name)
        {
            foreach (Anim a in an)
            {
                if (a.Nom == name)
                {
                    Console.WriteLine(a.ToString());
                }

            }
        }

        public int MoyAge()
        {
            int s = 0;
            foreach(Anim a in an)
            {
                s = s + a.Age;
            }
            //il sort de la boucle pour faire la somme
            return s / an.Count;
        }

        public int Moypoids()
        {
            int s = 0;
            foreach (Anim a in an)
            {
                s = s + a.Poids;
            }
            
            return s / an.Count;
        }

        public static void chercherace(string rc)
        {
            int sage=0;
            int spoid=0;
            int cpt = 0;
            foreach(Anim a in an)
            {
                if (a.Race == rc)
                {
                    Console.WriteLine(a.affichage());
                    cpt++;
                    sage = sage + a.Age;
                    spoid = spoid + a.Poids;
                    //il va faire la somme des anm de meme race , meme poids et l'age
                }
            }
            
            Console.WriteLine("la moyenne d'age est"+sage / cpt);
            Console.WriteLine("la moyenne du poids est"+spoid / cpt);
        }

        public static void aff()
        {
            foreach(Anim a in an)
            {
                Console.WriteLine(a.affichage());
            }
        }

        public static void trieeage()
        {
            Anim c;
            for (int i = 0; i < an.Count; i++)
            {               
                for(int j = i + 1; j < an.Count; i++)
                {
                    Anim a = (Anim)an[i];
                    Anim b = (Anim)an[j];
                    if ((a.Age>b.Age)&&(a.Poids>b.Poids)) 
                    {
                        c = a;
                        a = b;
                        b = c;
                    }
                    
                }
            }
        }

        public static void triepoid()
        {
            Anim c;
            for (int i = 0; i < an.Count; i++)
            {
                for (int j = i + 1; j < an.Count; i++)
                {
                    Anim a = (Anim)an[i];
                    Anim b = (Anim)an[j];
                    if (a.Age > b.Age)  
                    {
                        c = a;
                        a = b;
                        b = c;
                    }

                }
            }
        }

    }
}
