public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] toReturn = new int[2];
        for(int i=0;i<numbers.Length;i++){
            int remSum= target-numbers[i];
            Console.WriteLine($"{numbers[i]}, {i}, {target},{remSum}");
            for(int j=i+1;j<numbers.Length;j++){
                // if(numbers[j]>remSum)
                // break;
                 if(numbers[j]==remSum){
                    Console.WriteLine($"{numbers[j]}, {numbers[i]}");
                    toReturn[0]=i+1;
                    toReturn[1]=j+1;
                }
                
            }

        }
        return toReturn;
    }
}
