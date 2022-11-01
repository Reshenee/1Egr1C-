// Zadanie 1

  /*for (int i = 1; i < 31; i++)
    Console.WriteLine(i + " " + "Listopada");*/


// Zadanie 2

    // for(int i = 1;i < 10;i += 2)
    //   Console.WriteLine(i * i);

// Zadanie 3

    // for(int i = 1137;i < 10000;i += 379)
    //   Console.WriteLine(i);


// Zadanie 4

// Wersja 1

    // for(int i = 100;i < 1000;i++)
    // {
    //   if(i % 5==0 || i % 6==0 || i % 11==0)
    //     Console.Write(i);
    // }


// Wersja 2

//  for(int i = 100;i < 1000;i++)
//     {
//       if((i % 5==0) && (i % 6==0) || (i % 11==0))
//         Console.Write(i);
//     }


// Zadanie 5

// int n = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int suma = 0;
// for(int i = 0;i<n;i++)
//   suma += int.Parse(Console.ReadLine());
// Console.WriteLine(suma);


// Zadanie 6

// int k = int.Parse(Console.ReadLine());
// suma = 0;
// for(int i = 0;i < (k * 2);i += 2)
//   suma += i;
// Console.WriteLine(suma);


// Zadanie 7

// int m = int.Parse(Console.ReadLine());
// suma = 0;
// for(int i = 11;i < (m * 2) + 11;i += 2)
//   suma += i;
// Console.WriteLine(suma);

// Zadanie 8

// Console.WriteLine("Wprowadź kwotę")
// int W0 = int.Parse(Console.ReadLine());
// Console.WriteLine("Wprowadź czas")
// int L = float.Parse(Console.ReadLine());
// Console.WriteLine(L);
// double wartosc = W0;
// for(double i = 0;i<L;i+=0.5)
// {
//   for(int j = 0;j<6;j++)
//     wartosc+=wartosc*(0.06/12);
// }
// Console.WriteLine(wartosc);

// Zadanie 9

// n = int.Parse(Console.ReadLine());
// suma = 0;
// for(int i = 21;i <= (n - 1)*100 + 21;i += 100)
//   suma += i;
// Console.WriteLine(suma);

// Zadanie 10

// x = 0
// s = 32
// for(int i = x;i < s;i++)
//     {
//       int a = (i * i);
//       if(i < 10)
//         while(a >= 10)
//           a -= 10;
//       else
//         while(a >= 100)
//           a -= 100;
//       if(a == i)
//         Console.WriteLine(i * i);
