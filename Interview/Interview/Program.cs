using System;
using System.Linq;
using System.Collections;
using System.Dynamic;
using System.Collections.Generic;

namespace Interview
{
    class ReverseString  //using temprory variable
    {
        static void Main1(string[] args)
        {
            String input = "This is a string";
            Console.WriteLine("This is input string : " + input);
            String[] words = input.Split();
            //Array.Reverse(words);
            for (int i = 0; i < words.Length / 2; i++)
            {
                String temp = words[i];
                words[i] = words[words.Length - i - 1];
                words[words.Length - i - 1] = temp;
            }
            String reverse = String.Join(" ", words);

            Console.WriteLine("This is output string : " + reverse);
        }
    }
}

class ReverseStringDifferent
{
    static void Main28(String[] args)
    {
        string input = "This is a string";
        string[] words = input.Split();
        string reverseWord = string.Empty;
        for (int i = words.Length - 1; i >= 0; i--)
        {         
            reverseWord = reverseWord + words[i];
        }
        Console.WriteLine(reverseWord + " ");
    }
}

class ReverseEachWordInAString
{
    static void Main4(string[] args)
    {
        String input = "This is a string";
        String[] words = input.Split();
        for (int i = 0; i < words.Length; i++)
        {
            //convert words into character array
            char[] charArray = words[i].ToCharArray();
            //reverse the character array
            //Array.Reverse(charArray);
            
            for (int j = 0; j < charArray.Length / 2; j++)
            {
                char temp = charArray[j];
                charArray[j] = charArray[charArray.Length - j - 1];
                charArray[charArray.Length - j - 1] = temp;
            }
            
            //convert character array into words]
            words[i] = new string(charArray);
        }
        //convert words into string
        String reverse = string.Join(" ", words);
        Console.WriteLine(reverse);
    }
}
public class Program
{
    public static void Main27()
    {
        string str = "Temporary string";
        string[] s = str.Split(' ');
        foreach (string temp in s)
        {
            string reverseWord = string.Empty;
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                reverseWord = reverseWord + temp[i];
            }
            Console.Write(reverseWord + " ");
        }
    }
}
class RemoveDuplicatesfromAString
{
    static void Main3(string[] args)
    {
        String input = "This is a string";
        String output = " ";
        //String[] words = input.Split();
        //List<String> Listofwords = new List<String>();
        //for (int i = 0; i < words.Length; i++)
        //{
        //    if (!Listofwords.Contains(words[i]))
        //    {
        //        Listofwords.Add(words[i]);
        //    }
        //    Console.WriteLine(words[i]);
        //}
        foreach (char c in input)
        {
            // index of operator : The method returns -1 if the character or string is not found.
            //check for each character in string, if indexof returns -1 then add that character in output
            if (output.IndexOf(c) == -1)
            {
                output = output + c;
            }
        }
        Console.WriteLine(output);
    }
}

class OccuranceOfParticularCharacterInAString
{
    static void Main5(string[] args)
    {
        String input = "This is a string";
        char ch = 's';
        int count = 0;

        foreach (char c in input)
        {
            if (c == ch)
            {
                count++;
            }
        }
        Console.WriteLine("Occurance of character {0} in a string is {1} times ", ch, count);
    }
}


class SearchAWordInAstring
{
    static void Main6(string[] args)
    {
        String input = "This is a string";
        String[] words = input.Split(" ");
        String search = "not";
        bool found = false;
        foreach (string s in words)
        {
            if (s == search)
            {
                found = true;
                break;
            }
        }
        if (found == true)
        {
            Console.WriteLine("The word '{0}' is found", search);
        }
        else
        {
            Console.WriteLine("The word '{0}' is not found", search);
        }
    }
}

class Palindrome
{
    static void Main6(String[] args)
    {
        String input = "madam";
        String reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        Console.WriteLine(reversed);
        if (reversed == input)
        {
            Console.WriteLine("String is palindrome");
        }
        else
        {
            Console.WriteLine("String is not a palindrome");
        }
    }
}

class Anagram
{
    static void Main8(String[] args)
    {
        String input1 = "race";
        String input2 = "care";
        char[] arr1 = input1.ToLower().ToCharArray();
        char[] arr2 = input2.ToLower().ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        String val1 = new string(arr1);
        String val2 = new string(arr2);
        if (val1 == val2)
        {
            Console.WriteLine("Given string is anagram");
        }
        else
        {
            Console.WriteLine("Not anagram");
        }
    }
}

class CountCapitalandSmallLetters
{
    static void Main9(String[] args)
    {
        String Input = "TDJRjdl wkdjkD ";
        int CapCount = 0;
        int smallCount = 0;
        for (int i = 0; i < Input.Length; i++)
        {
            if (char.IsUpper(Input[i]))
            {
                CapCount++;
            }
            else if (char.IsLower(Input[i]))
            {
                smallCount++;
            }

        }
        Console.WriteLine($"Count of capital letters in a string are : {CapCount}");
        Console.WriteLine($"Count of small letters in a string are : {smallCount}");
    }
}

class SortArrayinAsscending
{
    static void Main(String[] args)
    {
        int[] arr = { 10, 15, 5, 8 };
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }

    }
}

class SumofDigits
{
    public static void Main11(String[] args)
    {
        int n = 2567;
        int sum = 0;
        /*
        for(int i = n; i != 0; i = i/10 )
        {
            sum = sum + i % 10;
        }*/
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of digits is : " + sum);
    }
}

class Factorial
{
    static void Main12()
    {
        int n = 5;
        int ans = 1;
        while (n > 0)
        {
            ans *= n;
            n--;
        }
        Console.WriteLine(ans);
    }
}

class FibonacciSeries
{
    static void Main13()
    {
        int num = 6;
        int first = 0;
        int second = 1;
        int next;
        Console.Write("Fibonacci series :  " + first + " " + second);
        for (int i = 2; i < num; i++)
        {
            next = first + second;
            Console.Write(" " + next);
            first = second;
            second = next;
        }
    }
}

class SecondLargestElement
{
    public static void Main14(String[] args)
    {
        int[] arr = { 5, 8, 1, 6, 9, 3, 7, 2, 4 };
        int largest = arr[0], secondLargest = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            //for i = 1
            //if 8(arr[1] > 5(arr[0]
            //then 5 is now second largest
            // and largest is 8
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            // and if arr[1]i.e 8 is not greater than largest 5
            //check if it is greater than secondLargest and not equal to largest. If it is, we update only secondLargest.
            //We don't update secondLargest if the current element is equal to largest,
            //because in that case it cannot be the second largest element.
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }
        Console.WriteLine("Second largest element is " + secondLargest);
    }
}

class ThirdLargestElement
{
    public static void Main15(String[] args)
    {
        int[] arr = { 5, 8, 1, 6, 9, 3, 7, 2, 4 };
        int first = arr[0], second = int.MinValue, third = int.MinValue;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > first)
            {
                third = second;
                second = first;
                first = arr[i];
            }
            else if (arr[i] > second && arr[i] != first)
            {
                third = second;
                second = arr[i];
            }
            else if (arr[i] > third && arr[i] != second && arr[i] != first)
            {
                third = arr[i];
            }
        }
        Console.WriteLine("Third largest element is " + third);
    }
}

class primeNumber
{
    static void Main16(String[] args)
    {
        int num = 13;
        int flag = 0;

        if (num == 0 || num == 1)
        {
            Console.WriteLine("Number {0} is not a prime number ", num);
        }
        else
        {
            for (int i = 2; i < num/2; i++)
            {
                if ((num % i) == 0)
                {
                    Console.WriteLine("Number {0} is not a prime number ", num);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Number {0} is a prime number ", num);
            }
        }

    }
}

class pyramid
{
    static void Main17(String[] args)
    {
        int n = 6;
        for(int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < (2 * i) - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
/*
     *
    **
   ***
 */
class pattern
{
    static void Main18(String[]args)
    {
        int n = 8;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n - i- 1; j++)
            {
                Console.Write(" ");
            }
            for(int k = 0; k < i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }


    }

}

class practice
{
    static void Main20()
    {
        String input = "This is a string";
        String[] words = input.Split();
        String reversed = " ";
        for(int i = 0; i < words.Length/2; i++)
        {
            String temp = words[i];
            words[i] = words[words.Length - i - 1];
            words[words.Length - i - 1] = temp;
        }
        reversed = String.Join(" ", words);
        Console.WriteLine(reversed);
    }
}

/*
 * 1 2 3 4 
 * 5 6 7
 * 8 9
 * 10
 */
 class reverseNumber
{
    static void Main21()
    {
        int k = 1;
        //for row number outer for loop
        for(int i = 1; i <= 4; i++) //outer loop for row as there are 4 rows
        {
            for(int j = i; j <= 4; j++) //inner loop will start from i and will complete till the last value 
            {
                Console.Write(k);
                Console.Write("\t");
                k++;
            }
            Console.WriteLine("");
        }
    }
}

class UniqueNumber
{
    static void Main22()
    {
        int[] a = { 1, 4, 4, 4, 6, 7, 6, 8, 8 };
        //Create an empty array list and push the number to it
        List<int> ab = new List<int>();
        for(int i = 0; i< a.Length; i++)
        {
            int k = 0;
            if (!ab.Contains(a[i]))
            {
                ab.Add(a[i]);
                k++;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == a[i])
                    {
                        k++;
                    }
                }
                Console.WriteLine(a[i] + " is repeated " + k + " times");   
            }
            if (k == 1)
                Console.WriteLine(a[i] + " is unique number");
        }
    }
}

class ReverseArray
{
    static void Main23()
    {
        int[] a = { 4, 5, 7, 9, 10, 11, 12, 13 };

        for (int i = 0; i < a.Length / 2; i++)
        {
            int temp = a[i];
            a[i] = a[a.Length - i - 1];
            a[a.Length - i - 1] = temp;
        }
        //foreach ( int element in a)
        //{
        //    Console.Write(element + "\t");
        //}
        for (int k = 0; k < a.Length; k++)
        {
            Console.Write(a[k] + " ");
        }
    }

    static void Main24()
    {
        int[] a = { 4, 5, 7, 9, 10, 11, 12, 13 };
        int[] b = new int[a.Length];
        int index = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            b[index] = a[i];
            index++;
        }
        foreach (int element in b)
        {
            Console.Write(element + " ");
        }

    }
}

class DuplicateCharacterinaString
{
    static void Main25(string[] args)
    {
        String Input = "This is a string";
        int count = 0;
        char[] chars = Input.ToCharArray();
        Console.WriteLine("Duplicate characters are:");
        for (int i = 0; i < Input.Length; i++)
        {
            for (int j = i + 1; j < Input.Length; j++)
            {
                if (chars[i] == chars[j])
                {
                    Console.WriteLine(chars[j]);
                    count++;
                    break;
                }
            }
        }
    }
}

class ReverseString
{
    public static void Main26(String[] args)
    {
        String str = "Automation Practise";
        String reverse = "";
        int length = str.Length;
        //for (int i = 0; i < length; i++)
        //{
        //    reverse = str.ElementAt(i) + reverse;
        //}
        //for (int i = length - 1; i >= 0; i--)
        //{
        //    reverse = reverse + str[i];
        //}
        for (int i = length - 1; i >= 0; i--)
        {
            reverse += str[i];
        }
            Console.WriteLine(reverse);
    }
}

class OccuranceOfCharacter
{
    public static void Main27(String[] args)
    {
        String str = "Automation Testing Interview";
        int[] count = new int[256];

        // loop through the string and count frequency of every character and store it in count array
        for (int i = 0; i < str.Length; i++)
        {
            count[str.ElementAt(i)]++;
        }

        //Print the frequency
        char[] ch = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            ch[i] = str.ElementAt(i);
            int find = 0;
            for (int j = 0; j <= i; j++)
            {
                //if any matches found  
                if (str.ElementAt(i) == ch[j])
                    find++;
            }
            if (find == 1)
                //prints occurrence of the character   
                Console.WriteLine("The occurrence of " + str.ElementAt(i) + " is: " + count[str.ElementAt(i)]);
        }
    }        
}
