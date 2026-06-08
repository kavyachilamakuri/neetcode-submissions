public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int[] arr=new int[nums.Length];
       int prefix=1,postfix=1;
        for(int i=0;i<nums.Length;i++){
            arr[i]=prefix;
            prefix=prefix*nums[i];
        }
        for(int i=nums.Length-1;i>=0;i--){
            arr[i]=arr[i]*postfix;
            postfix=postfix*nums[i];
        }
        return arr;
    }
}
