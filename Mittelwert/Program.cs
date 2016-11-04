using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mittelwert
{
  class Program
  {
    static void Main(string[] args)
    {
      int eingabe_INT = 0, i = 0, fehler = 0;
      double ergebnis = 0;
      string eingabe;

      Console.WriteLine("Bitte geben Sie die Zahlen ein, deren Mittelwert Sie errechnen wollen.\nDrücken Sie 'm' um die Eingabe zu beenden.");
      Console.WriteLine("Wert {0}: ", i + 1);
      eingabe = Console.ReadLine();

      while (eingabe.ToUpper() != "M" && i < 500)
      {
        Console.Clear();
        Console.WriteLine("Bitte geben Sie die Zahlen ein, deren Mittelwert Sie errechnen wollen.\nDrücken Sie 'm' um die Eingabe zu beenden.");
        if (int.TryParse(eingabe, out eingabe_INT) == false)
        {
          Console.WriteLine("Es wurde eine ungültige Zahl eingegeben!");
          fehler++;
          if (fehler > 2)
          {
            Console.WriteLine("Es wurden zu viele Fehlangaben getätigt");
            Console.Read();
            return;
          }
        }
        else
        {
          fehler = 0;
          ergebnis += eingabe_INT;
          Console.WriteLine("Zwichensumme: {0}", ergebnis);
          i++;
        }

        Console.WriteLine("Wert {0}: ", i + 1);
        eingabe = Console.ReadLine();

      }
      ergebnis /= i;
      Console.WriteLine("Es wurden {0} Zahlen erfasst", i);
      Console.WriteLine("Der Mittelwert ist: {0}", ergebnis);
      Console.ReadLine();
    }
  }
}
