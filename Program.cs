using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Batting Average Calculater!");
            do
            {
                Console.WriteLine("enter number of player");
                int noplayer = Validatenumber();


                double[][] bat = new double[noplayer][];
                for (int row = 0; row < noplayer; row++)
                {
                    Console.WriteLine($"enter the number of at bat for player no.{row + 1}");
                    


                   
                    
                    int colum = Validatenumber();

                        bat[row] = new double[colum];
                }
                for (int row = 0; row < noplayer; row++)
                {
                    for (int colum = 0; colum < bat[row].Length; colum++)
                    {
                        Console.WriteLine($"enter result for at bat {colum+1} ");
                        bat[row][colum] = double.Parse(Console.ReadLine());
                    }
                }


                for (int row = 0; row < noplayer; row++)
                {
                    Double av = 0; double sum = 0;
                    double sp = 0; int i = 0;
                    for (int colum = 0; colum < bat[row].Length; colum++)
                    {

                        sum = sum + bat[row][colum];
                        if (bat[row][colum] != 0)
                        {
                            i++;
                        }

                    }
                    sp = sum / bat[row].Length;
                    av = (i / bat[row].Length);
                    Console.WriteLine($"batting average:{av}");
                    Console.WriteLine($"slugging percentage:{sp}");


                }
            }
            while (Continuquestion());
        }
        public static bool Continuquestion()
        {
            string answer = ""; bool flag = true;
            Console.Write("another batter?(y/n):    ");
            answer = Console.ReadLine();
            if (answer == "n" || answer == "N")
            {

                flag = false;
                return flag;


            }
            else if (answer == "y" || answer == "Y")



                return flag;

            else
            {
                Console.Write("try again invalid input   ");
                return Continuquestion();

            }

        }
        public static int Validatenumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || !(number >= 1 && number <= 100))
            {
                Console.WriteLine("enter a valid number");
            }
            return number;
        }


    }
}
