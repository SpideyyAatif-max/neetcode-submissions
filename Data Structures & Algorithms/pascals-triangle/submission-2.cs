public class Solution {
    public List<List<int>> Generate(int numRows) {
        List<List<int>> Matrix = new List<List<int>>();
        for(int i=0;i<numRows;i++)
        {
            List<int> row = new List<int>();
            for(int j=0;j<=i;j++)
            {
                if(j==0 || j==i)
                {
                    row.Add(1);
                }
                else{
                    int val = Matrix[i-1][j-1] + Matrix[i-1][j];
                    row.Add(val);
                }
            }
            Matrix.Add(row);
        }
        return Matrix;
    }
}