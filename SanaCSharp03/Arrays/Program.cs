﻿using static System.Math;
Console.Write("Введіть N: ");
int n = int.Parse(Console.ReadLine());
double[] array = new double[n];
Random ran = new Random();
int n1;
for (int i = 0;i<array.Length;i++)
{
    n1 = ran.Next(0,2);
    array[i]=Round(ran.NextDouble()*(-100 - 100   )+100, n1);
    Console.WriteLine(array[i]);
}
double negativeElemetsSum = 0;
double maxElement = array[0];
int maxElementIndex=0;
double MaxElementByModule = array[0];
int PositiveIndexCount = 0;
for(int i =0;i<array.Length;i++)
{
    if (array[i]<0)
    {
        negativeElemetsSum+=array[i];
    }
    if (maxElement < array[i])
    {
        maxElement = array[i];
        maxElementIndex = i;
    }
    if (Abs(MaxElementByModule) < Abs(array[i]))
    {
        MaxElementByModule= array[i];
    }
    if (array[i]>0)
    {
        PositiveIndexCount += i;
    }
    
}
int SolidNumbersCount = 0;
for(int i =0;i<array.Length;i++)
{
    if (array[i]%1==0)
    {
        SolidNumbersCount++;
    }
}
Console.WriteLine($"Сума від’ємних елементів масиву: {negativeElemetsSum}\nмаксимальний елемент масиву: {maxElement}\nномер (індекс) максимального елемента масиву: {maxElementIndex}\n" +
    $"максимальний за модулем елемент масиву: {MaxElementByModule}\ncуму індексів додатних елементів: {PositiveIndexCount}\nкількість цілих чисел у масиві: {SolidNumbersCount}");