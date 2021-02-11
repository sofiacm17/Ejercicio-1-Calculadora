using System;//son directivas que permiten utilizar funcionalidades que vienen dadas por defectos en nuestro programa, por ej: la clase console

namespace CALCULADORA //espacio de nombres definidas como nuestro proyecto
{
    class Program //clase principal de nuestro proyecto, llamado Program
    {
        //El método Main() es el punto de entrada de las aplicaciones C#.
        //El método Main es el primero que se invoca.
        //Main se declara dentro de una clase o estructura. El valor de Main debe ser estático y no público.
        //Main puede tener un tipo de valor devuelto void, int
        //El método Main se puede declarar con o sin un parámetro string [] que contiene los argumentos de línea de comandos.

        /*Si el valor devuelto de Main no se usa, la devolución de void permite contar con un código ligeramente mñas simple.
         * En cambio, devolver un valor entero permite que el programa comunique información de estado a otros programas o
         * scripts que invocan el archivo ejecutable. El valor devuelto de Main se trata como el código de salida para el proceso.
         * Si se devuelve void de Main, el código de salida será implícitamente 0.*/
        static void Main(string[] args) /*esto es un comentario*/ /*es el método principal que viene dado por defecto para ejecutar nuestro código*/
        {
            //utilizando métodos de la clase console:
            //La clase Console proporciona compatibilidad básica para las aplicaciones que leen caracteres de la consola y escriben caracteres en ella.

            //Console.WriteLine("Hello World!"); //línea de código que se muestra en pantalla al ejecutar la aplicación

            //Declarar variables
            try
            {
                decimal num1 = 0, num2 = 0, resultado = 0;
                char opcion = '0'; string valorelegido = "";
                int n = 1;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("BIENVENIDO A LA CALCULADORA" + "\n" + "¿Desea realizar alguna operación? <S/N> \n"); // "\n indica un salto de línea"

                    valorelegido = Console.ReadLine();
                    if (valorelegido.ToUpper() == "S")
                    {
                        //interactuar con el usuario
                        Console.WriteLine("Elija una operación: + - / *");
                        opcion = Convert.ToChar(Console.ReadLine());
                        Peticion(opcion, num1, num2, resultado);
                        n++;
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (valorelegido.ToUpper() == "N")
                    {
                        Console.WriteLine("Pulse cualquier tecla para salir de la aplicación");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("La opción elegida no es válida");
                        //propiedad para borrar en pantalla
                        Console.Clear();
                        n++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha habido un fallo en la aplicación. Contacte con el soporte técnico." + ex.Message);
                Console.ReadKey();

            }
        }
        //se declara la función Petición para pedir los números al usuario
        public static void Peticion(char opcion, decimal num1, decimal num2, decimal resultado)
        {
            switch (opcion)
            {
                case '+':
                    Console.WriteLine("Escriba un número");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escriba otro número");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es:" + resultado);
                    break;
                case '-':
                    Console.WriteLine("Escriba un número");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escriba otro número");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es:" + resultado);
                    break;
                case '/':
                    Console.WriteLine("Escriba un número");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escriba otro número");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    if (num2 == 0)
                    {
                        //se provoca una excepción para que vaya directamente al catch y capture el error del argumento que le hemos añadido
                        throw new ArgumentException("Se ha intentado dividir entre 0");
                    }
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado de la división es:" + resultado);
                    break;
                case '*':
                    Console.WriteLine("Escriba un número");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escriba otro número");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicación es:" + resultado);
                    break;
                default:
                    Console.WriteLine("La opción elegida no es válida");
                    break;
            }

            //interactuar con el usuario
            //Console.WriteLine("Escriba un número");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escriba otro número"),
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Elija una operación");
            //char opcion = Convert.ToChar(Console.ReadLine());

            //if (opcion == '+')
            {
                //resultado = num1 + num2;
                //Console.WriteLine("El resultado de la suma es:" + resultado);
            }
            //else if (opcion == '-')
            {
                //resultado = num1 - num2;
                //Console.WriteLine("El resultado de la resta es:" + resultado);
            }
            //else if (opcion == '/')
            {
                //resultado = num1 / num2;
                //Console.WriteLine("El resultado de la división es:" + resultado);
            }
            //else if (opcion == '*')
            {
                //resultado = num1 * num2;
                //Console.WriteLine("El resultado de la multiplicación es:" + resultado);
            }
            //Console.ReadLine(); //paramos el código en este punto con el intro, también sirve para recoger los valores que introduzca el usuario
            //Console.ReadKey(); //paramos el código con cualquier tecla
        }
        //public string Mostrarnumero() { return "4"; } //ejemplo de función
    }
}

