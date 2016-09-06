using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("please write some text");
            input = Console.ReadLine();
           
            Console.WriteLine(toUpeer(input));
        }
        static string toUpeer(string uup)
        {
            string show = "";

            for (int i = 0; i < uup.Length;i++ )
            {
                 switch (uup[i])
                {
                     case 'a':
                        show += 'A';
                        break;
                     case 'b':
                        show += 'B';
                        break;
                     case 'c':
                        show += 'C';
                        break;
                     case 'd':
                        show += 'D';
                        break;
                     case 'e':
                        show += 'E';
                        break;
                     case 'f':
                        show += 'F';
                        break;
                     case 'g':
                        show += 'G';
                        break;
                     case 'h':
                        show += 'H';
                        break;
                     case 'i':
                        show += 'I';
                        break;
                     case 'j':
                        show += 'J';
                        break;
                     case 'k':
                        show += 'K';
                        break;
                     case 'l':
                        show += 'L';
                        break;
                     case 'm':
                        show += 'M';
                        break;
                     case 'n':
                        show += 'N';
                        break;
                     case 'o':
                        show += 'O';
                        break;
                     case 'p':
                        show += 'P';
                        break;
                     case 'q':
                        show += 'Q';
                        break;
                     case 'r':
                        show += 'R';
                        break;
                     case 's':
                        show += 'S';
                        break;
                     case 't':
                        show += 'T';
                        break;
                     case 'u':
                        show += 'U';
                        break;
                     case 'v':
                        show += 'V';
                        break;
                     case 'w':
                        show += 'W';
                        break;
                     case 'y':
                        show += 'Y';
                        break;
                     case 'z':
                        show += 'Z';
                        break;                  
                    default :
                        show += uup[i];
                        break;

                }

            }

            return show;

        }
    }
}
