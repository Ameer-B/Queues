using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    internal class ArrayQueue<T>
    {
        public int Count { get; private set; } // The amount of items in the Queue
        private T[] data = new T[5]; // Backing for the Queue
        private int head; // The point to remove at
        private int tail; // The point to add at

        public ArrayQueue() // Construct the Queue
        {
        }

        public void Enqueue(T value)  // Add an item to the end of the Queue
        {
            if (tail == data.Length)
            {
                tail = 0;
            }

            if (tail == head && Count > 0)
            {
                Resize(2);
                head = 0;
            }
            data[tail] = value;
            tail++;
            Count++;
        }


        public T Dequeue()  // Remove and get the item at the front of the Queue
        {
            if (head == data.Length)
            {
                head = 0;
            }
            if (Count == data.Length / 4)
            {
                Resize(1 / 2);
            }
            head++;
            Count--;
            return data[head - 1];
        }

        public T Peek() // Get the item at the front of the Queue
        {
            return data[head];
        }



        private void Resize(int size)  // Resize and re-index the data 
        {
            T[] tempData = new T[data.Length * size];
            for (int i = 0; i < data.Length; i++)
            {
                tempData[i] = data[i];
            }
            data = tempData;
        }


        public bool IsEmpty()  // Returns if the Queue is empty
        {
            return Count == 0;
        }
        public void Clear()  // Deletes all data in the Queue
        {
            data = new T[0];
        }

    }
}
