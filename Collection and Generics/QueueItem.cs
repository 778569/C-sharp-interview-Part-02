using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_and_Generics
{
    public class QueueItem
    {
        public void Test()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            int removeItem = queue.Dequeue();
            Console.WriteLine(removeItem);
            int removeItem2nd = queue.Dequeue();
            Console.WriteLine(removeItem2nd);

            Console.WriteLine(queue.Peek());

            int DeletedItem;

            while (queue.TryDequeue(out DeletedItem))
            {
                Console.WriteLine(DeletedItem);
            }

        }
    }
}
