using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class Jefe : Persona
    {
        private DateTime nacimiento;

        public Jefe()
        {

        }

        public Jefe(DateTime nacimiento)
        {
            this.nacimiento = nacimiento;
        }

        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }

        public void MostrarJefe()
        {
            Console.WriteLine("ID Jefe: " + this.Id + 
                "\nNombre: " + this.Nombre + 
                "\nDireccion: " + this.Direccion + 
                "\nFono: " + this.Fono + 
                "\nNacimiento: " + this.Nacimiento.ToString("dd/MM/yyyy") + 
                "\n*************************");
        }
    }
}
