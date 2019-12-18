using System;

namespace DataStructures_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueController queue = new QueueController(5);

            queue.QueEnqueue(10);
            queue.QueEnqueue(87);
            queue.QueEnqueue(32);
            queue.QueEnqueue(56);
            queue.QueEnqueue(13);


            queue.QueDisplay();

            queue.QueDequeue();
            queue.QueDequeue();

            Console.WriteLine();

            queue.QueDisplay();

            Console.ReadKey();
        }
    }
}