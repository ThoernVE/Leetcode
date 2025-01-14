public class Solution {
    public string BestHand(int[] ranks, char[] suits) {
        int highestCountRanks = 1;
        int highestCountSuits = 1;
        for(int i = 0; i < ranks.Length; i++)
        {
            
            int countSuits = 1;
            int countRanks = 1;
            for(int j = 1; j < ranks.Length;j++)
            {
                
                if(ranks[i] == ranks[j] && i != j)
                {
                    countRanks++;
                }
                if(suits[i] == suits[j] && i != j)
                {
                countSuits++;
                }
            }
            if(countSuits > highestCountSuits)
            {
                highestCountSuits = countSuits;
            }
            if(countRanks > highestCountRanks)
            {
                highestCountRanks = countRanks;
            }
        }
        if(highestCountSuits == 5)
        {
            return "Flush";
        }
        else if(highestCountRanks >= 3)
        {
            return "Three of a Kind";
    }
        else if(highestCountRanks == 2)
        {
            return "Pair";
        }
        else
        {
            return "High Card";
        }
    }
}