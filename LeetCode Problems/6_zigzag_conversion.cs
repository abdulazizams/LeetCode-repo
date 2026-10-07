//URL: https://leetcode.com/problems/zigzag-conversion
public class Solution {
    public string Convert(string s, int numRows) {

        //early escape
        if(numRows == 1){return s;}
        string output = "";

        List<List<char>> zigzag = new List<List<char>>();

        for (int i = 0; i < numRows; i++)
        {
            zigzag.Add(new List<char>());
        }

        int idx = 0;
        while(idx < s.Length)
        {
            for(int i = 0; i < numRows; i++)
            {
                zigzag[i].Add(s[idx]);
                idx++;
                if(idx >= s.Length){goto populateOutput;}
            }
            
            for(int i = numRows - 2; i > 0; i--)
            {
                zigzag[i].Add(s[idx]);
                idx++;
                if(idx >= s.Length){goto populateOutput;}
            }
        }

    populateOutput:
        foreach(List<char> list in zigzag)
        {
            foreach(char let in list)
            {
                output += let;
            }
        }

        return output;
    }
}
