public class Solution {
    public int Trap(int[] height) {
        //This will not work, imagine reversed example 1
        //I think just this but from both sides converging inwards
        int leftMax = 0;
        int rightMax = height.Length - 1;

        int i = 0;
        int j = height.Length - 1;

        int totalVolume = 0;

        while(i < j) {
            if(height[i] < height[j]) {
                i++;
                if(height[i] < height[leftMax]) totalVolume += height[leftMax] - height[i];
                if(height[i] >= height[leftMax]) leftMax = i;
            } else {
                j--;
                if(height[j] < height[rightMax]) totalVolume += height[rightMax] - height[j];
                if(height[j] >= height[rightMax]) rightMax = j;
            }
        }

        return totalVolume;
    }
}
