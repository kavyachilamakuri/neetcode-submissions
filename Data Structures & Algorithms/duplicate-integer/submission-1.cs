public class Solution {
    public bool hasDuplicate(int[] nums) {
       bool hasDup=false;
       if(nums.Length==0||nums.Length==1) return false;
       int[] numsDistinct= nums.ToList().Distinct().ToArray();
       if(numsDistinct.Length==nums.Length) return false;
       return true;
        
    }
}