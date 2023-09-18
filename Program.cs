worked with Allysa Martinez

   using System;

public class Program {

  public static void Main(string[] args) {
    //---------------------------------------------- QUESTION 1
    Console.WriteLine("Input an integer:");
    string prime = Console.ReadLine();
    int N = Convert.ToInt32(prime);
    while (N ==1, 2) {
      if (N == 2) {
        Console.WriteLine("N is prime");
        break;
      } else if (N == 1) {
        Console.WriteLine("N is a composite");
        break;
      }
    }
    if (N != 1 || N != 2) {

      for (int x = 2; x < N; x++) {
        if (N % x == 0) {
          Console.WriteLine("N is non-prime");
          break;
        } else if (N % x != 0) {
          if (N - 1 == x && N % x != 0) {
            Console.WriteLine("N is prime");
          } else {
            continue;
          }
        }
      }
      //---------------------------------------------- QUESTION 2
      Console.WriteLine("\nAssign an int value to N:");
      string box = Console.ReadLine();
      int Nbox = Convert.ToInt32(box);
      for (int z = 0; z < Nbox; z++) {
        for (int y = 0; y < Nbox; y++) {
          Console.Write("*");
          if (y + 1 == Nbox) {
            Console.Write("\n");
            break;
          }
        }
      }
      //---------------------------------------------- QUESTION 3
      Console.WriteLine("\nAssign an int value to N:");
      string tri = Console.ReadLine();
      int Ntri = Convert.ToInt32(tri);
      for (int h = 0; h < Ntri; h++) {
        for (int g = 0; g < Ntri; g++) {
          Console.Write("*");
          if (g == h) {
            Console.Write("\n");
            break;
          } else {
            continue;
          }
        }
      }
      //---------------------------------------------- BONUS 
      Console.WriteLine("\nAssign an int value to N:");
      string tri_b = Console.ReadLine();
      int Ntri_b = Convert.ToInt32(tri_b);
      int count = 0;
      int space = 0;
      for (int t = 0; t < Ntri_b; t++) {
        count++;
        while (space <= Ntri_b) {
          Console.Write(" ");
          space++;
          if (space == Ntri_b) {
            space = count;
            break;
          }
        }
        for (int s = 0; s < Ntri_b; s++) {
          Console.Write(count);
          if (s == t) {
            Console.Write("\n");
            break;
          } else {
            continue;
          }
        }
      }
    }
  }
}




