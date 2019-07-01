using System;

namespace ExRate
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            float exchangeRate, euro, dollar, lira;
            int exchangeOperation;
            string[] isimler = { "Kukaraca", "Okey", "YamaşitoKombamba", "SA", "AS", "OY OY", "Emine", "Ne yaptın", "Sansasyonel", "Tamam", "Easy", "Burag" , "Zenginsin ha", "Yes", "No", "AAAA", "COME", "Ovv", "Right", "Bomb"};
            Random sayi = new Random();
            int no = sayi.Next(0, isimler.Length);


            Console.WriteLine("Welcome, Choose Your Exchange Operation : 1 for Euro to Dollar ;\n" +
                              "2 for Euro to Lira ;\n" +
                              "3 for Dollar to Euro ;\n" +
                              "4 for Dollar to Lira ;\n" +
                              "5 for Lira to Dollar ;\n" +
                              "6 for Lira to Euro ;\n");

            exchangeOperation = Convert.ToInt32(Console.ReadLine());

            if (exchangeOperation == 1)
            {
                do
                {
                    
                    Console.Write("Euro:");
                    euro = Convert.ToSingle(Console.ReadLine());

                    exchangeRate = 1;

                    dollar = euro * exchangeRate;


                    Console.WriteLine( isimler[no]  + dollar.ToString(" 0.00 $"));




                    Console.Write("Should we end the program? (yes/no)");
                    string s = Console.ReadLine();
                    i = string.Compare(s, "yes");

                } while (i != 0);
            }
            else if (exchangeOperation == 2)
            {
                do
                {
                    
                    Console.Write("Euro:");
                    euro = Convert.ToSingle(Console.ReadLine());

                    exchangeRate = 5.9f;

                    lira = euro * exchangeRate;


                    Console.WriteLine( isimler[no]  + lira.ToString(" 0.00 TL"));




                    Console.Write("Should we end the program? (yes/no)");
                    string s = Console.ReadLine();
                    i = string.Compare(s, "yes");

                } while (i != 0);
            }
            else if (exchangeOperation == 3)
            {
                do
                {
                    
                    Console.Write("Dollar:");
                    dollar = Convert.ToSingle(Console.ReadLine());

                    exchangeRate = 1;

                    euro = dollar * exchangeRate;


                    Console.WriteLine( isimler[no]  + euro.ToString(" 0.00 Euro "));




                    Console.Write("Should we end the program? (yes/no)");
                    string s = Console.ReadLine();
                    i = string.Compare(s, "yes");

                } while (i != 0);
            }
            else if (exchangeOperation == 4)
            {
                do
                {
                    
                    Console.Write("Dollar:");
                    dollar = Convert.ToSingle(Console.ReadLine());

                    exchangeRate = 5.9f;

                    lira = dollar * exchangeRate;


                    Console.WriteLine( isimler[no]  + lira.ToString(" 0.00 TL"));




                    Console.Write("Should we end the program? (yes/no)");
                    string s = Console.ReadLine();
                    i = string.Compare(s, "yes");

                } while (i != 0);
            }
            else if (exchangeOperation == 5)
            {
                do
                {
                    

                    Console.Write("Lira:");
                    lira = Convert.ToSingle(Console.ReadLine());

                    exchangeRate = 5.9f;

                    dollar = lira * exchangeRate;


                    Console.WriteLine( isimler [no]  + lira.ToString(" 0.00 $"));




                    Console.Write("Should we end the program? (yes/no)");
                    string s = Console.ReadLine();
                    i = string.Compare(s, "yes");

                } while (i != 0);
            }
            else if (exchangeOperation == 6)
            {
                do
                {
                    
                    Console.Write("Lira:");
                    lira = Convert.ToSingle(Console.ReadLine());

                    exchangeRate = 5.9f;

                    euro = lira * exchangeRate;


                    Console.WriteLine( isimler [no]  + euro.ToString(" 0.00 Euro "));




                    Console.Write("Should we end the program? (yes/no)");
                    string s = Console.ReadLine();
                    i = string.Compare(s, "yes");

                } while (i != 0);
            }
        }
    }
}
