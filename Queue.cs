using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    public class Queue<T>
    {
        public int Count { get; private set; } // The amount of items in the Queue
        private LinkedList<T> data = new LinkedList<T>(); // Backing for the Queue

        public Queue()  // Construct the Queue
        { 

        }
        public void Enqueue(T value)  // Add an item to the end of the Queue
        {
            data.AddLast(value);
            Count++;
        }
        public T Dequeue()  // Remove and get the item at the front of the Queue
        {
            T returnValue = data.Head.Value;
            data.RemoveFirst();
            Count--;
            return returnValue;
        }
        public T Peek()  // Get the item at the front of the Queue
        {
            return data.Head.Value;
        }

        // Optional Functions
        /*
        public bool IsEmpty() { ... } // Returns if the Queue is empty
        public void Clear() { ... } // Deletes all data in the Queue
        */
    }
}
