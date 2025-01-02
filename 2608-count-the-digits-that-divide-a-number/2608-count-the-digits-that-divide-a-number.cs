public class Solution {
    public int CountDigits(int num) {
        string numAsString = num.ToString();
        int numbersDividable = 0;

        for (int i = 0; i < numAsString.Length; i++)
        {
            char charNum = numAsString[i];
            int iNum = Int32.Parse(charNum.ToString());
           
            if (num % iNum == 0)
            {
                numbersDividable ++;
            }
        }
       return numbersDividable;
        
    }
}