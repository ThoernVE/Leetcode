public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i = digits.Length-1; i >= 0; i--)
        {
            
            digits[i]++;
            if(digits[i] > 9)
            {
                digits[i] = 0;
                if(i == 0)
                {
                    int[] newArray = new int[digits.Length+1];
                    newArray[0] = 1;
                    for(int j = 0; j < digits.Length; j++)
                    {
                        newArray[j+1] = digits[j];
                    }
                    return newArray;
                }
                
            }
            else
            {
                return digits;
            }
        }
        return digits;
    }
}