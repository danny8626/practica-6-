using System;

namespace ejercicio_1
{
    ///Crear una clase Persona que tenga como atributos el "cedula, nombre, apellido y la edad (definir las propiedades para poder acceder a dichos atributos)". Definir como responsabilidad un método para mostrar ó imprimir. Crear una segunda clase Profesor que herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo. Definir un objeto de la clase Persona y llamar a sus métodos y propiedades. También crear un objeto de la clase Profesor y llamar a sus métodos y propiedades.

     class Program
    {
        static void Main(string[] args)
        {
           class Persona
    {
        private string cedula;

        private string nombre;

        private string apellido;

        private int edad;

        public Persona(){
            Console.Write("Ingrese su cedula: ");
            cedula = Console.ReadLine();
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            string Linea = Console.ReadLine();
            edad = int.Parse(Linea);
        }

        public void Imprimir()
        {
            Console.WriteLine("Bienvenido " + nombre);
            Console.WriteLine("Cedula: " + cedula);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);
        }

     class Profesor  
        {
           private double Sueldo;

           public Profesor(){
               Sueldo = 98700;
           }

           public void Imprime()
           {
             Console.WriteLine("Su sueldo es: {0} ", Sueldo);  
           }

        }

        static void Main(string[] args)
        {
            Persona Persona01 = new Persona();
            Profesor Profesor01 = new Profesor();

            Persona01.Imprimir();
            Profesor01.Imprime();
        }
    }
}
    }


