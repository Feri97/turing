using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turing
{
    class Program
    {
        static int i = 0;
        public static char állapot = 'a';
        static void Main(string[] args)
        {
            string szalag = Console.ReadLine();
            List<char> output = new List<char>();
            for (int j = 0; j < szalag.Length; j++)
            {
                output.Add(szalag[j]);
            }
            while (i<output.Count)
            {
                
                output[i] = Delta(output[i], ref állapot);
                if (output.Contains('!'))
                {
                    Console.WriteLine("error");
                    break;
                }
                if (i < 0)
                {
                    eltol(output);
                    i = 0;
                }
            }
            for (int x = 0; x < output.Count; x++)
            {
                Console.Write(output[x]);
            }
            Console.ReadKey();
        }

        static void eltol(List<char> lista)
        {
            lista.Add(' ');
            for (int j = lista.Count - 1; j > 0; j--)
            {
                lista[j] = lista[j - 1];
            }
            lista[0] = ' ';
        }
        static char Delta(char input, ref char állapot)
        {
            if (állapot == 'a')
            {
                if (input == '0')
                {
                    állapot = 'b';
                    i--;
                    return ' ';
                }
                else if (input == '1')
                {
                    állapot = 'c';
                    i--;
                    return ' ';
                }
                else
                {
                    return '!';
                }
            }
            else if (állapot == 'b')
            {
                if (input == '0')
                {
                    állapot = 'b';
                    i--;
                    return '0';
                }
                else if (input == '1')
                {
                    állapot = 'b';
                    i--;
                    return '1';
                }
                else if (input == ' ')
                {
                    állapot = 'd';
                    i++;
                    return ' ';
                }
                else
                {
                    return '!';
                }
            }
            else if (állapot == 'c')
            {
                if (input == '0')
                {
                    állapot = 'c';
                    i--;
                    return '0';
                }
                else if (input == '1')
                {
                    állapot = 'c';
                    i--;
                    return '1';
                }
                else if (input == ' ')
                {
                    állapot = 'e';
                    i++;
                    return ' ';
                }
                else
                {
                    return '!';
                }
            }
            else if (állapot == 'd')
            {
                if (input == '0')
                {
                    állapot = 'd';
                    i++;
                    return '0';
                }
                else if (input == '1')
                {
                    állapot = 'e';
                    i++;
                    return '0';
                }
                else if (input == ' ')
                {
                    állapot = 'a';
                    i++;
                    return '0';
                }
                else
                {
                    return '!';
                }
            }
            else if (állapot == 'e')
            {
                if (input == '0')
                {
                    állapot = 'd';
                    i++;
                    return '1';
                }
                else if (input == '1')
                {
                    állapot = 'e';
                    i++;
                    return '1';
                }
                else if (input == ' ')
                {
                    állapot = 'a';
                    i++;
                    return '1';
                }
                else
                {
                    return '!';
                }
            }
            else
            {
                return '!';
            }
        }
    }
}
