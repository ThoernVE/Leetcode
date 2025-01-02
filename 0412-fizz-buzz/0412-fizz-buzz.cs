public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> returnList = new List<string>();
        for(int i = 1; i <= n; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                returnList.Add("FizzBuzz");
            }
            else if(i % 5 == 0)
            {
                returnList.Add("Buzz");
            }
            else if(i % 3 == 0)
            {
                returnList.Add("Fizz");
            }
            else
            {
                returnList.Add(Convert.ToString(i));
            }
        }
        return returnList;
    }
}