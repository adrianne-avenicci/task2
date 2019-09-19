using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;

namespace TestTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValues(Console.ReadLine());
            Console.WriteLine();
            Console.ReadLine();
        }
        static public float[,] GetValues(String path)
        {
            String[] lines = System.IO.File.ReadAllLines(path);
            float[,] coordinates = new float[lines.Length, 2];
            String pattern = @"(\d+[.\d+]*)\s+(\d+[.\d+]*)";

            int counter = 0;

            foreach (string line in lines)
            {
                Console.WriteLine(line);
                MatchCollection mc = Regex.Matches(line, pattern);
                foreach (Match m in mc)
                {
                    //Console.WriteLine(m);
                    
                    //Console.Write(m.Groups[1].Value);
                    coordinates[counter, 0] = float.Parse(m.Groups[1].Value);
                    //Console.WriteLine(m.Groups[2].Value);
                    coordinates[counter, 1] = float.Parse(m.Groups[2].Value);
                    counter++;
                    
                }
            }
            for (int i=0; i<coordinates.GetLength(0); i++)
            {
                Console.Write(coordinates[i, 0] + " ");
                Console.WriteLine(coordinates[i, 1]);
            }

            return coordinates;
        }
        /*
        private bool IsPointInPolygon(PointF[] polygon, PointF point)
        {
            bool isInside = false;
            for (int i = 0, j = polygon.Length - 1; i < polygon.Length; j = i++)
            {
                if (((polygon[i].Y > point.Y) != (polygon[j].Y > point.Y)) &&
                (point.X < (polygon[j].X - polygon[i].X) * (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) + polygon[i].X))
                {
                    isInside = !isInside;
                }
            }
            return isInside;
        }
        */
    }
}
