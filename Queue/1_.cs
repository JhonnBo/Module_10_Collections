using System;

namespace Queue
{ // Класс Queue<T> представляет обычную очередь, которая работает
  // по алгоритму FIFO ("первый вошел - первый вышел").
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(3); // очередь 3
            numbers.Enqueue(5); // очередь 3, 5
            numbers.Enqueue(8); // очередь 3, 5, 8

            // T Dequeue(): извлекает и возвращает первый элемент очереди
            // получаем первый элемент очереди
            int queueElement = numbers.Dequeue(); //теперь очередь 5, 8
            Console.WriteLine(queueElement);

            // void Enqueue(T item): добавляет элемент в конец очереди
            Queue<Person> persons = new Queue<Person>();
            persons.Enqueue(new Person() { Name = "Tom" });
            persons.Enqueue(new Person() { Name = "Bill" });
            persons.Enqueue(new Person() { Name = "John" });

            // T Peek(): просто возвращает первый элемент из начала очереди без его удаления
            // получаем первый элемент без его извлечения
            Person pp = persons.Peek();
            Console.WriteLine(pp.Name);

            Console.WriteLine("Сейчас в очереди {0} человек", persons.Count);

            // теперь в очереди Tom, Bill, John
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }

            // Извлекаем первый элемент в очереди - Tom
            Person person = persons.Dequeue(); // теперь в очереди Bill, John
            Console.WriteLine(person.Name);
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}