using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countingValleys
{
    class Program
    {

        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int numValleys=0;
            int numMount = 0;
            int seaLevel = 0;
            int currentLevel = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'D')
                {
                    if (currentLevel > 0 && currentLevel - 1 == 0)
                    {
                        numMount += 1;
                    }

                    currentLevel -= 1;
                    
                }
                else if (s[i] == 'U')
                {
                    if(currentLevel<0 && currentLevel+1 ==0 ) {
                        numValleys += 1;
                    }
                    currentLevel += 1;
                }
               
            }

            return numValleys;

        }
        static void Main(string[] args)
        {

            
            int n = Convert.ToInt32(Console.ReadLine());


            //string s = Console.ReadLine();

            string s = "UDDDUDUU";

            int result = countingValleys(n, s);

            Console.WriteLine(result);
            Console.ReadLine();

    }
    }
}
