int numerador1, denominador1, numerador2, denominador2;
int opcion;
int resultado1 = 0;
int resultado2 = 0;
int resultado3 = 0;
int resultado4 = 0;
do
{

    Console.WriteLine("Seleccione una operación:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");
    Console.WriteLine("5. Salir");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {   
        case 1:
            Console.Write("Ingrese el numerador de la primera fracción: ");
            numerador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "\n");

            Console.Write("Ingrese el denominador de la primera fracción: ");
            denominador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + "\n");

            Console.Write("Ingrese el numerador de la segunda fracción: ");
            numerador2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + " + " + numerador2+ "\n");

            Console.Write("Ingrese el denominador de la segunda fracción: ");
            denominador2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + " + " + numerador2 + "/" + denominador2+ "\n");
            if (denominador1 == denominador2)
            {
                resultado1 = numerador1 + numerador2;
                resultado2 = denominador1 ;
                Console.WriteLine("valor de la suma es: " +resultado1 +"/" + resultado2);

            }
            else
            {
                resultado1 = (numerador1 * denominador2);
                resultado2 = (numerador2 * denominador1);
                resultado3 = (denominador1 * denominador2);
                resultado4 = (resultado1 + resultado2);
                Console.WriteLine("el resultado de la suma es: " + resultado4 + "/" + resultado3);
            }
        break;
        case 2:
            Console.Write("Ingrese el numerador de la primera fracción: ");
            numerador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "\n");

            Console.Write("Ingrese el denominador de la primera fracción: ");
            denominador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + "\n");

            Console.Write("Ingrese el numerador de la segunda fracción: ");
            numerador2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + " - " + numerador2+ "\n");

            Console.Write("Ingrese el denominador de la segunda fracción: ");
            denominador2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + " - " + numerador2 + "/" + denominador2+ "\n");

            if (denominador1 == denominador2)
            {
                resultado1 = numerador1 - numerador2;
                resultado2 = denominador1 ;
                Console.WriteLine("valor de la resta es: " +resultado1 +"/" + resultado2);

            }
            else
            {
                resultado1 = (numerador1 * denominador2);
                resultado2 = (numerador2 * denominador1);
                resultado3 = (denominador1 * denominador2);
                resultado4 = (resultado1 - resultado2);
                Console.WriteLine("el resultado de la resta de fraciones es: " + resultado4 + "/" + resultado3);
            }

            break;

        case 3:
            Console.Write("Ingrese el numerador de la primera fracción: ");
            numerador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "\n");

            Console.Write("Ingrese el denominador de la primera fracción: ");
            denominador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + "\n");

            Console.Write("Ingrese el numerador de la segunda fracción: ");
            numerador2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + " * " + numerador2+ "\n");

            Console.Write("Ingrese el denominador de la segunda fracción: ");
            denominador2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + " * " + numerador2 + "/" + denominador2+ "\n");

            resultado1 = numerador1 * numerador2;
            resultado2 = denominador1 * denominador2;

            Console.WriteLine("el resultado de la multiplicacion de fraciones es: " + resultado1 + "/" + resultado2);

            break;
        case 4:
            Console.Write("Ingrese el numerador de la primera fracción: ");
            numerador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "\n");

            Console.Write("Ingrese el denominador de la primera fracción: ");
            denominador1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + "\n");

            Console.Write("Ingrese el numerador de la segunda fracción: ");
            numerador2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + " ÷ " + numerador2+ "\n");

            Console.Write("Ingrese el denominador de la segunda fracción: ");
            denominador2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("estado de operacion \n" + numerador1 + "/" + denominador1 + " ÷ " + numerador2 + "/" + denominador2+ "\n");

            if (numerador1 == 0 || numerador2 == 0)
            {
                Console.WriteLine("la División no se puede realizar entre cero, ingrese otro numero");
            }
            else
            {
            resultado1 = numerador1 / denominador2;
            resultado2 = numerador2 * denominador1;
            Console.WriteLine("el resultado de la multiplicacion de fraciones es: " + resultado1 + "/" + resultado2);
            }
            break;
        case 5:
            Console.WriteLine("ha salido de la calculadora");
            break;
        default:
            Console.WriteLine("Opción no válida, seleccione una opcion de 1 a 5");
            break;
    }
} while (opcion != 5);
