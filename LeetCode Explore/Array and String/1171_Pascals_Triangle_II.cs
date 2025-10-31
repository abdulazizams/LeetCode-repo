namespace LeetCode.Learn.Array_and_String
{
public class Pascals_Triangle_II {
    public IList<int> GetRow(int rowIndex) {

        List<int> output = new List<int>{1};
        //edge cases
        if(rowIndex < 2)
        {
        if(rowIndex == 0){return output;}
else if (rowIndex == 1){output.Add(1); return output;}
        }
        
        //start by adding 1
        output.Add(1);
        //declare middle for readability
        int half;

for(int i = 2; i < rowIndex + 1; i++)
{
    half = i/2 + i%2;
    
    output.Add(1);
        
    for (int j = half; j > 0; j--)
    {
output[j] += output[j - 1];
}
    
    for (int j = i; j > half; j--)
    {
output[j] = output[i-j];
    }

}
        
        return output;
    }
}
}
