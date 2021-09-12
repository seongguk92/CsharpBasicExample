using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DataTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 문자
            StringExample1();//String(Immutable Type)
            StringExample2();//StringBuilder(Mutable Type)
            #endregion

            #region 정수
            IntExample1();
            IntExample2();
            #endregion

            #region 논리값 자료형 
            BoolExample1();
            #endregion
        }

        #region 문자

        /// <summary>
        /// String
        /// </summary>
        private static void StringExample1()
        {
            string name = "seongguk";
            string ment = $"my name is {name}";//문자열 보간
            Console.WriteLine(ment);
        }

        /// <summary>
        /// StringBuilder
        /// </summary>
        private static void StringExample2()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A");
            sb.Append("B");
            sb.Append("C");
            sb.Append("D");
            sb.Append("E");
            sb.Append("F");
            sb.Append("G");

            Console.WriteLine($"{sb}");
        }

        #endregion

        #region 정수

        /// <summary>
        /// int
        /// </summary>
        private static void IntExample1()
        {
            string strNum = "123";
            //정규식 사용하여 숫자인지 판단 후 int형으로 변경
            if(Regex.IsMatch(strNum, @"^[0-9]+$"))
            {
                int num = int.Parse(strNum);
                Console.WriteLine($"숫자변환 완료 : {num}");
            }
            else
            {
                Console.WriteLine("숫자가 아닙니다.");
            }
        }


        /// <summary>
        /// double, decimal
        /// </summary>
        private static void IntExample2()
        {
            Double[] values = { 10.0, 2.88, 2.88, 2.88, 9.0 };
            Double result = 27.64;
            Double total = 0;
            foreach (var value in values)
                total += value;

            if (total.Equals(result))
                Console.WriteLine("같음");
            else
                Console.WriteLine($"더한 값 : ({total}) 결과 : ({result}).");

            decimal deResult = (decimal)result;
            decimal detotal = (decimal)total;

            if (deResult.Equals(detotal))
                Console.WriteLine("같음");
            else
                Console.WriteLine($"더한 값 : ({deResult}) 결과 : ({detotal}).");
        }

        #endregion

        #region 논리값 자료형
        private static void BoolExample1()
        {
            bool isRed = true;

            if (isRed)
            {
                Console.WriteLine($"빨간색입니다.");
            }
            else
            {
                Console.WriteLine($"빨간색이 아닙니다.");
            }
        }
        #endregion
    }
}
