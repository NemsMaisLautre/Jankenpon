using System;
using System.Threading;

string ValeurUser, ValeurBot;
int ScorePlayer = 0;
int ScoreBot = 0;
bool PlayAgain = true;
int RandomInt;

while(PlayAgain)
{
    Console.WriteLine("Pierre, Feuille, Ciseaux !");
    Console.WriteLine("---------------------------------");

    Console.WriteLine("Hello et bienvenue dans ce jeux de Jankenpon ! (Pierre Feuille Ciseaux)");
    Thread.Sleep(3000);

    Console.WriteLine("Dans ce jeux, tu devras choisir entre Pierre (p), Feuille(f) et Ciseaux(c) !");
    Thread.Sleep(3000);

    Console.WriteLine("Commençons sans plus tarder ! Choisis une option parmis celles présentes :");
    Console.WriteLine("\t-PIERRE pour Pierre");
    Console.WriteLine("\t-FEUILLE pour Feuille");
    Console.WriteLine("\t-CISEAUX pour Ciseaux");

    ValeurUser = Convert.ToString(Console.ReadLine());
    ValeurUser = ValeurUser.ToUpper();
    Console.WriteLine("Ta valeur est donc " + ValeurUser + " !");

    Random rnd = new Random();

    RandomInt = rnd.Next(1, 4);

    switch (RandomInt)
    {
        case 1:
            
                ValeurBot = "PIERRE";
                Console.WriteLine("L'ordinateur a choisi PIERRE !");
                Console.WriteLine("Chargement des résultats...\n\n");
                Thread.Sleep(2000);
                    if(ValeurUser == "PIERRE")
                {
                    Console.WriteLine("Égalité ! Les deux joueurs ont choisi PIERRE !\n\n");
                }

                else if(ValeurUser == "FEUILLE")
                {
                    Console.WriteLine("Le joueur a gagné !\n\n");
                    ScorePlayer++;

                }
                else if(ValeurUser =="CISEAUX")
                {
                    Console.WriteLine("Le joueur a perdu !\n\n");
                    ScoreBot++;
                }

            break;

        case 2:

            ValeurBot = "FEUILLE";
            Console.WriteLine("L'ordinateur a choisi FEUILLE !");
            Console.WriteLine("Chargement des résultats...\n\n");
            Thread.Sleep(2000);
            if (ValeurUser == "PIERRE")
            {
                Console.WriteLine("Le joueur a perdu !\n\n");
                ScoreBot++;
            }

            else if (ValeurUser == "FEUILLE")
            {
                Console.WriteLine("Égalité ! Les deux joueurs ont choisi FEUILLE !\n\n");
                

            }
            else if (ValeurUser == "CISEAUX")
            {
                Console.WriteLine("Le joueur a gagné !\n\n");
                ScorePlayer++;
            }
            break;

        case 3:

            ValeurBot = "CISEAUX";
            Console.WriteLine("L'ordinateur a choisi CISEAUX !");
            Console.WriteLine("Chargement des résultats...\n\n");
            Thread.Sleep(2000);
            if (ValeurUser == "PIERRE")
            {
                Console.WriteLine("Le joueur a gagné !\n\n");
                ScorePlayer++;
            }

            else if (ValeurUser == "FEUILLE")
            {
                Console.WriteLine("Le joueur a perdu !\n\n");
                ScoreBot++;

            }
            else if (ValeurUser == "CISEAUX")
            {
                Console.WriteLine("Égalité ! Les deux joueurs ont choisi FEUILLE !\n\n");
                
            }
            break;

         default:
            Console.WriteLine("Entrée invalide !");
            break;
    }

    Console.WriteLine("Chargement des scores...");
    Thread.Sleep(2000);
    Console.WriteLine("Voici les scores : \n\t-Joueur : {0} !\n\t-Bot : {1} !", ScorePlayer, ScoreBot);

    if (ScorePlayer > ScoreBot)
    {
        Console.WriteLine("Le joueur a gagné !");
    }

    else if (ScoreBot > ScorePlayer)
    {
        Console.WriteLine("Le bot a gagné !");
    }

    else
    {

    }

    Console.WriteLine("Voulez-vous rejouer ? (y/n)");
    string loop = Console.ReadLine();
    if (loop == "y")
    {
        PlayAgain = true;
        Console.Clear();

    }
    else if (loop == "n")
    {
        PlayAgain = false;
    }
    else
    {
        Console.WriteLine("Égalité parfaite !");
    }
}