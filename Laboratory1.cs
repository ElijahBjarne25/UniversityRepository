/*
 * Лабораторная работа № 1. 
 * Михайлюк Илья Владимирович, группа ОБ-7351-20.
 * Знак * в выводе означает несовпадение с ответом в Лабораторной.
 */ 


using System;

namespace UniLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------//
            // Number 1.                                  //
            //--------------------------------------------//

            double x, y, z;
            double t;
            double t1, t2, t3, t4;

            x = 14.26;
            y = -1.22;
            z = 3.5e-2;

            t1 = 2 * Math.Cos(x - Math.PI / 6);
            t2 = 0.5 + Math.Pow(Math.Sin(y), 2);
            t3 = Math.Pow(z, 2);
            t4 = 3 - t3 / 5;

            t = t1 / t2 * (1 + t3 / t4);
            
            Console.WriteLine("№1 t = " + t);

             //--------------------------------------------//
            // Number 2.                                  //
           //--------------------------------------------//

            double u;
            double u1, u2, u3, u4;

            x = -4.5;
            y = 0.75e-4;
            z = 0.845e2;

            u1 = Math.Sqrt(8 + Math.Pow(Math.Abs(x - y), 2) + 1);
            u2 = Math.Pow(x, 2) + Math.Pow(y, 2) + 2;
            u3 = Math.Exp(Math.Abs(x - y));
            u4 = Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x);

            u = u1 / u2 - u3 * u4;
            
            Console.WriteLine("№2 u = " + u + " * "); 

            //--------------------------------------------//
            // Number 3.                                  //
            //--------------------------------------------//

            double v;

            x = 3.74e-2;
            y = -0.825;
            z = 0.16e2;

            v = (1 + Math.Pow(Math.Sin(x + y), 2)) / Math.Abs(x - (2 * y / 1 + Math.Pow(x, 2) * Math.Pow(y,2)))
                * Math.Pow(x, Math.Abs(y)) + Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

            Console.WriteLine("№3 v = " + v);

             //--------------------------------------------//
            // Number 4.                                  //
           //--------------------------------------------//

            double w;
            double w1, w2, w3;

            x = 0.4e4;
            y = -0.875;
            z = -0.475e-3;

            w1 = Math.Abs(Math.Cos(x) - Math.Cos(y));
            w2 = 1 + 2 * Math.Pow(Math.Sin(y), 2);
            w3 = 1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 4) / 4;

            w = Math.Pow(w1, w2) * w3;

            Console.WriteLine("№4 w = " + w);

             //-----------------------------------------//
            // Number 5.                               //
           //-----------------------------------------//

            double alpha;
            double alpha1, alpha2, alpha3;

            x = -15.246;
            y = 4.642e-2;
            z = 20.001e2;

            alpha1 = Math.Log10(Math.Pow(y, -Math.Sqrt(Math.Abs(x))));
            alpha2 = x - (y / 2);
            alpha3 = Math.Pow(Math.Sin(Math.Atan(z)), 2);

            alpha = alpha1 * alpha2 + alpha3;

            Console.WriteLine("№5 Alpha = " + alpha + " * ");

            //-----------------------------------------//
            // Number 6.                               //
            //-----------------------------------------//

            double beta;
            double beta1, beta2;

            x = 16.55e-3;
            y = -2.75;
            z = 0;

            beta1 = Math.Sqrt(10 * (Math.Pow(x, 1 / 3) + Math.Pow(x, y + 2)));
            beta2 = Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y);

            beta = beta1 * beta2;

            Console.WriteLine("№6 Beta = " + beta + " * ");

            //---------------------------------------//
            // Number 7.                             //
            //---------------------------------------//

            double gamma;
            double gamma1, gamma2, gamma3, gamma4;

            x = 0.1722;
            y = 6.33;
            z = 3.25e-4;

            gamma1 = 5 * Math.Atan(x);
            gamma2 = 1 / 4 * Math.Acos(x);
            gamma3 = x + 3 * Math.Abs(x - y) + Math.Pow(x, 2);
            gamma4 = Math.Abs(x - y) * z + Math.Pow(x, 2);

            gamma = gamma1 - gamma2 * gamma3 / gamma4;

            Console.WriteLine("№7 Gamma = " + gamma + " * ");

            //--------------------------------------//
            // Number 8.                            //
            //--------------------------------------//

            double Phi;
            double Phi1, Phi2, Phi3;

            x = -2.235e-2;
            y = 2.23;
            z = 15.221;

            Phi1 = Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), x + y);
            Phi2 = Math.Atan(x) + Math.Atan(z);
            Phi3 = Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log10(y), 2), 1 / 3);

            Phi = Phi1 / Phi2 + Phi3;

            Console.WriteLine("№8 Phi = " + Phi);

            //-------------------------------------//
            // Number 9.                           //
            //-------------------------------------//

            double psi;
            double psi1, psi2, psi3, psi4;

            x = 1.825e2;
            y = 18.225;
            z = -3.298e-2;

            psi1 = Math.Abs(Math.Pow(x, 1 / 2) - Math.Pow(y / x, 1 / 3));
            psi2 = y - x;
            psi3 = Math.Cos(y) - (z / psi2);
            psi4 = 1 + Math.Pow(psi2, 2);

            psi = psi1 + psi2 * psi3 / psi4;

            Console.WriteLine("№9 Psi = " + psi + " * ");

            //--------------------------------------//
            // Number 10.                           //
            //--------------------------------------//

            double Alpha;
            double Alpha1, Alpha2, Alpha3, Alpha4;

            x = 3.981e-2;
            y = -1.625e3;
            z = 0.512;

            Alpha1 = Math.Pow(2, -x);
            Alpha2 = Math.Sqrt(x + Math.Pow(Math.Abs(y), 1 / 4));
            Alpha3 = x - 1 / Math.Sin(z);
            Alpha4 = Math.Pow(Math.Exp(Alpha3), 1 / 3);

            Alpha = Alpha1 * Alpha2 * Alpha4;

            Console.WriteLine("№10 Alpha = " + Alpha + " * ");

            //--------------------------------------//
            // Number 11.                           //
            //--------------------------------------//

            double b;
            double b1, b2, b3, b4;

            x = 6.251;
            y = 0.827;
            z = 25.001;

            b1 = Math.Pow(y, Math.Pow(Math.Abs(x), 1 / 3));
            b2 = Math.Pow(Math.Cos(y), 3);
            b3 = Math.Abs(x - y) * (1 + Math.Pow(Math.Sin(z), 2) / Math.Sqrt(x + y));
            b4 = Math.Exp(Math.Abs(x - y)) + x / 2;

            b = b1 + b2 * b3 / b4;

            Console.WriteLine("№11 b = " + b + " *");

            //--------------------------------------//
            // Number 12.                           //
            //--------------------------------------//

            double c;
            double c1, c2, c3, c4;

            x = 3.251;
            y = 0.325;
            z = 0.466e-4;

            c1 = Math.Pow(2, Math.Pow(y, x));
            c2 = Math.Pow(Math.Pow(3, x), y);
            c3 = y * (Math.Atan(z) - Math.PI / 6);
            c4 = Math.Abs(x) + 1 / Math.Pow(y, 2) + 1;

            c = c1 + c2 - c3 / c4;

            Console.WriteLine("№12 c = " + c);

            //--------------------------------------//
            // Number 13.                           //
            //--------------------------------------//

            double F;
            double F1, F2, F3, F0;

            x = 17.421;
            y = 10.365e-3;
            z = 0.828e5;

            F0 = Math.Pow(x - 1, 1 / 3);
            F1 = Math.Pow(y + F0, 1 / 4);
            F2 = Math.Abs(x - y);
            F3 = Math.Pow(Math.Sin(z), 2) + Math.Tan(z);

            F = F1 / (F2 + F3);

            Console.WriteLine("№13 F = " + F + " *");

            //--------------------------------------//
            // Number 14.                           //
            //--------------------------------------//

            double g;
            double g1, g2, g3, g4, g5, g0;

            x = 12.3e-1;
            y = 15.4;
            z = 0.252e3;

            g1 = Math.Pow(y, x + 1);
            g2 = Math.Pow(Math.Abs(y - 2) + 3, 1 / 3);
            g3 = x + (y / 2);
            g4 = 2 * Math.Abs(x + y);
            g0 = -1 / Math.Sin(z);
            g5 = Math.Pow(x + 1, g0);

            g = (g1 / g2) + (g3 / g4) * g5;

            Console.WriteLine("№14 g = " + g + " *");

            //--------------------------------------//
            // Number 15.                           //
            //--------------------------------------//

            double h;
            double h1, h2, h3, h4, h5, h0;

            x = 2.444;
            y = 0.869e-2;
            z = -0.13e3;

            h0 = Math.Abs(y - x);
            h1 = Math.Pow(x, y + 1) + Math.Exp(y - 1);
            h2 = 1 + x * Math.Abs(y - Math.Tan(z));
            h3 = 1 + h0;
            h4 = Math.Pow(Math.Abs(h0), 2) / 2;
            h5 = Math.Pow(Math.Abs(h0), 3) / 3;

            h = (h1 / h2) * h3 + h4 - h5;

            Console.WriteLine("№15 h = " + h);
        }
    }
}
