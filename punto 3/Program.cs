int opcion;
int numero;
int suma = 0;
int val_digito;



do
{

    Console.WriteLine("!!!verifica si tus numeros son especiales!!! las conediones son: \n\n 1. el numero ingresado es divisible entre 5 \n 2. El numero ingresado NO es divisible entre 2 ni 3. \n 3. La suma de sus dígitos es mayor a 10\n");

    Console.WriteLine("1. validar numeros ESPECIAL");
    Console.WriteLine("2. Salir");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingresar un numero para verificar si es ESPECIAL? ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 5 != 0)
            {
                Console.WriteLine("El " + numero + " no es divisible entre 5.");
                Console.WriteLine("Te invito a seguir buscando ese numero !!!ESPECIAL!!!");
            }
            else
            {
                Console.WriteLine("El " + numero + " es divisible entre 5.");
                if (numero % 2 == 0 || numero % 3 == 0)
                {
                    Console.WriteLine("El " + numero + " es divisible entre 2 o 3.");
                    Console.WriteLine("Te invito a seguir buscando ese numero !!!ESPECIAL!!!");
                }
                else
                {
                    Console.WriteLine("El " + numero + " No divisible entre 2 o 3");
                    while (numero > 0)
                    {
                        val_digito = numero % 10;
                        suma += val_digito;
                        numero /= 10;
                    }

                    if (suma <= 10)
                    {
                        Console.WriteLine("La suma de los dígitos es menor o igual a 10.\n");
                        Console.WriteLine("Te invito a seguir buscando ese numero !!!ESPECIAL!!!");
                    }
                    else
                        Console.WriteLine("El " + numero + " es !!!!! E S P C I A L !!!!!!!.\n\n");
                }
            }

            break;
        case 2:
            Console.WriteLine("ha salido del validador de numeros Especiales");
            break;
        default:
            Console.WriteLine("Opción no válida, seleccione una opcion de 1 a 2");
            break;
    }
} while (opcion != 2);