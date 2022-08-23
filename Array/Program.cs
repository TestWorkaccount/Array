using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            //namn[0] = "Alf";
            //namn[1] = "Jonas";
            //namn[2] = "Jesper";
            //namn[3] = "Kalle";
            //namn[4] = "Hobbe";

            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine("Skriv namn på index " + i);
                namn[i] = Console.ReadLine();
                Console.WriteLine(namn[i]);
            }


            Console.ReadLine();
        }
    }
}
