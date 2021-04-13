using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime fecha = new DateTime();
            //DEPARTAMENTO
            Departamento d1 = new Departamento
            {
                Id = 1,
                Nombre = "Departamento 1"
            };
            Departamento d2 = new Departamento
            {
                Id = 2,
                Nombre = "Departamento 2"
            };
            //FIN DEPARTAMENTO


            Jefe j1 = new Jefe
            {
                Id = 123,
                Nombre = "Jefe 1",
                Direccion = "Direecion falsa 1",
                Fono = 123456789,
                Nacimiento = new DateTime(1994,01,25)  
            };
            Jefe j2 = new Jefe
            {
                Id = 12377,
                Nombre = "Jefe 2",
                Direccion = "Direecion falsa 2",
                Fono = 123456789,
                Nacimiento = new DateTime(2004, 01, 25)
            };

            Empleado e1 = new Empleado {
              Id = 332,
              Nombre = "Empleado 1",
              Direccion = "Direccion 1",
              Fono = 912345678,
              Email = "example1@email.cl",     
              Departamento = d1,
              Jefe = j1
            };
            e1.mostrarEmpleado();

            Console.ReadKey();
        }
    }
}
