namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Brachiosaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Compsognathus");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            // IndexOf
            Console.WriteLine("\nIndexOf(\"Tyrannosaurus\"): {0}",
                dinosaurs.IndexOf("Tyrannosaurus"));

            Console.WriteLine("\nIndexOf(\"Tyrannosaurus\", 3): {0}",
                dinosaurs.IndexOf("Tyrannosaurus", 3));

            Console.WriteLine("\nIndexOf(\"Tyrannosaurus\", 2, 2): {0}",
                dinosaurs.IndexOf("Tyrannosaurus", 2, 2));

            // LastIndexOf
            Console.WriteLine("\nLastIndexOf(\"Tyrannosaurus\"): {0}",
                dinosaurs.LastIndexOf("Tyrannosaurus"));

            Console.WriteLine("\nLastIndexOf(\"Tyrannosaurus\", 3): {0}",
                dinosaurs.LastIndexOf("Tyrannosaurus", 3));

            Console.WriteLine("\nLastIndexOf(\"Tyrannosaurus\", 4, 5): {0}",
                dinosaurs.LastIndexOf("Tyrannosaurus", 4, 5));
        }
    }
}

// https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.generic.list-1?view=net-7.0
