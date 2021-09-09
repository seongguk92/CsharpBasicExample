using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DataTypeExample
{
    class Program
    {
        /// <summary>
        /// 문자열(string)
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {
            #region 문자
            //StringExample1();//String(Immutable Type)
            //StringExample2();//StringBuilder(Mutable Type)
            #endregion

            #region 정수
            IntExample1();
            #endregion
        }

        #region string

        /// <summary>
        /// String
        /// </summary>
        public static void StringExample1()
        {
            string name = "seongguk";
            string ment = $"my name is {name}";//문자열 보간
            Console.WriteLine(ment);
        }

        /// <summary>
        /// StringBuilder
        /// </summary>
        public static void StringExample2()
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

        #region int

        /// <summary>
        /// int
        /// </summary>
        public static void IntExample1()
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

        #endregion

    }
}
