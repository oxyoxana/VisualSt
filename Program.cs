using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_simples
{
    class Program
    {
        /*Console.WriteLine("Introduce un importe: \n");
            double importe = 0;
            string mensaje = "";
            importe = double.Parse(Console.ReadLine());
            mensaje = importe > (99.9) ? "No se dispone de ese importe"
                : "Se retirará " + importe;
            Console.WriteLine(mensaje);
            Console.ReadKey();*/

        static void Main(string[] args)
        {
            /** 3) Realiza un pequeño programa que tenga una variable entera a la 
             * que se le asigna el valor 10 por defecto. 
             * La aplicación debe comprobar si este numero es par o impar y en 
             * función de esta condición debe mostrar el mensaje si es par o no. 
             * Usar el método Console.WriteLine(mensaje); para imprimir por pantalla. Usar el operador ?.
             */

            /*
            int variable = 10;
            string comprobar = "";
            comprobar = (variable%2 == 0) ? "Es par" : "Es impar";
            Console.WriteLine(comprobar);
            Console.ReadKey();
            */

            /*4) Realiza un programa de consola que pida al usuario (Console.ReadLine()) el valor de 
             * un lado de un cuadrado y muestre como resultado el área del mismo. 
             * Nota: No se puede hacer un casting de tipo de datos para ReadLine, para ello debemos 
             * utilizar la función Parse que tiene cada tipo de dato. Por ejemplo: 
             * double.Parse(Console.ReadLine()) transforma la entrada de consola en tipo double.
             */

            /*
            Console.WriteLine("Introduce un número: \n");
            int lado = 0;
            int area = 0;
            lado = int.Parse(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El área de tu cuadrado es " + area);
            Console.ReadKey();
            */

            /*5) Codifica un programa que pida al usuario un numero que represente una cantidad 
             * expresada en pesetas. Si tenemos en cuenta que 1 euro = 166,386 pesetas, muestra por 
             * pantalla la conversión a euros de ese numero de pesetas. Si se introduce un numero 
             * positivo se realizará la conversión, en caso contrario mostrará una mensaje al
             *  usuario “El valor de pesetas establecido no es correcto”.
             * */
            /*
            Console.WriteLine("Introduce un cantidad en pesetas: \n");
            double pesetas = 0;
            double euros = 0;
            string mensaje = "";
            pesetas = double.Parse(Console.ReadLine());
            euros = (pesetas / 166.386);
            mensaje = pesetas > 0 ? "La conversión a euros de pesetas: " + euros
               : "El valor de pesetas establecido no es correcto" ;
            Console.WriteLine(mensaje);
            Console.ReadKey();
            */

            /*6) Desarrollar un programa que pida por consola un día de la semana y devolverá la 
             * actividad extraescolar a la que debe acudir nuestro hijo. Las actividades que se 
             * realizan son: lunes-> psicomotricidad, martes->natación, miércoles->música, 
             * jueves->natación y viernes -> descanso. Los días sábado y domingo no hay actividades 
             * con lo que si el usuario escribe por error alguno de estos días de la semana debe 
             * mostrar el mensaje “Día sin actividades”. Si por equivocación, además, se escribe un día 
             * inexistente se debe mostrar en pantalla “Día erróneo”.*/

            /*
            Console.WriteLine("Introduce un día de la semana: \n");
            string diaSemana = "";
            diaSemana = Console.ReadLine();
            switch (diaSemana)
            {
                case "lunes":
                    Console.WriteLine("psicomotricidad");
                    Console.ReadKey();
                    break;
                case "martes":
                    Console.WriteLine("natación");
                    Console.ReadKey();
                    break;
                case "miércoles":
                    Console.WriteLine("música");
                    Console.ReadKey();
                    break;
                case "jueves":
                    Console.WriteLine("natación");
                    Console.ReadKey();
                    break;
                case "viernes":
                    Console.WriteLine("descanso");
                    Console.ReadKey();
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Día sin actividades");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Día erróneo");
                    Console.ReadKey();
                    break;
                    */

            /*7) Realiza un programa que pida dos números x e y, y realice la multiplicación de
             *  ambos mediante el uso de sumas (con while)*/

            /*
            Console.WriteLine("Introduce dos números: \n");
            int x = 0;
            int y = 0;
            int suma = 0;
            int cont = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("La multiplicación de los números " + x + " e "
               + y + " es :");
            while (cont < y)
            {
               suma = suma + x;
               cont++;
               Console.WriteLine(suma);
            }
            Console.ReadKey();
            */

            /*8) Realiza un programa que muestre los números divisibles de 7 entre 1 y 100
             * (con for)*/

            /*
            int i = 0;
            Console.Write("Números divisibles entre 7: ");
            for (i = 1; i <= 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(" "+i);
                }
            }
            Console.ReadKey();
           */

            /*
             9) Supongamos que nos piden hacer un pequeño menú de tres opciones.
             Este debe visualizarse como sigue:
             1.Calcular diámetro
             2.Calcular circunferencia
             3.Calcular área
             El objetivo del algoritmo es que al iniciar se pida al usuario el radio de un circulo y a 
             continuación se muestre el menú.Si el usuario selecciona la opción 1 se pasara a calcular 
             el diámetro del circulo cuyo radio se ha especificado.Si seleccionamos la opción 2 calcularemos 
             su circunferencia. La ultima de sus opciones calculará el área. Tras cada cálculo el resultado
             debe ser mostrado por pantalla.*/
            /*
            int radio = 0, menu = 0;
            double diametro = 0;
            double circunf = 0;
            double area = 0;
            const double pi = (3.14);
            Console.WriteLine("Introduzca el radio de un circulo: ");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Calcular diámetro \n2.Calcular circunferencia \n3.Calcular área");
            menu =int.Parse(Console.ReadLine());
            switch (menu)
            {
               case 1:
                   Console.WriteLine("1.Calcular diámetro");
                   diametro = (radio * 2);
                   Console.WriteLine("El diámetro de "+radio+" es "+diametro);
                   break;
               case 2:
                   Console.WriteLine("2.Calcular circunferencia");
                   circunf = (radio * 2) * pi;
                   Console.WriteLine("La circunferencia de " + radio + " es " + circunf);
                   break;
               case 3:
                   Console.WriteLine("3.Calcular área");
                   area = pi * (radio * radio);
                   Console.WriteLine("El área de " + radio + " es " + area);
                   break;

            }
            Console.ReadKey();
            */

            /* 10) Escribir una función llamada redondear tal que acepte como parámetros 
             * un numero real y un numero entero, siendo el primero de ellos el que se debe 
             * redondear. La función devolverá el numero redondeado en la cantidad de 
             * posiciones decimales que establezca el parámetro entero a través del propio 
             * parámetro real, es decir, cuando realicemos la llamada: redondear(numero, 
             * posiciones); será en numero donde se almacena el resultado, la función no 
             * devuelve ningún tipo de datos.Ejemplo: redondear(2.3658, 2)-> 2,37*/
            /*
            Console.WriteLine("Introduzca un número real: ");
            double real = 0;
            real = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca un número entero: ");
            int entero = 0;
            entero = int.Parse(Console.ReadLine());


            Console.ReadKey();
            */

            /* 11) Realizar un programa que muestre por pantalla una pirámide de números tal
             *  que el usuario indique el nivel de esta. Por ejemplo, si el usuario especifica
             *  nivel 4, debe mostrarse como sigue:
                 1
                121
               12321
              1234321 */

            ///*
            Console.WriteLine("Introduzca un número: ");
            int entero = 0;
            entero = int.Parse(Console.ReadLine());

            for (int i = 1; i<=entero; i++)
            {
                for (int j =1 ; j<i; j++) {
                    Console.Write(j);
                    /*for (j = i; j>i; j--) {
                        Console.Write(j);
                    }*/
                }
                Console.Write(i+"\n");


            }

            Console.ReadKey();
            //*/

            /* 12) Realizar un programa que permita calcular el área de diferentes figuras geométricas
             *  de forma que muestre el siguiente menú:
            a.Circulo
            b.Cuadrado
            c.Triangulo
            d.Salir
            Se deben usar funciones que devuelvan el valor del área. El menú debe estar en una función
            también.*/

            /*13) Crea un arrray de tipo String. Inicializalo con las cadenas que desees. 
             * Haciendo uso del bucle foreach muestra por pantalla cada cadena con el numero de 
             * caracteres que contiene. La función que devuelve el numero de caracteres es Length.
             */



            /*14) Realiza un pequeño programa que permita al usuario realizar las siguientes 
             * operaciones
                a. Inicializar array números reales.
                b. Ordenar (usando método Sort)
                c. Insertar un nuevo elemento en el array
                d. Eliminar un elemento indicando su índice.
             */


            /*15) Realiza un programa que pida caracteres a un usuario. Finalizará la introducción 
             * cuando pulse @ o haya escrito 20 caracteres. A continuación se deben mostrar los 
             * elementos almacenados en mayúsculas. Ayuda: funciones String compareTo y toLower o 
             * toUpper*/


            /*16) Realiza un programa que dado un numero de IP sea capaz de dividirlo en partes y 
             * mostrar la mascara siguiendo esta instrucción: Si la primer parte de la IP está entre 
             * 1 y 127 entonces la mascara será 255.0.0.0, si está entre 128 y 191 entonces 
             * 255.255.0.0, si está entre 192 y 223 entonces 255.255.255.0 y si no está en esos 
             * rangos entonces 0.0.0.0*/



        }
    }
}
