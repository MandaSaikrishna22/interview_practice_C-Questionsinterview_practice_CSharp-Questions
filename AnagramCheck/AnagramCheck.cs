using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AnagramCheck
{
    internal class Program
    {
        //An anagram is a word formed by rearranging the letters of another word using the exact same characters the exact same number of times
        //(for example, "listen" and "silent").
      //Below Time Complexity : O(n log n)
        static void Main(string[] args)
        {
            string str1 = "listen";
            string str2 = "silent";

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("It is not a anagram");
            }
            else
            {
                char[] arr1 = str1.ToLower().ToCharArray();
                char[] arr2 = str2.ToLower().ToCharArray();

                arr1.Sort();
                arr2.Sort();
                bool anagramFlag = true;

                for(int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        continue;
                    }
                    else
                    {
                        anagramFlag = false;
                    }
                }
                if (anagramFlag)
                {
                    Console.WriteLine("It is a anagram");
                }
            }
        }
    }
}
