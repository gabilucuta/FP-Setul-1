using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_setul_1___2___3
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16(); 
            //P17();
            //P18()?????;
            P19();


        }

        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
        /// </summary>

        private static void P19()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
        /// </summary>

        private static void P18()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            int aux = 0;
            bool aux2 = false;

            while (n % 2 == 0)
            {
                aux = aux + 1;
                n = n / 2;
            }
            if (aux > 0)
            {
                Console.Write("2^{0}", aux);
                aux2 = true;
                aux = 0;
            }

            for (int i = 3; i < Math.Sqrt(n); i +=2)
            {
                while (n % i == 0)
                {
                    aux = aux + 1;
                    n /=  i;
                }

                if (aux > 0)
                {
                    if(aux2)
                    {
                        Console.Write(" x ");
                    }
                    Console.Write("{0}^{1}", i, aux);
                    aux2 = true;
                }
                aux = 0;
            }

            
        }

        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid
        /// </summary>

        private static void P17()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int x = a;
            int y = b;

            int dmax = 0;
            int mmin = 0;
            int i = 1;

            if (a < b)
            {
                while (i <= a)
                {
                    if (a % i == 0)
                    {
                        if (b % i == 0)
                        {
                            dmax = i;
                        }
                    }

                    i++;
                }
            }
            else
            {
                while (i <= b)
                {
                    if (b % i == 0)
                    {
                        if (a % i == 0)
                        {
                            dmax = i;
                        }
                    }

                    i++;
                }
            }

            mmin = (x * y) / dmax;


            Console.WriteLine("Cel mai mare divizor comun este : {0} si cel mai mic multiplu  este : {1} ", dmax, mmin);
        
    }

        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>

        private static void P16()
        {
            Console.Write("Introduceti a , b , c , d , e  = ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int aux;

            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if(d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }

            if( a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if(b>c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            Console.Write("{0} {1} {2} {3} {4} ", a, b, c, d, e);



        }

        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>

        private static void P15()
        {
            Console.Write("Introduceti a , b , c  = ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int aux;

            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }

            Console.Write("{0} {1} {2} ", a, b, c);
        }

        /// <summary>
        /// Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321
        /// </summary>

        private static void P14()
        {
            Console.Write("Introduceti n  = ");
            int n = int.Parse(Console.ReadLine());

            int aux;
            int num = 0;
            int a = n;

            while (n != 0)
            {
                aux = n % 10;
                num = num * 10 + aux;
                n = n / 10;
            }

            if (a == num)
                Console.Write("Numarul este palindrom");
            else
                Console.Write("Numarul nu este palindrom ");
            Console.WriteLine();
        }


        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>

        private static void P13()
        {
            Console.Write("anul y1 = ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("anul y2 = ");
            int y2 = int.Parse(Console.ReadLine());

            int aux = 0;

            for (int i = y1; i <= y2; i++)
            {

                if ((i % 4 == 0) && (i % 100 != 0))
                    aux = aux + 1;
            }

            Console.Write("Sunt {0} ani bisecti in intervalul dat ", aux);
        }

        /// <summary>
        /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].
        /// </summary>

        private static void P12()
        {
            Console.Write("Introduceti intervalul : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti n : ");
            int n = int.Parse(Console.ReadLine());

            int aux = 0;

            for (int i = a;i<=b;i++)
            {
                if (i % n == 0)
                    aux = aux + 1;
            }

            Console.Write("{0} numere intregi sunt divizibile cu {1} .", aux, n);
        }

        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>

        private static void P11()
        {
            Console.Write("Introduceti n ");
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                int aux = n % 10;
                Console.Write(" {0} ", aux);
                n = n / 10;
            }
        }

        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>

        private static void P10()
        {
            Console.Write("Introduceti n ");
            int n = int.Parse(Console.ReadLine());

            int aux = 1;

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    aux = aux + 1;
            }

            if (aux == 2)

                Console.WriteLine("Numar prim .");
            else
                Console.WriteLine("Nu este numar prim .");


        }

        /// <summary>
        /// Afisati toti divizorii numarului n. 
        /// </summary>

        private static void P9()
        {
            Console.Write("Introduceti n ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n;i++)
            {
                if (n % i == 0)
                    Console.Write(" {0} ", i);
            }
        }

        /// <summary>
        /// Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
        /// </summary>

        private static void P8()
        {
            Console.Write("Introduceti a , b   = ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = {0} ; b = {1}", a, b);
        }

        /// <summary>
        /// Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor
        /// </summary>

        private static void P7()
        {
            Console.Write("Introduceti a , b   = ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int aux = a;
             a = b;
             b = aux;

            Console.WriteLine("a = {0} ; b = {1}" , a , b);

        }

        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
        /// </summary>

        private static void P6()
        {
            Console.Write("Introduceti a , b , c  = ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < a + b))
                Console.Write("a , b si c pot fi laturile unui triunghi ");
            else
                Console.Write("a , b si c nu pot fi laturile unui triunghi ");


        }


        //P5

        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        /// </summary>

        private static void P5()
        {
            Console.Write("Introduceti numarul = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti k = ");
            int k = int.Parse(Console.ReadLine());

            int i = 0;

            while (n!=0)
            {
                int aux = n % 10;
                i = i + 1;

                if (i == k)
                {
                    Console.Write("A k-a cifra este {0} ", aux);
                    n = 0;
                }
                n = n / 10;
            }
        }

            //P4

            /// <summary>
            /// Detreminati daca un an y este an bisect.
            /// </summary>

            private static void P4()
        {
            Console.Write("anul = ");
            int y = int.Parse(Console.ReadLine());

            if ((y % 4 == 0) && (y % 100 != 0)) 
                Console.WriteLine("{0} este an bisect", y);
            else
                Console.WriteLine("{0} nu este an bisect", y);
        }

        //P3

        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare
        /// </summary>

        private static void P3()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine("{0} se divide cu {1} ,", n, k);
            else
                Console.WriteLine("{0} nu se divide cu {1} ,", n, k);
        }



        //P2


        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.
        /// </summary>
        private static void P2()
        {
            float a, b, c, dt;
            double x1, x2;
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0) Console.WriteLine("Ec. nedeterminat.");
                    else Console.WriteLine("Ec. imposibila");
                else
                {
                    x1 = -c / b;
                    Console.WriteLine("Ec. de gr. 1 cu x1 = {0}", x1);
                }
            else
            {
                dt = b * b - 4 * a * c;
                if (dt < 0)
                    Console.WriteLine("Ec. are solutii complxe");
                else
                {
                    if (dt == 0)
                    {
                        x1 = x2 = -b / (2 * a);
                        Console.WriteLine("x1 = x2 = {0}", x1);
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                        x2 = (-b - Math.Sqrt(dt)) / (2 * a);
                        Console.WriteLine("Solutiile sunt x1 = {0}, x2 = {1}", x1, x2);
                    }
                }
            }
        }





        //P1


        /// <summary>
        /// 1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        /// </summary>
        private static void P1()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            double x = -(a / b);

            Console.WriteLine("Solutia = {0}", x);
        }
    }
}

