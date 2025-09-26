public class Solution {
    public IList<string> LetterCombinations(string digits) {

        IList<string> result = new List<string>();
        Dictionary<int,string> phoneMap = new Dictionary<int,string>
        {
            {2, "abc"},
            {3, "def"},
            {4, "ghi"},
            {5, "jkl"},
            {6, "mno"},
            {7, "pqrs"},
            {8, "tuv"},
            {9, "wxyz"}
        };

        if(digits==null || digits=="")
            return result;

        if(digits.Length == 1)
        {
            int d1 = digits[0] - '0';
            if(phoneMap.ContainsKey(d1))
            {
                foreach(char c in phoneMap[d1])
                    result.Add(c.ToString());
            }
            return result;
        }

        int n = digits.Length;
        string[] letters = new string[n];

        for (int i = 0; i < n; i++)
        {
            int d = digits[i] - '0';
            if (!phoneMap.ContainsKey(d))
                return result;
            letters[i] = phoneMap[d];
        }

        int[] indices = new int[n];
        bool done = false;

        while(!done)
        {
            string s ="";
            for(int i = 0;i<n;i++)
                s+=letters[i][indices[i]];
            result.Add(s);

            for(int i =n-1;i>=0;i--)
            {
                if(indices[i]+1<letters[i].Length)
                {
                    indices[i]++;
                    break;
                }
                else
                {
                    indices[i]=0;
                    if(i==0)
                        done=true;
                }
            }
        }

        return result;
    }
}