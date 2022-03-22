// using System;

// namespace UsingVar
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             var a = 20;
//             Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

//             var b = 3.1414213;
//             Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

//             var c = "Hello, World!";
//             Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

//             var d = new int[] { 10, 20, 30 };
//             Console.WriteLine("Type: {0}, Value: ", d.GetType());
//             foreach (var e in d)
//                 Console.WriteLine("{0} ", e);        // 값이 이어지지 않고 따로 출력됨

//             Console.WriteLine();
//         }
//     }
// }

////////////////////////////////////////////////////////////////////////////

// // CTS 예제

// using System;

// namespace CTS
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             System.Int32 a = 123;
//             int b = 456;

//             // Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
//             // Console.WriteLine("b type:{0}, value:{1}", b.GetType().ToString(), b);
//             Console.WriteLine("a type:{0}, value:{1}", a.GetType(), a);
//             Console.WriteLine("b type:{0}, value:{1}", b.GetType(), b);

//             System.String c = "abc";
//             string d = "def";

//             Console.WriteLine("c type:{0}, value:{1}", c.GetType(), c);
//             Console.WriteLine("d type:{0}, value:{1}", d.GetType(), d);
//             // Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
//             // Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);

//         }
//     }
// }

////////////////////////////////////////////////////////////////////////////

// // StringSearch 문자열 찾기

// using static System.Console;

// namespace StringSearch
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             string greeting = "Good Morning";

//             WriteLine(greeting);
//             WriteLine();

//             // IndexOf()
//             WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
//             WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

//             // LastIndexOf()
//             WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
//             WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

//             // StartsWith()
//             WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
//             WriteLine("StratsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

//             // EndsWith()
//             WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
//             WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

//             // Contains()
//             WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
//             WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

//             // Replace()
//             WriteLine("Replaced 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
//         }
//     }
// }

////////////////////////////////////////////////////////////////////////////

// // StringModify 문자열 변형

// using static System.Console;

// namespace StringModify
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             WriteLine("ToLower() : '{0}'", "ABC".ToLower());
//             WriteLine("Toupper() : '{0}'", "abc".ToUpper());

//             WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
//             WriteLine("Remove() :  '{0}'", "I Don't Love You.".Remove(2,6));

//             WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
//             WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
//             WriteLine("TrimEnd : '{0}'", " No Spaces ".TrimEnd());
//         }
//     }
// }

////////////////////////////////////////////////////////////////////////////




