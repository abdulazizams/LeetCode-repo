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
        
        //append 1 to list
        output.Add(1);
        //declare middle for readability
        int half;

//to save space, use recursion
//a row is recalculated rowIndex times
for(int i = 2; i < rowIndex + 1; i++)
{
//middle point
    half = i/2 + i%2;

    //append i'th item
    output.Add(1);

        //each row is syymetric about middle
    for (int j = half; j > 0; j--)
    {
output[j] += output[j - 1];
}

    //mirror first half
    for (int j = i; j > half; j--)
    {
output[j] = output[i-j];
    }

}
        
        return output;
    }
}
}
