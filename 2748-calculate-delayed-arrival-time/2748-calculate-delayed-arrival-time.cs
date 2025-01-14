public class Solution {
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime) {
        for(int i = 0; i < delayedTime; i++)
        {
            arrivalTime++;
            if(arrivalTime == 24)
            {
                arrivalTime = 0;
            }
        }
        return arrivalTime;
    }
}