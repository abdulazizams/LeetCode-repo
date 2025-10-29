namespace LeetCode.Learn.Array_and_String
{

    public class Add_Binary
    {

        public string AddBinary(string a, string b)
        {

            //initilaize resultant string
            string res = "";
            //index from last character
            int aInd = a.Length - 1;
            int bInd = b.Length - 1;


            // carry value        
            int carry = 0;

            //in lieu of padding the shorter strings with zeros, the program
            // will cascade through cases

            //first case is when there values in a and b
            while (aInd >= 0 && bInd >= 0)
            {
                //add character to the left of current string using function
                res = addBin(a[aInd], b[bInd], ref carry) + res;
                aInd--;
                bInd--;
            }

            //if b is done, add a to result
            while (aInd >= 0)
            {
                res = addBin(a[aInd], '0', ref carry) + res;
                aInd--;
            }

            //if a is done, add b to result
            while (bInd >= 0)
            {
                res = addBin('0', b[bInd], ref carry) + res;
                bInd--;
            }

            //if carry is not 0; add it to result
            if (carry == 1) { res = addBin('0', '0', ref carry) + res; }

            return res;

        }

        //addBin() takes two characters and an int carry and adds them in binary
        char addBin(char a, char b, ref int carry)
        {
            //convert characters to int; I should check if a and b are '1' or '0'
            // but I trust the problem constraints
            int sum = a - '0' + b - '0' + carry;

            //sum can never exceed 3 or 0b11; 
            //update carry which is the value of right shifted sum (either 0 or 1)

            carry = sum >> 1;

            //output is 1's place of sum; is found by anding sum with 1
            //then convert it back to ASCII char
            char output = (char)((sum & 1) + '0');
            return output;
        }
    }
}