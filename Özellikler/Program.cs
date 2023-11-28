using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Özellikler
{
    public class Ucgen 
    {
        int a=5;
        int b=4;
        int c=3;
        public int A 
        { 
            get { return a; }
            set 
            {
                if ( value<=0) 
                {
                    Console.WriteLine("hatalı sayı");
                   
                }
                else
                    a = value;
            }

        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı sayı");

                }
                else
                    b = value;
            }

        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı sayı");

                }
                else
                    c = value;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
