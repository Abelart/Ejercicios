using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class EjerciciosExamen
    {
        //Hacer una función que reciba dos enteros y devuelva la suma de esos dos enteros

        public static int Suma(int a, int b)
        {
            return a + b;
        }

        //Hacer una función que reciba dos reales y devuelva la resta de esos dos reales

        public static double Resta(double a, double b)
        {
            return a - b;
        }

        //Hacer una función que reciba dos enteros y devuelva el menor de los dos

        public static int MinNumber(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        //Hacer una función que reciba dos enteros y devuelva si el primero es menor que el segundo

        public static bool EsMenor(int a, int b)
        {
            return a < b;
        }

        //Hacer una función que reciba tres string y devuelva la concatenacion de esos tres string

        public static string Cat(string s1, string s2, string s3)
        {
            return s1 + s2 + s3;
        }

        //Hacer una función que reciba dos enteros y devuelva -1 si el primero es menor que el segundo, 
        //+1 si el segundo es menor que el primero, 0 en cualquier otro caso 

        public static int Compare(int a, int b)
        {
            if (a < b)
                return -1;
            if (a > b)
                return 1;
            return 0;
        }

        //Hacer una función que reciba un código de error e imprima por pantalla lo siguiente: 
        //Error crítico en caso de que el código sea 0
        //Error leve en caso de que el código sea 1
        //Error moderado en caso de que el código sea 2
        //Error desconocido en cualquier otro caso

        public static void PrintError(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error crítico");
                    break;
                case 1:
                    System.Console.WriteLine("Error leve");
                    break;
                case 2:
                    System.Console.WriteLine("Error moderado");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;
            }
        }

        //Hacer una función que reciba por párametro un número y escriba lo siguiente:
        //0, 3, 6, 9, 12, ... hasta llegar a ese número
        //Por ejemplo: función(10) imprimiría 0,3,6,9

        public static void SerieNumeros(int a)
        {
            int result = 0;
            while (a > result)
            {
                System.Console.Write(result + ",");

                result = result + 3;
            }
        }

        //Hacer una función que se le pasen 3 enteros y devuelva el menor de los 3

        public static int MinOf3(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b < c)
                    return b;
                else
                    return c;
            }
        }

        //Hacer una función que se le pasen 4 enteros y devuelva el menor de los 4

        public static int MinOf4(int a, int b, int c, int d)
        {
            if (a < b)
            {
                if (a < c)
                {
                    if (a < d)
                        return a;
                    else
                        return d;
                }
                else
                {
                    if (c < d)
                        return c;
                    return d;
                }
            }
            else
            {
                if (b < c)
                {
                    if (b < d)
                        return b;
                    else
                        return d;
                }
                else
                {
                    if (c < d)
                        return c;
                    else
                        return d;
                }
            }
        }

        //Hacer una función que se le pase un entero e imprima por pantalla la siguiente serie
        //de ejemplo: serie(10) = 0,1,2,3,4,5,6,7,8,9,

        public static void SerieDeNumeros(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write(i + ",");
        }

        //Hacer una función que se le pase un entero e imprima por pantalla la siguiente serie
        //de ejemplo: serie(10) = 0,1,2,3,4,5,6,7,8,9

        public static void SerieDeNumeros2(int n)
        {
            if (n > 0)
            System.Console.Write(0);
            for (int i = 0; i < n; i++)
                System.Console.Write("," + i);
        }

        //Hacer una función que se le pase un entero e imprima una línea de tantos arteriscos como 
        //el número introducido

        public static void Arteriscos(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");
        }

        //Hacer una función que se le pase un entero e imprima el siguiente patrón: (4) = *+*+

        public static void ArteriscosSumas(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }
        }

        //Hacer una función que se le pase un entero e imprima el siguiente patrón: (4) = *+-/

        public static void PatronVariado(int n)
        {
            for(int i=0; i<n;i++)
            {
                int resto = i % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }
            }

        }

        //Hacer una función que se le pase un entero e imprima un cuadrado de "*" del tamañado del entero
        

        public static void Cuadrados(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                    System.Console.Write("*");
                System.Console.WriteLine();
            }
        }

        //Hacer una función que devuelva el menor de 16 enteros en una sola línea

        public static int MinOf16(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10,
            int n11, int n12, int n13, int n14, int n15, int n16)
        {
            return MinOf4(MinOf4(n1, n2, n3, n4), MinOf4(n5, n6, n7, n8), MinOf4(n9, n10, n11, n12), MinOf4(n13, n14, n15, n16));           
        }

        //Hacer una función que se le pase un entero e imprima un cuadrado de "*" y "+" del tamaño del entero

        public static void Cuadrado2(int n)
        {
            for(int r = 0; r < n; r++)
            {
                for(int c = 0; c < n; c++)
                {
                    if ((r % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }

        //Hacer una función que se le pase un entero e imprima un cuadrado de "*" y "+" de forma salteada

        public static void Cuadrado3(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    int flag = r + c;
                    if ((flag % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }

        //Hacer una función que se le pase un entero e imprima una escalera de arteriscos

        public static void Escalera(int n)
        {
            for(int r = 1; r <= n; r++)
            {
                for(int c = 0; c < r; c++)
                {
                        System.Console.Write("*");                  
                }
                System.Console.WriteLine();
            }
        }

        //Hacer una función que se le pase un entero e imprima una escalera de arteriscos al revés

        public static void Escalera2(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int nespacios = n - r - 1;
                int narteriscos = r + 1;
                for (int c = 0; c < nespacios; c++)
                    System.Console.Write(" ");

                for (int c = 0; c < narteriscos; c++)
                    System.Console.Write("*");

                System.Console.WriteLine();
            }
        }

        //Hacer una función que imprima por pantalla todos los divisores desde 1 hasta el número que se le pase

        public static void SerieDivisores(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((n % i) == 0)
                    System.Console.Write(i + ",");
            }
        }

        public static void Escalera3(int n)
        {
            for(int r = 0; r < n; r++)
            {
                int nespacios = n - r -1;
                int nespacios2 = r * 2;
                for (int c = 0; c < nespacios; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                for (int c = 0; c < nespacios2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                System.Console.WriteLine("");
            }
        }

        public static void Escalera4(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int nespacios =r;
                int nespacios2 = (n - r - 1) * 2;
                for (int c = 0; c < nespacios; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                for (int c = 0; c < nespacios2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                System.Console.WriteLine("");
            }
        }

        public static void Rombo(int n)
        {
            Escalera3(n);
            Escalera4(n);
        }

        //Hacer una función que devuelva 2 elevado a un número entero

        public static int DosElevado(int n)
        {
            int result = 1;
            for (int i = 0; i <= n; i++)
                result = 2 * 2;
                return result;           
        }

        //Hacer una función que imprima la bandera de USA

        public static void BanderaUSA()
        {
            for (int r = 0; r <= 9; r++)
            {
                for (int c = 0; c < 20; c++)
                {
                    if (c >= 0 && c <= 8 && r >= 0 && r <= 2)
                    {
                        int flag = r + c;
                        if ((flag % 2) == 0)
                            System.Console.Write("+");
                        else
                            System.Console.Write(" ");
                    }
                    else if (((r / 2) % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine("");
            }
            
        }

        //Hacer una función que devuelva el sumatorio de un número

        public static int Sumatorio(int n)
        {
            int result = 0;
            for(int i = 0; i <= n; i++)
            
                result += 1;

            
            return result;
        }

     
    }
}
