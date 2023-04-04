namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Pachycephalosaurus");
            dinosaurs.Add("Parasauralophus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Coelophysis");
            dinosaurs.Add("Oviraptor");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nSort");
            dinosaurs.Sort();

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nReverse");
            dinosaurs.Reverse();
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nReverse Range(1, 4)");
            dinosaurs.Reverse(1, 4);
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }            
        }
    }
}
