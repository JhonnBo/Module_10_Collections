namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "Brachiosaurus",
                           "Amargasaurus",
                           "Mamenchisaurus" };
            // Создание списка из массива
            List<string> dinosaurs = new List<string>(input);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            input = new string[] { "Tyrannosaurus",
                               "Deinonychus",
                               "Velociraptor"};

            Console.WriteLine("\nInsertRange(1, input)");
            // Вставка с индекса 1 нового массива
            dinosaurs.InsertRange(1, input);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

        }
    }
}
