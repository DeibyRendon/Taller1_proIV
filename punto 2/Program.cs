int opcion;
int tabla1;
int tabla2;
int tabla3;
int valor_oculto1;
int valor_oculto2;
int valor_oculto3;
int valor_adivinar1 = 0;
int valor_adivinar2 = 0;
int valor_adivinar3 = 0;
int respuesta1;
int respuesta2;
int respuesta3;
int intentos1 = 3;

Random random = new Random();
do
{

    Console.WriteLine("Aprende y juega con las Tablas de Multiplicar");
    Console.WriteLine("1. Ingresar tabla");
    Console.WriteLine("2. Salir");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingresa un número aleatorio: ");
            tabla1 = Convert.ToInt32(Console.ReadLine());

            valor_oculto1 = random.Next(1, 11);

            Console.WriteLine("Tabla de multiplicar del " + tabla1);


            for (int i = 1; i <= 10; i++)
            {
                if (i == valor_oculto1)
                {
                    
                    Console.WriteLine(tabla1 + " x " + i + " = ?");
                    valor_adivinar1 = tabla1 * i;
                }
                else
                {
                    Console.WriteLine(tabla1 + " x " + i + " = " + tabla1 * i);
                }
            }
            while (intentos1 > 0)
            {
                Console.Write("Puedes adivinar el valor que falta en la tabla de multiplicar ");
                respuesta1 = Convert.ToInt32(Console.ReadLine());

                if ( respuesta1 == valor_adivinar1 )
                {
                    Console.WriteLine("¡Correcto! Has adivinado el valor.");
                    break;
                }
                else
                {
                    Console.WriteLine("estas seguro? prueba de nuevo!!");
                    intentos1--;
                    Console.WriteLine("te quedan: " + intentos1 + "Intentos");
                }
            }

            Console.WriteLine($"Tablas siguiente: ");

            valor_oculto2 = random.Next(0, 10);

            for (int j = 1; j <= 1; j++)
            {
                tabla2 = tabla1 + j;
                Console.WriteLine("Tabla de multiplicar del " + tabla2);
                for (int i = 1; i <= 10; i++)
                {
                    if (i == valor_oculto2)
                    {
                        Console.WriteLine(tabla2 + " x " + i + " = ?");
                        valor_adivinar2 = tabla2 * i;
                    }
                    else
                    {
                        Console.WriteLine(tabla2 + " x " + i + " = " + tabla2 * i);
                    }
                }
            }
            while (intentos1 > 0)
            {
                Console.Write("Puedes adivinar el valor que falta en la tabla de multiplicar ");
                respuesta2 = Convert.ToInt32(Console.ReadLine());

                if ( respuesta2 == valor_adivinar2 )
                {
                    Console.WriteLine("¡Correcto! Has adivinado el valor.");
                    break;
                }
                else
                {
                    Console.WriteLine("estas seguro? prueba de nuevo!!");
                    intentos1--;
                    Console.WriteLine("te quedan: " + intentos1 + "Intentos");
                }
            }

            Console.WriteLine($"Tablas siguiente: ");

            valor_oculto3 = random.Next(1, 11);

            for (int k = 2; k <= 2; k++)
            {
                tabla3 = tabla1 + k;
                Console.WriteLine("Tabla de multiplicar del " + tabla3);
                for (int i = 1; i <= 10; i++)
                {
                    if (i == valor_oculto3)
                    {
                        Console.WriteLine(tabla3 + " x " + i + " = ?");
                        valor_adivinar3 = tabla3 * i;
                    }
                    else
                    {
                        Console.WriteLine(tabla3 + " x " + i + " = " + tabla3 * i);
                    }
                }
            }
            while (intentos1 > 0)
            {
                Console.Write("Puedes adivinar el valor que falta en la tabla de multiplicar ");
                respuesta3 = Convert.ToInt32(Console.ReadLine());

                if ( respuesta3 == valor_adivinar3 )
                {
                    Console.WriteLine("¡Correcto! Has adivinado el valor.");
                    break;
                }
                else
                {
                    Console.WriteLine("estas seguro? prueba de nuevo!!");
                    intentos1--;
                    Console.WriteLine("te quedan: " + intentos1 + "Intentos");
                }
            }
            break;
        case 2:
            Console.WriteLine("ha salido del juega con las Tablas de Multiplicar");
            break;
        default:
            Console.WriteLine("Opción no válida, seleccione una opcion de 1 a 2");
            break;
    }
} while (opcion != 2);