# CsharpBasicExample
C# 기본문법 , 자료구조  등 사용법 예제


![필수 문법](https://user-images.githubusercontent.com/18062612/133263666-1dba40d2-18a4-46f2-903b-ea6176ff3bec.png)
Velog url : https://velog.io/@seongguk/C-%EA%B8%B0%EB%B3%B8-%EB%AC%B8%EB%B2%95
> **C# 기본문법** 정리
**data type** (String, StringBuilder, int, double, bool)
**조건문**(if, switch)
**반복문**(for, foreach)
**예외처리**(try, catch, finally)
**Class**


## 😁 DataType
### String
- 프로그램에서 가장 많이 쓰이는 데이터 타입
- Immutable Type
> Immutable Type -> 값이 설정되면 다시 변경할 수 없는 타입
~~~cs
public static void StringExample1()
{
     string name = "seongguk";
     string ment = $"my name is {name}";//문자열 보간
     Console.WriteLine(ment);
}
~~~

### StringBuilder
- 문자열 갱신이 많은 경우 사용.
- Mutable Type
> Mutable Type -> 값을 계속 변경할 수 있는 타입
~~~cs
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
~~~

### int
- 가장 많이 사용하는 정수형 범위
(–2,147,483,648 ~ 2,147,483,647)
- 부호 있는 32비트 정수
~~~cs
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
~~~
### double vs float vs decimal
- 부동소수점인 **float, double**은 덧셈시 근사치값을 나타내여 정확하지 않음.
- **decimal**은 금융 거래와 같이 유효 숫자가 필요한 민감한 정보를 기록하는데 권장.
> 1. decimal 단점은 완전 느리다.
>2. float, double은 데이터 크기 및 사용법 그리고 소수점 최대 자리가 다르다.

~~~cs
public static void IntExample2()
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
~~~
### bool
- 논리값을 나타내는 자료형
- **true** or **false**
~~~cs
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
~~~

## 😁 필수 문법
### 조건문 (if, switch)
- 코딩을 할 때 가장 많이 쓰는 문법
- 조건식의 참, 거짓에 따라 서로 다른 블럭의 코드를 실행
> **If** : 조건이 5개 미만일 경우 사용하자.
**switch** : 조건이 5개 이상일 경우 사용하자.
>
~~~cs
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
~~~
### 반복문(for, foreach)
- 반복문 또한 코딩을 할 때 가장 많이 쓰이는 문법
- 반복문이란 조건식이 참을 반환할 경우 구문을 반복시키는 예약어
> **for** : 일정한 개수 만큼 반복하고 싶으면 사용.
**foreach** : 자료구조를 이용한 반복문일 경우 사용.
~~~cs
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
~~~
### 예외처리(try, catch, finally)
> **try** : 메인 동작 구문 넣는 부분.
**catch** : 메인 동작에 오류가 발생시 동작.
**finally** : 정상동작, 오류동작 무조건 동작.

~~~cs
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
~~~
### Class
- 객체 지향 프로그래밍으로 속성과 메서드를 공유하는 유사한 성질의 객체들을 하나로 그룹화한 것.
> **객체**는 붕어빵, **클래스**는 붕어빵 틀
~~~cs
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

class Person
{
    private string name;
    private string age;

    public Person(string name, string age)
    {
        this.name = name;
        this.age = age;
    }
    public void InfoPerson()
    {
        Console.WriteLine($"{name}의 나이는 {age}입니다.");
    }
}
~~~

##### 출처 및 참조 : 
http://www.csharpstudy.com/CSharp/CSharp-string.aspx
