using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_code
{
    public class Hallgato
    {
        public string Név { get; set; } = "";

        public override int GetHashCode()
        {
            return 0;
            //return Név.GetHashCode();
        }
    }

    public class Dictionary
    {
        public static void DictExample()
        {
            Dictionary<Hallgato, int> dictionary = new Dictionary<Hallgato, int>();
            Hallgato h1 = new Hallgato() { Név = "Béla" };
            //h1.Név = "Béla";

            dictionary.Add(h1, 1000);

            Hallgato h2 = new Hallgato() { Név = "Gizi" };
            dictionary.Add(h2, 2000);

            Console.WriteLine(dictionary[h1]);
            Console.WriteLine(dictionary[h2]);

            int érték = 10;
            dictionary.TryGetValue(h1, out érték);
            Console.WriteLine(érték);

            int értékNemLeszBenne = 0;
            if (dictionary.TryGetValue(new Hallgato(), out értékNemLeszBenne))
                Console.WriteLine(értékNemLeszBenne);

            h2.Név = "Józsi";
            Console.WriteLine(dictionary[h1]);
            Console.WriteLine(dictionary[h2]);
            dictionary.Values.ToList().ForEach(x => Console.WriteLine(x));


            foreach (KeyValuePair<Hallgato, int> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key.Név}, {pair.Value}");
            }

            Dictionary<Hallgato, int>.KeyCollection keyColl = dictionary.Keys;

            foreach (var key in keyColl)
            {
                Console.WriteLine(key.Név);
            }

            // object equal but not the same, doesnt work (object reference type)
            //Console.WriteLine(dictionary[new Hallgato() {Név = "Béla" }]);
        }

    }
}
