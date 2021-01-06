using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CalcBody
{
    //This class is used to parse and order the equation setting it up to do the math following the proper rules 
    public class Parsing
    {
        public static int parseSpot = 0;
        public static int stringSize= 0;
        Regex r;

        //This method is used to read the string and seperate the numbers and symbols into different lists using regex
        public double ReadString(string equation, Regex pass, int stringSpot)
        {
            stringSize = equation.Length;
            int place = stringSpot;
            string nonConNum = "";
            double stringSum,a;
            bool negNum = false;
            
            Parsing paran = new Parsing();
            CalcMethods work = new CalcMethods();
            
            List<double> numsL = new List<double>();
            List<char> signL = new List<char>();
           
            r = pass;
            
            for (int x = place; x <= stringSize - 1; x++)
            {
                if (r.IsMatch(equation[x].ToString()))
                {
                    nonConNum = nonConNum + equation[x].ToString();

                    if (x == stringSize - 1)
                    {
                        a = Convert.ToDouble(nonConNum);
                        nonConNum = "";
                        numsL.Add(a);
                    }
                }
                
                else if (equation[x].ToString() == "(" && x == 0 )
                {
                    place = x + 1;
                    numsL.Add(paran.ReadString(equation, pass, place));
                    x = Program.parsespot;
                }
                else if (equation[x].ToString() == "(" && r.IsMatch(equation[x - 1].ToString()))
                {                   
                    a = Convert.ToDouble(nonConNum);
                    nonConNum = "";
                    numsL.Add(a);
                    signL.Add('*');                   
                    place = x + 1;                                                        
                    numsL.Add(paran.ReadString(equation, pass,place));
                    x = Program.parsespot;

                }
                
                else if (equation[x].ToString() == "(")
                {
                    place = x + 1;
                    numsL.Add(paran.ReadString(equation, pass, place));
                    x = Program.parsespot;
                }
                
                else if (equation[x].ToString() == ")")
                {
                    if (nonConNum != "")
                    {
                        a = Convert.ToDouble(nonConNum);
                        nonConNum = "";
                        numsL.Add(a);
                    }
                    if ( x != stringSize - 1)
                    {
                        Program.parsespot = x;
                    }
                    else
                    {
                        Program.parsespot = x;
                    }
                    break;
                }
               
                else
                {
                    if ( nonConNum != "")
                    {
                        a = Convert.ToDouble(nonConNum);
                        nonConNum = "";
                        numsL.Add(a);
                    }
                    if (equation[x].ToString() == "-")
                    {
                        if ( x == 0 || equation[x-1].ToString() == "(")
                        {
                            nonConNum = nonConNum + equation[x].ToString();
                            negNum = true;
                        }
                    }
                    if ( negNum == false )
                    {
                        signL.Add(equation[x]);
                    }
                    else
                    {
                        negNum = false;
                    }
                    
                }
            }
            
            work.FillList(numsL, signL);
            stringSum = work.DoMath();
            
            return stringSum;

        }
        //with gui it is possible it is  no longer needed. Used to eleminate space and make reading easier
        public string ElimSpace(string unFixed)
        {
            string pattern = "\\s";
            string sub = "";
            Regex r = new Regex(pattern);
            string newS = r.Replace(unFixed, sub);

            return newS;
        }

    }
}
