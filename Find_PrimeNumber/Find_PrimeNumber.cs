namespace Find_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 15,12,8,16,7 };

            for (int i = 0; i < nums.Length; i++)
            {
                bool primeflag = true;
                if (nums[i] <= 1)
                {
                    primeflag = false;
                }
                else
                {
                    // Loop 2 (j): Test divisors from 2 up to Sqrt of nums[i]
                    for (int j = 2; j < Math.Sqrt(nums[i]); j++) 
                    {
                        if (nums[i]%j==0)
                        {
                            primeflag=false;
                            break;
                        }
                    }
                }
                // Print AFTER Loop 2 finishes checking all divisors
                if (primeflag)
                {
                    Console.WriteLine(nums[i]);
                }

                //OUTPUT : 7
            }
        }
    }
}
