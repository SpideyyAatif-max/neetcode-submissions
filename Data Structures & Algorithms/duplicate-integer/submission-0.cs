public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach(int x in nums)
        {
            if(!set.Add(x))
            {
                return true;
            }
        } 
        return false;
    }
}