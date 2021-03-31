using System;

namespace ProgEx10
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro
            Console.WriteLine("Welcome to C# Exercise 10: Base Number Conversion");
            while (true)
            {

                //check to see if we will go another round
                Console.WriteLine("Enter 'Q' to exit, 'N' to continue:");
                string exit = Console.ReadLine();
                if (exit == "q" || exit == "Q")
                    Environment.Exit(0);

                //get base to convert from
                Console.WriteLine("Please enter the base to convert from: ( 2 | 8 | 10 | 16 )");
                string n2 = Console.ReadLine();
                int from = int.Parse(n2);

                // get number to convert
                Console.WriteLine("Please enter the integer to convert:");
                string n1 = Console.ReadLine();
                bool success = Int32.TryParse(n1, out int number);
                if (success)
                    Console.WriteLine($"Number: {number}, base: {from} \n");
                else
                    Console.WriteLine($"Number: {n1}, base: {from} \n");

                long result = 0;
                string str_result = "";

                // convert decimal to ""
                if (from == 10)
                {
                    int rem;
                    int number1 = number;
                    while (number1 > 0)
                        {
                        rem = number1 % 2;
                        number1 /= 2;
                        result = rem + result;
                    }
                    Console.WriteLine($"Binary conversion is {result}");

                    int i, j, ocno = 0;
                    int number2 = number;
                    i = 1;
                    for (j=number2; j>0; j=j/8)
                    {
                        ocno = ocno + (j % 8) * i;
                        i = i * 10;
                        number2 = number2 / 8;
                        result = number2;
                    }
                    Console.WriteLine($"Octal conversion is {result}");

                    int number3 = number;
                    str_result = number3.ToString("X");
                    Console.WriteLine($"Hex conversion is {str_result}");
                }
                //convert binary to ""
                else if (from == 2)
                {
                    string number4 = number.ToString();
                    char[] array = number4.ToCharArray();
                    Array.Reverse(array);
                    int sum = 0;
                    for(int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == '1')
                        {
                            if (i == 0)
                            {
                                sum += 1;
                            }
                            else
                            {
                                sum += (int)Math.Pow(2, i);
                            }
                        }
                        result = sum;
                    }
                    Console.WriteLine($"Decimal conversion is {result}");

                    string an1 = n1;
                    result = Convert.ToInt32(an1, 2);
                    Console.WriteLine($"Octal conversion is {Convert.ToString(result,8)}");

                    string bn1 = n1;
                    str_result = Convert.ToInt32(bn1, 2).ToString("X");
                    Console.WriteLine($"Hex conversion is {str_result}");
                }
                //convert octal to ""
                else if (from == 8)
                {
                    int cn1 = Convert.ToInt32(n1);
                    int n5, p = 1;
                    int dec = 0, i = 1, j, d;
                    int binno = 0;
                    n5 = cn1;
                    for (j=cn1; j>0;j=j/10)
                    {
                        d = j % 10;
                        if (i == 1)
                            p = p * 1;
                        else
                            p = p * 8;
                        dec = dec + (d * p);
                        i++;
                    }
                    i = 1;
                    for(j=dec;j>0;j=j/2)
                    {
                        binno = binno + (dec % 2) * i;
                        i = i * 10;
                        dec = dec / 2;
                    }
                    result = dec;
                    Console.WriteLine($"Binary conversion is {result}");

                    int k;
                    int dn1 = Convert.ToInt32(n1);
                    int n6 = dn1;
                    for (; dn1 > 0; dn1 = dn1 / 10)
                    {
                        k = dn1 % 10;
                    }
                    for(j=dn1;j>0;j=j/10)
                    {
                        d = j % 10;
                        if (i == 1)
                            p = p * 1;
                        else
                            p = p * 8;
                        dec = dec + (d * p);
                            i++;
                        result = dec;
                    }
                    Console.WriteLine($"Decimal conversion is {result}");

                    int en1 = Convert.ToInt32(n1);
                    int decim = 0;
                    int bas = 1;
                    int temp = en1;
                    while(temp>0)
                    {
                        int ld = temp % 10;
                        temp = temp / 10;
                        decim += ld * bas;
                        bas = bas * 8;
                    }
                    char[] hexadecinum = new char[100];
                    string ans = "";
                    int n = 0;
                    while (n!=0)
                    {
                        temp = 0;
                        temp = n % 16;
                        if(temp<10)
                        {
                            hexadecinum[i] = (char)(temp + 48);
                            i++;
                        }
                        else
                        {
                            hexadecinum[i] = (char)(temp + 87);
                            i++;
                        }
                        n = n / 16;
                        for(int j=i-1; j>= 0; j--)
                        {
                            ans += hexadecinum[j];
                        }
                        str_result = ans;
                    }
                    Console.WriteLine($"Hex conversion is {str_result}");
                }
                //convert hex to ""
                else if (from == 16)
                {
                    string fn1 = n1;
                    fn1 = Convert.ToString((Convert.ToInt32(n1, 16), 2));
                    result = Convert.ToInt32(fn1);
                    Console.WriteLine($"Binary conversion is {result}");

                    string gn1 = n1;
                    gn1 = Convert.ToString(Convert.ToInt32(gn1, 16), 8);
                    result = Convert.ToInt32(gn1);
                    Console.WriteLine($"Octal conversion is {result}");

                    string hn1 = n1;
                    int value = Convert.ToInt32(hn1, 16);
                    str_result = Convert.ToString(value);
                    Console.WriteLine($"Decimal conversion is {str_result}");
                }
                else
                    Console.WriteLine("Error in base to convert from");
            }
        }
    }
}
