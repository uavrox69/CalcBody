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



        static void Main(string[] args)
        {           
            Application.Run(new Form1());
            Parsing sent = new Parsing();
            string pattern = "[0-9.]";
            Regex r = new Regex(pattern);

            //Console.WriteLine("Enter a equation");

            //string test = Console.ReadLine();
            //test = sent.ElimSpace(test);
            //sum = sent.ReadString(test, r, parsespot);            

            //Console.WriteLine(sum);
            
        }      
    }
}
