public class Solution {
    public List<List<int>> Generate(int numRows) {
        List<List<int>> Triangle = new List<List<int>>();
        for(int i=0;i<numRows;i++)
        {
            List<int> row = new List<int>();
            for(int j=0;j<=i;j++)
            {
                if(j==0 || j==i)
                {
                    row.Add(1);
                }else{
                    int val = Triangle[i-1][j-1] + Triangle[i-1][j];
                    row.Add(val);
                }
            }
            Triangle.Add(row);
        }
        return Triangle;
    }
}