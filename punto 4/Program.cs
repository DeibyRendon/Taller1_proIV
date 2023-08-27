string frace = "El gato juega en el jardin";
string adivinaFrase;
int palabra1 = 0;
int palabra2 = 0;
int palabra3 = 0;
string valor1 = "_____";
string valor2 = "_____";
string valor3 = "_____";
int opcion;
int contador1 = 0;
int contador2 = 0;

do
{

    Console.WriteLine("Bienvenido al Juego Adivina la Palabra Oculta");
    Console.WriteLine("1. Intentar adivinar la frace");
    Console.WriteLine("2. Salir");

    opcion = Convert.ToInt32(Console.ReadLine());


    switch (opcion)
    {

        case 1:
            do
            {
                Console.WriteLine("el " + valor1 + " juega " + valor2 + " el " + valor3);
                Console.WriteLine("ingresa la palabra a adivinar"+"\n\n");
                adivinaFrase = Console.ReadLine().ToLower();

                if (adivinaFrase == "gato" && palabra1 == 1)
                {
                    
                    Console.WriteLine("\n\n"+"la fase ya fue ingresada");
                    contador1++;

                }else if (adivinaFrase == "gato" && palabra1 == 0){
                    Console.WriteLine("Has adivinado "+ adivinaFrase +" es una de las palabras "+"\n\n");
                    valor1 = adivinaFrase;
                    contador2++;
                }else if (adivinaFrase == "en" && palabra2 == 1){
                    Console.WriteLine("la fase ya fue ingresada");
                    contador1++;

                }else if (adivinaFrase == "en" && palabra2 == 0){
                    Console.WriteLine("Has adivinado "+ adivinaFrase +" es una de las palabras "+"\n\n");
                    valor2 = adivinaFrase;
                    contador2++;
                }else if (adivinaFrase == "jardin" && palabra3 == 1)
                {
                    Console.WriteLine("la fase ya fue ingresada ");
                    contador1++;

                }else if (adivinaFrase == "jardin" && palabra3 == 0)
                {
                    Console.WriteLine("Has adivinado "+ adivinaFrase +" es una de las palabras "+"\n\n");
                    valor3 = adivinaFrase;
                    contador2++;
                }else
                {
                    contador1++;
                    Console.WriteLine("Lo lamento!! "+adivinaFrase +" no es la palabra :( \nte quedan " + (10 - contador1) + " intentos" );
                }

            } while (contador1 < 10 && contador2 <3);
            
            if (contador2 == 3)
            {
                Console.WriteLine("Has ganado la frase");
                Console.WriteLine("el " + valor1 + " juega " + valor2 + " el " + valor3);
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