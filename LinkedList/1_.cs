namespace LinkedList
{ // Класс LinkedList<T> представляет двухсвязный список,
  // в котором каждый элемент хранит ссылку
  // одновременно на следующий и на предыдущий элемент.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создадим связный список
            LinkedList<string> link = new LinkedList<string>();

            // AddFirst(T value): вставляет новый узел со значением value в начало списка
            // Добавим несколько элементов
            link.AddFirst("Украина");
            link.AddFirst("Австрия");
            link.AddFirst("Швейцария");
            link.AddFirst("Франция");

            // Отобразим элементы в прямом направлении
            LinkedListNode<string> node;
            Console.WriteLine("Элементы коллекции в прямом направлении: ");
            for (node = link.First; node != null; node = node.Next) //Next: возвращает ссылку на следующий элемент типа LinkedListNode<T> в списке. Если следующий элемент отсутствует, то имеет значение null
                Console.Write(node.Value + "  "); // Value: возвращает или устанавливает само значение узла, представленное типом T

            // Отобразить элементы в обратном направлении
            Console.WriteLine("\n\nЭлементы коллекции в обратном направлении: ");
            for (node = link.Last; node != null; node = node.Previous) // Previous: возвращает ссылку предыдущий элемент типа LinkedListNode<T> в списке. Если предыдущий элемент отсутствует, то имеет значение null
                Console.Write(node.Value + "  ");
        }
    }
}