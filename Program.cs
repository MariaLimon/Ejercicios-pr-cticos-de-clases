using Ejercicios_prácticos_de_clases.Clases;
using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //persona
            Persona persona = new Persona();
            Console.WriteLine("dame tu nombre");
            persona.NombrePersona = Console.ReadLine();
            Console.WriteLine("dame tu edad");
            persona.EdadPesona = Convert.ToInt16(Console.ReadLine());

            //datos persona
            Console.WriteLine($"tu nombre es: {persona.NombrePersona} y tu edad es: {persona.EdadPesona}");


            //vehiculo y auto
            Vehiculo vehiculo = new Vehiculo();
            Console.WriteLine("dame la marca del vehiculo");
            vehiculo.MarcaCarro = Console.ReadLine();
            //clase derivada
            Auto auto = new Auto();
            Console.WriteLine("dame la marca del auto");
            auto.MarcaCarro = Console.ReadLine();
            Console.WriteLine("dame el modelo del auto");
            auto.ModeloAuto = Console.ReadLine();
            //imprime datos
            Console.WriteLine($"datos vehiculo: marca {vehiculo.MarcaCarro}");
            Console.WriteLine($"datos auto: marca {auto.MarcaCarro} y modelo: {auto.ModeloAuto}");
            

            //calculadora
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("dame el primer numero");
            double numero1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("dame el segundo numero");
            double numero2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("¿que tipo de operacion se va a hacer? 1 suma, 2 resta, 3 multiplicación y 4 división");
            int opcionOperacion = int.Parse(Console.ReadLine()!);

            //seleccion de opcion
            switch (opcionOperacion)
            {
                case 1:
                    calculadora.Sumar(numero1, numero2);
                    Console.WriteLine($"el resultado de la suma es: {calculadora.Resultado}");
                    break;

                case 2:
                    calculadora.Restar(numero1, numero2);
                    Console.WriteLine($"el resultado de la resta es: {calculadora.Resultado}");
                    break;

                case 3:
                    calculadora.Multiplicar(numero1, numero2);
                    Console.WriteLine($"el resultado de la multiplicación es: {calculadora.Resultado}");
                    break;

                case 4:
                    calculadora.Dividir(numero1, numero2);
                    Console.WriteLine($"el resultado de la divicion es: {calculadora.Resultado}");
                    break;
            }
            
             //rectangulo
            Rectangulo rectangulo = new Rectangulo();
            Console.WriteLine("dame el ancho del rectangulo");
            rectangulo.Ancho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("dame el alto del rectangulo");
            rectangulo.Alto = Convert.ToDouble(Console.ReadLine());
            rectangulo.respuestaArea = rectangulo.CalculaArea(rectangulo.Ancho, rectangulo.Alto);
            rectangulo.respuestaPerimetro = rectangulo.CalcularPerimetro(rectangulo.Ancho,rectangulo.Alto);

            Console.WriteLine($"el area es {rectangulo.respuestaArea}");
            Console.WriteLine($"el perimetro es {rectangulo.respuestaPerimetro}");
            */

            //libro
            Libro libro = new Libro();
            Console.WriteLine("dame el titulo del libro");
            libro.Autor = Console.ReadLine();
            Console.WriteLine("dame el autor del libro");
            libro.Titulo = Console.ReadLine();

            Console.WriteLine($"titulo: {libro.Titulo} y autor: {libro.Autor}");


        }
    }
}