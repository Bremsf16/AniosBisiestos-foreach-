
//Tarea: Realizar el programa con foreach que imprima los años bisiestos que hay entre 1990-2022

namespace Años_Bisiestos
{
    public class A
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Los años bisiestos entre 1990 y 2022 son:\n");

            int[] Años = { 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022 };

            foreach (int i in Años)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine("- Año {0} - Es un año bisiesto\n", i);
                }
                else
                {
                    Console.WriteLine("- Año {0} - No es un año bisiesto\n", i);
                }

                Console.ReadLine();
            }
            
        }
    }
}


