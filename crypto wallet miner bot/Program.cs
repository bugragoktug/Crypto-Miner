using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto_wallet_miner_bot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region entry screen
            Console.WriteLine("Welcome To FAKE Crypto Miner");
            Console.WriteLine("This App Is Fake, Written For Fun");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("░░░░░░░░░░░█▀▀░░█░░░░░░\r\n░░░░░░▄▀▀▀▀░░░░░█▄▄░░░░\r\n░░░░░░█░█░░░░░░░░░░▐░░░\r\n░░░░░░▐▐░░░░░░░░░▄░▐░░░\r\n░░░░░░█░░░░░░░░▄▀▀░▐░░░\r\n░░░░▄▀░░░░░░░░▐░▄▄▀░░░░\r\n░░▄▀░░░▐░░░░░█▄▀░▐░░░░░\r\n░░█░░░▐░░░░░░░░▄░█░░░░░\r\n░░░█▄░░▀▄░░░░▄▀▐░█░░░░░\r\n░░░█▐▀▀▀░▀▀▀▀░░▐░█░░░░░\r\n░░▐█▐▄░░▀░░░░░░▐░█▄▄░░░\r\n░░░▀▀▄░░░░░░░░▄▐▄▄▄▀░░░\r\n░░░░░░░░░░░░░░░░░░░░░░░");
            #endregion
            #region loading screen
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LOADING...");
            System.Threading.Thread.Sleep(600);
            Console.WriteLine("→→→ [■□□□□□□□□□] %10");
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine("→→→ [■■□□□□□□□□] %20");
            System.Threading.Thread.Sleep(900);
            Console.WriteLine("→→→ [■■■□□□□□□□] %30");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("→→→ [■■■■□□□□□□] %40");
            System.Threading.Thread.Sleep(750);
            Console.WriteLine("→→→ [■■■■■□□□□□] %50");
            System.Threading.Thread.Sleep(750);
            Console.WriteLine("→→→ [■■■■■■□□□□] %60");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("→→→ [■■■■■■■□□□] %70");
            System.Threading.Thread.Sleep(600);
            Console.WriteLine("→→→ [■■■■■■■■□□] %80");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("→→→ [■■■■■■■■■□] %90");
            System.Threading.Thread.Sleep(900);
            Console.WriteLine("→→→ [■■■■■■■■■■] %100");
            System.Threading.Thread.Sleep(200);
        #endregion
            #region Mining Currency Choosing Screen
            EnBas:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose Your Mining Currency");
            Console.WriteLine("[1] Doge");
            Console.WriteLine("[2] BTC");
            Console.WriteLine("[3] ETH");
            Console.WriteLine("[4] TRX");
            var a = Console.ReadLine();
            #endregion
            #region Doge Mining Codes
            if (a == "1")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("IF YOU ENTER THE WRONG ADDRESS, THE BALANCE WILL BE LOST!!");
                Console.Write("Enter Your Doge Adress :");
                var b = Console.ReadLine();
            kazimYeri:
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mining Started!!");
                Console.WriteLine("It will takes 55 seconds");
                System.Threading.Thread.Sleep(1000);
                for (int i = 1; i <= 500; i++)
                {
                    Random rastgele = new Random();
                    string harfler = "ABCDEFGHIJKLMNOPRSTUVYZXQWabcdefghijklmnoprstuvyzxqw";
                    string uret = "";
                    for (int m = 0; m < 33; m++)
                    {
                        uret += harfler[rastgele.Next(harfler.Length)];
                    }
                    Console.WriteLine(">  " + uret + "  [0.00000 Doge]");
                    System.Threading.Thread.Sleep(110);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mining Ended");
                Console.WriteLine("Earned Doge:31.3131");
                Console.WriteLine("Would You Like To Withdraw This Balance To Your Adress ?");
            yesNo:
                Console.WriteLine("[Y]: Yes       [N]: No (Funds will be lost)");
                var n = Console.ReadLine();
                if (n == "Y" || n == "y")

                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Funds Sending...");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("→→→ [■□□□□□□□□□] %10");
                    System.Threading.Thread.Sleep(1200);
                    Console.WriteLine("→→→ [■■□□□□□□□□] %20");
                    System.Threading.Thread.Sleep(900);
                    Console.WriteLine("→→→ [■■■□□□□□□□] %30");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("→→→ [■■■■□□□□□□] %40");
                    System.Threading.Thread.Sleep(750);
                    Console.WriteLine("→→→ [■■■■■□□□□□] %50");
                    System.Threading.Thread.Sleep(750);
                    Console.WriteLine("→→→ [■■■■■■□□□□] %60");
                    System.Threading.Thread.Sleep(800);
                    Console.WriteLine("→→→ [■■■■■■■□□□] %70");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("→→→ [■■■■■■■■□□] %80");
                    System.Threading.Thread.Sleep(400);
                    Console.WriteLine("→→→ [■■■■■■■■■□] %90");
                    System.Threading.Thread.Sleep(900);
                    Console.WriteLine("→→→ [■■■■■■■■■■] %100");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FUNDS SENDED!!");
                    Console.WriteLine("Funds yarrak Sended");
                    System.Threading.Thread.Sleep(400);
                tekrar:
                    Console.WriteLine("[0]: Dig Doge Again to Same Address    [1]: Change Crypto to be Mined");
                    var q = Console.ReadLine();
                    if (q == "0")
                    {
                        Console.WriteLine("Processing...");
                        System.Threading.Thread.Sleep(2000);
                        goto kazimYeri;
                    }
                    else if (q == "1")
                    {
                        Console.WriteLine("Processing...");
                        System.Threading.Thread.Sleep(2000);
                        goto EnBas;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Valid Value...");
                        System.Threading.Thread.Sleep(250);
                        goto tekrar;
                    }
                }
                else if (n == "n" || n == "N")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Funds Are Losing...");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Lunds Lost");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto EnBas;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter a Valid Value...");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto yesNo;

                }


            }
            #endregion
            #region BTC Mining Codes
            else if (a == "2")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("IF YOU ENTER THE WRONG ADDRESS, THE BALANCE WILL BE LOST!!");
                Console.Write("Enter Your BTC Adress :");
                var b = Console.ReadLine();
            kazimYeri:
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mining Started!!");
                Console.WriteLine("It will takes 55 seconds");
                System.Threading.Thread.Sleep(1000);
                for (int i = 1; i <= 500; i++)
                {
                    Random rastgele = new Random();
                    string harfler = "ABCDEFGHIJKLMNOPRSTUVYZXQWabcdefghijklmnoprstuvyzxqw";
                    string uret = "";
                    for (int m = 0; m < 33; m++)
                    {
                        uret += harfler[rastgele.Next(harfler.Length)];
                    }
                    Console.WriteLine(">  " + uret + "  [0.00000 BTC]");
                    System.Threading.Thread.Sleep(110);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mining Ended");
                Console.WriteLine("Earned BTC:0.00031313131");
                Console.WriteLine("Would You Like To Withdraw This Balance To Your Adress ?");
            yesNo:
                Console.WriteLine("[Y]: Yes       [N]: No (Funds will be lost)");
                var n = Console.ReadLine();
                if (n == "Y" || n == "y")

                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Funds Sending...");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("→→→ [■□□□□□□□□□] %10");
                    System.Threading.Thread.Sleep(1200);
                    Console.WriteLine("→→→ [■■□□□□□□□□] %20");
                    System.Threading.Thread.Sleep(900);
                    Console.WriteLine("→→→ [■■■□□□□□□□] %30");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("→→→ [■■■■□□□□□□] %40");
                    System.Threading.Thread.Sleep(750);
                    Console.WriteLine("→→→ [■■■■■□□□□□] %50");
                    System.Threading.Thread.Sleep(750);
                    Console.WriteLine("→→→ [■■■■■■□□□□] %60");
                    System.Threading.Thread.Sleep(800);
                    Console.WriteLine("→→→ [■■■■■■■□□□] %70");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("→→→ [■■■■■■■■□□] %80");
                    System.Threading.Thread.Sleep(400);
                    Console.WriteLine("→→→ [■■■■■■■■■□] %90");
                    System.Threading.Thread.Sleep(900);
                    Console.WriteLine("→→→ [■■■■■■■■■■] %100");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FUNDS SENDED!!");
                    Console.WriteLine("Funds yarrak Sended");
                    System.Threading.Thread.Sleep(400);
                tekrar:
                    Console.WriteLine("[0]: Dig BTC Again to Same Address    [1]: Change Crypto to be Mined");
                    var q = Console.ReadLine();
                    if (q == "0")
                    {
                        Console.WriteLine("Processing...");
                        System.Threading.Thread.Sleep(2000);
                        goto kazimYeri;
                    }
                    else if (q == "1")
                    {
                        Console.WriteLine("Processing...");
                        System.Threading.Thread.Sleep(2000);
                        goto EnBas;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Valid Value...");
                        System.Threading.Thread.Sleep(250);
                        goto tekrar;
                    }
                }
                else if (n == "n" || n == "N")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Funds Are Losing...");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Lunds Lost");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto EnBas;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter a Valid Value...");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto yesNo;
                }

            }
            #endregion
            #region ETH Mining Codes
            else if (a == "3")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("IF YOU ENTER THE WRONG ADDRESS, THE BALANCE WILL BE LOST!!");
                Console.Write("Enter Your ETH Adress :");
                var b = Console.ReadLine();
            kazimYeri:
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mining Started!!");
                Console.WriteLine("It will takes 55 seconds");
                System.Threading.Thread.Sleep(1000);
                for (int i = 1; i <= 500; i++)
                {
                    Random rastgele = new Random();
                    string harfler = "ABCDEFGHIJKLMNOPRSTUVYZXQWabcdefghijklmnoprstuvyzxqw";
                    string uret = "";
                    for (int m = 0; m < 33; m++)
                    {
                        uret += harfler[rastgele.Next(harfler.Length)];
                    }
                    Console.WriteLine(">  " + uret + "  [0.00000 ETH]");
                    System.Threading.Thread.Sleep(110);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mining Ended");
                Console.WriteLine("Earned ETH:0.00313131");
                Console.WriteLine("Would You Like To Withdraw This Balance To Your Adress ?");
            yesNo:
                Console.WriteLine("[Y]: Yes       [N]: No (Funds will be lost)");
                var n = Console.ReadLine();
                if (n == "Y" || n == "y")

                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Funds Sending...");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("→→→ [■□□□□□□□□□] %10");
                    System.Threading.Thread.Sleep(1200);
                    Console.WriteLine("→→→ [■■□□□□□□□□] %20");
                    System.Threading.Thread.Sleep(900);
                    Console.WriteLine("→→→ [■■■□□□□□□□] %30");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("→→→ [■■■■□□□□□□] %40");
                    System.Threading.Thread.Sleep(750);
                    Console.WriteLine("→→→ [■■■■■□□□□□] %50");
                    System.Threading.Thread.Sleep(750);
                    Console.WriteLine("→→→ [■■■■■■□□□□] %60");
                    System.Threading.Thread.Sleep(800);
                    Console.WriteLine("→→→ [■■■■■■■□□□] %70");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("→→→ [■■■■■■■■□□] %80");
                    System.Threading.Thread.Sleep(400);
                    Console.WriteLine("→→→ [■■■■■■■■■□] %90");
                    System.Threading.Thread.Sleep(900);
                    Console.WriteLine("→→→ [■■■■■■■■■■] %100");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FUNDS SENDED!!");
                    Console.WriteLine("Funds yarrak Sended");
                    System.Threading.Thread.Sleep(400);
                tekrar:
                    Console.WriteLine("[0]: Dig ETH Again to Same Address    [1]: Change Crypto to be Mined");
                    var q = Console.ReadLine();
                    if (q == "0")
                    {
                        Console.WriteLine("Processing...");
                        System.Threading.Thread.Sleep(2000);
                        goto kazimYeri;
                    }
                    else if (q == "1")
                    {
                        Console.WriteLine("Processing...");
                        System.Threading.Thread.Sleep(2000);
                        goto EnBas;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Valid Value...");
                        System.Threading.Thread.Sleep(250);
                        goto tekrar;
                    }
                }
                else if (n == "n" || n == "N")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Funds Are Losing...");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Lunds Lost");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto EnBas;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter a Valid Value...");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto yesNo;
                }

            }
            #endregion
            #region TRX Mining Codes
            else if (a == "4")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("IF YOU ENTER THE WRONG ADDRESS, THE BALANCE WILL BE LOST!!");
                Console.Write("Enter Your TRX Adress :");
                var b = Console.ReadLine();
            kazimYeri:
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mining Started!!");
                Console.WriteLine("It will takes 55 seconds");
                System.Threading.Thread.Sleep(2200);
                for (int i = 1; i <= 500; i++)
                {
                    Random rastgele = new Random();
                    string harfler = "ABCDEFGHIJKLMNOPRSTUVYZXQWabcdefghijklmnoprstuvyzxqw";
                    string uret = "";
                    for (int m = 0; m < 33; m++)
                    {
                        uret += harfler[rastgele.Next(harfler.Length)];
                    }
                    Console.WriteLine(">  " + uret + "  [0.00000 TRX]");
                    System.Threading.Thread.Sleep(110);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mining Ended");
                Console.WriteLine("Earned TRX:313.131");
                Console.WriteLine("Would You Like To Withdraw This Balance To Your Adress ?");
            yesNo:
                Console.WriteLine("[Y]: Yes       [N]: No (Funds will be lost)");
                var n = Console.ReadLine();
                if (n == "Y" || n == "y")

                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Funds Sending...");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("→→→ [■□□□□□□□□□] %10");
                    System.Threading.Thread.Sleep(1200);
                    Console.WriteLine("→→→ [■■□□□□□□□□] %20");
                    System.Threading.Thread.Sleep(900);
                    Console.WriteLine("→→→ [■■■□□□□□□□] %30");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("→→→ [■■■■□□□□□□] %40");
                    System.Threading.Thread.Sleep(750);
                    Console.WriteLine("→→→ [■■■■■□□□□□] %50");
                    System.Threading.Thread.Sleep(750);
                    Console.WriteLine("→→→ [■■■■■■□□□□] %60");
                    System.Threading.Thread.Sleep(800);
                    Console.WriteLine("→→→ [■■■■■■■□□□] %70");
                    System.Threading.Thread.Sleep(600);
                    Console.WriteLine("→→→ [■■■■■■■■□□] %80");
                    System.Threading.Thread.Sleep(400);
                    Console.WriteLine("→→→ [■■■■■■■■■□] %90");
                    System.Threading.Thread.Sleep(900);
                    Console.WriteLine("→→→ [■■■■■■■■■■] %100");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FUNDS SENDED!!");
                    Console.WriteLine("Funds yarrak Sended");
                    System.Threading.Thread.Sleep(400);
                tekrar:
                    Console.WriteLine("[0]: Dig TRX Again to Same Address    [1]: Change Crypto to be Mined");
                    var q = Console.ReadLine();
                    if (q == "0")
                    {
                        Console.WriteLine("Processing...");
                        System.Threading.Thread.Sleep(2000);
                        goto kazimYeri;
                    }
                    else if (q == "1")
                    {
                        Console.WriteLine("Processing...");
                        System.Threading.Thread.Sleep(2000);
                        goto EnBas;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Valid Value...");
                        System.Threading.Thread.Sleep(250);
                        goto tekrar;
                    }
                }
                else if (n == "n" || n == "N")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Funds Are Losing...");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Lunds Lost");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto EnBas;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter a Valid Value...");
                    System.Threading.Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto yesNo;
                }
            }
            #endregion
            #region else mining
            else
            {
                Console.WriteLine("Please Enter A Valid Value");
                System.Threading.Thread.Sleep(250);
                goto EnBas;
            }
            #endregion
        }   
        
    }
}
