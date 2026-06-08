public class Solution {
    public int LongestConsecutive(int[] nums) {
        // Array.Sort(nums);
        if(nums.Length==0) return 0;
        if(nums.Length==1) return 1;
        var list= nums.ToList().Distinct();
        var nums_=list.ToArray();
        Array.Sort(nums_);
        int count=1,tempCount=1;
        
        for(int i=0;i<nums_.Length-1;i++){
            if(nums_[i]+1==nums_[i+1]){
                Console.WriteLine($"valu:{nums_[i]},{nums_[i+1]}");
                tempCount++;
            }
            else{
            count=Math.Max(tempCount,count);
            Console.WriteLine($"We broke at:${i}.{count},{tempCount}");
            tempCount=1;
            continue;
            }

        }
        return Math.Max(tempCount,count);
    }
}
