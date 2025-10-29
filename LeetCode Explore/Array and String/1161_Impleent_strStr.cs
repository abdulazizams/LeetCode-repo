namespace LeetCode.Learn.Array_and_String
{
    public class Implement_strStr
    {
        public int StrStr(string haystack, string needle)
        {
            //string lengths
            int needLen = needle.Length;
            int hayLen = haystack.Length;

            //edge case: needle is longer than haystack
            if (needLen > hayLen)
            {
                return -1;
            }

            //edge case: same length, but different first letter
            else if (needLen == hayLen && needle[0] != haystack[0])
            {
                return -1;
            }

            //loop through string characters
            for (int i = 0; i <= hayLen - needLen; i++)
            {
                //if the haystack equals needle's first letter; go to function
                if (needle[0] == haystack[i])
                {
                    //retrun index if match
                    if (checkEqual(ref needle, ref haystack, i)) { return i; }
                }
            }

            //default, return -1
            return -1;
        }
        
        //once first letters match, this function checks the rest
        public bool checkEqual(ref string needl, ref string hayst, int ind)
        {
            //loop through needle, and compare it to haystack
            for (int i = 0; i < needl.Length; i++)
            {
                if (needl[i] != hayst[ind + i]) { return false; }
            }
            //return true only if all characters match
            return true;
        }

    }
    
}