namespace Base
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var fruits = new List<int>();
            fruits.Add(1);
            fruits.Add(2);
            fruits.Add(3);
            fruits.Add(4);
            fruits.Add(5);

            // First / Last (Pega o primeiro e o ultimo)

            Console.WriteLine(fruits.First());
            Console.WriteLine(fruits.FirstOrDefault(0));

            // Any(Verificar se o item ou algum item existe)

            Console.WriteLine(fruits.Any(x => x == 1));

            // All (Verifica se todos os elementos tem o mesmo valor)

            Console.WriteLine(fruits.All(x => x == 1));

            // Count (Conta os elementos da lista)

            Console.WriteLine(fruits.Count());

            // ElementAt (Coleta o elemento pelo indice)

            Console.WriteLine(fruits.ElementAt(1));

            // Take (Coleta os elementos da lista)

             foreach (int i in fruits.Take(1..))
            {
                Console.WriteLine(i);
            }

            // Where (Coleta um item específico da lista)

            foreach (int i in fruits.Where(x => x == 1))
            {
                Console.WriteLine(i);
            }

            // Single (Verifica se o item selecionado é único)

            Console.WriteLine(fruits.Single(x => x == 1));

            // Skipe (Pula alguns elemestos)

            foreach (int i in fruits.Skip(1))
            {
                Console.WriteLine(i);
            }
        }
    }

}