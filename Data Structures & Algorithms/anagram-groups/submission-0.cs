public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        foreach(string str in strs)
        {
            char[] chararray = str.ToCharArray();
            Array.Sort(chararray);
            string key = new String(chararray);
            if(!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(str);
        }
        return new List<List<string>>(map.Values);
    }
}
