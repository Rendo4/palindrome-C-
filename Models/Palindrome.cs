using System; //maybe we need this? see: https://www.learnhowtoprogram.com/c-and-net-part-time/objects-and-methods/static-methods

namespace Palindrome
{
public class Program
{
  public static void Main()
  {
    Palindrome somethingElse = new Palindrome (stringWord, 0);
    Console.WriteLine("Enter a word: ");
    string stringWord = Console.ReadLine();
    // Console.WriteLine(Palindrome.IsPalindrome(stringWord));

  }

  public bool IsPalindrome(string stringWord)
    {
        Array myArray = Array.CreateInstance(typeof(string), stringWord.Length);
        myArray = stringWord.Split("");
        Console.WriteLine(myArray);
        // string[] reverseArray = Array.Reverse(myArray); //we have a new error now at least (cannot convert void to string[])

        // if (myArray == reverseArray) return true;
        // else return false;
        return false;

    }
   
  }
}

