using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class Empleado : Persona
    {
        private string email;
        private Departamento departamento;
        private Jefe jefe;

        public Empleado()
        {

        }
        public Empleado(int Id, string nombre, string direccion, int fono, string email)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Fono = Fono;
            this.Email = Email;
        }
        public string Email { get => email; set => email = value; }
        internal Departamento Departamento { get => departamento; set => departamento = value; }
        internal Jefe Jefe { get => jefe; set => jefe = value; }
        public void mostrarEmpleado()
        {

            Console.WriteLine("Empleado"+
                "\nID Empleado: "+Id+
                "\nNombre Empleado: "+Nombre+
                "\nDireccion: "+Direccion+
                "\nFono: "+Fono+
                "\nEmpleado: "+Email);
            Departamento.MostrarDepartamento();
            Jefe.MostrarJefe();
        }
    }
    
}
