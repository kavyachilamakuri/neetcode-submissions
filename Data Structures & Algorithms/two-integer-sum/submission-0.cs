public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] toReturn= new int[2];
        for(int i=0;i<nums.Length;i++){
            int diff=target-nums[i];
            for(int j=i+1;j<=nums.Length-1;j++){
            if(diff==nums[j]){
                toReturn[0]=i;
                toReturn[1]=j;
            }
            }
        }
        return toReturn;

    }
}
