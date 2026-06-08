public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //Form a dictionary or hashmap based on the length of the strings.
        //For each object(key is length and value is a list with strs of the given len)
        //Find check the anagram pattern using the first program
        //Add the element which has this hashmap 
        //if the currElemnt in anagram , add it to the list.
        //Remove both elements from the list.
        // var listGroup=new Dictionary<int, List<string>>().
        var ret= new List<List<string>>();
        var seen= new bool[strs.Length];

       for(int i=0;i<strs.Length;i++){
         if(seen[i]) continue;
         var currentStr=strs[i];
         int currLength=currentStr.Length;
         var listCurr= new List<string>();
         listCurr.Add(currentStr);
         seen[i]=true;
         
         for(int j=i+1;j<strs.Length;j++){
            if((strs[j].Length!=currLength)|| seen[j]){
               continue;
            }
            else{
             //Check if its anagram with currentStr
             if(IsAnagram(strs[j],currentStr))
             {
                seen[j]=true;
                listCurr.Add(strs[j]);
             }
            }
         }
         ret.Add(listCurr);
       }
        return ret;
    }
    private bool IsAnagram(string strA, string strB){
        // var dict= new Dictionary<char,int>();
       // var res= strA.GroupBy(x=>x).ToDictionary(g=>g.Key,g=>g.Count());
       return strA.OrderBy(c=>c).SequenceEqual(strB.OrderBy(a=>a));
        
    }
  
}