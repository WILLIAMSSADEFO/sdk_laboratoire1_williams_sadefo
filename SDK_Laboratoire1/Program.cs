using System;

public class NoteTransformer
{
    public static string Transform(string note)
    {
        switch (note.ToUpper())
        {
            case "A":
                return "DO";
            case "B":
                return "RÉ";
            case "C":
                return "MI";
            case "D":
                return "FA";
            case "E":
                return "SOL";
            case "F":
                return "LA";
            case "G":
                return "SI";
            default:
                return "votre saisie est incorrecte. Veuillez entrer une option valide";
        }
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Quel type de conversion souhaitez-vous faire ?");
            Console.WriteLine("1. NOTE => alphabétique vers note");
            Console.WriteLine("2. QUITTER");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Veuillez entrer une note alphabétique entre (A, B, C, D, E, F, G) : ");
                string input = Console.ReadLine();

                string note = Transform(input);
                Console.WriteLine("La note correspondante est : " + note);

                Console.WriteLine(); // Ligne vide pour la sépareration des résultats
            }
            else if (choice == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("selction invalide. Veuillez entrer une option valide.");
                Console.WriteLine(); // Ligne vide pour la sépareration des résultats
            }
        }
    }
}
