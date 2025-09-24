public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> indexNums = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            int currentNum = nums[i];
            int complement = target-currentNum;
            if(indexNums.ContainsKey(complement))
            {
                int firstIndex = indexNums[complement];
                return new int[] {firstIndex,i};
            }
            if(!indexNums.ContainsKey(currentNum))
                indexNums[currentNum]=i;
        }

        return new int[0];


        // for(int i = 0;i<nums.Length;i++)
        // {
        //     for(int j = 0;j<nums.Length;j++)
        //     {
        //         if(j==i) continue;

        //         if(nums[i]+nums[j]==target)
        //         {
        //              return new int[] {i,j};
        //         }
        //     }
        // }
        // return new int[0];
    }
}