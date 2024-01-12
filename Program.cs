using System;
using static System.Console;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

#region 사칙연산
/*
// 1000
string[] s = Console.ReadLine().Split();
Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));

======================================================================
// 1001
string[] s = Console.ReadLine().Split();
Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));

======================================================================
// 10998
string[] s = Console.ReadLine().Split();
Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));

======================================================================
// 1008
string[] s = Console.ReadLine().Split();
Console.WriteLine(double.Parse(s[0]) / double.Parse(s[1]));

======================================================================
// 10869
string[] s = Console.ReadLine().Split();
Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
Console.WriteLine(int.Parse(s[0]) / int.Parse(s[1]));
Console.WriteLine(int.Parse(s[0]) % int.Parse(s[1]));

======================================================================
// 10926
Console.WriteLine(Console.ReadLine() + "??!");

======================================================================
// 18108
string s = Console.ReadLine();
Console.WriteLine(int.Parse(s) - 543);

======================================================================
// 10430
string[] s = Console.ReadLine().Split( );
Console.WriteLine((int.Parse(s[0]) + int.Parse(s[1])) % int.Parse(s[2]));
Console.WriteLine(((int.Parse(s[0]) % int.Parse(s[2])) + (int.Parse(s[1]) % int.Parse(s[2]))) % int.Parse(s[2]));
Console.WriteLine((int.Parse(s[0]) * int.Parse(s[1])) % int.Parse(s[2]));
Console.WriteLine(((int.Parse(s[0]) % int.Parse(s[2])) * (int.Parse(s[1]) % int.Parse(s[2]))) % int.Parse(s[2]));

======================================================================
// 2588
string a1 = Console.ReadLine();
string a2 = Console.ReadLine();

char[] a3 = a2.ToCharArray();

int n1 = int.Parse(a1);
int[] n2 = new int[a3.Length];

for (int i = 0; i < a3.Length; i++)
{
    n2[i] = int.Parse(a3[i].ToString());
}

Console.WriteLine(n1 * n2[2]);
Console.WriteLine(n1 * n2[1]);
Console.WriteLine(n1 * n2[0]);
Console.WriteLine(n1 * n2[2] + n1 * n2[1] * 10 + n1 * n2[0] * 100);

======================================================================
// 11382
string[] s = Console.ReadLine().Split();
Console.WriteLine(long.Parse(s[0]) + long.Parse(s[1]) + long.Parse(s[2]));

======================================================================
// 10171
Console.WriteLine("\\    /\\");
Console.WriteLine(" )  ( ')");
Console.WriteLine("(  /  )");
Console.WriteLine(" \\(__)| ");

======================================================================
// 10172
Console.WriteLine("|\\_/|");
Console.WriteLine("|q p|   /}");
Console.WriteLine("( 0 )\"\"\"\\");
Console.WriteLine("|\"^\"`    |");
Console.WriteLine("||_/=\\\\__|");

======================================================================

 */
#endregion

#region 조건문
/*
// 1330
string[] s = Console.ReadLine().Split( );
if (int.Parse(s[0]) > int.Parse(s[1]))
{
    Console.WriteLine(">");
}
else if (int.Parse(s[0]) < int.Parse(s[1]))
{
    Console.WriteLine("<");
}
else if (int.Parse(s[0]) == int.Parse(s[1]))
{
    Console.WriteLine("==");
}

======================================================================
// 9498
string s = Console.ReadLine();
int n = int.Parse(s);

if (100 >= n && 90 <= n) Console.WriteLine("A");
else if (89 >= n && 80 <= n) Console.WriteLine("B");
else if (79 >= n && 70 <= n) Console.WriteLine("C");
else if (69 >= n && 60 <= n) Console.WriteLine("D");
else Console.WriteLine("F");

======================================================================
// 2753
string s = Console.ReadLine();
int n = int.Parse(s);

if (n % 4 == 0)
{
    if (n % 100 != 0 || n % 400 == 0)
    {
        Console.WriteLine("1");
    }
    else Console.WriteLine("0");
}
else Console.WriteLine("0");

======================================================================
// 14681

string n1 = Console.ReadLine();
string n2 = Console.ReadLine();
int x = int.Parse(n1);
int y = int.Parse(n2);

if (x > 0 && y > 0) Console.WriteLine("1");
else if (x < 0 && y > 0) Console.WriteLine("2");
else if (x < 0 && y < 0) Console.WriteLine("3");
else if (x > 0 && y < 0) Console.WriteLine("4");

======================================================================
// 2884
string[] s = Console.ReadLine().Split();
int h = int.Parse(s[0]);
int m = int.Parse(s[1]);
if (h < 0 || h > 24 || m < 0 || m > 59) return;

if (m < 45)
{
    h--;
    m += 15;

    if (h < 0)
    {
        h = 23;
    }
}
else m -= 45;

Console.WriteLine("{0} {1}", h, m);

======================================================================
// 2525
string[] s = Console.ReadLine().Split();
int h = int.Parse(s[0]);
int m = int.Parse(s[1]);
int c = int.Parse(Console.ReadLine());

m += c;

while (m >= 60)
{
    h++;
    m -= 60;
}

if (h >= 24) h -= 24;

Console.WriteLine(h + " " + m);

======================================================================
// 2480
string[] s = Console.ReadLine().Split();
int a = int.Parse(s[0]);
int b = int.Parse(s[1]);
int c = int.Parse(s[2]);

if (a == b && b == c) Console.WriteLine(10000 + (a * 1000));
else if (a == b) Console.WriteLine(1000 + a * 100);
else if (a == c) Console.WriteLine(1000 + a * 100);
else if (b == c) Console.WriteLine(1000 + b * 100);
else
{
    if (a > b && a > c) Console.WriteLine(100 * a);
    else if (b > c) Console.WriteLine(100 * b);
    else Console.WriteLine(100 * c);
}
======================================================================

*/
#endregion

#region 반복문
/* 
// 2739
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{n} * {i} = {n * i}");
}
=================================================
// 10950
int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] s = Console.ReadLine().Split();
    int n1 = int.Parse(s[0]);
    int n2 = int.Parse(s[1]);

    Console.WriteLine(n1 + n2);
}
=================================================
// 8393
int t = int.Parse(Console.ReadLine());

int n = 0;

for (int i = 0; i < t + 1; i++)
{
    n += i;
}
Console.WriteLine($"{n}");
=================================================
// 25304
int total = int.Parse(Console.ReadLine());
int cnt = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < cnt; i++)
{
    int[] pro = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    sum += pro[0] * pro[1];
}
if (sum == total) Console.WriteLine("Yes");
else Console.WriteLine("No");
=================================================
// 25314
int num = int.Parse(Console.ReadLine());

for (int i = num / 4; i > 0; i--) 
{
    Console.Write("long ");
}
Console.Write("int");
=================================================
// 15552
StringBuilder sb = new StringBuilder();

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] num = Console.ReadLine().Split();
    sb.Append(int.Parse(num[0]) + int.Parse(num[1]) + "\n");
}
Console.WriteLine(sb.ToString());
=================================================
// 11021
StringBuilder sb = new StringBuilder();

int t = int.Parse(Console.ReadLine());

int[] num = new int[t];

for (int i = 0; i < t; i++)
{
    string[] s = Console.ReadLine().Split();
    num[i] = int.Parse(s[0]) + int.Parse(s[1]);
    sb.AppendLine($"Case #{i + 1}: " + num[i].ToString());
}
Console.WriteLine(sb.ToString());
=================================================
// 11022
StringBuilder sb = new StringBuilder();

int t = int.Parse(Console.ReadLine());
int[] num = new int[t];

for (int i = 0; i < t; i++)
{
    string[] ab = Console.ReadLine().Split();
    num[i] = int.Parse(ab[0]) + int.Parse(ab[1]);
    sb.AppendLine($"Case #{i + 1}: {ab[0]} + {ab[1]} = " + num[i].ToString());
}
Console.WriteLine(sb.ToString());
=================================================
// 2438
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}
=================================================
// 2439
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (j <= (n - i)) Console.Write(" ");
        else Console.Write("*");
    }
    Console.WriteLine();
}
=================================================
// 10952
StringBuilder answer = new StringBuilder();

while (true)
{
    string[] s = Console.ReadLine().Split();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);

    if (a == 0 && b == 0) break;

    answer.AppendLine((a + b).ToString());
}
Console.WriteLine(answer);
=================================================
// 10951
while (true)
{
    string input = Console.ReadLine();

    if (input == null) break;
    string[] s = input.Split();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    Console.WriteLine(a + b);
}
=================================================
 
 */
#endregion

#region 1차원 배열
/*
// 10807
int n = int.Parse(Console.ReadLine());

string[] numbers = Console.ReadLine().Split();

string f = Console.ReadLine();

int result = Array.FindAll(numbers, x => x == f).Length;
Console.WriteLine(result);
=============================================
// 10871
string[] s = Console.ReadLine().Split();
string[] q = Console.ReadLine().Split();

StringBuilder answer = new StringBuilder();

for (int i = 0; i < int.Parse(s[0]); i++)
{
    if (int.Parse(s[1]) > int.Parse(q[i])) answer.Append(q[i] + " ");
}
Console.WriteLine(answer.ToString());
=============================================
// 10818
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

string[] s = Console.ReadLine().Split();

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(s[i]);
}
Array.Sort(arr);
Console.WriteLine($"{arr[0]} {arr[n - 1]}");
=============================================
// 2562
int[] arr = new int[9];
int max = 0;
int num = 0;

for (int i = 0; i < 9; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        num = i + 1;
    }
}
Console.WriteLine(max);
Console.WriteLine(num);
=============================================
// 10810
string[] s = ReadLine().Split();

int n = int.Parse(s[0]);
int[] N = new int[n + 1];

int m = int.Parse(s[1]);

for (int q = 0; q < m; q++)
{
    string[] input = ReadLine().Split();

    int i;
    int j = int.Parse(input[1]);
    int k = int.Parse(input[2]);

    for (i = int.Parse(input[0]); i <= j; i++)
    {
        N[i] = k;
    }
}
for (int q = 1; q < n + 1; q++) 
{
    Write(N[q] + " ");
}
=============================================
// 10813
string[] s = ReadLine().Split();

int n = int.Parse(s[0]);
int m = int.Parse(s[1]);

int[] N = new int[n + 1];
N[0] = 0;

for (int q = 1; q <= n; q++)
{
    N[q] = q;
}

int temp;
for (int q = 0; q < m; q++)
{
    string[] ij = ReadLine().Split();

    int i = int.Parse(ij[0]);
    int j = int.Parse(ij[1]);

    temp = N[i];
    N[i] = N[j];
    N[j] = temp;
}
for (int q = 1; q < n + 1; q++)
{
    Write(N[q] + " ");
}
=============================================
// 5597
int[] ns = new int[31];

for (int i = 0; i < 28; i++)
{
    int n = int.Parse(ReadLine());
    ns[n] = 1;
}

for (int i = 1; i < 31; i++)
{
    if (ns[i] != 1) WriteLine(i);
}
=============================================
// 3052
using System.Linq;

int[] arr = new int[10];
for (int i = 0; i < 10; i++)
{
    arr[i] = int.Parse(ReadLine()) % 42;
}
WriteLine(arr.Distinct().Count());
=============================================
// 10811
string[] nm = ReadLine().Split();

int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

int[] N = new int[n];

int i;
int temp;
for (i = 0; i < N.Length; i++)
{
    N[i] = i + 1;
}
for (i = 0; i < m; i++)
{
    string[] ab = ReadLine().Split();
    int a = int.Parse(ab[0]) - 1;
    int b = int.Parse(ab[1]) - 1;

    while (a < b)
    {
        temp = N[a];
        N[a++] = N[b];
        N[b--] = temp;
    }
}
for (i = 0; i < N.Length; i++)
{
    Write(N[i] + " ");
}
=============================================
// 1546
int n = int.Parse(ReadLine());
string[] s = ReadLine().Split();
float[] score = Array.ConvertAll(s, float.Parse);

float max = float.MinValue;

for (int i = 0; i < n; i++)
{
    if (score[i] > max) max = score[i];
}
float sum = 0.0f;
for (int i = 0; i < n; i++)
{
    score[i] = score[i] / max * 100;
    sum += score[i];
}
WriteLine("{0:0.00####}", sum / n);
=============================================
 */
#endregion