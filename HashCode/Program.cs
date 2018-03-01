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
         
           
            
             string[]   text = File.ReadAllLines(path);
            
            List<Rides> rides= new List<Rides>();
            string firstrow = text[0];
            string[] first = firstrow.Split(' ');
            int rows = int.Parse(first[0]);
            int columns = int.Parse(first[1]);
            int fleet = int.Parse(first[2]);
            int nrides = int.Parse(first[3]);
            int bonus = int.Parse(first[4]);
            int nsteps = int.Parse(first[5]);
            int[,] arr = new int[rows, columns];
            
            int j = 0;
            for (int i = 0; i < rows; i++)
            {

                rides.Add( new Rides(int.Parse(text[i + 1].Split(' ')[0]), int.Parse(text[i + 1].Split(' ')[1]), int.Parse(text[i + 1].Split(' ')[2]), int.Parse(text[i + 1].Split(' ')[3]), int.Parse(text[i + 1].Split(' ')[4]), int.Parse(text[i + 1].Split(' ')[5])));
  
            }
           


        }


    }
}

