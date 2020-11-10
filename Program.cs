using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp23
{
    public class Menu
    {

            public void DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine("1. Get coin");
            Console.WriteLine("2. Store");
            Console.WriteLine("Press Esc to Exit");
        }

        public void StoreMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Купить червя ( " + (GetCoin.mod1+100)+")");
            Console.WriteLine("2. Купить зомбю( " + (GetCoin.mod2 + 1000) + ")");
            Console.WriteLine("3. Купить вампира(" + (GetCoin.mod3 + 10000) + ")");
            Console.WriteLine("4. Купить оборотня(" + (GetCoin.mod4 + 100000) + ")");
            Console.WriteLine("5. Купить демона(" + (GetCoin.mod5 + 1000000) + ")");
            Console.WriteLine("Press Esc to Exit");
        }
        public void Store()
        {
            Menu result2 = new Menu();
            GetCoin monster = new GetCoin();
            ConsoleKeyInfo cki;

            do
            {

                Console.Clear();
               result2.StoreMenu();
                Console.WriteLine("Coin:" +GetCoin.pocket );
                Console.WriteLine("Income:" + GetCoin.income);
                

                cki = Console.ReadKey(false);
                switch (cki.KeyChar.ToString())
                {
                    case "1":

                        if (GetCoin.pocket > GetCoin.mod1)
                        {
                            monster.Monster1();
                            GetCoin.pocket = GetCoin.pocket - GetCoin.mod1;
                        }
                        else
                        {  }
                       
                        break;

                    case "2":

                        if (GetCoin.pocket > GetCoin.mod2)
                        {
                            monster.Monster2();
                            GetCoin.pocket = GetCoin.pocket - GetCoin.mod2;
                        }
                        else
                        { }

                        break;

                    case "3":

                        if (GetCoin.pocket > GetCoin.mod3)
                        {
                            monster.Monster3();
                            GetCoin.pocket = GetCoin.pocket - GetCoin.mod3;
                        }

                        else
                        { }

                        break;

                    case "4":

                        if (GetCoin.pocket > GetCoin.mod4)
                        {
                            monster.Monster4();
                            GetCoin.pocket = GetCoin.pocket - GetCoin.mod4;
                        }

                        else
                        { }

                        break;

                    case "5":
                        if (GetCoin.pocket > GetCoin.mod5)
                        {
                            monster.Monster5();
                            GetCoin.pocket = GetCoin.pocket - GetCoin.mod5;     
                        }

                        else
                        { }

                        break;

                    default:

                        break;

                }
            }
            while (cki.Key != ConsoleKey.Escape);
            

        }
    }

    public class GetCoin
    {
        public static int income { get; set; }
        public static double pocket { get; set; }
        public static double mod1 { get; set; }
        public static double mod2 { get; set; }
        public static double mod3 { get; set; }
        public static double mod4 { get; set; }
        public static double mod5 { get; set; }

        public static int monincome1 { get; set; }
        public static int monincome2 { get; set; }
        public static int monincome3 { get; set; }
        public static int monincome4 { get; set; }
        public static int monincome5 { get; set; }

        public int Click()
        {
            pocket = 0;
            income = 1 + monincome1 + monincome2 + monincome3 + monincome4 + monincome5;
            pocket = pocket + income;
            return income;
        }

        public void Monster1()
        {
            monincome1++;
            monincome1 = monincome1 * 1;
            mod1 = 100;
            mod1 = mod1 * monincome1;
            
        }

        public void Monster2()
        {
            monincome2++;
            monincome2 = monincome2 * 3;
            mod2 = 1000;
            mod2 = mod2 * monincome1;

        }
        public void Monster3()
        {
            monincome3++;
            monincome3 = monincome3 * 10;
            mod3 = 10000;
            mod3 = mod3 * monincome1;

        }
        public void Monster4()
        {
            monincome4++;
            monincome4 = monincome4*25;
            mod4 = 100000;
            mod4 = mod4 * monincome1;

        }
        public void Monster5()
        {
            monincome5++;
            monincome5 = monincome5*100;
            mod5 = 1000000;
            mod5 = mod5 * monincome1;

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            double bag=0;
            Menu result = new Menu();
            GetCoin click = new GetCoin();
            ConsoleKeyInfo cki;
            

            do
            {
                Console.Clear();
                result.DisplayMenu();
                Console.WriteLine("Coin:" +bag);
                Console.WriteLine("Income:" + GetCoin.income);
                bag = GetCoin.pocket;

                cki = Console.ReadKey(false);
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        bag = bag + click.Click();
                        GetCoin.pocket = bag;

                        
                        
                        break;

                    case "2":

                        //Console.Clear();
                        result.Store();

                        break;

                    case "3":

                        break;

                }



            } while (cki.Key != ConsoleKey.Escape);

            

        }
    }
}
