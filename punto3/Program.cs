// Una pizzería llamada Pizzas el Fercho tiene pizzas vegetarianas y no vegetarianas. Los ingredientes para cada una de las pizzas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estructuraswitch1
{
    class Program
    {
        static void Main(string[] args)
        {

                 //mensaje para conocer el tipo de pizza


            Console.Write("Pizzas el Fercho ");
            Console.Write("Ingrese un valor entre 1 y 2:");
            Console.Write("carnivoro   (1):");
            Console.Write("vegetariano (2);");
            int valor = int.Parse(Console.ReadLine());

            //ingresar el valor para decidir la pizza 


            switch (valor)
            {

                    //switch para los ingredientes carnivoro


                case 1: Console.Write("carnivoro");
                Console.Write("Ingredientes pizza no vegetarianos: Pepperoni, Salami y Pollo.");
                 Console.Write("Ingrese un valor entre 1 y 5:");
                 Console.Write("pepperoni(1), salami(2), pollo(3), trescarnes(4), mixta(5):");
                  int valor1 = int.Parse(Console.ReadLine());
            switch (valor1)
            {
                case 1: Console.Write("peperoni");
                        break;
                case 2: Console.Write("salami");
                        break;
                case 4: Console.Write("trescarnes:pollo,salami y pepperoni");
                        break;
                case 3: Console.Write("pollo ");
                        break;
                case 5: Console.Write("mixtad (carne y vegetariana)");
                        break;
                default:
                        Console.Write("Se ingreso un valor fuera de rango");
                        break;
            }
             //ingredientes pizza vegetariano
            Console.ReadKey();
                        break;
                case 2: Console.Write("vegetariano");
                Console.Write("Ingredientes pizza vegetariana: Pimiento y champiñones");
                 Console.Write("Ingrese un valor entre 1 y 3:");
                 Console.Write("champiñones(1), pimiento(2), mixta(3) :");
            int valor2 = int.Parse(Console.ReadLine());
            switch (valor2)
            {
                case 1: Console.Write("champiñones");
                        break;
                case 2: Console.Write("pimiento");
                        break;
                case 3: Console.Write("mixta");
                        break;
                default:
                        
                        break;
            }
            Console.ReadKey();
                        break;
                
                default:
                        Console.Write("Se ingreso un valor fuera de rango");
                        break;
            }
            Console.ReadKey();
        }
    }
}