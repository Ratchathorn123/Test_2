using System;

namespace TEST_NO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number of box 1 :");
            int box1 = int.Parse(Console.ReadLine());
            Console.Write("number of box 2 :");
            int box2 = int.Parse(Console.ReadLine());
            Console.Write("number of box 3 :");
            int box3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Player A");
            Console.WriteLine("Choose your box");
            string t = Console.ReadLine();
            Console.WriteLine("How many box do you want to pick");
            int b = int.Parse(Console.ReadLine());

            Switch(t)
                Case 1 :
                box1 = box1 - b;
            Case 2 :
                box2 = box2 - b;
            Case 3 :
                box3 = box3 - b;


            Console.WriteLine("Number of the box left:{0},{1},{2}", box1, box2, box3);

            else
                Console.WriteLine("Player B");
            Console.WriteLine("Choose your box");
            string t = Console.ReadLine();
            Console.WriteLine("How many box do you want to pick");
            int b = int.Parse(Console.ReadLine());

            Switch(t)
                Case 1 :
                box1 = box1 - b;
            Case 2 :
                box2 = box2 - b;
            Case 3 :
                box3 = box3 - b;


            Console.WriteLine("Number of the box left:{0},{1},{2}", box1, box2, box3);

            if (box1 == 0 && box2 == 0 && box3 == 0)
            {
                Console.WriteLine("The winner is {0},A");
            }
            else
            {
                Console.WriteLine("The winner is {0},B");
            }
            Console.ReadLine();
        }
    }
}
