public class Solution {
    public int ScoreOfString(string s) {
        char[] inputArray;
        int lengthOfArray = s.Length;
        inputArray = s.ToCharArray(0, lengthOfArray);

        char[] charArray = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        int[] numArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26];

        int returnNumber = 0;

        List<int> numList = new List<int>();
        
       foreach(char c in inputArray)
       {
            int charArrayPosition = Array.IndexOf(charArray, c);
            numList.Add(numArray[charArrayPosition]);
       }

       for(int i = 0; i < s.Length -1; i++)
       {
        int absoluteDistance = Math.Abs(numList[i] - numList[i + 1]);
        returnNumber = returnNumber + absoluteDistance;
       }

       return returnNumber;
    }
    }
