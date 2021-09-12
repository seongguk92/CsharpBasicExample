using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BasicGrammarExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 조건문(if, switch)
            //ifExample();
            //switchExample();
            #endregion

            #region 반복문(for, foreach)
            //forExample();
            //foreachExample();
            #endregion

            #region 예외처리(try, catch, finally)
            //ExceptionExample();
            #endregion

            #region Class
            classExample();
            #endregion
        }

        #region 조건문 (if, switch)

        public static void ifExample()
        {
            string result;
            int score = 90;
            if(score >= 90)
            {
                result = "A";
            }
            else if(score >= 80)
            {
                result = "B";
            }
            else 
            {
                result = "F";
            }
            Console.WriteLine($"{score}점은 {result}등급 입니다.");
        }

        public static void switchExample()
        {
            int day = 3;

            // 관계 패턴
            string week = day switch
            {
                1 => "월",
                2 => "화",
                3 => "수",
                4 => "목",
                5 => "금",
                6 => "토",
                7 => "일",
                _ => "X"//default
            };
            Console.WriteLine($"오늘은 {week}요일 입니다.");
        }

        #endregion

        #region 반복문(for, foreach)
        /// <summary>
        /// for
        /// </summary
        public static void forExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"num : {i}");
            }
        }

        /// <summary>
        /// foreach
        /// </summary>
        public static void foreachExample()
        {
            List<string> listSeason = new List<string>();
            foreach (var item in Enum.GetValues(typeof(eSeason)))
            {
                listSeason.Add(item.ToString().Trim());
            }
            foreach (string item in listSeason)
            {
                Console.WriteLine($"계절 = {item}");
            }
        }

        #endregion

        #region 예외처리
        /// <summary>
        /// 예외처리 example
        /// </summary
        public static void ExceptionExample()
        {
            try
            {
                string strNum = "아아";
                int num = Convert.ToInt32(strNum);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Console.WriteLine("무조건 실행");
            }
        }

        #endregion

        #region class

        /// <summary>
        /// class 예제
        /// </summary>
        public static void classExample()
        {
            Person person1 = new Person("A", "23");
            Person person2 = new Person("A", "30");
            person1.InfoPerson();
            person2.InfoPerson();
        }

        #endregion
    }
}
enum eSeason
{
    Spring,
    Summer,
    Autumn,
    Winter
}