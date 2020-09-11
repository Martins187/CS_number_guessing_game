using System;
using System.Linq;

namespace pasa_istais_2._projekts
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int x1 = (random.Next(0,9));
            
            int x2 = (random.Next(0, 9));
           
            int x3 = (random.Next(0, 9));

            //Console.WriteLine(x1 + "" + x2 + "" + x3);
            int gajienu_skaits = 0;
            int errors = 0;


            Console.WriteLine("Uzmini 3 ciparus un pareizu to secību, ievadi ciparus!");
            Spele:

            String input = Console.ReadLine();
            gajienu_skaits += 1;
            errors += 1;
            try
            {
                int number5 = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Iemācies izlasīt nosacījumus, jāievada cipari!");
                goto Spele;
                
            }
            if ((input.Length<3) || (input.Length > 3))
            {
                Console.WriteLine("Nosacījumus māki lasīt? JĀIEVADA 3 CIPARI!!!");
                goto Spele;
            }
            
            
            int number1 = Convert.ToInt32(input);
            int y3 = number1 % 10;
            int number2 = number1 / 10;

            int y2 = number2 % 10;
            int number3 = number2 / 10;

            int y1 = number3 % 10;
            
            
            int[] kopa1 = { x1, x2, x3 };
            

           

            while (answer(x1, x2, x3, y1, y2, y3) == false) 
            {
                if (option_kopas1(kopa1,y1,y2,y3))
                {
                    if (option_int1(x1, x2, x3, y1, y2, y3))
                    {
                        if (option_int4(y1, y2, y3))
                        {
                            if (option_int2(x1, x2, x3, y1, y2, y3))
                            {
                                Console.WriteLine("Cipars, ko ievadīji 3x ir pareizs divās vietās!");
                            }
                            else
                            {
                                Console.WriteLine("Cipars, ko ievadīji 3x ir pareizs vienā vietā!");
                            }
                        }
                        else if (option_int3(y1, y2, y3))
                        {
                            if (option_int2(x1, x2, x3, y1, y2, y3))
                            {
                                Console.WriteLine("Divi cipari kopumā ir pareizās vietās, taču cipars, ko ievadīji divreiz, ir pareizs tikai vienā vietā!");
                            }
                            else
                            {
                                Console.WriteLine("Viens no cipariem, ko ievadīji divreiz, atrodas citā vietā, otrs ir pareizā vietā. Vienreiz ievadītais cipars atrodas citā vietā! Praktiski esi jau uzminējis!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Viens cipars ir pareizā vietā, divi vēl ir jāsamaina vietām!");
                        }
                    }
                    else 
                    {
                        if (option_int3(x1, x2, x3))
                        {
                            if (option_int3(y1, y2, y3))
                            {
                                Console.WriteLine("Cipars, ko ievadīji vienreiz, ir sastopams divreiz, cipars, ko ievadīji divreiz, ir sastopams vienreiz!");
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            Console.WriteLine("Visi cipari ir pareizi, taču neatrodas pareizās vietās!");
                        }
                    }
                }
                else if (option_kopas2(kopa1, y1, y2, y3))
                {
                    if (option_int2(x1, x2, x3, y1, y2, y3))
                    {
                        Console.WriteLine("Divi cipari atrodas pareizās pozīcijās!");
                    }
                    else if (option_int1(x1, x2, x3, y1, y2, y3))
                    {
                        
                        if (option_int3(y1, y2, y3))
                        {
                            Console.WriteLine("Cipars, ko ievadīji divreiz, ir pareizs vienā no pozīcijām");
                        }
                        else
                        {
                            Console.WriteLine("Divi cipari ir pareizi, taču tikai viens atrodas savā pozīcijā!");
                        }
                    }
                    else
                    {
                        if (option_int3(y1, y2, y3))
                        {
                            Console.WriteLine("Cipars, ko ievadīji divreiz, ir pareizs, tikai tas netroads nevienā no pozīcijām, kurās ievadīji to!");
                        }
                        else
                        {
                            Console.WriteLine("Divi cipari ir pareizi, tikai neatrodas pareizās pozīcijās!");
                        }
                    }
                }
                else if (option_kopas3(kopa1, y1, y2, y3))
                {
                    if (option_int1(x1, x2, x3, y1, y2, y3))
                    {
                        if (option_int3(x1, x2, x3))
                        {
                            Console.WriteLine("Viens no cipariem, ko ievadīji, ir pareizā vietā, un tāds pats cipars ir arī vēl vienā vietā!");
                        }
                        else
                        {
                            Console.WriteLine("Viens cipars atrodas pareizā pozīcijā!");
                        }
                    }
                    else
                    {
                        if (option_int3(x1, x2, x3))
                        {
                            Console.WriteLine("Viens cipars, ko ievadīji, neatrodas pareizā vietā, taču atrodas atlikušajās divās vietās!");
                        }
                        else
                        {
                            Console.WriteLine("Viens cipars ir pareizs, taču neatrodas pareizajā pozīcijā!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Neviens cipars nav pareizs, kur nu vēl pareizā pozīcijā! Mini vēlreiz!");
                }

                gajienu_skaits += 1;

                input = Console.ReadLine();
                try
                {
                    int number5 = Convert.ToInt32(input);
                }
                catch
                {
                    Console.WriteLine("Iemācies izlasīt nosacījumus, jāievada cipari!");
                    goto Spele;
                    
                }
                if ((input.Length < 3) || (input.Length > 3))
                {
                    Console.WriteLine("Nosacījumus māki lasīt? JĀIEVADA 3 CIPARI!!!");
                    goto Spele;
                    

                }
                
                number1 = Convert.ToInt32(input);

                y3 = number1 % 10;
                number2 = number1 / 10;

                y2 = number2 % 10;
                number3 = number2 / 10;

                y1 = number3 % 10;

            }
            
            Console.WriteLine("Apsveicu, uzminēji ar " + gajienu_skaits + " piegājieniem!");
            if (gajienu_skaits == 1)
            {
                Console.WriteLine("Tā bieži negadās, impressive!");
            }
            else if (gajienu_skaits <= 5)
            {
                Console.WriteLine("Diezgan labs rezultāts!");
            }
            else if (gajienu_skaits <= 10) 
            {
                Console.WriteLine("Pārliecinošs rezultāts!");
            }
            else
            {
                Console.WriteLine("Nja, ir kur tiekties!");
            }

            if (errors > 1)
            {
                Console.WriteLine("Vispār, ja tu nebūtu tik atpalicis un spētu izlasīt nosacījumus, rezultāts jau būtu labāks!");
            }
            
        }

        
        
        static bool answer(int a, int b, int c, int d, int e, int f)
        {
            if (a==d &&  b==e && c==f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool option_kopas1(int[]a, int b, int c, int d)
        {
            if (a.Contains(b) && a.Contains(c) && a.Contains(d))
            {
                return true;
            }
            else 
            {
                return false;
            }
           
            
        }
        static bool option_kopas2(int[]a, int b, int c, int d)
        {
            if ((a.Contains(b) && a.Contains(c)) || (a.Contains(c) && a.Contains(d)) || (a.Contains(b) && a.Contains(d)))
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        static bool option_kopas3(int[]a, int b, int c, int d)
        {
            if (a.Contains(b) || a.Contains(c) || a.Contains(d))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool option_int1(int a, int b, int c, int d, int e, int f)
        {
            if (a == d)
            {
                return true;
            }
            else if (b == e)
            {
                return true;
            }
            else if (c == f)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool option_int2(int a, int b, int c, int d, int e, int f)
        {
            if (((a == d) && (b == e)) || ((a == d) && (c == f)) || ((b == e) && (c == f)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool option_int3(int d, int e, int f)
        {
            if ((d==e) || (e==f) || (d == f))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool option_int4(int d, int e, int f)
        {
            if ((d==e) && (e == f))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
