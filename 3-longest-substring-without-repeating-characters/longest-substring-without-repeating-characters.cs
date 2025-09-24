public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> index = new Dictionary<char,int>();
        int maxLength = 0;
        int j = 0;

        for(int i = 0; i<s.Length;i++)
        {
            char thisChar = s[i];
            if(index.ContainsKey(thisChar) && index[thisChar] >= j )
            {
                j=index[thisChar]+1;
            }
            index[thisChar]=i;
            int currentLength=i-j+1;
            maxLength=Math.Max(maxLength,currentLength);
        }
        return maxLength;

    }
}