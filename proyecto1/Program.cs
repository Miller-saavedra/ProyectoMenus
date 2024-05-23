using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace proyecto1
{
    internal class Program
    {
        static int n;
        static int p;
        static Random r = new Random();
        static int[] vector1; //vector original
        static int[] vector2; //segundo vector en caso de suma
        static int[] vectorsuma; // resultado de la suma de vectores
        static int[,] matriz1; //matriz original
        static int[] sumamatriz; //vector donde se alojara la suma de las columnas de la matriz
        static List<int> lista1 = new List<int>(); //lista original
        static List<int> lista2 = new List<int>(); // otra lista para operar
        static List<int> listasuma = new List<int>(); // lista del resultado
        static Stack<int> pila1 = new Stack<int>();  // pila original
        static void Main(string[] args)
        {
            Menuprincipal();

            bool validar = true;

            //Llamado a las funciones principales
            do
            {
                int opcion = Leernumero();
                Console.WriteLine("\n");

                switch (opcion)
                {
                    case 1:
                        Menuvector();
                        break;
                    case 2:
                        Menumatriz();
                        break;
                    case 3:
                        Menulista();
                        break;
                    case 4:
                        Menupilas();
                        break;
                    case 5:
                        validar = false;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta. Por favor, elige una opción válida.\n");
                        Menuprincipal();
                        break;
                }

            } while (validar);
        }
        //-------------------------------------------------------- Menu principal --------------------------------------------------------------------------------
        static void Menuprincipal()
        {
            Console.WriteLine("\n************************************ PROYECTO MENU DE FUNCIONES ***************************************\nPor favor digita la opción que deseas conocer: \n1. Arreglos Unidimensionales \n2. Arreglos Bidimensionales \n3. Listas \n4. Pilas \n5. Cerrar programa\n");
        }
        // ------------------------------------------------------ Todas las funciones de los vectores ------------------------------------------------------------
        static void Menuvector()
        {
            Console.WriteLine("Por favor selecciona qué opción deseas explorar: \n1. Llenar vector con números aleatorios \n2. Mostrar ordenado de mayor a menor y mayor a menor\n3. Sumar vectores \n4. Volver al menú principal\n");
            int opcionmenu = Leernumero();

            switch (opcionmenu)
            {
                case 1:
                    Llenarvector();
                    break;
                case 2:
                    Mostrarvector();
                    break;
                case 3:
                    Sumarvector();
                    break;
                case 4:
                    Menuprincipal();
                    break;
                default:
                    Console.WriteLine("\nEsta opción no es válida.\n");
                    Menuvector();
                    break;
            }
        }

        static void Llenarvector()
        {
            Console.WriteLine("\nPor favor digite el tamaño del arreglo: \n");
            n = int.Parse(Console.ReadLine());
            vector1 = new int[n];
            vector2 = new int[n];
            vectorsuma = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector1[i] = r.Next(99);
            }
            Console.WriteLine("\nVector llenado \n");
            Menuvector();
        }

        static void Mostrarvector()
        {
            if (vector1 == null || vector1.Length == 0)
            {
                Console.WriteLine("\nLos vectores están vacíos.\n");
            }
            else if (vector1.Length > 0 && vectorsuma.Length > 0)
            {
                Console.WriteLine("\nVector original");
                foreach (int i in vector1)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\n Vector original ordenado de menor a mayor");
                Array.Sort(vector1);
                foreach (int i in vector1)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\nVector original ordenado de mayor a menor");
                Array.Reverse(vector1);
                foreach (int i in vector1)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\n");
                Console.WriteLine("\nVector sumado");
                foreach (int i in vectorsuma)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\nVector sumado ordenado de menor a mayor");
                Array.Sort(vectorsuma);
                foreach (int i in vectorsuma)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\nVector sumado ordenado de mayor a menor");
                Array.Reverse(vectorsuma);
                foreach (int i in vectorsuma)
                {
                    Console.Write(i + "\t");
                }
            }
            else
            {
                Console.WriteLine("\nVector original");
                foreach (int i in vector1)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\nVector original ordenado de menor a mayor");
                Array.Sort(vector1);
                foreach (int i in vector1)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\nVector original ordenado de mayor a menor");
                Array.Reverse(vector1);
                foreach (int i in vector1)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine("\n");
            Menuvector();
        }

        static void Sumarvector()
        {

            if (vector1 == null || vector1.Length == 0)
            {
                Console.WriteLine("\nNo se puede sumar porque el vector principal está vacío \n");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    vector2[i] = r.Next(99);
                }
                for (int i = 0; i < n; i++)
                {
                    vectorsuma[i] = vector1[i] + vector2[i];
                }
                Console.WriteLine("\nVector sumado correctamente\n");
            }
            Menuvector();
        }

        // ------------------------------------------------------------ Todas las funciones de las matricez --------------------------------------------------------
        static void Menumatriz()
        {
            Console.WriteLine("Por favor selecciona qué opción deseas explorar: \n1. Llenar matriz con números aleatorios \n2. Mostrar matriz original \n3. Mostrar diagonal principal \n4. Mostrar diagonal secundaria \n5. Mostrar Triangulo inferior principal \n6. Mostrar triangulo superior principal \n7. Mostrar triangular inferior secundaria \n8. Mostrar triangular superior secundaria\n9. Suma de columnas  \n10. Volver al menu principal \n");
            int opcionmenu = Leernumero();

            switch (opcionmenu)
            {
                case 1:
                    Llenarmatriz();
                    break;
                case 2:
                    Mostrarmatriz(matriz1);
                    break;
                case 3:
                    Diagonalprincipal(matriz1);
                    break;
                case 4:
                    Diagonalsecundaria(matriz1);
                    break;
                case 5:
                    Trianguloinferior(matriz1);
                    break;
                case 6:
                    Triangulosuperior(matriz1);
                    break;
                case 7:
                    Trianguloinferiorsecundario(matriz1);
                    break;
                case 8:
                    Triangulosuperiorsecundario(matriz1);
                    break;
                case 9:
                    Sumacolumnas(matriz1);
                    break;
                case 10:
                    Menuprincipal();
                    break;
                default:
                    Console.WriteLine("\nEsta opción no es válida.\n");
                    Menumatriz();
                    break;
            }
        }
        static void Llenarmatriz()
        {
            Console.WriteLine("\nPor favor ingrese el tamaño de la matriz \n");
            int n = int.Parse(Console.ReadLine());
            matriz1 = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz1[i, j] = r.Next(99);
                }
            }
            Console.WriteLine("\nmatriz llenada \n");
            Menumatriz();
        }

        static void Mostrarmatriz(int[,] matriz1)
        {
            if (matriz1 == null || matriz1.Length == 0)
            {
                Console.WriteLine("\nEl Arreglo bidimensional está vacío.");
            }
            else
            {
                Console.WriteLine("\nmatriz Llena: \n");

                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        Console.Write(matriz1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Menumatriz();
        }

        static void Diagonalprincipal(int[,] matriz1)
        {
            if (matriz1 == null || matriz1.GetLength(0) < 2 && matriz1.GetLength(1) < 2)
            {
                Console.WriteLine("\nEl Arreglo bidimensional está vacío o esta incompleto para sacar una diagonal minimo que sea 2x2.");
            }
            else
            {
                Console.WriteLine("\nDiagonal principal \n");
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    Console.WriteLine(matriz1[i, i] + "\t");
                }
            }
            Console.WriteLine("\n");
            Menumatriz();
        }

        static void Diagonalsecundaria(int[,] matriz1)
        {
            Console.WriteLine("\n");
            if (matriz1 == null || matriz1.GetLength(0) < 2)
            {
                Console.WriteLine("El Arreglo bidimensional está vacío o esta incompleto para sacar una diagonal se necesita minimo que sea de tamaño 2x2.");
            }
            else
            {
                Console.WriteLine("Diagonal secundaria");
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    Console.WriteLine(matriz1[i, matriz1.GetLength(1) - 1 - i]);
                }
            }
            Console.WriteLine("\n");
            Menumatriz();
        }

        static void Trianguloinferior(int[,] matriz1)
        {
            Console.WriteLine("\n");
            if (matriz1 == null || matriz1.GetLength(0) < 2)
            {
                Console.WriteLine("\nEl Arreglo bidimensional está vacío o esta incompleto para sacar un triangulo se necesita como minimo que sea  de tamaño 2x2.");
            }
            else
            {
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        if (i < j)
                        {
                            Console.Write(matriz1[i, j] + "\t");
                        }
                        else
                        {
                            Console.Write(" \t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
            Menumatriz();
        }

        static void Triangulosuperior(int[,] matriz1)
        {
            Console.WriteLine("\n");
            if (matriz1 == null || matriz1.GetLength(0) < 2)
            {
                Console.WriteLine("\nEl Arreglo bidimensional está vacío o esta incompleto para sacar un triangulo se necesita como minimo que sea  de tamaño 2x2.");
            }
            else
            {
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        if (i > j)
                        {
                            Console.Write(matriz1[i, j] + "\t");
                        }
                        else
                        {
                            Console.Write(" \t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
            Menumatriz();
        }

        static void Triangulosuperiorsecundario(int[,] matriz1)
        {
            Console.WriteLine("\n");
            if (matriz1 == null || matriz1.GetLength(0) < 2)
            {
                Console.WriteLine("\nEl Arreglo bidimensional está vacío o está incompleto para sacar un triángulo se necesita como mínimo que sea de tamaño 2x2.");
            }
            else
            {
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        if (j > matriz1.GetLength(1) - 1 - i)
                        {
                            Console.Write(matriz1[i, j] + "\t");
                        }
                        else
                        {
                            Console.Write(" \t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
            Menumatriz();
        }

        static void Trianguloinferiorsecundario(int[,] matriz1)
        {
            Console.WriteLine("\n");
            if (matriz1 == null || matriz1.GetLength(0) < 2)
            {
                Console.WriteLine("\nEl Arreglo bidimensional está vacío o está incompleto para sacar un triángulo se necesita como mínimo que sea de tamaño 2x2.");
            }
            else
            {
                for (int i = 0; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz1.GetLength(1); j++)
                    {
                        if (j < matriz1.GetLength(1) - 1 - i)
                        {
                            Console.Write(matriz1[i, j] + "\t");
                        }
                        else
                        {
                            Console.Write("\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
            Menumatriz();
        }

        static void Sumacolumnas(int[,] matriz1)
        {
            Console.WriteLine("\n");
            if (matriz1 == null || matriz1.GetLength(0) < 2)
            {
                Console.WriteLine("\nEl Arreglo bidimensional está vacío o está incompleto para realizar la suma de columnas.");
            }
            else
            {
                int[] sumaColumnas = new int[matriz1.GetLength(1)];

                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    for (int i = 0; i < matriz1.GetLength(0); i++)
                    {
                        sumaColumnas[j] += matriz1[i, j];
                    }
                }

                Console.WriteLine("Suma de columnas:");
                for (int j = 0; j < sumaColumnas.Length; j++)
                {
                    Console.Write(sumaColumnas[j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Menumatriz();
        }

        // ----------------------------------------------------------------- Todas las funciones de las listas ------------------------------------------------------------------
        static void Menulista()
        {
            Console.WriteLine("Por favor selecciona qué opción deseas explorar: \n1. Llenar lista con números aleatorios \n2. Agregar elementos a la lista \n3. Mostrar lista \n4. Sumar listas \n5. Ordenar listas de menor a mayor y mayor a menor \n6. Volver al menu principal \n");
            int opcionmenu = Leernumero();

            switch (opcionmenu)
            {
                case 1:
                    Llenarlista();
                    break;
                case 2:
                    Agregarelemento();
                    break;
                case 3:
                    Mostrarlista();
                    break;
                case 4:
                    Sumarlista();
                    break;
                case 5:
                    Ordenarlista();
                    break;
                case 6:
                    Menuprincipal();
                    break;
                default:
                    Console.WriteLine("\nEsta opción no es válida.\n");
                    Menulista();
                    break;
            }
        }
        //Llenar lista
        static void Llenarlista()
        {
            if (lista1 == null || lista1.Count == 0)
            {
                Console.WriteLine("\nIngrese el tamaño de la lista: \n");
                p = int.Parse(Console.ReadLine());
                for (int i = 0; i < p; i++)
                {
                    lista1.Add(r.Next(99));
                }
                Console.WriteLine("\nLista llena \n");
                Menulista();
            }
            else
            {
                Console.WriteLine("\nIngrese el nuevo tamaño de la lista: \n");
                int o = int.Parse(Console.ReadLine());
                p += o;
                for (int i = 0; i < o; i++)
                {
                    lista1.Add(r.Next(99));
                }
                Console.WriteLine("\nLista llena \n");
                Menulista();
            }
        }

        static void Agregarelemento()
        {
            Console.WriteLine("\n ingresa el numero de valores que vas a alojar: \n");
            int j = int.Parse(Console.ReadLine());
            p = p + j;
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine($"\n Ingresa el {i + 1} elemento que deseas agregar a la lista: \n");
                int q = int.Parse(Console.ReadLine());
                lista1.Add(q);
            }
            Console.WriteLine("\n Elementos agregados \n");
            Menulista();
        }

        static void Mostrarlista()
        {
            Console.WriteLine("\n");
            if (lista1 == null || lista1.Count == 0)
            {
                Console.WriteLine("La lista principal está vacía.");
            }
            else if (lista1.Count > 0 && listasuma.Count > 0)
            {
                Console.WriteLine("Lista original: ");
                foreach (int i in lista1)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine("\nLista Suma: ");
                foreach (int i in listasuma)
                {
                    Console.Write(i + ", ");
                }
            }
            else
            {
                Console.WriteLine("Lista original: ");
                foreach (int i in lista1)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine("\n");
            Menulista();
        }

        static void Sumarlista()
        {
            Console.WriteLine("\n");
            if (lista1 == null || lista1.Count == 0)
            {
                Console.WriteLine("La lista principal está vacía por eso no se puede operar.");
            }
            else
            {
                for (int i = 0; i < p; i++)
                {
                    lista2.Add(r.Next(99));
                }
                for (int i = 0; i < p; i++)
                {
                    listasuma.Add(lista1[i] + lista2[i]);
                }
                Console.WriteLine("Lista sumada correctamente");
                //foreach (int i in listasuma)
                //{
                //    Console.Write(i + ", ");
                //}
            }
            Console.WriteLine("\n");
            Menulista();
        }

        static void Ordenarlista()
        {
            Console.WriteLine("\n");
            if (lista1 == null || lista1.Count == 0)
            {
                Console.WriteLine("La lista principal está vacía por eso no se puede ordenar.");
            }
            else if (lista1.Count > 0 && lista2.Count > 0)
            {
                lista1.Sort();
                listasuma.Sort();
                Console.WriteLine("Lista original organizada de menor a mayor");
                foreach (int i in lista1)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine("\nLista organizada de mayor a menor");
                lista1.Reverse();
                foreach (int i in lista1)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine("\n");
                Console.WriteLine("\nLista suma organizada de menor a mayor");
                foreach (int i in listasuma)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine("\nLista suma organizada de mayor a menor");
                listasuma.Reverse();
                foreach (int i in listasuma)
                {
                    Console.Write(i + ", ");
                }
            }
            else
            {
                lista1.Sort();
                Console.WriteLine("Lista original organizada de menor a mayor");
                foreach (int i in lista1)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine("\nLista organizada de mayor a menor");
                lista1.Reverse();
                foreach (int i in lista1)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine("\n");
            Menulista();
        }
        // ------------------------------------------------------------------ Todas las funciones de pilas -----------------------------------------------------------------------------------------------
        static void Menupilas()
        {
            Console.WriteLine("\nPor favor selecciona qué opción deseas explorar: \n1. Llenar pila con números aleatorios \n2. Sacar primer elemento de la pila \n3. Mostrar primer elemento de la pila \n4. Mostrar toda la pila \n5. Limpiar la pila \n6. Mostrar cuantos elementos tiene la pila \n7. Volver al menu principal \n");
            int opcionmenu = Leernumero();

            switch (opcionmenu)
            {
                case 1:
                    Llenarpila();
                    break;
                case 2:
                    Sacarprimerelementopila();
                    break;
                case 3:
                    Mostrarprimerelementopíla();
                    break;
                case 4:
                    Mostrarpila();
                    break;
                case 5:
                    Limpiarpila();
                    break;
                case 6:
                    Numeroelementospila();
                    break;
                case 7:
                    Menuprincipal();
                    break;
                default:
                    Console.WriteLine("\nEsta opción no es válida.\n");
                    Menupilas();
                    break;
            }
        }

        static void Llenarpila()
        {
            Console.WriteLine("\nIngrese el numero de elementos que deseas alojar en la pila \n");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = 0; i < l; i++)
            {
                pila1.Push(r.Next(99));
            }
            Console.WriteLine("\nPila llena");
            Console.WriteLine("\n");
            Menupilas();
        }

        static void Sacarprimerelementopila()
        {
            if (pila1 == null || pila1.Count == 0)
            {
                Console.WriteLine("\nLa pila no contiene ningun elemento por lo tanto no se puede sacar nada.\n");
            }
            else
            {
                Console.WriteLine("\nEl primer elemento de la pila ha sido excluido correctamente: ");
                Console.WriteLine(pila1.Pop());
            }
            Menupilas();
        }

        static void Mostrarprimerelementopíla()
        {
            if (pila1 == null || pila1.Count == 0)
            {
                Console.WriteLine("\nLa pila no contiene ningun elemento por lo tanto no se puede mostrar nada.\n");
            }
            else
            {
                Console.WriteLine("\nEl primer elemento de la pila es: ");
                Console.WriteLine(pila1.Peek());
            }
            Menupilas();
        }

        static void Mostrarpila()
        {
            if (pila1 == null || pila1.Count == 0)
            {
                Console.WriteLine("\nLa pila no contiene ningun elemento por lo tanto no se puede mostrar nada.\n");
            }
            else
            {
                int h = 1;
                Console.WriteLine("\nLos elementos de la pila son: ");
                foreach (int i in pila1)
                {
                    Console.WriteLine($"{h} Elemento de la pila es: {i}");
                    h++;
                }
            }
            Menupilas();
        }

        static void Limpiarpila()
        {
            if (pila1 == null || pila1.Count == 0)
            {
                Console.WriteLine("\nLa pila no contiene ningun elemento, no se puede limpiar.\n");
            }
            else
            {
                pila1.Clear();
                Console.WriteLine("La pila se ha limpiado correctamente\n");
            }
            Menupilas();
        }

        static void Numeroelementospila()
        {
            if (pila1 == null || pila1.Count == 0)
            {
                Console.WriteLine("\nLa pila esta vacia.\n");
            }
            else
            {
                Console.WriteLine($"El numero de elementos que contiene la pila es: {pila1.Count}");
            }
            Menupilas();
        }
        // metodo para que el programa no se caiga en dado que se le meta una letra
        static int Leernumero()
        {
            int numero;
            bool conver;

            do
            {
                string e = Console.ReadLine();
                conver = int.TryParse(e, out numero);

                if (!conver)
                {
                    Console.WriteLine("\nEntrada no válida. Por favor, ingrese un número entero.\n");
                }

            } while (!conver);

            return numero;
        }

    }
}


