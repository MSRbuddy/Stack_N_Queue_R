using System;

namespace Queue_UC2
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
                if (this.rear == null)
                {
                    this.front = this.rear = temp;
                    return;
                }
                this.rear.next = temp;
                this.rear = temp;
            }
            public void Dequeue()
            {
                if (this.front == null)
                    return;
                this.front = this.front.next;
                if (this.front == null)
                    this.rear = null;
                Console.WriteLine("After Dequeue front element in Queue is: " + ((this.front != null) ? (this.front).key : -1));
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

            myQue.Dequeue();
            myQue.Dequeue();
            myQue.Dequeue();
            Console.WriteLine("After dequeueing all elements, Now Queue is empty!");
        }
    }
}
