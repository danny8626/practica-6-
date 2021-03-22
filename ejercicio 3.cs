using System;

namespace ejercicio_3
{
    ///Crear tres clases ClaseA, ClaseB, ClaseC que ClaseB herede de ClaseA y ClaseC herede de ClaseB. Definir un constructor a cada clase que muestre un mensaje. Luego definir un objeto de la clase ClaseC.

    class Program
    {
        static void Main(string[] args)
        {
          public class A
    {
        public A()
        {
            Console.WriteLine("Constructor de la clase A");
        }
    }
   public class B: A
    {
        public B()
        {
            Console.WriteLine("Constructor de la clase B");
        }
    }

    public class C: B
    {
        public C()
        {
            Console.WriteLine("Constructor de la clase C");
        }
    }

    class Objeto
    {
        static void Main (string[] args)
        {
            C obj = new C();
            Console.ReadKey();
        }
    }
}

        }
    
