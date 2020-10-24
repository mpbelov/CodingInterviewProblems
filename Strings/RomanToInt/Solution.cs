public static class Solution {
    public static int RomanToInt(string s) {
        int num = 0;
        var sArray = s.ToCharArray();
        
        for (int i = sArray.Length - 1; i >= 0; i--) {
            switch (sArray[i]) {
                case 'I':
                    num += 1;
                    break;
                case 'V':
                    num += 4;
                    if ((i - 1) >= 0 && sArray[i - 1] == 'I') {
                        i--;
                    }
                    else {
                        num += 1;
                    }
                    break;
                case 'X':
                    num += 9;
                    if ((i - 1) >= 0 && sArray[i - 1] == 'I') {
                        i--;
                    }
                    else {
                        num += 1;
                    }
                    break;
                case 'L':
                    num += 40;
                    if ((i - 1) >= 0 && sArray[i - 1] == 'X') {
                        i--;
                    }
                    else {
                        num += 10;
                    }
                    break;
                case 'C':
                    num += 90;
                    if ((i - 1) >= 0 && sArray[i - 1] == 'X') {
                        i--;
                    }
                    else {
                        num += 10;
                    }
                    break;
                case 'D':
                    num += 400;
                    if ((i - 1) >= 0 && sArray[i - 1] == 'C') {
                        i--;
                    }
                    else {
                        num += 100;
                    }
                    break;
                case 'M':
                    num += 900;
                    if ((i - 1) >= 0 && sArray[i - 1] == 'C') {
                        i--;
                    }
                    else {
                        num += 100;
                    }
                    break;
            }
        }
        
        return num;
    }
}