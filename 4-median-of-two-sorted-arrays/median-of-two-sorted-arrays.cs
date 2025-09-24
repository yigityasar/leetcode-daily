public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> mergedList = new List<int>();
        mergedList.AddRange(nums1);
        mergedList.AddRange(nums2);
        mergedList.Sort();
        int[] nums = mergedList.ToArray();

        if(nums.Length%2!=0)
            {
                double median= nums[nums.Length/2];
                return median;
            }
        else
        {
            double median = (nums[nums.Length/2]+nums[nums.Length/2-1])/2.0;
            return median;
        }
    }
}