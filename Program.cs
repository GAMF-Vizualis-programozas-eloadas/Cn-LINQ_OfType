using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CnLINQ_OfType
{
	class Program
	{
    static void Main(string[] args)
    {
      ArrayList A = new ArrayList() { 2, 4, 5, 1, 8, 5, 7 };
      Console.WriteLine("Az összes szám: 2,4,5,1,8,5,7");
      IEnumerable<int> I = A.OfType<int>();
      IEnumerable<int> E = from x in I
                           where x % 2 == 0
                           orderby x descending
                           select x;

      Console.Write("Páros számok csökkenő sorrendben: ");
      foreach (int i in E)
        Console.Write(i + ", ");
      Console.ReadLine();

      ArrayList B = new ArrayList() { 2, 4, "valami", 5, 1, "semmi", 8, 5, "akármi", 7, 9.5, 13.5 };
      Console.WriteLine("Az összes adat: 2, 4, 'valami', 5, 1,'semmi', 8, 5, 'akármi', 7, 9.5, 13.5");
      IEnumerable<string> Szavak = B.OfType<string>();

      Console.Write("Szavak: ");
      foreach (string s in Szavak)
        Console.Write(s + ", ");
      Console.ReadLine();
    }
  }
}
