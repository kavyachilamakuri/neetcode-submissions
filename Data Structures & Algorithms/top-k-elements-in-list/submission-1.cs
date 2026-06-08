public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //List<int> ret=new List<int>();
        int[] ret=new int[k];
        if(k>nums.Length || k==0 || nums.Length==0) return ret.ToArray();
        var dict=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(dict.ContainsKey(nums[i]))
            dict[nums[i]]++;
            else dict[nums[i]]=1;
        }
        return dict.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();

    }
}
