public static class Solution {
    public static string IntToRoman(int num) {
        int thousands = num / 1000;
        int hundreds = (num - thousands * 1000) / 100;
        int tens = (num - thousands * 1000 - hundreds * 100) / 10;
        int ones = num - thousands * 1000 - hundreds * 100 - tens * 10;

        var s = "";
        
        while (thousands-- > 0) s += 'M';

        if (hundreds >= 1 && hundreds <= 3) while (hundreds-- > 0) s += 'C';
        switch (hundreds) {
            case 4:
                s += "CD";
                break;
            case 5:
                s += 'D';
                break;
        }
        if (hundreds >= 6 && hundreds <= 8) {
            s += 'D';
            while (hundreds-- > 5) s += 'C';
        }
        else if (hundreds == 9) s += "CM";
        
        if (tens >= 1 && tens <= 3) while (tens-- > 0) s += 'X';
        switch (tens) {
            case 4:
                s += "XL";
                break;
            case 5:
                s += 'L';
                break;
        }
        if (tens >= 6 && tens <= 8) {
            s += 'L';
            while (tens-- > 5) s += 'X';
        }
        else if (tens == 9) s += "XC";
                    
        if (ones >= 1 && ones <= 3) while (ones-- > 0) s += 'I';
        switch (ones) {
            case 4:
                s += "IV";
                break;
            case 5:
                s += 'V';
                break;
        }
        if (ones >= 6 && ones <= 8) {
            s += 'V';
            while (ones-- > 5) s += 'I';
        }
        else if (ones == 9) s += "IX";
                    
        return s;
    }
}