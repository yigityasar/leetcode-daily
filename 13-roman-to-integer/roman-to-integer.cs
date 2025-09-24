public class Solution
{
    public int RomanToInt(string Roman)
    {
        int result = 0;
        int i = 0;

        while (i < Roman.Length)
        {
            if (Roman[i] == 'I' && i + 1 < Roman.Length)
            {
                if (Roman[i + 1] == 'V')
                {
                    result += 4; i += 2;
                }
                else if (Roman[i + 1] == 'X')
                {
                    result += 9; i += 2;
                }
                else
                {
                    result += GetRomanNumber(Roman[i]);
                    i++;
                }
            }

            else if (Roman[i] == 'X' && i + 1 < Roman.Length)
            {
                if (Roman[i + 1] == 'L')
                {
                    result += 40; i += 2;
                }
                else if (Roman[i + 1] == 'C')
                {
                    result += 90; i += 2;
                }
                else
                {
                    result += GetRomanNumber(Roman[i]);
                    i++;
                }

            }

            else if (Roman[i] == 'C' && i + 1 < Roman.Length)
            {
                if (Roman[i + 1] == 'D')
                {
                    result += 400; i += 2;
                }
                else if (Roman[i + 1] == 'M')
                {
                    result += 900; i+=2;
                }
                else
                {
                    result += GetRomanNumber(Roman[i]);
                    i++;
                }
            }

            else
            {
                result += GetRomanNumber(Roman[i]);
                i++;
            }
        }
        return result;
    }
    public int GetRomanNumber(char x)
    {
        if (x == 'I') return 1;
        else if (x == 'V') return 5;
        else if (x == 'X') return 10;
        else if (x == 'L') return 50;
        else if (x == 'C') return 100;
        else if (x == 'D') return 500;
        else if (x == 'M') return 1000;
        else return 0;
    }
}