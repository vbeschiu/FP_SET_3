using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Data;

namespace SET_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Meniu();
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            P9();
            //P10();
        }
        private static void Meniu()
        {
            int p = -1;
            do
            {
                Console.WriteLine("Alegeti o problema introducad numarul corespunzator din lista de mai jos:");
                Console.WriteLine();
                Console.WriteLine("0. IESIRE");
                Console.WriteLine("1. ");
                Console.WriteLine("2. ");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("6. ");
                Console.WriteLine("7. ");
                Console.WriteLine("8. ");
                Console.WriteLine("9. ");
                Console.WriteLine("10.");
                Console.WriteLine("11.");
                Console.WriteLine("12. ");
                Console.WriteLine("13. ");
                Console.WriteLine("14. ");
                Console.WriteLine("15. ");
                Console.WriteLine("16. ");
                Console.WriteLine("17. ");
                Console.WriteLine("18. ");
                Console.WriteLine("19. ");
                Console.WriteLine("20. ");
                Console.WriteLine("21. ");
                Console.WriteLine("22. ");
                Console.WriteLine("23. ");
                Console.WriteLine("24. ");
                Console.WriteLine("25. ");
                Console.WriteLine("26. ");
                Console.WriteLine("27. ");
                Console.WriteLine("28. ");
                Console.WriteLine("29. ");
                Console.WriteLine("30. ");
                Console.WriteLine("31. ");
                string m = "Apasati Enter pentu a merge la meniu.";
                try
                {
                    Console.WriteLine();
                    p = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                { }

                if (p == 0)
                    break;
                else
                {
                    if (p >= 0 && p <= 17)
                    {
                        switch (p)
                        {
                            case 1: Console.Clear(); P1(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 2: Console.Clear(); P2(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 3: Console.Clear(); P3(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 4: Console.Clear(); P4(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 5: Console.Clear(); P5(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 6: Console.Clear(); P6(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 7: Console.Clear(); P7(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 8: Console.Clear(); P8(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 9: Console.Clear(); P9(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 10: Console.Clear(); P10(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 11: Console.Clear(); P11(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 12: Console.Clear(); P12(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 13: Console.Clear(); P13(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 14: Console.Clear(); P14(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 15: Console.Clear(); P15(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 16: Console.Clear(); P16(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 17: Console.Clear(); P17(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 18: Console.Clear(); P18(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 19: Console.Clear(); P19(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 20: Console.Clear(); P20(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 21: Console.Clear(); P21(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 22: Console.Clear(); P22(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 23: Console.Clear(); P23(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 24: Console.Clear(); P24(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 25: Console.Clear(); P25(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 26: Console.Clear(); P26(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 27: Console.Clear(); P27(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 28: Console.Clear(); P28(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 29: Console.Clear(); P29(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 30: Console.Clear(); P30(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                                //case 31: Console.Clear(); P31(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;

                        }

                    }
                }
            } while (p >= 0 && p <= 31);
        }
        /// <summary>
        /// Citeste numarul si elementele vectorului 
        /// </summary>
        private static int[] ReadArray(int[] v, int n)
        {
            Console.WriteLine($"Introduceti cele {n} elemente ale vectorului separate de un spatiu..");
            char[] sep = new char[] { ' ', ',', '/', ';', ':' };
            string[] s = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(s[i]);
            return v;
        }
        /// <summary>
        /// Afiseaza in consola elemntele vectorului
        /// </summary>
        private static void WriteArray(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }
        /// <summary>
        /// Iverseaza elementele unui vector
        /// </summary>
        /// <returns>Returneaza alt vector cu elementele inversate fata de cel initial</returns>
        private static int[] InvertArray(int[] v, int n)
        {
            int[] x = new int[n];
            int c = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                x[c] = v[i];
                c++;
            }
            return x;
        }
        /// <summary>
        /// Roteste vectorul v de lungime n cu k pozitii spre stanga
        /// </summary>
        /// <returns>Vectorul rotit spre stanga cu k pozitii</returns>
        private static int[] RotArray(int[] v, int n, int k)
        {
            int[] x = new int[n];
            int c = 0;
            for (int i = k; i < n; i++)
            {
                x[c] = v[i];
                c++;
            }
            for (int i = 0; i < k; i++)
            {
                x[c] = v[i];
                c++;
            }
            return x;
        }

        /// <summary>
        /// Calculeaza suma elementelor unui vector
        /// </summary>
        private static void P1()
        {
            Console.WriteLine("1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] v = new int[n];
            ReadArray(v, n);
            for (int i = 0; i < n; i++)
                sum += v[i];
            Console.WriteLine($"Suma elementelor vectorului este: {sum}");
            Console.WriteLine();
        }
        /// <summary>
        /// Afiseaza pozitia pe care se gaseste elementul k
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. " +
                              "Daca k nu apare in vector rezultatul va fi -1."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int pozi = -1;
            int[] v = new int[n];
            ReadArray(v, n);
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                if (v[i] == k)
                {
                    pozi = i;
                    break;
                }
            if (pozi == -1)
                Console.WriteLine(pozi);
            else
                Console.WriteLine($"Prima pozitie a lui {k} in vector este: {pozi}");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina pozitiile celui mai mic si al celui mai mare element
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. " +
                              "Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz)."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            ReadArray(v, n);
            int min = v[0];
            int pmin = 0;
            int max = v[0];
            int pmax = 0;
            for (int i = 1; i < n; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    pmin = i;
                }
                if (v[i] > max)
                {
                    max = v[i];
                    pmax = i;
                }
            }
            Console.WriteLine($"Pozitia celui mai mic element este: {pmin}");
            Console.WriteLine($"Pozitia celui mai mare elemnt este: {pmax}");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina si numara printr-o singura parcurgere elementele min si max
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            ReadArray(v, n);
            int min = v[0];
            int cmin = 0;
            int max = v[0];
            int cmax = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] < min || v[i] == min)
                {
                    min = v[i];
                    cmin++;
                }
                if (v[i] > max || v[i] == max)
                {
                    max = v[i];
                    cmax++;
                }
            }
            Console.WriteLine($"Cel mai mic element este: {min} si apare de {cmin} ori.");
            Console.WriteLine($"Cel mai mare element este: {max} si apare de {cmax} ori.");
            Console.WriteLine();
        }
        /// <summary>
        /// Insereaza un element e pe pozitia k in vector
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k. " +
                              "Se cere sa se insereze valoarea e in vector pe pozitia k. " +
                              "Primul element al vectorului se considera pe pozitia zero."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            ReadArray(v, n);
            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int[] x = new int[n + 1];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == k)
                {
                    x[c] = e;
                    c++;
                }
                x[c] = v[i];
                c++;
            }
            WriteArray(x, c);
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// Sterge din vector elementul de pe pozitia k
        /// </summary>
        private static void P6()
        {
            Console.WriteLine("6. Se da un vector cu n elemente si o pozitie din vector k. " +
                              "Se cere sa se stearga din vector elementul de pe pozitia k. " +
                              "Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. "); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            ReadArray(v, n);
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int[] x = new int[n - 1];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (i != k)
                {
                    x[c] = v[i];
                    c++;
                }
            }
            WriteArray(x, c);
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// Inverseaza ordinea elemntelor unui vector
        /// </summary>
        private static void P7()
        {
            Console.WriteLine("7. "); Console.WriteLine();
            Console.WriteLine("7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. " +
                              "Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            ReadArray(v, n);
            WriteArray(InvertArray(v, n), n);
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Roteste vectorul cu o pozitie spre stanga
        /// </summary>
        private static void P8()
        {
            Console.WriteLine("8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga." +
                              "Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            ReadArray(v, n);
            int k = 1;
            WriteArray(RotArray(v, n, k), n);
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// Roteste vectorul cu k pozitii spre stanga
        /// </summary>
        private static void P9()
        {
            Console.WriteLine("9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            ReadArray(v, n);
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            WriteArray(RotArray(v, n, k), n);
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void P10()
        {
            Console.WriteLine("10. "); Console.WriteLine();

            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void P11()
        {
            Console.WriteLine("11. "); Console.WriteLine();

            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void P12()
        {
            Console.WriteLine("12. "); Console.WriteLine();

            Console.WriteLine();
        }
        /// <summary>
        ///  
        /// </summary>
        private static void P13()
        {
            Console.WriteLine("13. "); Console.WriteLine();

            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void P14()
        {
            Console.WriteLine("14. "); Console.WriteLine();

            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void P15()
        {
            Console.WriteLine("15. "); Console.WriteLine();

            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("16. ");

            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void P17()
        {
            Console.WriteLine("17. "); Console.WriteLine();

            Console.WriteLine();
        }
    }
}
