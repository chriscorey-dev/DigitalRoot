using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("5499648634153065336164371546744557154563710455371455327045327054653710455367045536704356170453671054360710453710455637145627415527123");
        }

        //DigitalRoot Function
        static void DigitalRoot(string rootThis)
        {
            var list = new List<int>() { };
            var answer = 0;

            for (int i = 0; i < rootThis.Count(); i++)
            {
                list.Add(Convert.ToInt32(rootThis[i].ToString()));
                answer = list[i] += answer;
            }

            Console.WriteLine(answer);

            Console.WriteLine();

            //If to see if the code needs to run again.
            if (answer.ToString().Length > 1)
            {
                DigitalRoot(answer.ToString());
            }
            else
            {
                End();
            }
        }

        //End Function
        static void End()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
