using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor sin parametros
            Alumno alumno1 = new Alumno();
            Console.WriteLine("alumno 1:");
            Console.WriteLine("nombre: " + alumno1.Nombre);
            Console.WriteLine("matricula: " + alumno1.Matricula);

            Alumno alumno2 = new Alumno();//constructor sin parametros dando despues los datos 
            alumno2.Nombre = "pedro";
            alumno2.Matricula = "123445";
            Console.WriteLine("alumno2:" + alumno2.Nombre);
            Console.WriteLine("matricula " + alumno2.Matricula);

            Alumno alumno3 = new Alumno("jose", "1234");//uso del constructor con parametros 
            Console.WriteLine("alumno 3:" + alumno3.Nombre);
            Console.WriteLine("matricula:" + alumno3.Matricula);

            Console.Read();


        }
    }
}
