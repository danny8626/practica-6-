﻿using System;

namespace ejercicio_2
{
    ///Crear una clase Contacto. Esta clase deberá tener los atributos "nombre, apellidos, telefono y direccion". También deberá tener un método "SetContacto", de tipo void y con los parámetros string, que permita cambiar el valor de los atributos. También tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " seguido de sus datos. Crear también una clase llamada ProbarContacto. Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo Contacto, les asignará los datos del contacto y les pedirá que saluden.

public class contacto
    {
        private string nombre;
        private string apellidos;
        private string direccion;
        private int telefono;

        public void SetContacto(string nombre)
        {
            this.nombre = nombre;
            
        }

        public void saludar()
        {
            Console.WriteLine("Hola soy {0} ", nombre);
        }
    }

    public class ProbarContacto
    {
        public static void Main()
        {
            contacto cont = new contacto();
            cont.SetContacto("Danny Galva");
            cont.saludar();
        }
    }



}
