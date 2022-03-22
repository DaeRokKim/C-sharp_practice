// // 부동소수점

// using System;

// namespace Decimal
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             float a = 3.1415_9265_7932_3846_2643_3832_79f;          // 출력 = 3.1415927
//             double b = 3.1415_9265_7932_3846_2643_3832_79;       // 출력 = 3.1415926579323847
//             decimal c = 3.1415_9265_7932_3846_2643_3832_79m;    // 출력 = 3.14159265793238462643383279

//             Console.WriteLine(a);
//             Console.WriteLine(b);
//             Console.WriteLine(c);
//         }
//     }
// }

///////////////////////////////////////////////////////////////////////////////////////

// // 문자열 char

// using System;

// namespace Char
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             char a = '안';
//             char b = '녕';
//             char c = '하';
//             char d = '세';
//             char e = '요';

//             Console.Write(a);
//             Console.Write(b);
//             Console.Write(c);
//             Console.Write(d);
//             Console.Write(e);
//             Console.WriteLine();

//         }
//     }
// }

////////////////////////////////////////////////////////////////////////

// // 문자열 string

// using System;

// namespace String
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             string a = "안녕하세요!";
//             string b = "반갑습니다 저는 ~입니다.";

//             Console.WriteLine(a);
//             Console.WriteLine(b);
//         }
//     }
// }

// // char = 작은 따옴표, string = 큰 따옴표

///////////////////////////////////////////////////////////////////////////

// // 논리식 bool

// using System;

// namespace Bool
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             bool a = true;
//             bool b = false;

//             Console.WriteLine(a);
//             Console.WriteLine(b);

//         }
//     }
// }

///////////////////////////////////////////////////////////////////////////////

// // Object

// using System;

// namespace Object
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             object a = 123;
//             object b = 3.141592653589793238462643383279m;
//             object c = true;
//             object d = "안녕하세요.";

//             Console.WriteLine(a);
//             Console.WriteLine(b);
//             Console.WriteLine(c);
//             Console.WriteLine(d);

//         }
//     }
// }

////////////////////////////////////////////////////////////////////////////////////

// // Boxing/Unboxing

// using System;

// namespace BoxingUnboxing
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             int a = 123;
//             object b = (object)a;   // a에 담긴 값을 박싱해서 힙에 저장
//             int c = (int)b;            // b에 담긴 값을 언박싱해서 스택에 저장

//             Console.WriteLine(a);
//             Console.WriteLine(b);
//             Console.WriteLine(c);

//             double x = 3.1414213;
//             object y = x;               // x에 담긴 값을 박싱해서 힙에 저장
//             double z = (double)y;   // y에 담긴 값을 언박싱해서 스택에 저장

//             Console.WriteLine(z);
//             Console.WriteLine(y);
//             Console.WriteLine(z);

//         }
//     }
// }

/////////////////////////////////////////////////////////////////////////////

// IntegralConversion

// using System;

// namespace IntegralConversion
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             sbyte a = 127;
//             Console.WriteLine(a);

//             int b = (int)a;
//             Console.WriteLine(b);

//             int x = 128;             // sbyte의 최댓값 127보다 1 큰 수
//             Console.WriteLine(x);

//             sbyte y = (sbyte)x;     // overflow 발생
//             Console.WriteLine(y);

//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// // floatConversion

// using System;

// namespace FloatConversion
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             float a = 69.6875f;
//             Console.WriteLine("a : {0}", a);

//             double b = (double)a;
//             Console.WriteLine("b : {0}", b);
//             Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

//             float x = 0.1f;
//             Console.WriteLine("x : {0}", x);

//             double y = (double)x;
//             Console.WriteLine("y : {0}", y);
//             Console.WriteLine("3.1 == y : {0}", 0.1 == y);

//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// // SignedUnsignedCoversion

// using System;

// namespace SignedUnsignedConversion
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             int a = 500;
//             Console.WriteLine(a);

//             uint b = (uint)a;
//             Console.WriteLine(b);

//             int x = -30;
//             Console.WriteLine(x);

//             uint y = (uint)x;
//             Console.WriteLine(y);

//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// FloatToIntegral

// using System;

// namespace FloatToIntegral
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             float a = 0.9f;
//             int b = (int)a;
//             Console.WriteLine(b);

//             float c = 1.1f;
//             int d = (int)c;
//             Console.WriteLine(d);
//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// // StringNumberConversion

// using System;

// namespace StringNumberConversion
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             int a = 123;
//             string b = a.ToString();
//             Console.WriteLine(b);

//             float c = 3.14f;
//             string d =  c.ToString();
//             Console.WriteLine(d);

//             string e = "123456";
//             int f = Convert.ToInt32(e);
//             Console.WriteLine(f);

//             string g = "1.2345";
//             float h = float.Parse(g);
//             Console.WriteLine(h);
//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// // Constant

// using System;

// namespace Constant
// {
//     class MainApp
//     {
//         static void Main(String[] args)
//         {
//             const int MAX_INT = 2147483647;
//             const int MIN_INT = -2147483647;

//             Console.WriteLine(MAX_INT);
//             Console.WriteLine(MIN_INT);

//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// // 상수 값을 변경하려고 하면??

// using System;

// namespace Constant
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             const int a = 3;
//             a = 4;      // 할당식의 왼쪽은 변수, 속성 또는 인덱서야 합니다. -- error
//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// // Enum

// using System;

// namespace Enum
// {
//     class MainApp
//     {
//         enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

//         static void Main(string[] args)
//         {
//             Console.WriteLine((int)DialogResult.YES);
//             Console.WriteLine((int)DialogResult.NO);
//             Console.WriteLine((int)DialogResult.CANCEL);
//             Console.WriteLine((int)DialogResult.CONFIRM);
//             Console.WriteLine((int)DialogResult.OK);   
//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// // Enum2 형식에 변수선언하고 값 대입하기

// using System;

// namespace Enum2
// {
//     class MainApp
//     {
//         enum DialogResult { YES, NO, CANCEL, CONFIRM, OK };

//         static void Main(string[] args)
//         {
//             DialogResult result = DialogResult.YES;

//             Console.WriteLine(result == DialogResult.YES);
//             Console.WriteLine(result == DialogResult.NO);
//             Console.WriteLine(result == DialogResult.CANCEL);
//             Console.WriteLine(result == DialogResult.CONFIRM);
//             Console.WriteLine(result == DialogResult.OK);

//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// // Enum3 상수에 직접 값 할당하기

// using System;

// namespace Enum3
// {
//     class MainApp
//     {
//         enum DialogResult { YES=10, NO, CANCEL, CONFIRM=50, OK }

//         static void Main(string[] args)
//         {
//             Console.WriteLine((int)DialogResult.YES);
//             Console.WriteLine((int)DialogResult.NO);
//             Console.WriteLine((int)DialogResult.CANCEL);
//             Console.WriteLine((int)DialogResult.CONFIRM);
//             Console.WriteLine((int)DialogResult.OK);

//         }
//     }
// }

////////////////////////////////////////////////////////////////////

// // Nullalbe

// using System;

// namespace Nullable
// {
//     class MainApp
//     {
//         static void Main(string[] args)
//         {
//             int? a = null;

//             Console.WriteLine(a.HasValue);
//             Console.WriteLine(a != null);

//             a = 3;

//             Console.WriteLine(a.HasValue);
//             Console.WriteLine(a != null);
//             Console.WriteLine(a.Value);
//         }
//     }
// }