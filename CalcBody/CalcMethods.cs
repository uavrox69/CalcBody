using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalcBody
{
    public class CalcMethods
    {
        private List<double> nums;
        private List<char> signs;
        public bool zero = false;
        
        public void Calcmethods()
        {
            nums = new List<double>();
            signs = new List<char>();

        }       
       
        public double MathStep( char sign, int spot )
        {
            double sum = 0;
            switch (sign)
            {
                case '+':
                    sum = nums[spot] + nums[spot + 1];
                    break;
                case '-':
                    sum = nums[spot] - nums[spot + 1];
                    break;
                case '*':
                    sum = nums[spot] * nums[spot + 1];
                    break;
                case '/':
                    sum = nums[spot] / nums[spot + 1];
                    break;
                default:
                    Console.WriteLine("Not a valid sign");
                    break;

            }
            return sum;
        }
       public double DoMath()
        {            
            double sum = 0;
            int spot;
            while (signs.Count != 0)
            {
                spot = FindHiSign();

                if ( spot == signs.Count + 1)
                {
                    spot = 0;
                }

                char sign = signs[spot];

                sum = MathStep(sign, spot);

                nums.RemoveAt(spot);
                nums.Insert(spot, sum);
                nums.RemoveAt(spot + 1);
                signs.RemoveAt(spot);

                sum = 0;
            }
            try
            {
                return nums[0]; 
            }
            catch ( System.ArgumentOutOfRangeException)
            {

                Program.msg.ErrorInEq();
                return 0;
            }
        }
        //This searches the list and finds the proper signs for proper order of operation
        public int FindHiSign()
        {
            int place = signs.Count + 1;
            
            for (int x = 0; x < signs.Count; x++)
            {
                char checker = signs[x];
                if ( checker == '*' || checker == '/' )
                {
                    place = x;                 
                }
            }

            return place;
        }
        public void FillList( List<double>num, List<char>ops )
        {
            nums = num;
            signs = ops;
        }

        
       
       
    }
}
