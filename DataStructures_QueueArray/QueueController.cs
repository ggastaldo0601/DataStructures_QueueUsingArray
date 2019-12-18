using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_Queue
{
    public class QueueController
    {
        public static int[] queue;
        public int start, end, size;


        public QueueController(int s)
        {
            start = end = 0;
            size = s;
            queue = new int[size];
        }


        public void QueEnqueue(int newData)
        {
            if (size == end)
            {
                Console.WriteLine("Queue is full.");
                return;
            }

            else
            {
                queue[end] = newData;
                end++;
            }
            return;
        }

        public void QueDequeue()
        {
            if (start == end)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            else
            {
                for (int i = 0; i < end - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                if (end < size)
                {
                    queue[end] = 0;
                }
                end--;
            }
            return;
        }

        public void QueDisplay()
        {
            if (start == end)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            for (int i = start; i < end; i++)
            {
                Console.Write(" {0} <-- ", queue[i]);
            }
            return;
        }
    }
}
