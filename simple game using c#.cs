using System;

namespace HelloWorldNotes
{

 class Forest {
        public string name; // can also be private
        public int trees;
      }


  class ProgramName
  {
    static void Main()
    {
        // write a comment /* multi-line*/
      Console.WriteLine("Hello Robert. How are you?");
      /*string answer = Console.ReadLine();
      Console.WriteLine(answer);
      Console.WriteLine($"I'm glad to hear you are {answer}");*/ 

      string myName = "Robert / \"Big Rob\" \nUK citizen";
      int myNameLength = myName.Length;
      int location = myName.IndexOf("UK");
      string nationality = myName.Substring(location); // (location, 2) for just "UK"
      char sixthChar = myName[5];
      string nameOnly = myName.Substring(0, 6).ToUpper(); // ToLower()
      string x = "Employed";
      string concat = myName + " " + x;
      int age = 36;
      double ageDouble = 36.5;
      int ageInt = (int)ageDouble;
      bool happy = false; // true also an option

      double ageLastYear = ageDouble - 1;
      Console.Write(ageDouble - age + 10 / (2 * 3) % 10);
      Console.WriteLine(ageLastYear);

      // double more accurate than float, faster than decimal. Decimal most accurate.
      decimal decName = 3.5632m;
      float floName = 4.532f;
      decName++; // --, +=, -=, 

      bool answer = 3 <= 5; // ==, !=, <, >, <=, >=
      bool both = ((4 == 4) && (5==5)); // ||(or)
      bool notOr = !(1 < 3) || both;

      if (x == "Unemployed")
      {
        Console.WriteLine("He is unemployed.");
      }
      else if (x == "Employed")
      {
        Console.WriteLine("He is employed.");
      }
      else
      {
        Console.WriteLine("Some other value.");
      }

      switch (x)
      {
        case "Unemployed":
        Console.WriteLine("Unemployed condition met");
        break;
        case "Employed":
        Console.WriteLine("Employed condition met");
        break;
        default:
        Console.WriteLine("No condition met");
        break;
      }

      string employmentStatus = (x == "Employed") ? "Yes, employed" : "No, not employed";

      MethodName("Has", "Not so good", namedArg: "Not the end");
      static void MethodName(string name, string optional = "Everything good", string namedArg = "End")
      {
        Console.WriteLine($"Method, \"{name}\" has been called. {optional}. {namedArg}.");
      }
      
      static string StringMethod()
      {
        return "This is returned";
      }
      string returnedValue = StringMethod();

      static void ExpressionBodied() => Console.WriteLine("It worked");
      ExpressionBodied();

      int[] variousNumbers = { 7, 4, 5 };
      int[] makeLater;
      makeLater = new int[] { 5, 6, 7, };
      int arrayLength = variousNumbers.Length;
      int itemTwo = variousNumbers[1];
      int[] arrayOfThree = new int[3];
      arrayOfThree[1] = 5;
      Array.Sort(variousNumbers);
      int fiveIndex = Array.IndexOf(variousNumbers, 5);
      int numberAboveSix = Array.Find(variousNumbers, num => num > 6);

      int y = 5;
      while (y > 0)
      {
        Console.WriteLine($"Printing number {y}");
        y--;
      }

      bool z = false;
      do
      {
        Console.WriteLine("It is true");
      } while (z == true);

      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine("Play three times");
      }

      for (int i = 0; i < variousNumbers.Length; i++)
      {
        Console.WriteLine(variousNumbers[i]);
      }

      foreach (int num in variousNumbers)
      {
        Console.WriteLine(num);
      }

      bool condition = true;
      while (condition == true)
      {
        Console.WriteLine("True, but i will stop...");
        break;
      }

      for (int i = 0; i < 10; i++)
      {
        if (i < 9)
        {
          continue;
        }
        Console.WriteLine("It has finished");
      }

      Forest f = new Forest();
      f.name = "Amazon";
      Console.WriteLine(f.name); // Prints "Amazon"
















     }
  }
}