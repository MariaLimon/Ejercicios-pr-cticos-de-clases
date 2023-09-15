using Ejercicios_prácticos_de_clases.Clases;
using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}