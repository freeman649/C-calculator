using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenue dans l'application de calculatrice console C#. Appuyez sur une touche pour continuer...");
        Console.ReadKey();

        // Déclarer les variables
        bool calculEnCours = true;
        float valeurBase = 0;
        float valeur2 = 0;
        string? saisie1, saisie2;

        // Saisir la première valeur et vérifier si elle est valide
        Console.WriteLine("Entrez un nombre :");
        saisie1 = Console.ReadLine();

        if (!float.TryParse(saisie1, out valeurBase))
        {
            Console.WriteLine("Entrée invalide. Veuillez entrer un nombre valide.");
            return;
        }

        while (calculEnCours)
        {
            // Choisir un opérateur
            Console.WriteLine("Entrez un opérateur : Addition +, Soustraction -, Multiplication *, Division /");
            string? oper = Console.ReadLine();

            // Saisir la deuxième valeur et vérifier si elle est valide
            Console.WriteLine("Entrez un autre nombre :");
            saisie2 = Console.ReadLine();

            if (!float.TryParse(saisie2, out valeur2))
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un nombre valide.");
                return;
            }

            // Calculer le résultat et réassigner valeurBase
            switch (oper)
            {
                case "+":
                    valeurBase += valeur2;
                    break;
                case "-":
                    valeurBase -= valeur2;
                    break;
                case "*":
                    valeurBase *= valeur2;
                    break;
                case "/":
                    if (valeur2 != 0)
                    {
                        valeurBase /= valeur2;
                    }
                    else
                    {
                        Console.WriteLine("Erreur : Division par zéro.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Vous avez entré un opérateur invalide.");
                    continue;
            }

            Console.WriteLine($"Résultat : {valeurBase}");

            // Demander à l'utilisateur s'il veut continuer
            Console.WriteLine("Voulez-vous continuer ? (yes/y pour continuer)");
            string? res = Console.ReadLine()?.ToLower();

            if (res != "yes" && res != "y")
            {
                calculEnCours = false;
                Console.WriteLine($"Le résultat final est {valeurBase}");
            }
        }

        Console.WriteLine("Fermeture de l'application");
    }
}
