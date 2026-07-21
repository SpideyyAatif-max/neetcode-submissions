public class Solution {
    public bool IsSubsequence(string s, string t) {
        int left = 0;
        int right = 0;
        int count = 0;
        while(left < s.Length && right < t.Length){
            if(s[left] == t[right])
            {
                count++;
                left++;
            }
            right++;
        }
        return count == s.Length;
    }
}