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

#region 기존문제모음
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

#region 문자열
/*
// 27866
using System.Linq;
using static System.Console;

string input = ReadLine();
string input_i = ReadLine();

int i = int.Parse(input_i);

WriteLine(input.ElementAt(i - 1));
===================================================
// 2743
string input = ReadLine();
WriteLine(input.Length);
===================================================
// 9086
string stringNumber = ReadLine();
int intNum = System.Convert.ToInt32(stringNumber);

string[] result = new string[intNum];
for (int i = 0; i < intNum; i++)
{
    string testCase = ReadLine();
    char[] array = testCase.ToCharArray();
    result[i] = array[0].ToString() + array[array.Length - 1].ToString();
}

foreach (string c in result)
{
    WriteLine(c);
}
===================================================
// 11654
char a = Convert.ToChar(ReadLine());
int x = Convert.ToInt32(a);

WriteLine(x);
===================================================
// 11720
int n = int.Parse(ReadLine());
string numbers = ReadLine();
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += int.Parse(numbers[i].ToString());
}
WriteLine(sum);
===================================================
// 10809
string s = ReadLine();
for (int i = 97; i < 123; i++)
{
    if (s.Contains(Convert.ToChar(i)))
    {
        Write(s.IndexOf(Convert.ToChar(i)));
        Write(" ");
    }
    else Write("-1 ");
}
===================================================
// 2675
int testCount = int.Parse(ReadLine());
StringBuilder output = new StringBuilder();

for (int i = 0; i < testCount; i++)
{
    string[] testCases = ReadLine().Split(" ");
    int spellRepeatCount = int.Parse(testCases[0]);
    string testString = testCases[1];

    for (int j = 0; j < testString.Length; j++)
    {
        output.Append(testString[j], spellRepeatCount);
    }
    output.Append("\n");
}
WriteLine(output.ToString());
===================================================
// 1152
int answer = 0;
string s = ReadLine().Trim();

for (int i = 0; i < s.Length; i++)
{
    if (s[i] == ' ') answer++;
}
if (s.Length == 0) WriteLine(0);
else WriteLine(answer + 1);
===================================================
// 2908
string[] s = ReadLine().Split();
int[] a = Array.ConvertAll(s, int.Parse);

int n1 = 0;
int n2 = 0;

while (a[0] > 0)
{
    n1 += a[0] % 10;
    n1 *= 10;
    a[0] /= 10;
}
while (a[1] > 0)
{
    n2 += a[1] % 10;
    n2 *= 10;
    a[1] /= 10;
}
WriteLine(n1 >= n2 ? n1 / 10 : n2 / 10);
===================================================
// 5622
int sum = 0;
char[] ch = ReadLine().ToUpper().ToCharArray();

for (int i = 0; i < ch.Length; i++)
{
    if ('A' <= ch[i] && ch[i] <= 'C') sum += 3;
    else if ('D' <= ch[i] && ch[i] <= 'F') sum += 4;
    else if ('G' <= ch[i] && ch[i] <= 'I') sum += 5;
    else if ('J' <= ch[i] && ch[i] <= 'L') sum += 6;
    else if ('M' <= ch[i] && ch[i] <= 'O') sum += 7;
    else if ('P' <= ch[i] && ch[i] <= 'S') sum += 8;
    else if ('T' <= ch[i] && ch[i] <= 'V') sum += 9;
    else if ('W' <= ch[i] && ch[i] <= 'Z') sum += 10;
}
WriteLine(sum);
===================================================
// 11718
while (true)
{
    string input = ReadLine();
    WriteLine(input);

    if (String.IsNullOrEmpty(input)) return;
}
===================================================
*/

#endregion

#region 심화 1단계
/*
// 25083
WriteLine("         ,r'\"7");
WriteLine("r`-_   ,'  ,/");
WriteLine(" \\. \". L_r'");
WriteLine("   `~\\/");
WriteLine("      |");
WriteLine("      |");
===========================================
// 3003
string[] input = ReadLine().Split();
int[] s = { 1, 1, 2, 2, 2, 8 };
for (int i = 0; i < input.Length; i++)
{
    s[i] -= int.Parse(input[i]);
}
foreach (int j in s)
{
    Write(j.ToString() + " ");
}
===========================================
// 2444
int n = int.Parse(ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 0; j < n - i; j++) Write(" ");
    for (int j = 0; j < (i - 1) * 2 + 1; j++) Write("*");
    WriteLine();
}
for (int i = n - 1; i >= 1; i--)
{
    for (int j = 0; j < n - i; j++) Write(" ");
    for (int j = 0; j < (i - 1) * 2 + 1; j++) Write("*");
    WriteLine();
}
===========================================
// 10988
string input = ReadLine();
int answer = 1;
char[] string_1 = new char[input.Length];
char[] string_2 = new char[input.Length];
for (int i = 0; i < input.Length; i++)
{
    string_1[i] = input[i];
}
int count = 0;
for (int i = input.Length; i > 0; i--)
{
    string_2[count] = input[i - 1];
    count++;
}

for (int i = 0; i < input.Length; i++)
{
    if (string_1[i] != string_2[i])
    {
        answer = 0;
        break;
    }
}
WriteLine(answer);
===========================================
// 1157
string inputStr = ReadLine().ToUpper();
int[] intArray = new int[91];

for (int i = 0; i < inputStr.Length; i++) intArray[inputStr[i]]++;

int max = 0;
char c = '?';
for (int i = 'A'; i <= 'Z'; i++)
{
    if (intArray[i] > max)
    {
        max = intArray[i];
        c = (char)i;
    }
    else if (intArray[i] == max) c = '?';
}
WriteLine(c);
===========================================
// 2941
string word = ReadLine();

word = word.Replace("c=", "1");
word = word.Replace("c-", "1");
word = word.Replace("dz=", "1");
word = word.Replace("d-", "1");
word = word.Replace("lj", "1");
word = word.Replace("nj", "1");
word = word.Replace("s=", "1");
word = word.Replace("z=", "1");

WriteLine(word.Count());
===========================================
// 1316
static void Main(string[] args)
{
    int n = int.Parse(ReadLine());
    string[] words = new string[n];
    int count = 0;

    for (int i = 0; i < n; i++) words[i] = ReadLine();

    for (int i = 0; i < n; i++)
    {
        if (checkWord(words[i])) count++;
    }
    WriteLine(count);
}

static bool checkWord(string word)
{
    for (int i = 0; i < word.Length; i++)
    {
        for (int j = 0; j < word.Length; j++)
        {
            if (j - i > 1)
            {
                if (word[i] == word[j]) return false;
            }
            if (word[i] == word[j]) i += j - i;
        }
    }
    return true;
}
===========================================
// 25206
double total = 0;
double score_total = 0;
for (int i = 0; i < 20; i++)
{
    string subject = ReadLine();
    string[] token = subject.Split();
    string name = token[0];
    double credit = double.Parse(token[1]);
    string score = token[2];

    if (score == "A+")
    {
        total += credit;
        score_total += (4.5 * credit);
    }
    else if (score == "A0")
    {
        total += credit;
        score_total += (4.0 * credit);
    }
    else if (score == "B+")
    {
        total += credit;
        score_total += (3.5 * credit);
    }
    else if (score == "B0")
    {
        total += credit;
        score_total += (3.0 * credit);
    }
    else if (score == "C+")
    {
        total += credit;
        score_total += (2.5 * credit);
    }
    else if (score == "C0")
    {
        total += credit;
        score_total += (2.0 * credit);
    }
    else if (score == "D+")
    {
        total += credit;
        score_total += (1.5 * credit);
    }
    else if (score == "D0")
    {
        total += credit;
        score_total += (1.0 * credit);
    }
    else if (score == "F")
    {
        total += credit;
        score_total += (0.0 * credit);
    }
}
WriteLine(Math.Round(score_total / total, 6));
===========================================
*/
#endregion

#region 2차원 배열
/*
// 2738
string stringN = ReadLine();
string[] stringArray = stringN.Split(' ', StringSplitOptions.None);
int Y = Convert.ToInt32(stringArray[0]);
int X = Convert.ToInt32(stringArray[1]);

int[,] matrixA = new int[Y, X];
for (int i = 0; i < Y; i++)
{
    string s = ReadLine();
    string[] sArray = s.Split(' ', StringSplitOptions.None);
    for (int j = 0; j < X; j++) matrixA[i, j] = Convert.ToInt32(sArray[j]);
}

int[,] matrixB = new int[Y, X];
for (int i = 0; i < Y; i++)
{
    string s = ReadLine();
    string[] sArray = s.Split(' ', StringSplitOptions.None);
    for (int j = 0; j < X; j++) matrixB[i, j] = Convert.ToInt32(sArray[j]);
}

int[,] matrixR = new int[Y, X];
for (int i = 0; i < Y; i++)
{
    for (int j = 0; j < X; j++)
    {
        matrixR[i, j] = matrixA[i, j] + matrixB[i, j];
        Write(matrixR[i, j] + " ");
    }
    WriteLine();
}
====================================
// 2566
int max = 0;
int[,] array = new int[9, 9];
int max_i = 0;
int max_j = 0;
for (int i = 0; i < 9; i++)
{
    string row = ReadLine();
    string[] token = row.Split();
    for (int j = 0; j < 9; j++)
    {
        array[i, j] = int.Parse(token[j]);
        if(max < array[i, j])
        {
            max_i = i;
            max_j = j;
            max = array[i, j];
        }
    }
}
WriteLine(max);
WriteLine($"{max_i + 1} {max_j + 1}");
====================================
// 10798
string[,] array = new string[5, 15];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 15; j++)
    {
        array[i, j] = "+";
    }
}

for (int i = 0; i < 5; i++)
{
    string r = ReadLine();
    string[] token = r.Split();
    for (int j = 0; j < r.Length; j++) array[i, j] = r[j].ToString();
}

for (int i = 0; i < 15; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array[j, i] == "+") continue;
        else Write(array[j, i]);
    }
}
====================================
// 2563
int[,] array = new int[100, 100];

int answer = 0;
int n = int.Parse(ReadLine());
for (int i = 0; i < n; i++)
{
    string input = ReadLine();
    string[] token = input.Split();
    int x = int.Parse(token[0]);
    int y = int.Parse(token[1]);

    for (int j = x; j < x + 10; j++)
    {
        for (int w = y; w < y + 10; w++)
        {
            if (array[j , w] == 0)
            {
                array[j, w] = 1;
                answer++;
            }
        }
    }
}
WriteLine(answer);
====================================
 */
#endregion

#region 일반 수학 1단계
/*
// 2745
string input = ReadLine();
string[] token = input.Split();
string n = token[0];
int m = int.Parse(token[1]);

Dictionary<string, int> dic = new Dictionary<string, int>();

for (int i = 0; i <= 35; i++)
{
    if (i < 10) dic.Add(i.ToString(), i);
    else dic.Add(((char)(i + 55)).ToString(), i);
}

int count = 0;
double total = 0;
for (int i = n.Length - 1; i>= 0; i--)
{
    total += ((double)Math.Pow(m, count) * dic[n[i].ToString()]);
    count++;
}
WriteLine(total);
=====================================
// 11005
string[] input = ReadLine().Split();
int n = int.Parse(input[0]);
int b = int.Parse(input[1]);
ArrayList arr = new ArrayList();
while (n > 0)
{
    int temp = n % b;
    n = n / b;
    if (temp >= 10)
    {
        temp += 55;
        arr.Add((char)temp);
    }
    else arr.Add(temp);
}
arr.Reverse();
foreach (var a in arr)
{
    Write(a);
}
=====================================
// 2720
int t = int.Parse(ReadLine());

for (int i = 0; i < t; i++)
{
    int money = int.Parse(ReadLine());
    int quarter = money / 25;
    money %= 25;
    int dime = money / 10;
    money %= 10;
    int nickel = money / 5;
    money %= 5;
    int penny = money;

    WriteLine("{0} {1} {2} {3}", quarter, dime, nickel, penny);
}
=====================================
// 2903
double n = double.Parse(ReadLine());
double square = 1 * Math.Pow(2, n);
double dot = square + 1;
double result = Math.Pow(dot, 2);

WriteLine(result);
=====================================
// 2292
double n = double.Parse(ReadLine());
if (n == 1) WriteLine(1);
else
{
    int start = 0;
    int gap = 1;
    int answer = 1;
    while (true)
    {
        if (n >= (6 * start + 2) && n <= (6 * (start + gap) + 1))
        {
            WriteLine(answer + 1);
            return;
        }
        start += gap;
        gap++;
        answer++;
    }
}
=====================================
// 1193
int x = int.Parse(ReadLine());

int level = 1;
int temp = 1;

while (temp < x)
{
    level++;
    temp += level;
}
int den = temp - x + 1;
if (level % 2 == 0) WriteLine($"{level + 1 - den}/{den}");
else WriteLine($"{den}/{level + 1 - den}");
=====================================
// 2869
string[] inputRaw = ReadLine().Split(' ');
int climbDistance = int.Parse(inputRaw[0]);
int fallDistance = int.Parse(inputRaw[1]);
int goalDistance = int.Parse(inputRaw[2]);

goalDistance -= fallDistance;

int dailyDistance = climbDistance - fallDistance;
int days = goalDistance / dailyDistance;
if ((goalDistance % dailyDistance) != 0) days += 1;
WriteLine(days);
=====================================
*/
#endregion

#region 약수와 배수 소수
/*
// 5086
while (true)
{
    string[] token = ReadLine().Split();
    int first = int.Parse(token[0]);
    int second = int.Parse(token[1]);

    if (first == 0 && second == 0) return;

    if ((first % second) == 0) WriteLine("multiple");
    else if ((second % first) == 0) WriteLine("factor");
    else WriteLine("neither");
}
==================================
// 2501
string n_string = ReadLine();
string[] token = n_string.Split();

int n = int.Parse(token[0]);
int k = int.Parse(token[1]);
int a = n;
List<int> list = new List<int>();

while (a> 0)
{
    if (n % a == 0) list.Add(a);
    a--;
}
list.Sort();

if (list.Count < k) WriteLine(0);
else WriteLine(list[k - 1]);
==================================
// 9506
using System.Collections.Generic;
using System.Linq;

while (true)
{
    int num = int.Parse(ReadLine());
    List<int> list = new List<int>();
    int add_num = 0;
    if (num == -1) break;
    for (int i = 1; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0) list.Add(i);
    }

    int cnt = list.Count;
    for (int i = 0; i < cnt; i++)
    {
        if (num / list[i] != num) list.Add(num / list[i]);
    }
    list = list.Distinct().ToList();
    list.Sort();
    cnt = list.Count;

    for (int i = 0; i < cnt; i++)
        add_num += list[i];

    if (add_num == num)
    {
        Write(num + " = " + list[0]);
        for (int i = 1; i < cnt; i++)
            Write(" + " + list[i]);
    }
    else
        Write(num + " is NOT perfect.");
    WriteLine();
}
==================================
// 1978
int num = int.Parse(ReadLine());
string word = ReadLine();
string[] token = word.Split();
int answer = num;
for (int i = 0; i < num; i++)
{
    if (int.Parse(token[i]) == 1)
    {
        answer--;
        continue;
    }
    for (int j = 2; j < int.Parse(token[i]); j++)
    {
        if (int.Parse(token[i]) % j == 0)
        {
            answer--;
            break;
        }
    }
}
Write(answer);
==================================
// 2581
static void Main(string[] args)
{
int n1 = int.Parse(ReadLine());
int n2 = int.Parse(ReadLine());
int max = 0;
int min = 0;

for (int index = n1; index <= n2; index++)
{
    if (IsPrime(index))
    {
        if (min == 0) min = index;
        max += index;
    }
}

if (min == 0) WriteLine(-1);
else WriteLine(max + "\n" + min);
}

public static bool IsPrime (int num)
{
if (num == 1) return false;

for (int i = 2; i <= num / 2; i++)
{
    if (num % i == 0) return false;
}
return true;
}
==================================
// 11653
int n = int.Parse(ReadLine());

for (int i = 2; i * i <= n; i++)
{
    while (n % i == 0)
    {
        WriteLine(i);
        n /= i;
    }
}
if (n > 1) WriteLine(n);
==================================
*/
#endregion

#region 직각삼각형과 삼각형 단계
/*
// 27323
int x = int.Parse(ReadLine());
int y = int.Parse(ReadLine());

WriteLine(x * y);
=====================================
// 1085
int[] input = Array.ConvertAll(ReadLine().Split(' '), int.Parse);

int x = input[0];
int y = input[1];
int w = input[2];
int h = input[3];

int[] NumArray = new int[] { x, y, w - x, h - y };
int min = NumArray[0];

for (int i = 1; i < NumArray.Length; i++)
{
    if (min > NumArray[i]) min = NumArray[i];
}
WriteLine(min);
=====================================
// 3009
string[] s = ReadLine().Split();
int x1 = int.Parse(s[0]);
int y1 = int.Parse(s[1]);
int x = 0;
int y = 0;
int cx = 0;
int cy = 0;
for (int i = 0; i < 2; i++)
{
    string[] s1 = ReadLine().Split();
    int x2 = int.Parse(s1[0]);
    int y2 = int.Parse(s1[1]);
    if (x1 == x2) cx++;
    else x = x2;
    if (y1 == y2) cy++;
    else y = y2;
}
Write("{0} {1}", cx == 1 ? x : x1, cy == 1 ? y : y1);
=====================================
// 15894
long n = long.Parse(ReadLine());
WriteLine(4 * n);
=====================================
// 9063
int n = int.Parse(ReadLine());
int rx = int.MinValue;
int ry = int.MinValue;
int lx = int.MaxValue;
int ly = int.MaxValue;

for (int i = 0; i< n; i++)
{
    int[] input = Array.ConvertAll(ReadLine().Split(" "), int.Parse);
    rx = Math.Max(input[0], rx);
    ry = Math.Max(input[1], ry);
    lx = Math.Min(input[0], lx);
    ly = Math.Min(input[1], ly);
}
WriteLine((rx - lx) * (ry - ly));
=====================================
// 10101
string st = ReadLine();
int a = int.Parse(st);
string st1 = ReadLine();
int b = int.Parse(st1);
string st2 = ReadLine();
int c = int.Parse(st2);
int sum = a + b + c;
if (sum == 180)
{
    if (a == 60 && b == 60 && c == 60) Write("Equilateral");
    else if (a == b || b == c || a == c) Write("Isosceles");
    else Write("Scalene");
}
else Write("Error");
=====================================

*/
#endregion

#region 시간복잡도
/*
// 24262
WriteLine(1);
WriteLine(0);
============================================
// 24263
int n = int.Parse(ReadLine());
WriteLine(n);
WriteLine(1);
============================================
// 24264
long.TryParse(ReadLine(), out long n);
WriteLine("{0}\n{1}", n * n, 2);
============================================
// 24267
Int64 n = Int64.Parse(ReadLine());
Int64 count = (n - 2) * (n - 1) * n / 6;
WriteLine($"{count}\n3");
============================================
// 24313
string[] s = ReadLine().Split();
int a1 = int.Parse(s[0]);
int a2 = int.Parse(s[1]);
int c = int.Parse(ReadLine());
int n = int.Parse(ReadLine());

if (a1 * n + a2 <= c * n && c >= a1) WriteLine(1);
else WriteLine(0);
============================================
*/
#endregion

#endregion

#region 정렬

#endregion

#region 약수, 배수와 소수 2

#endregion

#region 스택, 큐, 덱

#endregion