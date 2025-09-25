public class Solution {
    public string IntToRoman(int num) {
        string result = "";
        int temp=num;
        int m = temp/1000;
        temp %= 1000;
        int cm = temp/900;
        temp %= 900;
        int d = temp/500;
        temp %= 500;
        int cd = temp/400;
        temp %= 400;
        int c = temp/100;
        temp %= 100;
        int xc = temp/90;
        temp %= 90;
        int l = temp/50;
        temp %= 50;
        int xl = temp/40;
        temp %= 40;
        int x = temp/10;
        temp %= 10;
        int ix = temp/9;
        temp %= 9;
        int v = temp/5;
        temp %= 5;
        int iv = temp/4;
        temp %=4;
        int i = temp/1;

        for(int a = 0; a<m;a++)
            result+="M";
        for(int a = 0; a<cm;a++)
            result+="CM";
        for(int a = 0; a<d;a++)
            result+="D";
        for(int a = 0; a<cd;a++)
            result+="CD";
        for(int a = 0; a<c;a++)
            result+="C";
        for(int a = 0; a<xc;a++)
            result+="XC";
        for(int a = 0; a<l;a++)
            result+="L";
        for(int a = 0; a<xl;a++)
            result+="XL";
        for(int a = 0; a<x;a++)
            result+="X";
        for(int a = 0; a<ix;a++)
            result+="IX";
        for(int a = 0; a<v;a++)
            result+="V";
        for(int a = 0; a<iv;a++)
            result+="IV";
        for(int a = 0; a<i;a++)
            result+="I";

        return result;
    }
}