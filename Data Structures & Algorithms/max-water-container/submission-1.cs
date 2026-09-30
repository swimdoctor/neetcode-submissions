public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0;
        int j = heights.Length -1 ;

        int maxV = 0;

        while(i < j) {
            int vol = (j - i) * Math.Min(heights[i], heights[j]);
            if(vol > maxV) maxV = vol;
            if(heights[i] > heights[j]) j--;
            else i++;
        }

        return maxV;
    }
}
