namespace Stack
{// Класс Stack<T> представляет коллекцию, которая использует
 // алгоритм LIFO ("последний вошел - первый вышел").
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyStack = new Stack<char>();
            MyStack.Push('A');
            MyStack.Push('N');
            MyStack.Push('X');

            Console.WriteLine("Исходный стек: ");
            foreach (char s in MyStack)
                Console.Write(s);
            Console.WriteLine("\n");

            while (MyStack.Count > 0)
            {
                Console.WriteLine("Pop -> {0}", MyStack.Pop());
            }

            if (MyStack.Count == 0)
                Console.WriteLine("\nСтек пуст!");
        }
    }
}