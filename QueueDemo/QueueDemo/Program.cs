using System;

namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> ordersQueue = new Queue<Order>(); 

            foreach(Order o in RecieveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while(ordersQueue.Count > 0)
            {
                Order currentOrder= ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }

            ////define
            //Queue<int> myQueue = new Queue<int>();

            ////add
            //myQueue.Enqueue(1);
            //myQueue.Enqueue(2);
            //myQueue.Enqueue(3);
            //myQueue.Enqueue(5);

            ////remove
            //int queueItem = myQueue.Dequeue();

            //while (myQueue.Count > 0)
            //{
            //    Console.WriteLine("The front value {0} was removed from the queue", myQueue.Dequeue());
            //    Console.WriteLine("Current queue count is : {0}", myQueue.Count);
            //}

            //// front of queue
            //// Console.WriteLine(myQueue.Peek());

           


        }

        static Order[] RecieveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                    new Order(1,5),
                    new Order(2,4),
                    new Order(6,10)

            };
            return orders;
        }

        static Order[] RecieveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                    new Order(3,5),
                    new Order(4,4),
                    new Order(5,10)

            };
            return orders;
        }

        class Order
        {
            public int OrderId { get; set; }
            public int OrderQuantity { get; set; }

            public Order(int id, int quantity)
            {
                this.OrderId = id;
                this.OrderQuantity = quantity;
            }

            public void ProcessOrder()
            {
                Console.WriteLine($"Order {OrderId} processed");
            }
        }
    }
}