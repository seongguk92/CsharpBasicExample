 using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructureExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary<key, value>
            //ProcessDictionary();
            #endregion

            #region List<T>
            //ProcessList();
            #endregion

            #region Queue<T>
            //ProcessQueue();
            #endregion

            #region Stack<T>
            ProcessStack(); 
            #endregion

            #region LinkedList<T>
            #endregion

            #region SortedList<TKey, TValue>
            #endregion
        }

        #region Dictionary<key, value>
        public static void ProcessDictionary()
        {
            //Datatable
            //DateTime
            //int ... 
            //무슨 타입이던 
            //Red -> 빨강
            //Green -> 초록
            //Blue -> 파랑
            Dictionary<string, string> dicColor = new Dictionary<string, string>();
            dicColor.Add("Red", "빨강");
            dicColor.Add("Green", "초록");
            dicColor.Add("Blue", "파랑");

            try
            {
                //빨강을 꺼내고싶어요.
                if (dicColor.ContainsKey("Red"))
                {
                    Console.WriteLine($"Red : {dicColor["Red"]}");
                }

                //노랑을 꺼내고싶어요.
                if (dicColor.ContainsKey("Yellow"))
                {
                    Console.WriteLine($"Yellow : {dicColor["Yellow"]}");
                }
                else 
                {
                    Console.WriteLine($"Make Yellow");
                    dicColor.Add("Yellow", "노랑");
                }

                foreach (var item in dicColor)
                {
                    Console.WriteLine($"key:{item.Key} value:{item.Value}");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        #endregion

        #region List<T>
        public static void ProcessList()
        {
            List<Action> listWrite = new List<Action>();
            listWrite.Add(() => { Console.WriteLine("A Process"); });
            listWrite.Add(() => { Console.WriteLine("B Process"); });
            listWrite.Add(() => { Console.WriteLine("C Process"); });
            listWrite.Add(() => { Console.WriteLine("D Process"); });
            listWrite.Add(() => { Console.WriteLine("E Process"); });
            listWrite.Add(() => { Console.WriteLine("F Process"); });

            foreach (Action action in listWrite)
            {
                action();
            }
        }
        #endregion

        #region Queue<T>
        public static void ProcessQueue()
        {
            //FIFO 
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            //queue.Enqueue();// 집어넣는것
            //queue.Dequeue();// 빼내는것

            Task tEnq = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    queue.Enqueue(i);
                    Thread.Sleep(1000);
                }
            });

            Task tDnq = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result = 0;
                while(n < 100)
                {
                    if(queue.TryDequeue(out result))
                    {
                        Console.WriteLine($"{result}");
                    }
                }
            });

            Task.WaitAll(tEnq, tDnq);
        }
        #endregion

        #region Stack<T>
        public static void ProcessStack()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            Task tPush = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    stack.Push(i);
                    Thread.Sleep(100);
                }
            });

            Task tPop = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result = 0;

                while (n < 100)
                {
                    if(stack.TryPop(out result))
                    {
                        Console.WriteLine($"{result}");
                        n++;
                    }
                    Thread.Sleep(150);
                }
            });

            Task.WaitAll(tPush, tPop);
        }
        #endregion
    }
}
