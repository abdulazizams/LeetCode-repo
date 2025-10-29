namespace LeetCode.Learn.Array_and_String
{
    public class Sprial_Matrix
    {

        public IList<int> SpiralOrder(int[][] matrix)
        {

            //edge cases: one row; return that row
            if (matrix.Length == 1)
            {
                List<int> outList = new List<int>(matrix[0]);
                return outList;
            }

// edge case: one column; return that column   
            else if (matrix[0].Length == 1)
            {
                List<int> outList = new List<int>();
                for (int i = 0; i < matrix.Length; i++) { outList.Add(matrix[i][0]); }
                return outList;
            }

            //initialze output list
            int leng = matrix.Length * matrix[0].Length;
            List<int> output = new List<int>(leng);




            //set limits of movement
            int[] mRange = new int[] { 0, matrix.Length - 1 };
            int[] nRange = new int[] { 0, matrix[0].Length - 1 };

            //starting position
            direction Move = direction.right;
            int m = 0;
            int n = 0;



            for (int i = 0; i < leng; i++)
            {
                output.Add(matrix[m][n]);
                nextStep(ref mRange, ref nRange, ref Move, ref m, ref n);

            }

            return output;
        }
        

        //directon list
        public enum direction
        {
            right,
            down,
            left,
            up
        }

        
        //decide where to go next given current location
        public void nextStep(ref int[] mR, ref int[] nR, ref direction move, ref int m, ref int n)
        {
            switch (move)
            {
                case direction.right:
                    //keep stepping right through row m
                    n++;

                    //once row limit is reached
                    if (n == nR[1])
                    {
                        //change direction
                        move = direction.down;
                        //since upper row is done, increment row limit
                        mR[0]++;
                    }
                    break;

                case direction.down:
                    //keep stepping down
                    m++;
                    //once bottom limit is reached
                    if (m == mR[1])
                    {
                        //change direction
                        move = direction.left;
                        //since right most column is done, 
                        // decrement column upper limit
                        nR[1]--;
                    }
                    break;

                case direction.left:
                    n--;
                    if (n == nR[0])
                    {
                        move = direction.up;
                        mR[1]--;
                    }
                    break;

                case direction.up:
                    m--;
                    if (m == mR[0])
                    {
                        move = direction.right;
                        nR[0]++;
                    }
                    break;
            }

        }
    }

}