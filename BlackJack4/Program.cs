using System;
namespace BlackJack_4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            Random slump = new Random();
            string senasteVinnaren = "Ingen vinnare ännu";

            Console.WriteLine("Välkommen till backJack");

            string Val = "0";
            while (Val != "4")
            {

                Console.WriteLine("Välj ett av de 4 alternativen");
                Console.WriteLine("1. Spela 21");
                Console.WriteLine("2. Visa senaste vinnare");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta spelet");
                Val = Console.ReadLine();

                Console.WriteLine();

                switch (Val)
                {

                    case "1":
                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        Console.WriteLine("Två kort kommer att dras per spelare");
                        datornsPoäng += slump.Next(1, 11);
                        datornsPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);


                        string kortVal = "";
                        while (kortVal != "n" && spelarensPoäng <= 21)
                        {
                            Console.WriteLine($"Din poäng: {spelarensPoäng}");
                            Console.WriteLine($"Datorns poäng: {datornsPoäng}");
                            Console.WriteLine("Vill du ta ett till kort (j/n)");
                            kortVal = Console.ReadLine();

                            switch (kortVal)
                            {
                                case "j":
                                    int nyPoäng = slump.Next(1, 11);
                                    spelarensPoäng += nyPoäng;
                                    Console.WriteLine($"Ditt kort är värt: {nyPoäng} poäng");
                                    break;

                                case "n":
                                    break;

                                default:
                                    Console.WriteLine("Detta valet finns inte");
                                    break;
                            }

                        }


                        if (spelarensPoäng > 21)
                        {
                            Console.WriteLine("Du fick mer än 21, du förlorade");
                            break;
                        }


                        while (datornsPoäng < spelarensPoäng && datornsPoäng <= 21)
                        {
                            int datornsNyaPoäng = slump.Next(1, 12);
                            datornsPoäng += datornsNyaPoäng;
                            Console.WriteLine($"Datorns nya kort är värt{datornsNyaPoäng}");
                        }

                        Console.WriteLine($"Din poäng: {spelarensPoäng}");
                        Console.WriteLine($"Datorns poäng: {datornsPoäng}");


                        if (datornsPoäng > 21)
                        {
                            Console.WriteLine("Grattis du Vann");
                            Console.WriteLine("Skriv in ditt namn");
                            senasteVinnaren = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Datorn vann");
                        }

                        break;


                    case "2":
                        Console.WriteLine($"Senaste vinnaren är: {senasteVinnaren}");
                        break;



                    case "3":
                        string text = "Ditt mål är att tvinga datorn att få mer än 21 poäng.";
                        foreach (char c in text)
                        {
                            Console.Write(c);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");

                        string text2 = "Du får poäng genom att dra kort, varje kort har 1-10 poäng.";
                        foreach (char e in text2)
                        {
                            Console.Write(e);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");

                        string text3 = "Om du får mer än 21 poäng har du förlorat.";
                        foreach (char f in text3)
                        {
                            Console.Write(f);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");

                        string text4 = "Både du och datorn får två kort i början. Du ska dra kort till du är nöjd eller får över 21.";
                        foreach (char g in text4)
                        {
                            Console.Write(g);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");

                        string text5 = "När du är färdig drar datorn kort till den har mer poäng än dig eller över 21 poäng.";
                        foreach (char h in text5)
                        {
                            Console.Write(h);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine("");
                        string text6 = "Lycka till....";
                        foreach (char i in text6)
                        {
                            Console.Write(i);
                            Thread.Sleep(20);
                        }
                        break;

                        break;


                    case "4":
                        Console.WriteLine("Programmet kommer att stängas av......");
                        break;

                    default:
                        Console.WriteLine("Du ska välja ett av alternativen annars kan programmet inte köra!!");
                        break;
                }


                Console.WriteLine();
            }

            
        }
    }
}