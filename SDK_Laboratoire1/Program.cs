using System;

class ConvertisseurNote
{
    static string ConvertirNote(string noteAlphabetique)
    {
        switch (noteAlphabetique.ToUpper())
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
                return "Note invalide";
        }
    }

    static string ConvertirNoteAlphabetique(string noteSyllabe)
    {
        switch (noteSyllabe.ToUpper())
        {
            case "DO":
                return "A";
            case "RÉ":
                return "B";
            case "MI":
                return "C";
            case "FA":
                return "D";
            case "SOL":
                return "E";
            case "LA":
                return "F";
            case "SI":
                return "G";
            default:
                return "Note invalide";
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Quel type de conversion souhaitez-vous faire ?");
            Console.WriteLine("1. NOTE (Note vers alphabétique)");
            Console.WriteLine("2. ALPHABÉTIQUE (Alphabétique vers note)");
            Console.WriteLine("3. QUITTER");

            string choix = Console.ReadLine();

            if (choix == "1")
            {
                while (true)
                {
                    Console.WriteLine("Veuillez entrer la note syllabe à convertir (DO, RÉ, MI, FA, SOL, LA, SI) :");
                    string noteSyllabe = Console.ReadLine();

                    string noteAlphabetique = ConvertirNoteAlphabetique(noteSyllabe);
                    Console.WriteLine($"La note alphabétique correspondante est : {noteAlphabetique}");
                }
            }
            else if (choix == "2")
            {
                while (true)
                {
                    Console.WriteLine("Veuillez entrer la note alphabétique à convertir (A, B, C, D, E, F, G) :");
                    string noteAlphabetique = Console.ReadLine();

                    if (noteAlphabetique.Length != 1 || !"ABCDEFG".Contains(noteAlphabetique.ToUpper()))
                    {
                        Console.WriteLine("Note invalide. Veuillez entrer une note alphabétique valide.");
                        continue;
                    }

                    string noteSyllabe = ConvertirNote(noteAlphabetique);
                    Console.WriteLine($"La note syllabe correspondante est : {noteSyllabe}");
                }
            }
            else if (choix == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Choix invalide. Veuillez entrer un choix valide.");
            }
        }
    }
}
