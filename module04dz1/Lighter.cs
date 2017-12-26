using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul04dz
{
    public class Lighter
    {
        static int countLighter;
        private int year;
        private long price;
        private string mark;
        private string paint;
        private double size;
        private bool IsOn;

        static Lighter()
        {
            countLighter = 0;
        }
        public Lighter()
        {
            year = 1999;
            price = 1500;
            mark = "Parlament";
            paint = "White";
            size = 10.5;
            IsOn = false;
            countLighter++;
        }
        public Lighter(int year)
        {
            this.year = year;
            countLighter++;
        }
        public Lighter(int year, long price)
        {
            this.year = year;
            this.price = price;
            countLighter++;
        }
        public Lighter(int year, long price, string mark)
        {
            this.year = year;
            this.price = price;
            this.mark = mark;
            countLighter++;
        }
        public Lighter(int year, long price, string mark, string paint)
        {
            this.year = year;
            this.price = price;
            this.mark = mark;
            this.paint = paint;
            countLighter++;
        }
        public Lighter(int year, long price, string mark, string paint, double size)
        {
            this.year = year;
            this.price = price;
            this.mark = mark;
            this.paint = paint;
            this.size = size;
            countLighter++;
        }
        public Lighter(int year, long price, string mark, string paint, double size, bool IsOn)
        {
            this.year = year;
            this.price = price;
            this.mark = mark;
            this.paint = paint;
            this.size = size;
            this.IsOn = IsOn;
            countLighter++;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }
        public void SetPrice(long price)
        {
            this.price = price;
        }
        public void SetMark(string mark)
        {
            this.mark = mark;
        }
        public void SetPaint(string paint)
        {
            this.paint = paint;
        }
        public void SetSize(double size)
        {
            this.size = size;
        }
        public void SetIsOn(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        public int GetYear()
        {
            return year;
        }
        public int GetPrice()
        {
            return year;
        }
        public int GetMark()
        {
            return year;
        }
        public int GetPaint()
        {
            return year;
        }
        public int GetSize()
        {
            return year;
        }
        public int GetIsOn()
        {
            return year;
        }

        public void Show()
        {
            Console.WriteLine("Год пройзводства  : {0}", year);
            Console.WriteLine("Цена              : {0}", price);
            Console.WriteLine("Марка             : {0}", mark);
            Console.WriteLine("Цвет              : {0}", paint);
            Console.WriteLine("Размер            : {0}", size);
            if (IsOn)
            {
                Console.WriteLine("Включен");
            }
            else
            {
                Console.WriteLine("Выключен");
            }
        }
    }
}
