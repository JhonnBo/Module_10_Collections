namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создание списка и добавление элементов в коллекцию
            List<string> dinosaurs = new List<string>();

            Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");           

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);

            // 2. Мы можем осуществить доступ по индексу к опр. элементу списка
            Console.WriteLine("\ndinosaurs[3]: {0}", dinosaurs[3]);

            // 3. Мы можем вставить определенный элемен в определенное место
            Console.WriteLine("\nInsert(2, \"Compsognathus\")");
            dinosaurs.Insert(2, "Compsognathus");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
        }
    }
}
