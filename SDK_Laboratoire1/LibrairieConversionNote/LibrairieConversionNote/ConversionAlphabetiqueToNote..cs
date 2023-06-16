using System;

public class NoteTransformer
{
    public static string Transformer(string note)
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
                return "Saisie incorect. veuillez entrer une option valide";
        }
    }

    public static void Main()
    {
        while (true)
        {
            Console.Write("s'il vous plait, veuillez entrer une note alphabétique (A, B, C, D, E, F, G) : ");
            string input = Console.ReadLine();

            string note = Transformer(input);
            Console.WriteLine("La note qui correspond est : " + note);

            Console.WriteLine(); // C'est une igne vide pour séparer les résultats

            // Optionnel : fonction pour quitter la boucle si l'utilisateur entre "exit"
            if (input.ToLower() == "exit")
            {
                break;
            }
        }
    }
}
