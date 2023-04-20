using System;

namespace Stack_UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackUsingLl myStack = new StackUsingLl();
            myStack.Push(70);
            myStack.Push(30);
            myStack.Push(56);

            myStack.Display();
            Console.WriteLine("Top element in Stack is {0} ", myStack.Peek());
        }
        public class StackUsingLl
        {
            private class Node
            {
                public int data;
                public Node link;
            }
            Node top;
            public StackUsingLl()
            {
                this.top = null;
            }
            public void Push(int d)
            {
                Node temp = new Node();
                if (temp == null)
                {
                    Console.WriteLine("Stack Overflow");
                    return;
                }
                temp.data = d;
                temp.link = top;
                top = temp;
            }
            public bool isEmpty()
            {
                return top == null;
            }
            public int Peek()
            {
                if (!isEmpty())
                {
                    return top.data;
                }
                else
                {
                    Console.WriteLine("Stack is empty!");
                    return -1;
                }
            }
            public void Display()
            {
                if (top == null)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Node temp = top;
                    while (temp != null)
                    {
                        Console.WriteLine(temp.data);
                        temp = temp.link;
                    }
                }
            }
        }
    }
}


