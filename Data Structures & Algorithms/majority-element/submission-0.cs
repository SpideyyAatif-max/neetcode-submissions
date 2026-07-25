public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int x in nums)
        {
            if(!map.ContainsKey(x))
            {
                map[x] = 1;
            }else{
                map[x]++;
            }
        }
        foreach(var x in map)
        {
            if(x.Value > nums.Length/2)
            {
                return x.Key;
            }
        }
        return -1;
    }
}