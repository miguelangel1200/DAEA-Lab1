using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Los 10 Números Primos");
                Console.WriteLine("[7] Conversión a Celsios");
                Console.WriteLine("[8] Conversión a Farenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a1, b1, Resta(a1, b1));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", a2, b2, Multiplicacion(a2, b2));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", a3, b3, Division(a3, b3));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese Farenheit para convertir a celsios");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversión a Celsios es {0}", Celsios(c));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese Celsios para convertir a Farenheit");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversión a Farenheit es {0}", Fare(f));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }

        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        static int Division(int a, int b)
        {
            return a / b;
        }

        static float Celsios(float f)
        {
            return (5 * (f - 32)) / 9;
        }

        static float Fare(float c)
        {
            return (9 * c / 5) + 32;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }

        }


        static void Primos()
        {

            List<int> list = new List<int>()
            {
                2,
                3,
                5,
                7,
                11,
                13,
                17,
                19,
                23,
                29
            };

            //for (int x = 1; x <= 10; x++)
            //{
            //    if (x / x == 1 && x / 1 == x)
            //    {
            //        list.Add(x);
            //    }

            //}

            Console.WriteLine("Los 10 primeros números primos son: ");

            for (int i = 0; i <= list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            
        }

    }
}
