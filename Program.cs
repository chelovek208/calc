using System;
using System.Collections.Generic;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string Expression = Console.ReadLine()+"+";
            string Part ="";
            int NextPart=0;
            int IsDigit;
            List<int> Parts = new List<int>();
            char Switch = ' ';

            for ( int i = 0; i < Expression.Length; i++)
            {
                Int32.TryParse(Convert.ToString(Expression[i]), out IsDigit );
                
                if(Convert.ToBoolean(IsDigit))
                {
                    Part += Expression[i];
                }
                else
                {
                    if (Switch!=' ')
                    {
                        if (Switch == '*')
                        {
                            Part = Convert.ToString(Convert.ToInt32(Part) * NextPart);
                            Switch = ' ';
                        }
                        else
                        {
                            Part = Convert.ToString(NextPart / Convert.ToInt32(Part));
                            Switch = ' ';
                        }
                    }
                    
                    

                    switch (Expression[i])
                    {
                        case '+':
                            Parts.Add(Convert.ToInt32(Part));
                            Part = "";
                            break;

                        case '*':
                            NextPart = Convert.ToInt32(Part);
                            Switch = '*';
                            Part = "";
                            break;

                        case '/':
                            NextPart = Convert.ToInt32(Part);
                            Switch = '/';
                            Part = "";
                            break;
                    }
                    
                }

            }

            int Answer=0;
            for (int i = 0; i < Parts.Count; i++)
            {
                Answer += Parts[i];
            }
            Console.WriteLine(Answer);




        }

        
        
    }
}

