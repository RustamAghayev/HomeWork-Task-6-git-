namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Task 1
            //    Console.WriteLine("Masivin daxilindeki elementler ile muqayise C:");
            //l1:
            //    int c;
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("eded duzgun daxil edilmeyib");
            //        goto l1;
            //    }
            //l2:
            //    Console.WriteLine("Masivin Uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //    int[] a = new int[n];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.WriteLine($"[{i + 1}]");
            //        if (!int.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded Daxil Edilmeyib");
            //            goto l3;
            //        }
            //    }
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (Math.Abs(a[i]) < c)
            //        {
            //            Console.WriteLine($"{c} > {a[i]}");
            //        }
            //        else if (a[i] == c)
            //        {
            //            Console.WriteLine($"{c} = {a[i]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{c}<{a[i]}");
            //        }
            //    }
            /*
             1.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerini cap etmek
             (c deyisheninin qiymeti istifadeciden
             */
            #endregion
            #region Task 2
            //    Console.WriteLine("Masivin daxilindeki elementler ile muqayise C:");
            //l1:
            //    int c;
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("eded duzgun daxil edilmeyib");
            //        goto l1;
            //    }
            //l2:
            //    Console.WriteLine("Masivin Uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //    int[] a = new int[n];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.WriteLine($"[{i + 1}]");
            //        if (!int.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded Daxil Edilmeyib");
            //            goto l3;
            //        }
            //    }
            //    int sum = 0;
            //    int count = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (Math.Abs(a[i]) < c)
            //        {
            //            sum += a[i];
            //            count++;
            //        }

            //    }

            //    int num = sum / count;
            //    Console.WriteLine($"{num}");
            //}
            /*
             2.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerinin ededi ortasini tapmaq
             */
            #endregion
            #region Task 3
            //    string strC, strN, strA;
            //    int c, n;
            //    double geometricMean;
            //    int product = 1;
            //    int count = 0;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strA = Console.ReadLine();
            //        if (!int.TryParse(strA, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
            //    }
            //    //================================
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (Math.Abs(a[i]) > c)
            //        {
            //            product *= a[i];
            //            count++;
            //        }
            //    }
            //    geometricMean = Math.Pow(product, (1.0 / count));
            //    Console.WriteLine($"Hendesi ortasi: {geometricMean}");

            //    Console.ReadKey();


            /*
             3.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerinin hendesi ortasini tapmaq
             */
            #endregion
            #region Task 4
            //    string strC, strN, strA;
            //    int c, n;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strA = Console.ReadLine();
            //        if (!int.TryParse(strA, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
            //    }    
            //    if (a[n-1] > c)
            //    {
            //        Array.Sort(a);
            //        Array.Reverse(a);
            //    }

            //    Console.WriteLine($"Massivde mutleq deyeri {c}-den boyuk olan elementlerdir");
            //    foreach (int i in a)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    Console.ReadKey();
            /*
             4.  a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen elementlerini coxdan aza dogru siralamaq
             */
            #endregion
            #region Task 5
            //    string strC, strN, strA;
            //    int c, n;
            //L1:
            //    Console.Write("C deyerini daxil edin: ");
            //    strC = Console.ReadLine();
            //    if (!int.TryParse(strC, out c))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("Massivin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L2;
            //    }
            //    int[] a = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l3:
            //        Console.Write("a[" + (i + 1) + "] deyerini daxil edin: ");
            //        strA = Console.ReadLine();
            //        if (!int.TryParse(strA, out a[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l3;
            //        }
            //    }
            //    if (a[n - 1] > c)
            //    {
            //        Array.Sort(a);
            //        Array.Reverse(a);
            //    }

            //    Console.WriteLine($"Massivde icindeki maximum element {c}");
            //    Console.WriteLine(a[0]);
            //    Console.ReadKey();

            /*
             5.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementler icinden maximum elementi tapmaq
             */
            #endregion
            #region Task 6
            //    string strN1, strN2, strX, strY;
            //    int n1, n2;
            //L1:
            //    Console.Write("X(n) massivin uzunluğunu daxil edin: ");
            //    strN1 = Console.ReadLine();
            //    if (!int.TryParse(strN1, out n1))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //    int[] x = new int[n1];

            //    for (int i = 0; i < n1; i++)
            //    {
            //    l2:
            //        Console.Write("X[" + (i + 1) + "] deyerini daxil edin: ");
            //        strX = Console.ReadLine();
            //        if (!int.TryParse(strX, out x[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l2;
            //        }
            //    }
            //L3:
            //    Console.Write("Y(n) massivin uzunluğunu daxil edin: ");
            //    strN2 = Console.ReadLine();
            //    if (!int.TryParse(strN2, out n2))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L3;
            //    }
            //    int[] y = new int[n2];

            //    for (int j = 0; j < n2; j++)
            //    {
            //    l4:
            //        Console.Write("Y[" + (j + 1) + "] deyerini daxil edin: ");
            //        strY = Console.ReadLine();
            //        if (!int.TryParse(strY, out y[j]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l4;
            //        }
            //    }
            //    Console.Write("Netice: ");
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //      for (int j = 0; j < y.Length; j++)
            //        {
            //            if (x[i] == Math.Pow(y[j], 2))
            //            {
            //                Console.Write($"{x[i]} ");
            //            }
            //        }
            //    }

            //    Console.ReadKey();
            /*
             6.  X(n) ve Y(n) deye 2 massiv verilmishdir/Ele x[i] elementi tapmaq lazimdir
             ki x[i] = y[i] ^ 2 (eyni indexdeki x elementi hemin indexdeki y elementin kvadratina beraber olsun)
             */
            #endregion
            #region Task 7
            //    string strN1, strX;
            //    int a;
            //L1:
            //    Console.Write("X(n) massivin uzunluğunu daxil edin: ");
            //    strN1 = Console.ReadLine();
            //    if (!int.TryParse(strN1, out a))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto L1;
            //    }
            //    int[] x = new int[a];

            //    for (int i = 0; i < a; i++)
            //    {
            //    l2:
            //        Console.Write("X[" + (i + 1) + "] deyerini daxil edin: ");
            //        strX = Console.ReadLine();
            //        if (!int.TryParse(strX, out x[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l2;
            //        }
            //    }
            //    Array.Sort(x);


            //    double numAverage;
            //    double geometricMean;
            //    double product = x[0] * x[x.Length - 1];

            //    geometricMean = Math.Pow(product, 1.0 / 2);

            //    double One = x[0];
            //    double Two = x[x.Length-1];
            //    numAverage = (double)(One + Two) / 2.0;
            //    Console.WriteLine($"Ededi ortasi: {numAverage}");

            //    Console.WriteLine($"Hendesi ortasi: {geometricMean}");
            /*
             7.  a massivinin (a[0],a[1] .... a[n]) en kicik ve en boyuk elementlerinin hendesi ve ededi ortasini tapmali
             */
            #endregion
            #region Task 8
            //string strX, strY;
            //int product;

            //int[] x = new int[14];

            //for (int i = 0; i < 14; i++)
            //{
            //l1:
            //    Console.Write("X[" + (i + 1) + "] deyerini daxil edin: ");
            //    strX = Console.ReadLine();
            //    if (!int.TryParse(strX, out x[i]))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //}

            //int[] y = new int[14];

            //for (int i = 0; i < 14; i++)
            //{
            //l2:
            //    Console.Write("Y[" + (i + 1) + "] deyerini daxil edin: ");
            //    strY = Console.ReadLine();
            //    if (!int.TryParse(strY, out y[i]))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l2;
            //    }
            //}
            //int[] result = new int[14];
            //Console.WriteLine(" ");
            //Console.Write("Yeni massivin elementleri: ");
            //for (int i = 0; i < 14; i++)
            //{
            //    product = x[i] * y[i];
            //    if (product > 0)
            //    {
            //        result[i] = product;
            //    }
            //    Console.Write(result[i] + " ");
            //}

            /*
               8.  Heriri 14 elementli 2 massivin uygun elementlerini bir birine vurub?
               alinan musbet hasillerden  yeni massiv duzeltmeli
             */
            #endregion
            #region Task 9
            //string strX;

            //int[] x = new int[25];

            //for (int i = 0; i < 25; i++)
            //{
            //l1:
            //    Console.Write("X[" + (i + 1) + "] deyerini daxil edin: ");
            //    strX = Console.ReadLine();
            //    if (!int.TryParse(strX, out x[i]))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //}

            //int[] result1 = new int[8];
            //Console.WriteLine("Yeni 1-ci masivin elementleri(kvadrati artirilanlar): ");
            //for (int i = 0; i < 8; i++)
            //{
            //    result1[i] = (int)Math.Pow(x[i], 2);
            //}
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] result2 = new int[17];

            //Console.WriteLine("Yeni 2-ci masivin elementleri(4e bolunenler): ");
            //for (int i = 8; i < 25; i++)
            //{
            //    result2[i-8] = x[i] / 4;
            //}
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            /*
             9.  25 elementli massivin ilk 8 elementini kvadrata yukseltmeli,qalanini ise 4-e bolub,yeni iki massiv duzeltmeli
             */
            #endregion
            #region Task 10
            //    string strN, strX;
            //    int n;
            //    int maxNegative = 0;

            //l1:
            //    Console.Write("X(n) massivinin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //    int[] x = new int[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //    l2:
            //        Console.Write("x[" + (i + 1) + "] deyerini daxil edin: ");
            //        strX = Console.ReadLine();
            //        if (!int.TryParse(strX, out x[i]))
            //        {
            //            Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //            goto l2;
            //        }
            //    }

            //    Array.Sort(x);

            //    int result = x[0];
            //    Console.WriteLine(result);
            /*
             10. X(n) massivinden ancaq menfi elementlerin maximum elementi tapin
             */
            #endregion
            #region Task 11
            //    string strN, strX;
            //    int n;
            //    int maxNegative = 0;

            //l1:
            //    Console.Write("X(n) massivinin uzunluğunu daxil edin: ");
            //    strN = Console.ReadLine();
            //    if (!int.TryParse(strN, out n))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //    int[] x = new int[n];

            //    Random random = new Random();

            //    for (int i = 0; i < n; i++)
            //    {
            //        x[i] = random.Next(101);
            //    }
            //    Array.Sort(x);
            //    Array.Reverse(x);
            //    Console.WriteLine("X(n) massivinin ededleri azalma sirasina gore: ");
            //    foreach (var item in x)
            //    {
            //        Console.WriteLine(item);
            //    }
            /*
             11. X(n) massivinin elementlerini random olaraq 0-100 arasi ededlerle doldurub,sonra ise azalma sirasina gore duzmeli
             */
            #endregion
            #region Task 12
            //string strX;

            //int[] x = new int[20];

            //for (int i = 0; i < 20; i++)
            //{
            //l1:
            //    Console.Write("X[" + (i + 1) + "] deyerini daxil edin: ");
            //    strX = Console.ReadLine();
            //    if (!int.TryParse(strX, out x[i]))
            //    {
            //        Console.WriteLine("Eded duzgun daxil edilmeyib.");
            //        goto l1;
            //    }
            //}
            //int sum = 0;
            //int count1 = 0;
            //int count2 = 0;
            //long product = 1;
            //double numAverage;
            //double geometricMean;

            //for (int i = 0; i < 10; i++)
            //{
            //    sum += x[i];
            //    count1++;
            //}
            //numAverage = sum / count1;
            //Console.WriteLine($"Ilk yarisinin elementlerinin ededi ortasi: {numAverage}");

            //for (int i = 10; i < 20; i++)
            //{
            //    product *= x[i];
            //    count2++;
            //}
            //geometricMean = Math.Pow(product, 1.0 / count2);
            //Console.WriteLine($"Hendesi ortasi: {geometricMean}");
            /*
             12. X(20) massivinin ilk yarisinin ededi ortasini ikinci yarisinin hendesi ortasini tapmaq
             */
            #endregion
        }
    }

}
