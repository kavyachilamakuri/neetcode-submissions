public class Solution {
    public bool hasDuplicate(int[] nums) {
        int i=0,j=nums.Length;
        if(j==0||j==1) return false;
        Array.Sort(nums);
        for(i=0;i<j-1;i++){
         if(nums[i]==nums[i+1]) return true;

        }
        return false;
        
    }
}