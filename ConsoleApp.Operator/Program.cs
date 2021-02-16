using System;

namespace ConsoleApp.Operator
{
  class Program
  {
    static void Main(string[] args)
    {
      Apple apple1 = new Apple("Golden", 100, 100);
      Apple apple2 = new Apple("Antonovka", 120, 110);
      var sumApple = Apple.Add(apple1, apple2);
      var sumApple1 = apple1 + apple2;
      var sumApple2 = apple1 + 200;
      Console.WriteLine(apple1);
      Console.WriteLine(apple2);
      Console.WriteLine(sumApple);
      Console.WriteLine(sumApple1);
      Console.WriteLine(sumApple2);
      Console.ReadLine();
    }
  }
}
