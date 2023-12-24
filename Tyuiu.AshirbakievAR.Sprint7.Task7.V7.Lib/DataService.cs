using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;



namespace Tyuiu.AshirbakievAR.Sprint7.Task7.V7.Lib
{
    public class DataService
    {
        public int Avarege(int[] matrix)
        {
            double s = 0;
            int cnt = 0;
            for (int i=0;i<matrix.Length; i++)
            {

                    s += matrix[i];
                    cnt++;

            }
            return Convert.ToInt32(Math.Round(s / cnt));
        }
        public int Max(int[] matrix)
        {
            int s = int.MinValue;
            foreach (int c in matrix)
            {
                s = Math.Max(s, c);  

            }
            return s;
        }
        public int Min(int[] matrix)
        {
            int s = int.MaxValue;
            foreach (int c in matrix)
            {
                s = Math.Min(s, c);

            }
            return s;
        }
        public int Dept(bool[] matrix)
        {
            int cnt=0;
            foreach (bool c in matrix)
            {
                if (c == true)
                {
                    cnt++;
                }
            }
            return cnt;
        }
        public int NoDept(bool[] matrix)
        {
            int cnt = 0;
            foreach (bool c in matrix)
            {
                if (c == false)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
    public class Product
    {
        public int Apartment { get; set; }
        public int Entrance { get; set; }
        public int Fullarea { get; set; }
        public int Usefularea { get; set; }
        public int Rooms { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Members { get; set; }
        public int Children { get; set; }
        public bool Debt { get; set; }

        public Product(int apartment, int entrance, int fullarea, int usefularea, int rooms, string name, string date, int members, int children, bool debt)
        {
            Apartment = apartment;
            Entrance = entrance;
            Fullarea = fullarea;
            Usefularea = usefularea;
            Rooms = rooms;
            Name = name;
            Date = date;
            Members = members;
            Children = children;
            Debt = debt;
        }
        public Product()
        {

        }

    }
}
