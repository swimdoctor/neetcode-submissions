public class Solution {
    public int MaxProfit(int[] prices) {
        int currentMin = prices[0];
        int maxDiff = 0;

        foreach(int i in prices) {
            if(i < currentMin) currentMin = i;
            if(i - currentMin > maxDiff) maxDiff = i - currentMin;
        }

        return maxDiff;
    }
}
