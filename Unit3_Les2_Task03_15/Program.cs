// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// 2. По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");

int a = int.Parse(Console.ReadLine()!);

if (a <= 5)
{Console.WriteLine("Будни");}
else
{Console.WriteLine("Выходной");}

if (a == 1)
{     Console.WriteLine("понедельник");}
if (a == 2)
{     Console.WriteLine("вторник");}
if (a == 3)
{     Console.WriteLine("среда");}
if (a == 4)
{     Console.WriteLine("четверг");}
if (a == 5)
{     Console.WriteLine("пятница");}
if (a == 6)
{     Console.WriteLine("суббота");}
if (a == 7)
{     Console.WriteLine("воскресенье");}
