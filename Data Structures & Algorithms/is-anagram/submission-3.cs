public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> str1 = new Dictionary<char,int>();
        Dictionary<char,int> str2 = new Dictionary<char,int>();
        if(s.Length!=t.Length)
        {
            return false;
        }
        for(int i=0;i<s.Length;i++)
        {
            if(str1.ContainsKey(s[i]))
            {
                str1[s[i]]++;
            }
            else{
                str1[s[i]] = 1;
            }

            if(str2.ContainsKey(t[i]))
            {
                str2[t[i]]++;
            }
            else{
                str2[t[i]] = 1;
            }
        }
        foreach(KeyValuePair<char,int>page in str1)
        {
            if(!str2.TryGetValue(page.Key, out int count) || count!=page.Value)
            {
                return false;
            }
        }
        return true;
    }
}
