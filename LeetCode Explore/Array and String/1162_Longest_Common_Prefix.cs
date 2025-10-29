namespace LeetCode.Learn.Array_and_String
{
    public class Longest_Common_Prefix
    {

        public string LongestCommonPrefix(string[] strs)
        {
            //edge case
            if (strs.Length == 1)
            { return strs[0]; }
         
         string pref = "";

            for (int i = 0; i < strs[0].Length; i++)
            {
                //if letter at index i exists in all strings, add it to pref
                if (checkPref(ref strs, i))
                { pref += strs[0][i]; }

                //if a mismach OR string is shorter than inedx i, retrun currren pref
                else { return pref; }
            }

            return pref;
        }
         
         


        public bool checkPref(ref string[] strs, int ind)
        {
            //get the letter at index ind of the first string
            char let = strs[0][ind];

            //loop through all strings
            for (int i = 1; i < strs.Length; i++)
            {
                //check if all strings has that letter at index ind
                //if string is shorter OR does not have that letter, return 0
                if (strs[i].Length <= ind || strs[i][ind] != let) { return false; }
            }
            return true;
        }
    }
}