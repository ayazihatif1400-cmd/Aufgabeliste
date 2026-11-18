using System.ComponentModel.Design;
using System.Threading.Channels;

namespace projekt_aufgabeListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> aufgaben = new List < string>();
            bool weiter = true;

            while (weiter)
            {
                Console.WriteLine("Willkommen bei meine Aufgabe Liste! ");
                Console.WriteLine("1 - Anzeigen | 2 - Hinzufügen | 3 - Löschen | 0 - Beenden");
                string eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    if (aufgaben.Count == 0)
                    {
                        Console.WriteLine("Keine Aufgabe voehanden.");
                    }
                    for (int i = 0; i < aufgaben.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + aufgaben[i]);
                    }
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("Neue Aufgabe: ");
                    string neu = Console.ReadLine();
                    if (neu != "")
                    {
                        aufgaben.Add(neu);
                    }

                }
                else if (eingabe == "3")
                {

                    Console.WriteLine("Welche Nummer löschen? ");
                    int nr = Convert.ToInt32(Console.ReadLine());
                    if (nr >= 1 && nr <= aufgaben.Count)
                    {
                        aufgaben.RemoveAt(nr - 1);
                    }
                    else
                    {
                        Console.WriteLine("Diese Nummer gibt es nicht. ");
                    }
                }
                else if (eingabe == "0")
                {
                    weiter = false;
                }
            }
            
                
            
        }
    }
}
