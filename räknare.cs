using System;
using System.Net.NetworkInformation;

namespace Räknare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Hej!");
            bool confirmed = false;
            while (!confirmed)
            {
                Console.Write("Vad vill du räkna ut? ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[m/a/s/d/o/e]");
                Console.WriteLine("Multiplication (m), Addition (a), Subtraktion (s) , Division(d), Ohms lag (o), Effektens lag (e)");
                Console.ForegroundColor = ConsoleColor.White;
                string option = Console.ReadLine();

            

                if (option == "m")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vilka två tal vill du multiplicera?");
                    Console.WriteLine("tal 1");
                    float Talm1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("tal 2");
                    float Talm2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ditt tal blir " + Totm(Talm1,Talm2));

                }

                if (option == "a")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vilka två tal vill du addera?");
                    Console.WriteLine("tal 1");
                    float Tala1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("tal 2");
                    float Tala2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ditt tal blir " + Tota(Tala1, Tala2));
                }

                if (option == "d")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vilka två tal vill du dividera?");
                    Console.WriteLine("tal 1");
                    float Tald1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("tal 2");
                    float Tald2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ditt tal blir " + Totd(Tald1, Tald2));

                }

                if (option == "s")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vilka två tal vill du subtraktera?");
                    Console.WriteLine("tal 1");
                    float Tals1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("tal 2");
                    float Tals2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ditt tal blir " + Tots(Tals1, Tals2));

                }

                if (option == "o")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vad vill du räkna ut? [U/R/I]");
                    
                    string resultat = Console.ReadLine();
                    if (resultat == "U")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("vad är resistansen? (R)");
                        float R = float.Parse(Console.ReadLine());
                        Console.WriteLine("och vad är strömmen? (I)");
                        float I = float.Parse(Console.ReadLine());
                        Console.WriteLine("Spänningen är: " + U(R, I) + " V");
                    }
                    
                    if (resultat == "R")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("vad är spänningen? (U)");
                        float U = float.Parse(Console.ReadLine());
                        Console.WriteLine("och vad är strömmen? (I)");
                        float I = float.Parse(Console.ReadLine());
                        Console.WriteLine("Resistansen är: " + R(U, I) + " Ohm");
                    }

                    if (resultat == "I")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Vad är spänningen? (U)");
                        float U = float.Parse(Console.ReadLine());
                        Console.WriteLine("och vad är resistansen? (R)");
                        float R = float.Parse(Console.ReadLine());
                        Console.WriteLine("Strömmen är: " + I(U, R) + " A");
                    }
                }

                if (option == "e")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vad vill du räkna ut? [P/U/I]");
                    string resultat = Console.ReadLine();

                    if (resultat == "P")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("vad är spänningen? (U)");
                        float U = float.Parse(Console.ReadLine());
                        Console.WriteLine("och vad är strömmen? (I)");
                        float I = float.Parse(Console.ReadLine());
                        Console.WriteLine("Effekten är: " + Pe(U, I) + (" W"));
                    }

                    if (resultat == "U")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("vad är effekten? (P)");
                        float Pe = float.Parse(Console.ReadLine());
                        Console.WriteLine("och vad är strömmen? (I)");
                        float Ie = float.Parse(Console.ReadLine());
                        Console.WriteLine("Spänningen är: " + Ue(Pe, Ie) + " V");
                    }

                    if (resultat == "I")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Vad är spänningen? (U)");
                        float Ue = float.Parse(Console.ReadLine());
                        Console.WriteLine("och vad är resistansen? (R)");
                        float Pe = float.Parse(Console.ReadLine());
                        Console.WriteLine("Strömmen är: " + Ie(Pe, Ue) + " A");
                    }
                }
                Console.WriteLine("Vill du fortsätta? [y/n]");
                string svar = Console.ReadLine();
                if (svar == "n")
                    confirmed = true;

            }
        }

        static float Totm(float Talm1, float Talm2)
        {
            return (Talm1 * Talm2);
        }

        static float Tota(float Tala1, float Tala2)
        {
            return (Tala1 + Tala2);
        }

        static float Totd(float Tald1, float Tald2)
        {
            return (Tald1 / Tald2);
        }

        static float Tots(float Tals1, float Tals2)
        {
            return (Tals1 - Tals2);
        }
        //
        //
        //
        static float U(float R, float I)
        {
            return (R * I);
        }
        static float R(float U, float I)
        {
            return (U / I);
        }
        static float I(float U, float R)
        {
            return (U / R);
        }
        //
        //
        //
        static float Pe(float Ue, float Ie)
        {
            return (Ue * Ie);
        }
        static float Ue(float Pe, float Ie)
        {
            return (Pe / Ie);
        }
        static float Ie(float Pe, float Ue)
        {
            return (Pe / Ue);
        }
        //
        //
        //
    }
}
