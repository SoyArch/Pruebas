using System;
using System.Collections;

namespace Pruebas
{
    class RecorridoArray
    {
        public static void Inicio()
        {

            // En una prueba nos pidieron hacer un recorrido de un array sin utlizar un ciclo for. Voy a testear mi respuesta.

            int opcion = 0;

            Console.WriteLine("Ingrese una opcion del menu.");
            Console.WriteLine("1) Recorrido de array con ciclo for");
            Console.WriteLine("2) Recorrido de array con ciclo while + if");

            opcion = int.Parse(Console.ReadLine());

            ArrayList arrayl = new ArrayList();

            for (int a = 0; a < 10; a++)
            {
                arrayl.Add(a);

            }


            switch (opcion)
            {
                case 1:

                    // Recorrido de array con for

                    for (int i = 0; i < arrayl.Count; i++)
                    {
                        Console.WriteLine("Numero: {0}", arrayl[i]);
                    }

                    break;

                case 2:

                    // Recorrido de array con while

                    int fin = 0;
                    int j = 0;

                    while (fin == 0)
                    {

                        j = j + 1;

                        if (j == arrayl.Count)
                        {
                            fin = 1;
                        }
                        else
                        {

                            Console.WriteLine("Numero: {0}", arrayl[j]);
                        }

                    }
                    break;

            }

            Console.WriteLine("Ingrese cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
