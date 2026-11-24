namespace Subsets_of_An_Array
{
    internal class Program
    {
        //Start
        //Subsets: []

        //Step 1: Add 1
        //Keep:  []
        //Add 1: [1]
        //Subsets now: []  [1]


        //Step 2: Add 2
        //Keep:  []   [1]
        //Add 2: [2][1, 2]
        //Subsets now: []  [1][2][1, 2]



        //Step 3: Add 3
        //Keep:  []   [1][2][1, 2]
        //Add 3: [3][1, 3][2, 3][1, 2, 3]
        //Subsets now: []  [1][2][1, 2][3][1, 3][2, 3][1, 2, 3]

        public static List<List<int>> GetSubsetsIterative(int[] nums)
        {
            List<List<int>> result=new List<List<int>>();
            result.Add(new List<int>()) ;

            foreach(int num in nums)
            {
                int subsetcount = result.Count;
                for(int i =0;i<subsetcount;i++)
                {
                    List<int> subsets = new List<int>(result[i]);
                    subsets.Add(num) ;
                    result.Add(subsets) ;
                }

            }
            return result;
        }
        public static void Main()
        {
            int[] nums = { 1, 2, 3 };
            var subsets = GetSubsetsIterative(nums);

            foreach (var subset in subsets)
            {
                //string.Join(glue, item1, item2, item3, ...)
                Console.WriteLine("[" + string.Join(", ", subset) + "]");
            }
        }
    }
}
