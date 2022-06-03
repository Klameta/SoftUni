using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            double nf = double.Parse(Console.ReadLine());
            double ns = double.Parse(Console.ReadLine());
            char o = char.Parse(Console.ReadLine());
            double nObshto = 0.00;
            int evenOdd = 0;
            int div = 0;

            switch (o)
            {
                case '+':
                    nObshto = ns + nf;
                    evenOdd++;
                    break;
                case '-':
                    nObshto = nf - ns;
                    evenOdd++;
                    break;
                case '*':
                    nObshto = ns * nf;
                    evenOdd++;
                    break;
                case '/':
                    switch (ns)
                    {
                        case 0:
                            Console.WriteLine($"Cannot divide {nf} by zero");
                            break;
                        default:
                            nObshto = nf / ns;
                            Console.WriteLine($"{nf} {o} {ns} = {nObshto:f2}");
                            break;
                    }
                    break;
                default:
                    if (ns == 0)
                    {
                        Console.WriteLine($"Cannot divide {nf} by zero");
                        div++;
                    }
                    else
                    {
                        nObshto = nf % ns;


                    }
                    break;
            }
            if (o == '/')
            {
                return;
            }
            if (evenOdd == 0&&div==0)
            {
                Console.WriteLine($"{nf} {o} {ns} = {nObshto}");

            }
            else
            {

                if (nObshto % 2 == 0 && div==0)
                {
                    Console.WriteLine($"{nf} {o} {ns} = {nObshto} - even");
                }
                else
                {
                    Console.WriteLine($"{nf} {o} {ns} = {nObshto} - odd");
                }
            }

        }
    }
}
