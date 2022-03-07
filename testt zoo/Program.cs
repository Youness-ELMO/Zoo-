using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testt_zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;
            do
            {
                Console.WriteLine("1 : Ajouter un animal.\n2 : Chercher un animal.\n3 : Supprimer un animal.\n4 : Afficher un animal.\n5 : Afficher tous les animaux.\n6 : Afficher tous les animaux triés suivant l’âge.\n7 : Afficher tous les animaux triés suivant le poids.\n8 : … \n9 : Quitter.");

                Console.WriteLine("entrer votre choix: ");
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:

                        Anim a = new Anim();
                        Console.WriteLine("entrer le num: ");
                        a.Num = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrer le nom: ");
                        a.Nom = Console.ReadLine();
                        Console.WriteLine("entrer la race: ");
                        a.Race = Console.ReadLine();
                        Console.WriteLine("entrer l'age: ");
                        a.Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrer le poids");
                        a.Poids = int.Parse(Console.ReadLine());

                        zoo1.ajouter(a);
                        break;

                    case 2:
                        string name = Console.ReadLine();
                        zoo1.ChercherAnimal(name);
                        break;


                    case 3:
                        string n = Console.ReadLine();
                        zoo1.supp(n);
                        break;

                    case 4:
                        string rc = Console.ReadLine();
                        zoo1.chercherace(rc);
                        break;

                    case 5:
                        zoo1.aff();
                        break;

                    case 6:
                        zoo1.trieeage();
                        break;

                    case 7:
                        zoo1.triepoid();
                        break;

                    case 8:
                        Console.WriteLine("......");
                        break;

                    case 9:
                        Console.WriteLine("Quitter");
                        break;

                    default:
                        Console.WriteLine("choix non valide !");
                        break;
                }
                
            }while (choix != 9);
            Console.ReadKey();
        }
        
    }
}
