namespace LeetCode.Learn.Array_and_String
{
    public class Pascals_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            //declare output list
            IList<IList<int>> output = new List<IList<int>>(numRows);

            //initilaize first row to one
            output.Add([1]);

            //edge case
            if (numRows == 1) { return output; }


            int val;
            
            //iterate through rows of the triangel starting from second row
            for (int i = 1; i < numRows; i++)
            {
                //first value is always 1
                List<int> rowList = new List<int> { 1 };

                //conseequent values loop
                for (int j = 1; j < i; j++)
                {
                    //value at index j is the sum of value on previous row at
                    // indices j nad j-1
                    val = output[i - 1][j - 1] + output[i - 1][j];
                    rowList.Add(val);
                }

                //last value is also 1
                rowList.Add(1);
                
                output.Add(rowList);
            }

            return output;
        }
    }
}