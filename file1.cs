using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      // объявить массив типа double, выделить память для массива
      double[] A = new double[10];
      Random rnd_num = new Random();

      // заполнить массив случайными числами в диапазоне от 0 до 20
      for (int i = 0; i < A.Length; i++)
      {
        A[i] = rnd_num.NextDouble() * 2000;
      }

      // вывести массив для проверки
      Console.WriteLine("Array A:");
      for (int i = 0; i < A.Length; i++)
      {
        Console.Write("{0:f3} ", A[i]);
      }
      Console.WriteLine();

      // Использование цикла foreach для вычисления суммы элементов массива
      double summ = 0;
      foreach (double item in A)
      {
        summ += item;
      }

      Console.WriteLine("summ = {0:f3}", summ);
      Console.ReadKey();
    }
  }
}