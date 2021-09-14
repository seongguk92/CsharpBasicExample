 using System;
using System.Collections.Generic;

namespace DataStructureExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary <key, value>
            ProcessDictionary();
            #endregion
            #region List<T>
            #endregion
            #region Queue<T>
            #endregion
            #region Stack<T>
            #endregion
            #region LinkedList<T>
            #endregion
            #region SortedList<TKey, TValue>
            #endregion
        }

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
    }
}
