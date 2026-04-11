namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ListQueue = new Queue<int>();
            ArrayQueue<int> arrayQueue = new ArrayQueue<int>();
            /*
            ListQueue.Enqueue(1);
            ListQueue.Enqueue(35);
            ListQueue.Dequeue();
            ListQueue.Enqueue(91);
            ListQueue.Peek();
            */
//-----------------------------------------------------

            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(32);
            arrayQueue.Dequeue();
            arrayQueue.Enqueue(12);
            arrayQueue.Enqueue(23);
            arrayQueue.Dequeue();
            arrayQueue.Peek();
            arrayQueue.Enqueue(29);
            arrayQueue.Enqueue(93);
            arrayQueue.Enqueue(14);
        }
    }
}
