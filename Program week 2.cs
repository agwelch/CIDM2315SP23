using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Please input a letter grade:");
    string grade = Console.ReadLine();
    if (grade.ToUpper() == "A") {
      Console.WriteLine("GPA point: 4");
    } else if (grade.ToUpper() == "B") {
      Console.WriteLine("GPA point: 3");
    } else if (grade.ToUpper() == "C") {
      Console.WriteLine("GPA point: 2");
    } else if (grade.ToUpper() == "D") {
      Console.WriteLine("GPA point: 1");
    } else if (grade.ToUpper() == "F") {
      Console.WriteLine("GPA point: 0");
    } else {
      Console.WriteLine("Wrong Letter Grade");
    }

    Console.WriteLine("\nPlease input first number:");
    string one = Console.ReadLine();
    int Num1 = Convert.ToInt16(one);
    Console.WriteLine("Please input second number:");
    string two = Console.ReadLine();
    int Num2 = Convert.ToInt16(two);
    Console.WriteLine("Please input third number:");
    string three = Console.ReadLine();
    int Num3 = Convert.ToInt16(three);
    if ((Num1 < Num2) && (Num1 < Num3)) {
      Console.WriteLine("The smallest value is: " + Num1 + "\n");
    } else if ((Num2 < Num1) && (Num2 < Num3)) {
      Console.WriteLine("The smallest value is: " + Num2 + "\n");
    } else if ((Num3 < Num1) && (Num3 < Num2)) {
      Console.WriteLine("The smallest value is: " + Num3 + "\n");
    } else {
      Console.WriteLine("Two or more of the numbers match");
    }

    Console.WriteLine("\nPlease input a year:");
    string input = Console.ReadLine();
    int year = Convert.ToInt16(input);
    if ((year % 4 == 0) || (year % 400 == 0)) {
      if (year % 100 == 0) {
        Console.WriteLine(year + " is not a Leap Year.");
      } else {
        Console.WriteLine(year + " is a Leap Year.");
      }
    } else {
      Console.WriteLine(year + " is not a Leap Year.");
    }
  }
}