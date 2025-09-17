using System.Reflection.Metadata;

namespace vys_projekty
{
    class Program
    {
        static void Main()
        {
            //výber
            string[] moznosti = { "kámen", "nůžky", "papír" };

            while (true)

            {
                Console.WriteLine("vyber si, Kámen, nůžky, nebo papír");
                string tahHrace = Console.Readline().ToLower();

                if (tahHrace == "konec")
                {
                    Console.WriteLine("děkuji za hru");
                    break;
                }

                if (!Array.Exists(moznosti, prvek =>  prvek == tahHrace))
                {
                    Console.WriteLine("neplatný tah, zkus to znovu");
                    continue;

                }

                //tah počítače
                Random rnd = new Random();
                int index = rnd.Next(moznosti.Length);
                string tahPocitace = moznosti[index];

                Console.WriteLine($"Počítaž zvolil: {tahPocitace}");

                //výsledek or sum shi

                if (tahPocitace == tahHrace)
                {

                    Console.WriteLine("remíza");
                }
                else if (
                    (tahHrace == "kámen" && tahPocitace == "nůžky") ||
                    (tahHrace == "nůžky" && tahPocitace == "papír") ||
                    (tahHrace == "papír" && tahPocitace == "kámen")
                )

                {
                    Console.WriteLine("vyhrál jsi");
                }
                else
                {
                    Console.WriteLine("prohrál jsi");
                }

                Console.WriteLine();
            }
        }
    }
}
