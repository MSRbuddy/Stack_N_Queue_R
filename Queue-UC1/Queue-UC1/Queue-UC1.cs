using System;

namespace Queue_UC1
{
    internal class Program
    {
        class QNode
        {
            public int key;
            public QNode next;
            public QNode(int key)
            {
                this.key = key;
                this.next = null;
            }
        }
        class Queue
        {
            public QNode front, rear;
            public Queue()
            {
                this.front = this.rear = null;
            }
            public void Enqueue(int key)
            {
                QNode temp = new QNode(key);
                if(this.rear == null)
                {
                    this.front = this.rear = temp;
                    return;
                }
                this.rear.next = temp;
                this.rear = temp;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** welcome to Queue Program! *****");
            Queue myQue = new Queue();
            myQue.Enqueue(56);
            myQue.Enqueue(30);
            myQue.Enqueue(70);
            Console.WriteLine("Elements in Queue: " + "\n56" + "\n30" + "\n70");
            Console.WriteLine("Front in Queue is: " + ((myQue.front != null) ? (myQue.front).key : -1));
            Console.WriteLine("Rear in Queue is: " + ((myQue.rear != null) ? (myQue.rear).key : -1));
        }
    }
}
