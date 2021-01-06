using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalcBody

{
    class Program
    {
        public static List<double> numsL = new List<double>();
        public static List<char> signL = new List<char>();
        public static int parsespot = 0;
        public static Form1 msg = new Form1();



        static void Main(string[] args)
        {            
            Application.Run(msg);            
        }      
    }
}
