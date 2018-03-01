using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "example.in";
            string[] text = new string[10000];
            if (File.Exists(path))
            {
                text = File.ReadAllLines(path);
            }

            string firstrow = text[0];
            string[] first = firstrow.Split(' ');
            int rows = int.Parse(first[0]);
            int columns = int.Parse(first[1]);
            int fleet = int.Parse(first[2]);
            int nrides = int.Parse(first[3]);
            int bonus = int.Parse(first[4]);
            int nsteps = int.Parse(first[5]);
            int[,] arr = new int[rows, columns];
            Time[] times = new Time[rows];
            int j = 0;
            for (int i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    arr[i, j] = int.Parse(text[i + 1].Split(' ')[j]);
                }
                times[i].earliest = int.Parse(text[i + 1].Split(' ')[j]);
                times[i].latest = int.Parse(text[i + 1].Split(' ')[j + 1]);
            }
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    Console.Write(arr[i, k]);


                }
                Console.Write(times[i].earliest);
                Console.Write(times[i].latest);
                Console.WriteLine();
            }


        }


        struct Time
        {
            public int earliest;
            public int latest;
        }
    }
}

