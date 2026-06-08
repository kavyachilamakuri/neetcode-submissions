public class Solution {
    public bool IsAnagram(string s, string t) {
       Dictionary<char, int> dt=new Dictionary<char, int>();
       //Set up the hashtable with the frequencies of the letters
       for(int i=0;i<s.Length;i++){
        if(dt.ContainsKey(s[i])){
            dt[s[i]]++;
        }
        else {
            dt.Add(s[i],1);
        }
       }


       //Lets traverse through seen method.
       //If key exists, count>0 do a count -1
       //If the count is already 0 return false.
       //In the end, ensure all the values are 0 and return true else return false.
       for(int i=0;i<t.Length;i++){
        char curr= t[i];
        //Console.WriteLine('curr',curr);
        if(!dt.ContainsKey(curr)||dt[curr]==0)
        {
//Console.WriteLine($"returning false {curr} {dt.ContainsKey(curr)} {dt[curr]}");
        return false;
        }
        else{
        dt[curr]--;
        }
       }
       foreach(var e in dt){
        Console.WriteLine(e);
       }
       var remaining= dt.Where(x=>x.Value>0);
       if(remaining.Count()>0) return false;
       return true;
    

    }
}
