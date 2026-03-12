using System;
using System.Collections;
using System.Collections.Generic;

Stack objectStack = new Stack();
objectStack.Push(100);
objectStack.Push(200);
int value1 = (int)objectStack.Pop();
int value2 = (int)objectStack.Pop();

Console.WriteLine($"값1: {value1}, 값2: {value2}");

Stack<int> intStack = new Stack<int>();
intStack.Push(100);
intStack.Push(200);

int value11 = intStack.Pop();
int value21 = intStack.Pop();

Console.WriteLine($"값1: {value1}, 값2: {value2}");

Cup<string> textCup = new Cup<string>();
textCup.Content = "커피";

Cup<int> numberCup = new Cup<int>();
numberCup.Content = 500;

Console.WriteLine($"음료: {textCup.Content}");
Console.WriteLine($"용량: {numberCup.Content}ml");

var player = new Pair<string, int>("용사", 100);
var score = new Pair<int, double>(1, 95.5);
Console.WriteLine($"이름: {player.First}, HP: {player.Second}");
Console.WriteLine($"순위: {score.First}등, 점수: {score.Second}점");

void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}

int x = 10;
int y = 20;
Console.WriteLine($"교환 전: x={x}, y={y}");

Swap(ref x, ref y);
Console.WriteLine($"교환 후: x={x}, y={y}");

string first = "사과";
string second = "바나나";

Console.WriteLine($"교환 전: first={first}, second={second}");

Swap(ref first, ref second);
Console.WriteLine($"교환 후: first={first}, second={second}");

var intContainer = new NumberContainer<int>();
intContainer.Value = 100;
Console.WriteLine($"정수값: {intContainer.Value}");

var floatContainer = new NumberContainer<float>();
floatContainer.Value = 3.14f;
Console.WriteLine($"실수값: {floatContainer.Value}");

T CreateInstance<T>() where T : new()
{
    return new T();
}

Monster monster = CreateInstance<Monster>();
Console.WriteLine($"생성된 몬스터: {monster.Name}, HP: {monster.Hp}");

T GetMax<T>(T a, T b) where T : IComparable<T>
{
    return a.CompareTo(b) > 0 ? a : b;
}

int maxInt = GetMax(10, 20);
Console.WriteLine($"더 큰 정수: {maxInt}");

string maxString = GetMax("apple", "banana");
Console.WriteLine($"사전순 뒤: {maxString}");

T GetDefaultValue<T>()
{
    return default(T);
}

int intDefault = GetDefaultValue<int>();
bool boolDefault = GetDefaultValue<bool>();
string stringDefault = GetDefaultValue<string>();

Console.WriteLine($"int 기본값: {intDefault}");
Console.WriteLine($"bool 기본값: {boolDefault}");
Console.WriteLine($"string 기본값: {stringDefault ?? "(null)"}");

List<string> names = new List<string>();
names.Add("철수");
names.Add("영희");
names.Add("민수");

Console.WriteLine("이름 목록:");
foreach (string name in names)
{
    Console.WriteLine($"  - {name}");
}

Dictionary<string, int> scores = new Dictionary<string, int>();
scores["철수"] = 95;
scores["영희"] = 88;
scores["민수"] = 92;
Console.WriteLine("\n점수:");
foreach (var pair in scores)
{
    Console.WriteLine($"  {pair.Key}: {pair.Value}점");
}

var special = new SpecialContainer<string>();
special.Item = "특별한 아이템";
special.Description = "레어 등급";
Console.WriteLine($"{special.Item} ({special.Description})");
var intBox = new IntContainer();
intBox.Item = 50;
Console.WriteLine($"값: {intBox.Item}, 두 배: {intBox.Double()}");

Counter<int>.Count++;
Counter<int>.Count++;
Counter<string>.Count++;
Console.WriteLine($"Counter<int>.Count: {Counter<int>.Count}");
Console.WriteLine($"Counter<string>.Count: {Counter<string>.Count}");