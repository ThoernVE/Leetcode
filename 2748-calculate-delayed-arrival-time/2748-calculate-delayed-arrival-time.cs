public class Solution {
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime) {
        arrivalTime += delayedTime;
        if(arrivalTime >= 24)
        {
            arrivalTime -= 24;
        }
        return arrivalTime;
    }
}