public class Solution {
        public bool IsPalindrome(int number)
        {
            int tempNumber = number; int digit; int reversed = 0;

        if(number<0)     return false;

        while(tempNumber!=0)
            {
            digit = tempNumber%10;
            reversed=reversed*10+digit;
            tempNumber/=10; 
            }

        if(reversed==number)
            return true;
        else
            return false;
        }
    }